﻿using System;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            modalContainer.Style.Add("visibility", "hidden");
            if (Session["logged"] != null)
            {
                if (Session["accesslevel"] == "instituicao") Response.Redirect("~/WebFormTelaPrincipalInstituicao.aspx");
                if (Session["accesslevel"] == "estudante") Response.Redirect("~/TelaPrincipalEstudante.aspx");
            }
            else
            {
                Response.Redirect("~/TelaInicial.aspx");
            }

            using (var con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ecard"].ConnectionString))
            {
                con.Open();

                using (var cmd = new SqlCommand("select * from solicitacao_instituicao where status=0", con))
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
<<<<<<< HEAD
            int id = int.Parse(((Button)sender).CommandArgument.ToString());
            DAL.DALInstituicao p = new DAL.DALInstituicao();
            Modelo.Instituicao ponto = p.Select(id);
            Modalnome.Text = ponto.Nome;
            Modalemail.Text = ponto.Email;
            Modalcodigo.Text = ponto.Codigo_inep_mec;
            Modalcnpj.Text = ponto.cnpj;

            modalContainer.Style.Add("visibility", "visible");
=======
            //modalContainer.Style.Add("visibility", "visible");
            int id = int.Parse(((Button)sender).CommandArgument.ToString());
            DAL.DALInstituicao i = new DAL.DALInstituicao();
            Modelo.Instituicao instituicao = i.Select(id);
            modalNome.Text = instituicao.Nome;
            modalEmail.Text = instituicao.Email;
            modalCodigo.Text = instituicao.Codigo_inep_mec;

            //modalContainer.Style.Add("visibility", "visible");
        }

        protected void Recusar_click(object sender, EventArgs e)
        {

        }

        protected void Aceitar_click(object sender, EventArgs e)
        {

>>>>>>> d5cc7a8e95d967c2e3e7180d05426bbbfed515d7
        }


        /*protected void Button1_Click(object sender, EventArgs e)
{

   DAL.DALEstudante aDALEstudante = new DAL.DALEstudante();
   List<Modelo.Estudante> aListEstudante;
   int id = int.Parse(Session["userid"].ToString());

   string Arquivo = FileUpload1.FileName;

   if (FileUpload1.HasFile)
   {
       string nomeArquivo = Path.GetFileName(FileUpload1.PostedFile.FileName);
       FileUpload1.PostedFile.SaveAs(Server.MapPath("~/Teste/" + nomeArquivo));
       resposta.Text = "Arquivo enviado com sucesso";

       aListEstudante = aDALEstudante.SelectArquivoCsv(Arquivo);

       if (aListEstudante.Count > 0)
       {
           aDALEstudante.MudarSituacaoFalse(id);

           for (int i = 0; i < aListEstudante.Count; i++)
           {
               if (aDALEstudante.SelectComparacao(aListEstudante[i].cpf) == true)
               {
                   aDALEstudante.MudarSituacaoTrue(aListEstudante[i].cpf);
               }
               else
               {
                   aDALEstudante.Insert(aListEstudante[i]);
               }
           }
       }
   }
   else resposta.Text = "Por favor, selecione um arquivo a enviar";
}*/
    }
}