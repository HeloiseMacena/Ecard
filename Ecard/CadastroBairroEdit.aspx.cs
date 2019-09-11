using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecard
{
    public partial class CadastroBairroEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            Ecardmark1.Modelo.Bairro pr = new Ecardmark1.Modelo.Bairro(0, TextBox1.Text);
            Ecardmark1.DAL.DALBairro dal = new Ecardmark1.DAL.DALBairro();
            dal.Insert(pr);
            Response.Redirect("~//CadastroBairro.aspx");
        }
    }
}