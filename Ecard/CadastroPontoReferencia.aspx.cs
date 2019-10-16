﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecard
{
    public partial class CadastroPontoReferencia : System.Web.UI.Page
    {
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
        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string option = DDLSearch.Text;
                string value = valueSearch.Text;

                DAL.DALPonto_referencia aDALPonto_referencia = new DAL.DALPonto_referencia();

                Repeater1.DataSourceID = null;
                Repeater1.DataSource = aDALPonto_referencia.SearchSelect(value, option);
                Repeater1.DataBind();
            }
            catch { }
        }
    }
}