using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ecard.DAL;

namespace Ecard
{
    public partial class SolicitacaoEstudante : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["logged"] != null)
            {
                if (Session["accesslevel"] == "instituicao") Response.Redirect("~/WebFormTelaPrincipalInstituicao.aspx");
                if (Session["accesslevel"] == "estudante") Response.Redirect("~/TelaPrincipalEstudante.aspx");
            }
            else
            {
                Response.Redirect("~/TelaInicial.aspx");
            }
            using (var con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ecard"].ConnectionString))
            {
                con.Open();

                using (var cmd = new SqlCommand("Select * from Solicitacao_carteira where status = 0", con))
                {
                    Repeater1.DataSource = cmd.ExecuteReader();
                    Repeater1.DataBind();
                }
            }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = int.Parse(((Button)sender).CommandArgument.ToString());
                DALSolicitacao_carteira dal = new DALSolicitacao_carteira();
                DALEstudante dal_e = new DALEstudante();
                Modelo.Solicitacao_carteira solicitacao = dal.Select(id);
                Modelo.Estudante estudante = dal_e.Select(dal.SelectEstudante(solicitacao.id));
                Modal_id.Text = id.ToString();
                Modal_data.Text = solicitacao.data.ToShortDateString();
                Modal_estudante.Text = estudante.nome;
                ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "ToggleModal", "ToggleModal()", true);
            }
            
        }
    }
}