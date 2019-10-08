﻿using System;
using System.IO;
using System.Web;
using Ecard.DAL;

namespace Ecard
{
    public partial class TelaSolicitacaoCarteira : System.Web.UI.Page
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
            int id = int.Parse(Session["userid"].ToString());
            DALEstudante dal = new DALEstudante();
            DALInstituicao dal_instituicao = new DALInstituicao();
            Modelo.Estudante estudante = dal.Select(id);
            Modelo.Instituicao instituicao = dal_instituicao.Select(dal.instituicao_id(id));
            LabelNome.Text = estudante.nome;
            LabelRG.Text = estudante.rg;
            LabelCPF.Text = estudante.cpf;
            LabelInstituicao.Text = instituicao.Nome;
            Termo.Text = "Eu, " + estudante.nome +", CPF: "+ estudante.cpf + ", RG: " + estudante.rg;


        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                BinaryReader br = new BinaryReader(FileUpload1.PostedFile.InputStream);
                byte[] bytes = br.ReadBytes((int)FileUpload1.PostedFile.InputStream.Length);

                string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);


                byte[] imageBytes = Convert.FromBase64String(base64String);

                string filePath = Server.MapPath("~/Imagens/" + Path.GetFileName(FileUpload1.PostedFile.FileName));
                File.WriteAllBytes(filePath, imageBytes);

                userImage.ImageUrl = "Imagens/" + FileUpload1.FileName;
            } catch {
                
            }
        }

        protected void btnSendForm_Click(object sender, EventArgs e)
        {
            if (cbTerm.Checked)
            {
                int id = int.Parse(Session["userid"].ToString());
                DALEstudante dal = new DALEstudante();
                Modelo.Estudante estudante = dal.Select(id); 
                if (estudante.carteira_status == 0)
                {
                    dal.MudarSituacaoCarteira1(estudante.cpf);
                    Response.Redirect("~/TelaPrincipalEstudante.aspx");
                }
                
            }
        }
    }
}
