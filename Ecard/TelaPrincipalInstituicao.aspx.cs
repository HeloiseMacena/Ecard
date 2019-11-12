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
    }
}
