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
            if (Session["logged"] != null)
            {
                if (Session["accesslevel"] == "instituicao") Response.Redirect("~/TelaPrincipalInstituicao.aspx");
                if (Session["accesslevel"] == "administrador") Response.Redirect("~/WebFormTelaPrincipalAdm.aspx");
            }
            else
            {
                Response.Redirect("~/TelaInicial.aspx");
            }
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
            if (TextAtual.Text == estudante.senha && TextConfirmacao.Text == TextNova.Text)
            {
                estudante.senha = TextNova.Text;
                dal.Update(estudante);
                Response.Redirect("~/PerfilEstudante.aspx");
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Session["userid"].ToString());
            DALEstudante dal = new DALEstudante();
            Modelo.Estudante estudante = dal.Select(id);
            estudante.nome = Nome.Text;
            dal.Update(estudante);
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Session["userid"].ToString());
            DALEstudante dal = new DALEstudante();
            Modelo.Estudante estudante = dal.Select(id);
            estudante.email = Email.Text;
            dal.Update(estudante);
        }
    }
}