using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ecard.DAL;

namespace Ecard
{
    public partial class SolicitacaoEstudante : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            modalContainer.Style.Add("visibility", "hidden");
            if (Session["logged"] != null)
            {
                if (Session["accesslevel"] == "instituicao") Response.Redirect("~/TelaPrincipalInstituicao.aspx");
                if (Session["accesslevel"] == "estudante") Response.Redirect("~/TelaPrincipalEstudante.aspx");
            }
            else
            {
                Response.Redirect("~/TelaInicial.aspx");
            }
            using (var con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ecard"].ConnectionString))
            {
                con.Open();

                using (var cmd = new SqlCommand("Select * from Solicitacao_carteira where status = 0", con))
                {
                    Repeater1.DataSource = cmd.ExecuteReader();
                    Repeater1.DataBind();
                }
            }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
                int id = int.Parse(((Button)sender).CommandArgument.ToString());
                DALSolicitacao_carteira dal = new DALSolicitacao_carteira();
                DALEstudante dal_e = new DALEstudante();
                Modelo.Solicitacao_carteira solicitacao = dal.Select(id);
                Modelo.Estudante estudante = dal_e.Select(dal.SelectEstudante(solicitacao.id));
                Modal_id.Text = id.ToString();
                Modal_data.Text = solicitacao.data.ToShortDateString();
                Modal_estudante.Text = estudante.nome;
                string nome_arquivo = estudante.cpf + ".jpg";
                Image1.ImageUrl = "~/Imagens/" + nome_arquivo;
                modalContainer.Style.Add("visibility", "visible");


        }
        protected void Aceitar_click(object sender, EventArgs e)
        {
            int id = int.Parse(Modal_id.Text);

            DAL.DALSolicitacao_carteira dal_solicitacao = new DAL.DALSolicitacao_carteira();
            Modelo.Solicitacao_carteira solicitacao = dal_solicitacao.Select(id);
            solicitacao.descricao_erro = erro.SelectedItem.Text;
            DAL.DALEstudante p = new DAL.DALEstudante();
            Modelo.Estudante estudante = p.Select(dal_solicitacao.SelectEstudante(id));
            if (erro.SelectedIndex == 0)
            {
                solicitacao.status = 2;
                estudante.carteira_status = 2;
            }
            else
            {
                solicitacao.status = 1;
                estudante.carteira_status = 3;

            }
            dal_solicitacao.Update(solicitacao);
            p.Update(estudante);
            Response.Redirect("~/SolicitacaoCarteira.aspx");

        }
    }
}