using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecard
{
    public partial class CadastroRotaEdit : System.Web.UI.Page
    {
        

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            string nome = TextBoxNome.Text + ":  " + TextBoxBairro.Text + ", " + TextBoxReferencia.Text + ".";
            Modelo.Rota rota = new Modelo.Rota(nome);
            DAL.DALRota d = new DAL.DALRota();
            d.Insert(rota);
            Response.Redirect("~//CadastroRota.aspx");
        }
    }
}