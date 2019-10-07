using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecard
{
    public partial class CadastroBairroEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["logged"] != null)
            {
                if (Session["accesslevel"] == "instituicao") Response.Redirect("~/WebFormTelaPrincipalInstituicao.aspx");
                if (Session["accesslevel"] == "estudante") Response.Redirect("~/TelaPrincipalEstudante.aspx");
            }
            else
            {
                Response.Redirect("~/TelaInicial.aspx");
            }
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            Ecard.Modelo.Bairro pr = new Ecard.Modelo.Bairro(TextBox1.Text);
            Ecard.DAL.DALBairro dal = new Ecard.DAL.DALBairro();
            dal.Insert(pr);
            Response.Redirect("~//CadastroBairro.aspx");
        }
    }
}