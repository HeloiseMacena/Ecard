using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ecard.DAL;

namespace Ecard
{
    public partial class PerfilEstudante : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                id = int.Parse(Session["userid"].ToString());
                DALEstudante dal = new DALEstudante();
                Modelo.Estudante estudante = dal.Select(id);
                Nome.Text = estudante.nome;
                Email.Text = estudante.email;
            }
            

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Session["userid"].ToString());
            DALEstudante dal = new DALEstudante();
            Modelo.Estudante estudante = dal.Select(id);
            if (TextAtual.Text == estudante.senha)
            {
                estudante.senha = TextNova.Text;
                dal.Update(estudante);
                Response.Redirect("~/PerfilEstudante.aspx");
            }
            {
                CustomValidator1.IsValid = false;
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Session["userid"].ToString());
            DALEstudante dal = new DALEstudante();
            Modelo.Estudante estudante = dal.Select(id);
            if (estudante.nome != Nome.Text)
            {
                estudante.nome = Nome.Text;
                dal.Update(estudante);
                Response.Redirect("~/PerfilEstudante.aspx");
            }
                
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Session["userid"].ToString());
            DALEstudante dal = new DALEstudante();
            Modelo.Estudante estudante = dal.Select(id);
            if (estudante.email != Email.Text)
            {
                estudante.email = Email.Text;
                dal.Update(estudante);
                Response.Redirect("~/PerfilEstudante.aspx");
            }   
        }
    }
}