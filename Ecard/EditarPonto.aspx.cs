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
        protected void Page_Load(object sender, EventArgs e)
        {   
            if (!IsPostBack)
            {
                string id;
                id = Request.QueryString["id"];
                Ecardmark1.DAL.DALPonto_recarga aDALPonto_recarga;

                aDALPonto_recarga = new Ecardmark1.DAL.DALPonto_recarga();

                TextPonto.Text = aDALPonto_recarga.Select(id).ElementAt(0).nome_ponto;
                TextRua.Text = aDALPonto_recarga.Select(id).ElementAt(0).endereco_logradouro;
                TextBairro.Text = aDALPonto_recarga.Select(id).ElementAt(0).endereco_bairro;
                TextNumero.Text = aDALPonto_recarga.Select(id).ElementAt(0).endereco_numero;
                TextCEP.Text = aDALPonto_recarga.Select(id).ElementAt(0).endereco_cep;
                TextMunicipio.Text = aDALPonto_recarga.Select(id).ElementAt(0).endereco_municipio;
            }
        }

        protected void Update_Click(object sender, EventArgs e)
        {
            string id;
            id = Request.QueryString["id"];

            Ecardmark1.DAL.DALPonto_recarga aDALPonto_recarga;
            aDALPonto_recarga = new Ecardmark1.DAL.DALPonto_recarga();

            Ecardmark1.Modelo.Ponto_recarga aPonto_recarga;
            aPonto_recarga = new Ecardmark1.Modelo.Ponto_recarga(int.Parse(id), TextPonto.Text, TextNumero.Text, TextRua.Text, TextCEP.Text, TextBairro.Text, TextMunicipio.Text);
            aDALPonto_recarga.Update(aPonto_recarga);
            Response.Redirect("CadastroPonto.aspx");
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            string id;
            id = Request.QueryString["id"];

            Ecardmark1.DAL.DALPonto_recarga aDALPonto_recarga;
            aDALPonto_recarga = new Ecardmark1.DAL.DALPonto_recarga();

            Ecardmark1.Modelo.Ponto_recarga aPonto_recarga;
            aPonto_recarga = new Ecardmark1.Modelo.Ponto_recarga(int.Parse(id), TextPonto.Text, TextNumero.Text, TextRua.Text, TextCEP.Text, TextBairro.Text, TextMunicipio.Text);

            aDALPonto_recarga.Delete(aPonto_recarga); 
            Response.Redirect("CadastroPonto.aspx");
        }

    }
}