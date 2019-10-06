﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecard
{
    public partial class CadastroRota : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["logged"] != null)
            {
                if (Session["accesslevel"] == "instituicao") Response.Redirect("~/WebFormTelaPrincipalInstituicao.aspx");
                if (Session["accesslevel"] == "estudante") Response.Redirect("~/TelaPrincipalEstudante.aspx");
            }
            else
            {
                Response.Redirect("~/TelaInicial.aspx");
            }
        }

        /*  protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
         {
             if (e.CommandName == "Editar")
             {
                 string codigo;
                 int index = Convert.ToInt32(e.CommandArgument);
                 codigo = GridView1.Rows[index].Cells[0].Text;
                 Session["id"] = codigo;
                 Response.Redirect("~\\EditarRota.aspx");
             }
         } */
    }
}
 
 