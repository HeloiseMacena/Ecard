using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecard
{
    public partial class CadastroPonto : System.Web.UI.Page
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
        }

        protected void ToggleModal_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "ToggleModal", "ToggleModal()", true);
        }

        protected void getModalInfos_Click(object sender, EventArgs e)
        {
            int id = int.Parse(((Button)sender).CommandArgument.ToString());
            DAL.DALPonto_recarga p = new DAL.DALPonto_recarga();
            Modelo.Ponto_recarga ponto = p.Select(id);
            modalNum.Text = ponto.endereco_numero;
            modalCEP.Text = ponto.endereco_cep;
            modalMun.Text = ponto.endereco_municipio;

            modalContainer.Style.Add("visibility", "visible");

            // Session["OpenModal"] = "S";
            // ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "ToggleModal", "ToggleModal()", true);
        }

        /* protected void pModal_Click(object sender, EventArgs e)
         {
             string id = btnModal.CommandArgument;
             DAL.DALPonto_recarga aDALPonto_recarga;

             aDALPonto_recarga = new DAL.DALPonto_recarga();

             lblModalNumero.Text = aDALPonto_recarga.Select(id).ElementAt(0).endereco_numero;
             lblModalCEP.Text = aDALPonto_recarga.Select(id).ElementAt(0).endereco_cep;
         }*/
    }
}