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
            if (!IsPostBack)
            {
                TextBox1.Text = rota.nome;
                DAL.DALBairro dal_bairro = new DAL.DALBairro();
                ListItem li;
                foreach (Modelo.Bairro b in dal_bairro.SelectAll())
                {
                    li = new ListItem();
                    li.Text = b.Nome;
                    li.Value = (b.Id).ToString();
                    if (p.HasBairro(b.Id, rota.id)) li.Selected = true;
                    ListBoxBairro.Items.Add(li);
                }
                DAL.DALPonto_referencia dal_referencia = new DAL.DALPonto_referencia();
                foreach (Modelo.Ponto_referencia ponto in dal_referencia.SelectAll())
                {
                    li = new ListItem();
                    li.Text = ponto.Nome;
                    li.Value = (ponto.Id).ToString();
                    if (p.HasReferencia(ponto.Id, rota.id)) li.Selected = true;
                    ListBoxReferencia.Items.Add(li);
                }
            }

        }
        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            id = int.Parse(Request.QueryString["id"].ToString());

            DAL.DALRota p = new Ecard.DAL.DALRota();
            Modelo.Rota ponto = p.Select(id);
            ponto.nome = TextBox1.Text;
            List<int> bairros = new List<int>();
            foreach (ListItem b in ListBoxBairro.Items)
            {
                if (b.Selected) bairros.Add(int.Parse(b.Value.ToString()));
            }
            List<int> referencias = new List<int>();
            foreach (ListItem r in ListBoxReferencia.Items)
            {
                if (r.Selected)
                {
                    referencias.Add(int.Parse(r.Value.ToString()));
                }
            }
            if (referencias.Count != 0 && bairros.Count != 0)
            {
                p.Update(ponto, referencias, bairros);
                Response.Redirect("~//CadastroRota.aspx");
            }
            else
            {
                if (bairros.Count == 0) CustomValidator1.IsValid = false;
                if (referencias.Count == 0) CustomValidator2.IsValid = false;
            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            id = int.Parse(Request.QueryString["id"]);
            DAL.DALRota p = new DAL.DALRota();
            Modelo.Rota ponto = p.Select(id);
            p.Delete(ponto);
            Response.Redirect("~//CadastroRota.aspx");
        }


    }
}