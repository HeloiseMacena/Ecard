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
                if (Session["accesslevel"] == "instituicao") Response.Redirect("~/TelaPrincipalInstituicao.aspx");
                if (Session["accesslevel"] == "administrador") Response.Redirect("~/TelaPrincipalAdm.aspx");
            }
            else
            {
                Response.Redirect("~/TelaInicial.aspx");
            }
            DALEstudante estudante = new DALEstudante();
            Modelo.Estudante es = estudante.Select(int.Parse(Session["userid"].ToString()));
            LabelSaldo.Text = es.carteira_saldo.ToString();

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            DAL.DALEstudante aEstudante = new DAL.DALEstudante();
            int a = int.Parse(Session["userid"].ToString());
            if (aEstudante.SelectStatus(a) != 1)
            {
                double valor = double.Parse(TextBoxRecarga.Text);
                int id = int.Parse(Session["userid"].ToString());
                DALEstudante dal = new DALEstudante();
                Modelo.Estudante estudante = dal.Select(id);
                DALRecarga dalrec = new DALRecarga();
                Modelo.Recarga r = new Modelo.Recarga(valor);
                dalrec.Insert(r, estudante.id);
                estudante.carteira_saldo += valor;
                dal.Update(estudante);
                DALExtrato c = new DALExtrato();
                Modelo.Extrato d = new Modelo.Extrato();
                d.valor = valor;
                d.data = DateTime.Now;
                c.Insert(d, a);
                LabelSaldo.Text = estudante.carteira_saldo.ToString();
                Response.Redirect("~/TelaPrincipalEstudante.aspx");
            }
        }
    }
}