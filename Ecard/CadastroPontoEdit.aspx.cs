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
        
        protected void Unnamed2_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Modelo.Ponto_recarga pr = new Modelo.Ponto_recarga(TextBox1.Text, TextBox4.Text, TextBox2.Text, TextBox5.Text, TextBox3.Text, TextBox6.Text);
=======
            Modelo.Ponto_recarga pr = new Modelo.Ponto_recarga(0, TextPonto.Text, TextNumero.Text, TextRua.Text, TextCEP.Text, TextBairro.Text, TextMunicipio.Text);
>>>>>>> 8b4e53278fe63098a130cfa91e798f00b2a21a50
            DAL.DALPonto_recarga dal = new DAL.DALPonto_recarga();
            dal.Insert(pr);
            Response.Redirect("~//CadastroPonto.aspx");

        }
    }
}