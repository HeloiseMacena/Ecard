using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecard
{
    public partial class SolicitacaoInstituicao : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            modalContainer.Style.Add("visibility", "hidden");
            using (var con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ecard"].ConnectionString))
            {
                con.Open();

                using (var cmd = new SqlCommand("select * from instituicao where status=0", con))
                {
                    Repeater1.DataSource = cmd.ExecuteReader();
                    Repeater1.DataBind();
                }
            }
        }
        protected void ToggleModal_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "ToggleModal", "ToggleModal()", true);
        }

        protected void getModalInfos_Click(object sender, EventArgs e)
        {
            id = int.Parse(((Button)sender).CommandArgument.ToString());
            DAL.DALInstituicao p = new DAL.DALInstituicao();
            Modelo.Instituicao ponto = p.Select(id);
            Id_instituicao.Text = ponto.Id.ToString();
            Modalnome1.Text = ponto.Nome;
            Modalemail1.Text = ponto.Email;
            Modalcodigo1.Text = ponto.Codigo_inep_mec;
            Modalcnpj1.Text = ponto.cnpj;
            modalContainer.Style.Add("visibility", "visible");
        }


        protected void Enviar_click(object sender, EventArgs e)
        {
            id = int.Parse(Id_instituicao.Text);
            DAL.DALSolicitacao_instituicao dal_solicitacao = new DAL.DALSolicitacao_instituicao();
            Modelo.Solicitacao_instituicao solicitacao = dal_solicitacao.SelectInstituicao(id);
            solicitacao.descricao_erro = erro.SelectedItem.Text;
            DAL.DALInstituicao p = new DAL.DALInstituicao();
            Modelo.Instituicao instituicao = p.Select(id);
            if (erro.SelectedIndex == 0)
            {
                solicitacao.status = 2;
                instituicao.Status = 2;
            }
            else
            {
                solicitacao.status = 1;
                instituicao.Status = 1;

            }
            dal_solicitacao.Update(solicitacao);
            p.AlterarStatus(instituicao);
            Response.Redirect("~/SolicitacaoInstituicao.aspx");

        }

    }
}