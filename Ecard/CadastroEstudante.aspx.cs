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
            Ecard.Modelo.Estudante pr = new Ecard.Modelo.Estudante(Textbox1.Text, Textbox4.Text, Textbox2.Text,Textbox5.Text,false,"roberta",0,55,DateTime.Now);
            Ecard.DAL.DALEstudante dal = new Ecard.DAL.DALEstudante();
            dal.Insert(pr);
            Response.Redirect("~//TelaInicial.aspx");
        }
    }
}