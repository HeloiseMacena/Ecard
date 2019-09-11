using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecard
{
    public partial class CadastroEstudante : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Ecardmark1.Modelo.Estudante pr = new Ecardmark1.Modelo.Estudante(TextBox1.Text,TextBox4.Text,Textbox2.Text,TextB);
            Ecardmark1.DAL.DALEstudante dal = new Ecardmark1.DAL.DALEstudante();
            dal.Insert(pr);
            Response.Redirect("~//CadastroBairro.aspx");
        }
    }
}