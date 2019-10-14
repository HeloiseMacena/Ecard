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
    public partial class CadastroInstituicao : System.Web.UI.Pagehttp://localhost:63693/CadastroInstituicao.aspx.cs
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["logged"] != null)
            {
                if (Session["accesslevel"] == "instituicao") Response.Redirect("~/WebFormTelaPrincipalInstituicao.aspx");
                if (Session["accesslevel"] == "estudante") Response.Redirect("~/TelaPrincipalEstudante.aspx");
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DALInstituicao dal = new DALInstituicao();
            Instituicao instituicao = new Instituicao(TextBox1.Text, TextEmail.Text, TextCodigo.Text, false, TextSenha.Text, TextBairro.Text, TextCEP.Text, TextMunicipio.Text, TextLogradouro.Text, TextNumero.Text, TextCNPJ.Text);
            dal.Insert(instituicao);
            Response.Redirect("~//TelaInicial.aspx");
        }
    }
}