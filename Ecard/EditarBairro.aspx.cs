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
<<<<<<< HEAD

            if (!IsPostBack)
            {
                id = int.Parse(Request.QueryString["id"]);
                Ecardmark1.DAL.DALBairro p = new Ecardmark1.DAL.DALBairro();
                Ecardmark1.Modelo.Bairro bairro = p.Select(id);
                TextBox1.Text = bairro.nome;
            }

           
            
                id = int.Parse(Request.QueryString["id"]);
                Ecardmark1.DAL.DALBairro p = new Ecardmark1.DAL.DALBairro();
                Ecardmark1.Modelo.Bairro bairro = p.Select(id);
                //TextBox1.Text = bairro.nome;

=======
            if (!IsPostBack)
            {
                id = int.Parse(Request.QueryString["id"]);
                Ecard.DAL.DALBairro p = new Ecard.DAL.DALBairro();
                Ecard.Modelo.Bairro bairro = p.Select(id);
                txtNome.Text = bairro.Nome;
            }
>>>>>>> 8b4e53278fe63098a130cfa91e798f00b2a21a50
            
        }

        protected void Update_Click(object sender, EventArgs e)
        {
            id = int.Parse(Request.QueryString["id"]);

<<<<<<< HEAD
            Ecardmark1.DAL.DALBairro p = new Ecardmark1.DAL.DALBairro();
            Ecardmark1.Modelo.Bairro bairro = p.Select(id);
            bairro.nome = TextBox1.Text;
=======
            Ecard.DAL.DALBairro p = new Ecard.DAL.DALBairro();
            Ecard.Modelo.Bairro bairro = p.Select(id);
            bairro.Nome = txtNome.Text;
>>>>>>> 8b4e53278fe63098a130cfa91e798f00b2a21a50
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