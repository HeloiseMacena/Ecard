using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecard
{
    public partial class LoginAdm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button_click(object sender, EventArgs e)
        {
            if (TextUsuario.Text == "adm" && TextSenha.Text == "12345")
            {
                Session["userid"] = 0;
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