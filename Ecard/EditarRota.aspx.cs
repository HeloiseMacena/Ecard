using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecard
{
    public partial class EditarRota : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = int.Parse(Request.QueryString["id"].ToString());
            DAL.DALRota p = new DAL.DALRota();
            Modelo.Rota rota = p.Select(id);
<<<<<<< HEAD
            //TextBox1.Text = rota.nome;
        }
        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            Ecardmark1.DAL.DALRota p = new Ecardmark1.DAL.DALRota();
            Ecardmark1.Modelo.Rota ponto = p.Select(id);
            ponto.nome = TextBox1.Text;
            p.Update(ponto);
            Response.Redirect("~//CadastroRota.aspx");
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Ecardmark1.DAL.DALRota p = new Ecardmark1.DAL.DALRota();
            Ecardmark1.Modelo.Rota ponto = p.Select(id);
            p.Delete(ponto);
            Response.Redirect("~//CadastroRota.aspx");
        }

=======
            if (!IsPostBack) TextBox1.Text = rota.nome;
        }
        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            id = int.Parse(Request.QueryString["id"].ToString());

            Ecard.DAL.DALRota p = new Ecard.DAL.DALRota();
            Ecard.Modelo.Rota ponto = p.Select(id);
            ponto.nome = TextBox1.Text;
            p.Update(ponto);
            Response.Redirect("~//CadastroRota.aspx");
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            id = int.Parse(Request.QueryString["id"]);
            Ecard.DAL.DALRota p = new Ecard.DAL.DALRota();
            Ecard.Modelo.Rota ponto = p.Select(id);
            p.Delete(ponto);
            Response.Redirect("~//CadastroRota.aspx");
        }
>>>>>>> 8b4e53278fe63098a130cfa91e798f00b2a21a50
    }
}