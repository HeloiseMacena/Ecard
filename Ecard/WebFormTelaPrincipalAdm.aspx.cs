using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecard
{
    public partial class WebFormTelaPrincipalAdm : System.Web.UI.Page
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
            DAL.DALSolicitacao_carteira carteira = new DAL.DALSolicitacao_carteira();
            ContCarteira.Text = carteira.CountSolicitacoes().ToString();
            DAL.DALSolicitacao_instituicao instituicao = new DAL.DALSolicitacao_instituicao();
            Continstituicao.Text = instituicao.CountSolicitacoes().ToString();
        }
    }
}