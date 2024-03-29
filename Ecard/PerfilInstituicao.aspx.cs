﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ecard.DAL;

namespace Ecard
{
    public partial class PerfilInstituicao : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                id = int.Parse(Session["userid"].ToString());
                DALInstituicao dal = new DALInstituicao();
                Modelo.Instituicao instituicao = dal.Select(id);
                Nome.Text = instituicao.Nome;
                Email.Text = instituicao.Email;
            }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            id = int.Parse(Session["userid"].ToString());
            DALInstituicao dal = new DALInstituicao();
            Modelo.Instituicao instituicao = dal.Select(id);
            if (TextAtual.Text == instituicao.Senha)
            {
                instituicao.Senha = TextNova.Text;
                dal.Update(instituicao);
                Response.Redirect("~/PerfilInstituicao.aspx");
            }
            else
            {
                CustomValidator1.IsValid = false;
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            id = int.Parse(Session["userid"].ToString());
            DALInstituicao dal = new DALInstituicao();
            Modelo.Instituicao instituicao = dal.Select(id);
            if (instituicao.Nome != Nome.Text)
            {
                instituicao.Nome = Nome.Text;
                dal.Update(instituicao);
                Response.Redirect("~/PerfilInstituicao.aspx");
            }
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            id = int.Parse(Session["userid"].ToString());
            DALInstituicao dal = new DALInstituicao();
            Modelo.Instituicao instituicao = dal.Select(id);
            if (instituicao.Email != Email.Text)
            {
                instituicao.Email = Email.Text;
                dal.Update(instituicao);
                Response.Redirect("~/PerfilInstituicao.aspx");
            } 
        }

    }
}