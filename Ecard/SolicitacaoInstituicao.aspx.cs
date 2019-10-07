using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecard
{
    public partial class SolicitacaoInstituicao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ecard"].ConnectionString))
            {
                con.Open();

                using (var cmd = new SqlCommand("Select nome from Instituicao", con))
                {
                    Repeater1.DataSource = cmd.ExecuteReader();
                    Repeater1.DataBind();
                }
            }
        }
    }
}