using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecard
{
    public partial class CadastroEstudante : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public static bool ValidaCPF(string vrCPF)
        {
            string valor = vrCPF.Replace(".", "");
            valor = valor.Replace("-", "");

            if (valor.Length != 11)
                return false;

            bool igual = true;
            for (int i = 1; i < 11 && igual; i++)
                if (valor[i] != valor[0])
                    igual = false;

            if (igual || valor == "12345678909")
                return false;

            int[] numeros = new int[11];
            for (int i = 0; i < 11; i++)
                numeros[i] = int.Parse(
                valor[i].ToString());

            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += (10 - i) * numeros[i];

            int resultado = soma % 11;
            if (resultado == 1 || resultado == 0)
            {
                if (numeros[9] != 0)
                    return false;
            }
            else if (numeros[9] != 11 - resultado)
                return false;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += (11 - i) * numeros[i];

            resultado = soma % 11;

            if (resultado == 1 || resultado == 0)
            {
                if (numeros[10] != 0)
                    return false;

            }
            else
                if (numeros[10] != 11 - resultado)
                return false;
            return true;

        }

        
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Ecard.Modelo.Estudante pr = new Ecard.Modelo.Estudante(TextNome.Text, TextCPF.Text, Convert.ToString(TextRG.Text), TextEmail.Text, TextSenha.Text, 0, "roberta", 0, 55, DateTime.Now);
            Ecard.DAL.DALEstudante dal = new Ecard.DAL.DALEstudante();
            if (dal.ExisteEstudante(TextCPF.Text) == false)
            {
                dal.Insert(pr);
            }
            else
            {
                dal.Update(pr);
                dal.MudarSituacaoEstudante(0, TextCPF.Text);
            }
            Response.Redirect("~//TelaInicial.aspx");
        }

        protected void ValidateCPF (object source, ServerValidateEventArgs args)
        {
            if (ValidaCPF(TextCPF.Text) != true)
            {
                args.IsValid = false;
                return;
            }           
        }
    }
}