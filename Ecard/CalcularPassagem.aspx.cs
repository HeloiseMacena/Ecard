using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecard
{
    public partial class CalcularPassagem : System.Web.UI.Page
    {
        DAL.DALValorPassagem a = new DAL.DALValorPassagem();
        DAL.DALEstudante b = new DAL.DALEstudante();
        double valorbase1;
        double valorbase2;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label2.Text = "R$ " + a.SelectValor("Natal");
                Label3.Text = "R$ " + a.SelectValorInteiro("Natal");
                valorbase1 = double.Parse(a.SelectValor("Natal"));
                valorbase2 = double.Parse(a.SelectValorInteiro("Natal"));
            }
        }

        protected void tipoPreco_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tipoPreco.SelectedItem.Value == "Natal")
            {
                Label2.Text = "R$ " + a.SelectValor("Natal");
                Label3.Text = "R$ " + a.SelectValorInteiro("Natal");
                valorbase1 = double.Parse(a.SelectValor("Natal"));
                valorbase2 = double.Parse(a.SelectValorInteiro("Natal"));
            }
            if (tipoPreco.SelectedItem.Value == "Parnamirim")
            {
                Label2.Text = "R$ " + a.SelectValor("Parnamirim");
                Label3.Text = "R$ " + a.SelectValorInteiro("Parnamirim");
                valorbase1 = double.Parse(a.SelectValor("Parnamirim"));
                valorbase2 = double.Parse(a.SelectValorInteiro("Parnamirim"));
            }
            if (tipoPreco.SelectedItem.Value == "Extremoz")
            {
                Label2.Text = "R$ " + a.SelectValor("Extremoz");
                Label3.Text = "R$ " + a.SelectValorInteiro("Extremoz");
                valorbase1 = double.Parse(a.SelectValor("Extremoz"));
                valorbase2 = double.Parse(a.SelectValorInteiro("Extremoz"));
            }
            if (tipoPreco.SelectedItem.Value == "Ceará")
            {
                Label2.Text = "R$ " + a.SelectValor("Ceará Mirim");
                Label3.Text = "R$ " + a.SelectValorInteiro("Ceará Mirim");
                valorbase1 = double.Parse(a.SelectValor("Ceará Mirim"));
                valorbase2 = double.Parse(a.SelectValorInteiro("Ceará Mirim"));
            }
            if (tipoPreco.SelectedItem.Value == "Amarante")
            {
                Label2.Text = "R$ " + a.SelectValor("São Gonçalo do Amarante");
                Label3.Text = "R$ " + a.SelectValorInteiro("São Gonçalo do Amarante");
                valorbase1 = double.Parse(a.SelectValor("São Gonçalo do Amarante"));
                valorbase2 = double.Parse(a.SelectValorInteiro("São Gonçalo do Amarante"));
            }
        }

        protected void ButtonCalc_Click(object sender, EventArgs e)
        {
            int valor1 = int.Parse(TextBoxRecarga.Text);
            int valor2 = int.Parse(TextBox1.Text);
            int dias = int.Parse(TextBox2.Text);
            double saldo = b.SelectSaldo(int.Parse(Session["userid"].ToString()));
            double sobra = 0;
            double falta = 0;
            double valorTotal = dias * ((valor1 * valorbase1) + (valor2 * valorbase2));

            double verificacao = saldo - valorTotal;

            if (verificacao > 0)
            {
                sobra = verificacao;
                ResulSobra.Text = "R$ " + sobra;
            }
            else
            {
                falta = verificacao * -1;
                ResulFalta.Text = "R$ " + falta;
            }

            Label8.Text = "R$ " + saldo;
            Label10.Text = "R$ " + valorTotal;
        }
    }
}