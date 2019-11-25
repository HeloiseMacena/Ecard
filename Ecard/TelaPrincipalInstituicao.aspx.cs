using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Ecard
{
    public partial class TelaPrincipalInstituicao : System.Web.UI.Page
    {
        DAL.DALEstudante aDALEstudante = new DAL.DALEstudante();
        List<Modelo.Estudante> aListEstudante;
        DAL.DALInstituicao aDALInstituicao = new DAL.DALInstituicao();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                resposta.Style["display"] = "none";
                respostaError.Style["display"] = "none";
            }

            int id = int.Parse(Session["userid"].ToString());
            Modelo.Instituicao instituicao = aDALInstituicao.Select(id);
            if (instituicao.Status == 2) TextSituacao.Text = "Bem-vindo ao sistema!";
            else
            {
                btnUpload.Enabled = false;

                if (instituicao.Status == 0) TextSituacao.Text = "O cadastro da instituição será verificado em breve. Por favor, aguarde!";
                else
                {
                    DAL.DALSolicitacao_instituicao dal_solicitacao = new DAL.DALSolicitacao_instituicao();
                    List<Modelo.Solicitacao_instituicao> solicitacoes = dal_solicitacao.SelectAll();
                    ButtonSituacao.Style["display"] = "block";
                    if (solicitacoes[solicitacoes.Count - 1].descricao_erro == "Código INEP/MEC não identificado")
                    {
                        TextBoxCodigo.Style["display"] = "block";
                        ButtonSituacao.CommandArgument = "1";
                        TextSituacao.Text = "O Código INEP / MEC cadastrado não foi identificado. Por favor, insira um código válido:";
                    }
                    else
                    {
                        if (solicitacoes[solicitacoes.Count - 1].descricao_erro == "Código INEP/MEC e CNPJ não identificados")
                        {
                            TextBoxCodigo.Style["display"] = "block";
                            TextBoxCNPJ.Style["display"] = "block";
                            ButtonSituacao.CommandArgument = "2";
                            TextSituacao.Text = "O código INEP / MEC e o CNPJ cadastrados não foram identificados. Por favor, insira-os novamente:";
                        }
                        else
                        {
                            TextBoxCNPJ.Style["display"] = "block";
                            ButtonSituacao.CommandArgument = "3";
                            TextSituacao.Text = "O CNPJ cadastrado não foi identificado. Por favor, insira-o novamente:";
                        }

                    }
                }
            }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Session["userid"].ToString());
            string nomeArquivo = Path.GetFileName(FileUpload1.PostedFile.FileName);

            if (nomeArquivo.EndsWith(".txt"))
            {
                if (FileUpload1.HasFile)
                {
                    string Arquivo = Server.MapPath("Lista_Alunos/" + nomeArquivo);
                    FileUpload1.PostedFile.SaveAs(Arquivo);

                    resposta.Style["display"] = "block";
                    respostaError.Style["display"] = "none";

                    aListEstudante = aDALEstudante.SelectArquivoCsv(Arquivo);

                    if (aListEstudante.Count > 0)
                    {
                        aDALEstudante.MudarSituacaoFalse();

                        for (int i = 0; i < aListEstudante.Count; i++)
                        {
                            if (aDALEstudante.ExisteEstudante(aListEstudante[i].cpf) == true)
                            {
                                aDALEstudante.MudarSituacaoTrue(aListEstudante[i].cpf, int.Parse(Session["userid"].ToString()));
                            }
                            else
                            {
                                aDALEstudante.InsertPreCadastrado(aListEstudante[i], int.Parse(Session["userid"].ToString()));
                            }
                        }
                    }
                }
            }
            else { respostaError.Style["display"] = "block"; resposta.Style["display"] = "none"; }
        }
        protected void ButtonSituacao_Click(object sender, EventArgs e)
        {
            int tipo = int.Parse(((Button)sender).CommandArgument.ToString());
            int id = int.Parse(Session["userid"].ToString());
            Modelo.Instituicao instituicao = aDALInstituicao.Select(id);
            if (tipo == 1)
            {
                instituicao.Codigo_inep_mec = TextBoxCodigo.Text;
            }
            else
            {
                if (tipo == 2)
                {
                    instituicao.Codigo_inep_mec = TextBoxCodigo.Text;
                    instituicao.cnpj = TextBoxCNPJ.Text;
                }
                else
                {

                    instituicao.cnpj = TextBoxCNPJ.Text;
                }

            }
            instituicao.Status = 0;
            aDALInstituicao.Update(instituicao);
            DAL.DALSolicitacao_instituicao dal_solicitacao = new DAL.DALSolicitacao_instituicao();
            dal_solicitacao.Insert(id);
            Response.Redirect("~/TelaPrincipalInstituicao.aspx");
        }

        /*protected void btnUpload2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Session["userid"].ToString());
            string nomeArquivo = Path.GetFileName(FileUpload1.PostedFile.FileName);
            if (nomeArquivo.EndsWith(".txt"))
            {
                if (FileUpload1.HasFile)
                {
                    string Arquivo = Server.MapPath("Lista_Alunos/" + nomeArquivo);
                    FileUpload1.PostedFile.SaveAs(Arquivo);

                    Repeater1.DataSource = aDALEstudante.SelectArquivoCsv(Arquivo);
                    Repeater1.DataBind();
                }
            }
        }*/

    }
}
