using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecardmark1
{
    public partial class EditarPonto : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = int.Parse(Request.QueryString["id"]);
            DAL.DALPonto_recarga p = new DAL.DALPonto_recarga();
            Modelo.Ponto_recarga ponto = p.Select(id);
            /*TextBox1.Text = ponto.nome_ponto;
            TextBox2.Text = ponto.endereco_logradouro;
            TextBox3.Text = ponto.endereco_bairro;
            TextBox4.Text = ponto.endereco_numero;
            TextBox5.Text = ponto.endereco_cep;
            TextBox6.Text = ponto.endereco_municipio;*/
        }
        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            DAL.DALPonto_recarga p = new DAL.DALPonto_recarga();
            Modelo.Ponto_recarga ponto = p.Select(id);
            ponto.nome_ponto = TextBox1.Text;
            ponto.endereco_logradouro = TextBox2.Text;
            ponto.endereco_bairro = TextBox3.Text;
            ponto.endereco_numero = TextBox4.Text;
            ponto.endereco_cep = TextBox5.Text;
            ponto.endereco_municipio = TextBox6.Text;
            p.Update(ponto);
            Response.Redirect("~//CadastroPonto.aspx");
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            DAL.DALPonto_recarga p = new DAL.DALPonto_recarga();
            Modelo.Ponto_recarga ponto = p.Select(id);
            p.Delete(ponto);
            Response.Redirect("~//CadastroPonto.aspx");
        }
    }
}