using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
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

        public static class ValidaCPF
        {
            public static string FormatCPF(string CPF)
            {
                return Convert.ToUInt64(CPF).ToString(@"000\.000\.000\-00");
            }
            public static string SemFormatacao(string Codigo)
            {
                return Codigo.Replace(".", string.Empty).Replace("-", string.Empty);
            }
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
    }
}