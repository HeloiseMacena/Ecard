using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecard
{
    public partial class CadastroRota : System.Web.UI.Page
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
            /*int id = int.Parse(((Button)sender).CommandArgument.ToString());
            DAL.DALBairro p = new DAL.DALBairro();
            Modelo.Bairro ponto = p.Select(id);
            modalBairro.Text = ponto.Nome;*/

            /*int Id = int.Parse(((Button)sender).CommandArgument.ToString());
            DAL.DALPonto_referencia b = new DAL.DALPonto_referencia();
            Modelo.Ponto_referencia bo = b.Select(Id);
            modalPonto.Text = bo.Nome;*/


            modalContainer.Style.Add("visibility", "visible");
        }

        /*protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string option = DDLSearch.Text;
                string value = valueSearch.Text;

                DAL.DALPonto_recarga aDALPonto_recarga = new DAL.DALPonto_recarga();

                Repeater1.DataSourceID = null;
                Repeater1.DataSource = aDALPonto_recarga.SearchSelect(value, option);
                Repeater1.DataBind();
            }
            catch { }
        }*/
    }
}
 
 