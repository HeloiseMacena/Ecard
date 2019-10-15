using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecard
{
    public partial class WebFormTelaPrincipalInstituicao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["logged"] != null)
            {
                if (Session["accesslevel"] == "estudante") Response.Redirect("~/TelaPrincipalEstudante.aspx");
                if (Session["accesslevel"] == "administrador") Response.Redirect("~/WebFormTelaPrincipalAdm.aspx");
            }
            else
            {
                Response.Redirect("~/TelaInicial.aspx");
            }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            DAL.DALEstudante aDALEstudante = new DAL.DALEstudante();
            List<Modelo.Estudante> aListEstudante;
            int id = int.Parse(Session["userid"].ToString());

            string Arquivo = FileUpload1.FileName;

            if (FileUpload1.HasFile)
            {
                string nomeArquivo = Path.GetFileName(FileUpload1.PostedFile.FileName);
                FileUpload1.PostedFile.SaveAs(Server.MapPath("~/Lista_Alunos/" + nomeArquivo));

                resposta.Text = "Arquivo enviado com sucesso";

                aListEstudante = aDALEstudante.SelectArquivoCsv(Arquivo);

                if (aListEstudante.Count > 0)
                {
                    aDALEstudante.MudarSituacaoFalse(id);

                    for (int i = 0; i < aListEstudante.Count; i++)
                    {
                        if (aDALEstudante.ExisteEstudante(aListEstudante[i].cpf) == true)
                        {
                            aDALEstudante.MudarSituacaoTrue(aListEstudante[i].cpf);
                        }
                        else
                        {
                            aDALEstudante.Insert(aListEstudante[i]);
                        }
                    }
                }
            }
            else resposta.Text = "Por favor, selecione um arquivo a enviar";
        }
    }
}