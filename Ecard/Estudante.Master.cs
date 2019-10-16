﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ecard.DAL;
using Ecard.Modelo;

namespace Ecard
{
    public partial class Estudante : System.Web.UI.MasterPage
    {
        DALEstudante dal;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["logged"] != null)
            {
                if (Session["accesslevel"] == "instituicao") Response.Redirect("~/TelaPrincipalInstituicao.aspx");
                if (Session["accesslevel"] == "administrador") Response.Redirect("~/WebFormTelaPrincipalAdm.aspx");
            }
            else
            {
                Response.Redirect("~/TelaInicial.aspx");
            }
            dal = new DALEstudante();
            Modelo.Estudante estudante = dal.Select(int.Parse(Session["userid"].ToString()));
            usuario.Text = estudante.nome.ToString();
            nome_usuario.Text = estudante.nome.ToString();
            saldo.Text = "R$ " + estudante.carteira_saldo.ToString(); 

            string pageName = Path.GetFileNameWithoutExtension(Page.AppRelativeVirtualPath);
            switch(pageName)
            {
                case "TelaPrincipalEstudante":
                    break;

                case "PerfilEstudante":
                    box2.Style.Add("display", "none");
                    box2Card.Style.Add("display", "none");
                    break;
                case "CalcularPassagem":
                    box2Ponto.Style.Add("display", "none");
                    box2Card.Style.Add("display", "none");
                    break;
                case "ConsultaPontodeRecarga":
                    box2Card.Style.Add("display", "none");
                    break;
                case "Recarga":
                    box2Card.Style.Add("display", "none");
                    break;
                case "PesquisarRota":
                    box2Card.Style.Add("display", "none");
                    break;
                case "TelaSolicitacaoCarteira":
                    box2Card.Style.Add("display", "none");
                    break;
            }
            
        }
    }
}