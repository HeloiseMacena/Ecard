using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecard
{
    public partial class EditarBairro : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                id = int.Parse(Request.QueryString["id"]);
                Ecardmark1.DAL.DALBairro p = new Ecardmark1.DAL.DALBairro();
                Ecardmark1.Modelo.Bairro bairro = p.Select(id);
                TextBox1.Text = bairro.Nome;
            }
            
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            id = int.Parse(Request.QueryString["id"]);

            Ecardmark1.DAL.DALBairro p = new Ecardmark1.DAL.DALBairro();
            Ecardmark1.Modelo.Bairro bairro = p.Select(id);
            bairro.Nome = TextBox1.Text;
            p.Update(bairro);
            Response.Redirect("~//CadastroBairro.aspx");

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Ecardmark1.DAL.DALBairro p = new Ecardmark1.DAL.DALBairro();
            Ecardmark1.Modelo.Bairro bairro = p.Select(id);
            p.Delete(bairro);
            Response.Redirect("~//CadastroBairro.aspx");
        }
    }
}