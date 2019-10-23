using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ecard.DAL;
using Ecard.Modelo;

namespace Ecard
{
    public partial class LoginEstudante : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_click(object sender, EventArgs e)
        {
            DALEstudante dal = new DALEstudante();
            Modelo.Estudante estudante = dal.Login(TextUsuario.Text, TextSenha.Text);
            if (estudante.id != 0)
            {
                Session["userid"] = estudante.id;
                Session["username"] = estudante.nome;
                Session["logged"] = true;
                Session["accesslevel"] = "estudante";
                Response.Redirect("~/TelaPrincipalEstudante.aspx");
            }
        }
    }
}