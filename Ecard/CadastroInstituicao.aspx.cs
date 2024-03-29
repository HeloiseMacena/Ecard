﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ecard.DAL;
using Ecard.Modelo;


namespace Ecard
{
    public partial class CadastroInstituicao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {     

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            DALInstituicao dal = new DALInstituicao();
            if (dal.ExisteCNPJ(TextCNPJ.Text) || dal.ExisteCodigo(TextCodigo.Text))
            {
                if (dal.ExisteCNPJ(TextCNPJ.Text)) CustomValidator2.IsValid = false;
                if (dal.ExisteCodigo(TextCodigo.Text)) CustomValidator1.IsValid = false;
            }
            else
            {
                Instituicao instituicao = new Instituicao(TextBox1.Text, TextEmail.Text, TextCodigo.Text, 0, TextSenha.Text, TextBairro.Text, TextCEP.Text, TextMunicipio.Text, TextLogradouro.Text, TextNumero.Text, TextCNPJ.Text);
                dal.Insert(instituicao);
                Response.Redirect("~//TelaInicial.aspx");
            }
            
        }
    }
}