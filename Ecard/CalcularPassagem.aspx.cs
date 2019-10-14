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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed3_Click(object sender, EventArgs e)
        {
            DAL.DALValorPassagem a = new DAL.DALValorPassagem();

            if(tipoPreco.SelectedItem.Value == "Natal")
            {
                Label2.Text = "R$ " + a.SelectValor("Natal");
                Label3.Text = "R$ " + a.SelectValor("Natal");
            }
            if (tipoPreco.SelectedItem.Value == "Parnamirim")
            {
                Label2.Text = "R$ " + a.SelectValor("Parnamirim");
                Label3.Text = "R$ " + a.SelectValor("Parnamirim");
            }
            if (tipoPreco.SelectedItem.Value == "Extremoz")
            {
                Label2.Text = "R$ " + a.SelectValor("Extremoz");
                Label3.Text = "R$ " + a.SelectValor("Extremoz");
            }
            if (tipoPreco.SelectedItem.Value == "Ceará")
            {
                Label2.Text = "R$ " + a.SelectValor("Ceará");
                Label3.Text = "R$ " + a.SelectValor("Ceará");
            }
            if (tipoPreco.SelectedItem.Value == "Amarante")
            {
                Label2.Text = "R$ " + a.SelectValor("São Gonçalo do Amarante");
                Label3.Text = "R$ " + a.SelectValor("São Gonçalo do Amarante");
            }
        }
    }
}