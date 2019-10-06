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
            if (Session["logged"] != null)
            {
                if (Session["accesslevel"] == "instituicao") Response.Redirect("~/WebFormTelaPrincipalInstituicao.aspx");
                if (Session["accesslevel"] == "estudante") Response.Redirect("~/TelaPrincipalEstudante.aspx");
            }
            else
            {
                Response.Redirect("~/TelaInicial.aspx");
            }

            DALBairro dal_bairro = new DALBairro();
            ListItem li;
            foreach (Bairro b in dal_bairro.SelectAll())
            {
                li =  new ListItem();
                li.Text = b.Nome;
                li.Value = (b.Id).ToString();
                DropDownBairro.Items.Add(li);
            }
            DALPonto_referencia dal_referencia = new DALPonto_referencia();
            foreach (Ponto_referencia p in dal_referencia.SelectAll())
            {
                li = new ListItem();
                li.Text = p.Nome;
                li.Value = (p.Id).ToString();
                DropDownReferencia.Items.Add(li);
            }


        }
    
        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            string nome = TextBoxNome.Text;
            Rota rota = new Rota(nome);
            DALRota d = new DALRota();
            d.Insert(rota,int.Parse(DropDownReferencia.SelectedItem.Value),int.Parse(DropDownBairro.SelectedItem.Value));
            Response.Redirect("~//CadastroRota.aspx"); 
        }
    }
}