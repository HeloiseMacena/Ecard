using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecardmark1
{
    public partial class EditarRota : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            DAL.DALRota p = new DAL.DALRota();
            Modelo.Rota rota = p.Select(id);
            TextBox1.Text = rota.nome;
        }
        
    }
}