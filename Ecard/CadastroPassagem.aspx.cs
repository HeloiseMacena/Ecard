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
                if (Session["accesslevel"] == "instituicao") Response.Redirect("~/TelaPrincipalInstituicao.aspx");
                if (Session["accesslevel"] == "estudante") Response.Redirect("~/TelaPrincipalEstudante.aspx");
            }
            else
            {
                Response.Redirect("~/TelaInicial.aspx");
            }

            DAL.DALValorPassagem a = new DAL.DALValorPassagem();

            if (!IsPostBack)
            {
                try
                {
                    TextBox1.Text = a.SelectValorInteiro("Ceará Mirim");
                }
                catch { }
                try
                {
                    TextBox2.Text = a.SelectValorInteiro("Extremoz");
                }
                catch { }
                try
                {
                    TextBox3.Text = a.SelectValorInteiro("Natal");
                }
                catch { }
                try
                {
                    TextBox4.Text = a.SelectValorInteiro("Parnamirim");
                }
                catch { }
                try
                {
                    TextBox5.Text = a.SelectValorInteiro("São Gonçalo do Amarante");
                }
                catch { }
            }
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            DAL.DALValorPassagem a = new DAL.DALValorPassagem();
            if (TextBox1.Text != "")
            {
                a.Insert(double.Parse(TextBox1.Text), "Ceará Mirim");
            }
            if (TextBox2.Text != "")
            {
                a.Insert(double.Parse(TextBox2.Text), "Extremoz");
            }
            if (TextBox3.Text != "")
            {
                a.Insert(double.Parse(TextBox3.Text), "Natal");
            }
            if (TextBox4.Text != "")
            {
                a.Insert(double.Parse(TextBox4.Text), "Parnamirim");
            }
            if (TextBox5.Text != "")
            {
                a.Insert(double.Parse(TextBox5.Text), "São Gonçalo do Amarante");
            }
        }
    }
}