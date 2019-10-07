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
    public partial class LoginInstituicao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            DALInstituicao dal = new DALInstituicao();
            Instituicao instituicao = dal.Login(TextEmail.Text, TextSenha.Text);
            if (instituicao.Id != 0)
            {
                Session["userid"] = instituicao.Id;
                Session["username"] = instituicao.Nome;
                Session["logged"] = true;
                Session["accesslevel"] = "instituicao";
                Response.Redirect("~/WebFormTelaPrincipalAdm.aspx");
            }
            
        }
    }
}