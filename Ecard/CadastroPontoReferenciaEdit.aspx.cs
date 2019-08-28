using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecard
{
    public partial class CadastroPontoReferenciaEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            Ecardmark1.Modelo.Ponto_referencia pr = new Ecardmark1.Modelo.Ponto_referencia(TextBox1.Text);
            Ecardmark1.DAL.DALPonto_referencia dal = new Ecardmark1.DAL.DALPonto_referencia();
            dal.Insert(pr);
            Response.Redirect("~//CadastroPontoReferencia.aspx");
        }

    }
}