using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecard
{
    public partial class EditarPonto : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["logged"] != null)
            {
                if (Session["accesslevel"] == "instituicao") Response.Redirect("~/TelaPrincipalInstituicao.aspx");
                if (Session["accesslevel"] == "estudante") Response.Redirect("~/TelaPrincipalEstudante.aspx");
            }
            else
            {
                Response.Redirect("~/TelaInicial.aspx");
            }

            if (!IsPostBack)
            {
                id = int.Parse(Request.QueryString["id"]);
                DAL.DALPonto_recarga p = new DAL.DALPonto_recarga();
                Modelo.Ponto_recarga ponto = p.Select(id);
                TextPonto.Text = ponto.nome_ponto;
                TextRua.Text = ponto.endereco_logradouro;
                TextBairro.Text = ponto.endereco_bairro;
                TextNumero.Text = ponto.endereco_numero;
                TextCEP.Text = ponto.endereco_cep;
                TextMunicipio.Text = ponto.endereco_municipio;
            }

        }
        protected void Update_Click(object sender, EventArgs e)
        {
            id = int.Parse(Request.QueryString["id"]);
            DAL.DALPonto_recarga p = new DAL.DALPonto_recarga();
            Modelo.Ponto_recarga ponto = p.Select(id);
            ponto.nome_ponto = TextPonto.Text;
            ponto.endereco_logradouro = TextRua.Text;
            ponto.endereco_bairro = TextBairro.Text;
            ponto.endereco_numero = TextNumero.Text;
            ponto.endereco_cep = TextCEP.Text;
            ponto.endereco_municipio = TextMunicipio.Text;
            p.Update(ponto);
            Response.Redirect("~//CadastroPonto.aspx");
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            id = int.Parse(Request.QueryString["id"]);
            DAL.DALPonto_recarga p = new DAL.DALPonto_recarga();
            Modelo.Ponto_recarga ponto = p.Select(id);
            p.Delete(ponto);
            Response.Redirect("~//CadastroPonto.aspx");
        }
    }
}