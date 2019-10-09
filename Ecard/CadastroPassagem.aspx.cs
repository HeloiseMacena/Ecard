using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecard
{
    public partial class CadastroPassagem : System.Web.UI.Page
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
            DAL.DALValorPassagem a = new DAL.DALValorPassagem();
            if (TextBox1.Text != "R$ 5,90")
            {
                a.Insert(double.Parse(TextBox1.Text), 1);
            }
            if (TextBox2.Text != "R$ 4,45")
            {
                a.Insert(double.Parse(TextBox2.Text), 2);
            }
            if (TextBox3.Text != "R$ 4,00")
            {
                a.Insert(double.Parse(TextBox3.Text), 3);
            }
            if (TextBox4.Text != "R$ 4,45")
            {
                a.Insert(double.Parse(TextBox4.Text), 4);
            }
            if (TextBox5.Text != "R$ 4,20")
            {
                a.Insert(double.Parse(TextBox5.Text), 5);
            }
        }
    }
}