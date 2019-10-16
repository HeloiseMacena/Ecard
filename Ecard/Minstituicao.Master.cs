using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ecard.DAL;

namespace Ecard
{
    public partial class Minstituicao : System.Web.UI.MasterPage
    {
        DAL.DALInstituicao aDALInstituicao = new DALInstituicao();

        protected void Page_Load(object sender, EventArgs e)
        {
            int a = int.Parse((Session["userid"].ToString()));

            if (aDALInstituicao.SelectStatus(a) == 0)
            {
                status.Text = "Solicitado";
            }
            if (aDALInstituicao.SelectStatus(a) == 1)
            {
                status.Text = "Reprovado";
            }
            if (aDALInstituicao.SelectStatus(a) == 2)
            {
                status.Text = "Aprovado";
            }

            if (Session["logged"] != null)
            {
                if (Session["accesslevel"] == "estudante") Response.Redirect("~/TelaPrincipalEstudante.aspx");
                if (Session["accesslevel"] == "administrador") Response.Redirect("~/WebFormTelaPrincipalAdm.aspx");
            }
            else
            {
                Response.Redirect("~/TelaInicial.aspx");
            }
            DALInstituicao dal = new DALInstituicao();
            Modelo.Instituicao instituicao = dal.Select(int.Parse(Session["userid"].ToString()));
            Label1.Text = instituicao.Nome;
            nome_usuario.Text = instituicao.Nome;
        }
    }
}