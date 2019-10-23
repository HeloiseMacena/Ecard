using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ecard.DAL;

namespace Ecard
{
    public partial class PerfilAdm : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                id = int.Parse(Session["userid"].ToString());
                DALAdministrador dal = new DALAdministrador();
                Modelo.Administrador Administrador = dal.Select(id);
                Nome.Text = Administrador.nome;
                Email.Text = Administrador.email;
            }
        }
        protected void Unnamed_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Session["userid"].ToString());
            DALAdministrador dal = new DALAdministrador();
            Modelo.Administrador Administrador = dal.Select(id);
            if (TextAtual.Text == Administrador.senha)
            {
                Administrador.senha = TextNova.Text;
                dal.Update(Administrador);
                Response.Redirect("~/PerfilAdm.aspx");
            }
            {
                CustomValidator1.IsValid = false;
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Session["userid"].ToString());
            DALAdministrador dal = new DALAdministrador();
            Modelo.Administrador Administrador = dal.Select(id);
            if (Administrador.nome != Nome.Text)
            {
                Administrador.nome = Nome.Text;
                dal.Update(Administrador);
                Response.Redirect("~/PerfilAdm.aspx");
            }
            

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Session["userid"].ToString());
            DALAdministrador dal = new DALAdministrador();
            Modelo.Administrador Administrador = dal.Select(id);
            if (Administrador.email != Email.Text)
            {
                Administrador.email = Email.Text;
                dal.Update(Administrador);
                Response.Redirect("~/PerfilAdm.aspx");
            }        }
    }
}