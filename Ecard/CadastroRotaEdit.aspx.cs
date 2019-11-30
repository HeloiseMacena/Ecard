using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ecard.DAL;
using Ecard.Modelo;

namespace Ecard
{
    public partial class CadastroRotaEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                /*DALBairro dal_bairro = new DALBairro();
                ListItem li;
                foreach (Bairro b in dal_bairro.SelectAll())
                {
                    li = new ListItem();
                    li.Text = b.Nome;
                    li.Value = (b.Id).ToString();
                    CheckBoxListBairro.Items.Add(li);
                }
                DALPonto_referencia dal_referencia = new DALPonto_referencia();
                foreach (Ponto_referencia p in dal_referencia.SelectAll())
                {
                    li = new ListItem();
                    li.Text = p.Nome;
                    li.Value = (p.Id).ToString();
                    CheckBoxListReferencia.Items.Add(li);
                }*/
                DAL.DALBairro dal_bairro = new DAL.DALBairro();
                ListItem li;
                foreach (Modelo.Bairro b in dal_bairro.SelectAll())
                {
                    li = new ListItem();
                    li.Text = b.Nome;
                    li.Value = (b.Id).ToString();
                    ListBoxBairro.Items.Add(li);
                }
                DAL.DALPonto_referencia dal_referencia = new DAL.DALPonto_referencia();
                foreach (Modelo.Ponto_referencia ponto in dal_referencia.SelectAll())
                {
                    li = new ListItem();
                    li.Text = ponto.Nome;
                    li.Value = (ponto.Id).ToString();
                    ListBoxReferencia.Items.Add(li);
                }
            }
            
        }
        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            string nome = TextBoxNome.Text;
            Rota rota = new Rota(nome);
            DALRota d = new DALRota();
            List<int> bairros = new List<int>();
            foreach (ListItem item in ListBoxBairro.Items)
            {
                if (item.Selected)
                {
                    bairros.Add(int.Parse(item.Value.ToString()));
                }
            }
            List<int> referencias = new List<int>();
            foreach (ListItem item in ListBoxReferencia.Items)
            {
                if (item.Selected)
                {
                    referencias.Add(int.Parse(item.Value.ToString()));
                }
            }
            if (referencias.Count != 0 && bairros.Count != 0)
            {
                d.Insert(rota, referencias, bairros);
                Response.Redirect("~//CadastroRota.aspx");
            }
            else
            {
                if (bairros.Count == 0) CustomValidator1.IsValid = false;
                if (referencias.Count == 0) CustomValidator2.IsValid = false;
            }
            
        }

    }
}