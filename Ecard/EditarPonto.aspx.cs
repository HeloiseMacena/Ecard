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
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            DAL.DALPonto_recarga p = new DAL.DALPonto_recarga();
            Modelo.Ponto_recarga ponto = p.Select(id);
            TextBox1.Text = ponto.nome_ponto;
            TextBox2.Text = ponto.endereco_logradouro;
            TextBox3.Text = ponto.endereco_bairro;
            TextBox4.Text = ponto.endereco_numero;
            TextBox5.Text = ponto.endereco_cep;
            TextBox6.Text = ponto.endereco_municipio;
        }


    }
}