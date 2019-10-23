using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ecard.DAL;

namespace Ecard
{
    public partial class LoginAdm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button_click(object sender, EventArgs e)
        {
            DALAdministrador dal = new DALAdministrador();
            Modelo.Administrador administrador = dal.SelectAll()[0];
            if (TextUsuario.Text == administrador.nome && TextSenha.Text == administrador.senha)
            {
                Session["userid"] = administrador.id;
                Session["username"] = "Administrador";
                Session["logged"] = true;
                Session["accesslevel"] = "administrador";
                Response.Redirect("~/TelaPrincipalAdm.aspx");
            }
            else
            {
                CustomValidator1.IsValid = false;
            }
        }
    }
}