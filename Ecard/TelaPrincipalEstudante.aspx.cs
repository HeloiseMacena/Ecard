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
        DALEstudante dal;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["logged"] != null)
            {
                if (Session["accesslevel"] == "instituicao") Response.Redirect("~/WebFormTelaPrincipalInstituicao.aspx");
                if (Session["accesslevel"] == "administrador") Response.Redirect("~/WebFormTelaPrincipalAdm.aspx");
            }
            else
            {
                Response.Redirect("~/TelaInicial.aspx");
            }
            dal = new DALEstudante();
            Modelo.Estudante estudante = dal.Select(int.Parse(Session["userid"].ToString()));
            nome_usuario.Text = "<h1>" + estudante.nome.ToString() + "</h1>";
            saldo.Text = "R$ " + estudante.carteira_saldo.ToString();

        }
    }
}