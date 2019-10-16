using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecard
{
    public partial class CadastroPontoEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["logged"] != null)
            {
                if (Session["accesslevel"] == "instituicao") Response.Redirect("~/TelaPrincipalInstituicao.aspx");
                if (Session["accesslevel"] == "estudante") Response.Redirect("~/TelaPrincipalEstudante.aspx");
            }
            else
            {
                Response.Redirect("~/TelaInicial.aspx");
            }
        }
    
        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            Modelo.Ponto_recarga pr = new Modelo.Ponto_recarga(0, TextPonto.Text, TextNumero.Text, TextRua.Text, TextCEP.Text, TextBairro.Text, TextMunicipio.Text);
            DAL.DALPonto_recarga dal = new DAL.DALPonto_recarga();
            dal.Insert(pr);
            Response.Redirect("~//CadastroPonto.aspx");

        }
    }
}