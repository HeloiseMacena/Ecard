using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecard
{
    public partial class ConsultaPontodeRecarga : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            modalContainer.Style.Add("visibility", "hidden");
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
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string option = DDLSearch.Text;
                string value = valueSearch.Text;

                DAL.DALPonto_recarga aDALPonto_recarga = new DAL.DALPonto_recarga();

                Repeater1.DataSourceID = null;
                Repeater1.DataSource = aDALPonto_recarga.SearchSelect(value, option);
                Repeater1.DataBind();
            } catch { }
        }
    }
}