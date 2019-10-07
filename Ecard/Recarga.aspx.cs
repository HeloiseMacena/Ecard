using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ecard.DAL;

namespace Ecard
{
    public partial class Recarga : System.Web.UI.Page
    {
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
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            
            double valor = double.Parse(TextBoxRecarga.Text);
            int id = int.Parse(Session["userid"].ToString());
            DALEstudante dal = new DALEstudante();
            Modelo.Estudante estudante = dal.Select(id);
            DALRecarga dalrec = new DALRecarga();
            Modelo.Recarga r = new Modelo.Recarga(valor);
            dalrec.Insert(r, estudante.id, 1);
            estudante.carteira_saldo += valor;
            dal.Update(estudante);
            Response.Redirect("~/TelaPrincipalEstudante.aspx");
        }
    }
}