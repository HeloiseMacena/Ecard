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
            modalContainer.Style.Add("visibility", "hidden");
        }
        protected void ToggleModal_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "ToggleModal", "ToggleModal()", true);
        }

        protected void getModalInfos_Click(object sender, EventArgs e)
        {
            string rname = ((Button)sender).CommandArgument.ToString();
            DAL.DALBairro p = new DAL.DALBairro();
            Repeater2.DataSourceID = null;
            Repeater2.DataSource = p.SelectBairros(rname);
            Repeater2.DataBind();

            DAL.DALPonto_referencia b = new DAL.DALPonto_referencia();
            Repeater3.DataSourceID = null;
            Repeater3.DataSource = b.SelectPontos(rname);
            Repeater3.DataBind();



            modalContainer.Style.Add("visibility", "visible");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string option = DDLSearch.Text;
                string value = valueSearch.Text;

                DAL.DALRota aDALRota = new DAL.DALRota();

                Repeater1.DataSourceID = null;
                Repeater1.DataSource = aDALRota.SearchSelect(value, option);
                Repeater1.DataBind();
            }
            catch { }
        }

    }
}