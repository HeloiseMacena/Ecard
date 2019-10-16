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

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Session["userid"].ToString());

            if (FileUpload1.HasFile)
            {
                string nomeArquivo = Path.GetFileName(FileUpload1.PostedFile.FileName);
                string Arquivo = Server.MapPath("~/Lista_Alunos/" + nomeArquivo);
                FileUpload1.PostedFile.SaveAs(Arquivo);

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