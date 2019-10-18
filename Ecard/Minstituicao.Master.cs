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
            if (!IsPostBack)
            {
                status.Style["display"] = "none";
                statusaprovado.Style["display"] = "none";
                statusnegado.Style["display"] = "none";
            }

            int a = int.Parse((Session["userid"].ToString()));

            if (aDALInstituicao.SelectStatus(a) == 0)
            {
                status.Text = "Aguardando aprovação";
                status.Style["display"] = "block";
                statusaprovado.Style["display"] = "none";
                statusnegado.Style["display"] = "none";
            }
            if (aDALInstituicao.SelectStatus(a) == 1)
            {
                statusnegado.Text = "Reprovado";
                status.Style["display"] = "none";
                statusaprovado.Style["display"] = "none";
                statusnegado.Style["display"] = "block";
            }
            if (aDALInstituicao.SelectStatus(a) == 2)
            {
                statusaprovado.Text = "Aprovado";
                status.Style["display"] = "none";
                statusaprovado.Style["display"] = "block";
                statusnegado.Style["display"] = "none";
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