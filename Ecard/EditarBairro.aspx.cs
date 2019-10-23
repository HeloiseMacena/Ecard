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
                Ecard.DAL.DALBairro p = new Ecard.DAL.DALBairro();
                Ecard.Modelo.Bairro bairro = p.Select(id);
                txtNome.Text = bairro.Nome;
            }
        }
        protected void Update_Click(object sender, EventArgs e)
        {
            id = int.Parse(Request.QueryString["id"]);

            Ecard.DAL.DALBairro p = new Ecard.DAL.DALBairro();
            Ecard.Modelo.Bairro bairro = p.Select(id);
            bairro.Nome = txtNome.Text;
            p.Update(bairro);
            Response.Redirect("~//CadastroBairro.aspx");
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            id = int.Parse(Request.QueryString["id"]);
            Ecard.DAL.DALBairro p = new Ecard.DAL.DALBairro();
            Ecard.Modelo.Bairro bairro = p.Select(id);
            p.Delete(bairro);
            Response.Redirect("~//CadastroBairro.aspx");
        }
    }
}