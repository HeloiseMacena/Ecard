using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ecard.DAL;

namespace Ecard
{
    public partial class Administrador : System.Web.UI.MasterPage
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
            int id = int.Parse(Session["userid"].ToString());
            DALAdministrador dal = new DALAdministrador();
            Modelo.Administrador administrador = dal.Select(id);
            username.Text = administrador.nome;
            username2.Text = administrador.nome;
            
        }
    }
}