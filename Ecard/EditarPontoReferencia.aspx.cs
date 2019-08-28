using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecard
{
    public partial class EditarPontoReferencia : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = int.Parse(Request.QueryString["id"]);
            Ecardmark1.DAL.DALPonto_referencia p = new Ecardmark1.DAL.DALPonto_referencia();
            Ecardmark1.Modelo.Ponto_referencia Ponto_referencia = p.Select(id);
            //TextBox1.Text = Ponto_referencia.Nome;
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            Ecardmark1.DAL.DALPonto_referencia p = new Ecardmark1.DAL.DALPonto_referencia();
            Ecardmark1.Modelo.Ponto_referencia ponto = p.Select(id);
            ponto.Nome = TextBox1.Text;
            p.Update(ponto);
            Response.Redirect("~//CadastroPontoReferencia.aspx");
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Ecardmark1.DAL.DALPonto_referencia p = new Ecardmark1.DAL.DALPonto_referencia();
            Ecardmark1.Modelo.Ponto_referencia ponto = p.Select(id);
            p.Delete(ponto);
            Response.Redirect("~//CadastroPontoReferencia.aspx");
        }
    }
}