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
    public partial class TelaPrincipalEstudante : System.Web.UI.Page
    {
        DAL.DALEstudante aDALEstudante = new DAL.DALEstudante();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                welcome.Style["display"] = "block";
                solicitado.Style["display"] = "none";
                deferido.Style["display"] = "none";
                indeferido.Style["display"] = "none";
            }

            int a = int.Parse((Session["userid"].ToString()));

            if (aDALEstudante.SelectStatusCarteira(a) == 0)
            {
                welcome.Text = "Bem Vindo ao Ecard! Adquira a sua carteira";
                welcome.Style["display"] = "block";
                solicitado.Style["display"] = "none";
                deferido.Style["display"] = "none";
                indeferido.Style["display"] = "none";
            }

            if (aDALEstudante.SelectStatusCarteira(a) == 1)
            {
                solicitado.Text = "Aguardando Aprovação. Espere o deferimento de sua carteira.";
                welcome.Style["display"] = "none";
                solicitado.Style["display"] = "block";
                deferido.Style["display"] = "none";
                indeferido.Style["display"] = "none";
            }

            if (aDALEstudante.SelectStatusCarteira(a) == 2)
            {
                deferido.Text = "Solicitação deferida. Você deverá pegar a sua carteira de estudante no NatalCard zona sul Av.Sen.Salgado filho (Próximo à Agaé) - Candelária, Natal / RN ";
                welcome.Style["display"] = "none";
                solicitado.Style["display"] = "none";
                deferido.Style["display"] = "block";
                indeferido.Style["display"] = "none";
            }

            if (aDALEstudante.SelectStatusCarteira(a) == 3)
            {
                indeferido.Text = "Solicitação Indeferida. Por favor verifique se a foto que foi enviada condiz com os critérios";
                welcome.Style["display"] = "none";
                solicitado.Style["display"] = "none";
                deferido.Style["display"] = "none";
                indeferido.Style["display"] = "block";
            }

            if (Session["logged"] != null)
            {
                if (Session["accesslevel"] == "instituicao") Response.Redirect("~/TelaPrincipalInstituicao.aspx");
                if (Session["accesslevel"] == "administrador") Response.Redirect("~/WebFormTelaPrincipalAdm.aspx");
            }
            else
            {
                Response.Redirect("~/TelaInicial.aspx");
            }
        }
    }
}