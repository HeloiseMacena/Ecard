using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ecard.DAL;

namespace Ecard
{
    public partial class PerfilInstituicao : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["logged"] != null)
            {
                if (Session["accesslevel"] == "estudante") Response.Redirect("~/TelaPrincipalEstudante.aspx");
                if (Session["accesslevel"] == "administrador") Response.Redirect("~/WebFormTelaPrincipalAdm.aspx");
            }
            else
            {
                Response.Redirect("~/TelaInicial.aspx");
            }
            if (!IsPostBack)
            {
                id = int.Parse(Session["userid"].ToString());
                DALInstituicao dal = new DALInstituicao();
                Modelo.Instituicao instituicao = dal.Select(id);
                Nome.Text = instituicao.Nome;
                Email.Text = instituicao.Email;
            }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            id = int.Parse(Session["userid"].ToString());
            DALInstituicao dal = new DALInstituicao();
            Modelo.Instituicao instituicao = dal.Select(id);
            if (TextAtual.Text == instituicao.Senha && TextConfirmacao.Text == TextNova.Text)
            {
                instituicao.Senha = TextNova.Text;
                dal.Update(instituicao);
                Response.Redirect("~/PerfilInstituicao.aspx");
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            id = int.Parse(Session["userid"].ToString());
            DALInstituicao dal = new DALInstituicao();
            Modelo.Instituicao instituicao = dal.Select(id);
            instituicao.Nome = Nome.Text;
            dal.Update(instituicao);
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            id = int.Parse(Session["userid"].ToString());
            DALInstituicao dal = new DALInstituicao();
            Modelo.Instituicao instituicao = dal.Select(id);
            instituicao.Email = Email.Text;
            dal.Update(instituicao);
        }
    }
}