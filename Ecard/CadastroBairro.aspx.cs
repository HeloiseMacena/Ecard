﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecard
{
    public partial class CadastroBairro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string option = DDLSearch.Text;
                string value = valueSearch.Text;

                DAL.DALBairro aDALBairro = new DAL.DALBairro();

                Repeater1.DataSourceID = null;
                Repeater1.DataSource = aDALBairro.SearchSelect(value, option);
                Repeater1.DataBind();
            }
            catch { }
        }
    }
}