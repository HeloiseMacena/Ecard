using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecardmark1
{
    public partial class CadastroPonto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       /* protected void pModal_Click(object sender, EventArgs e)
        {
            string id = btnModal.CommandArgument;
            DAL.DALPonto_recarga aDALPonto_recarga;

            aDALPonto_recarga = new DAL.DALPonto_recarga();

            lblModalNumero.Text = aDALPonto_recarga.Select(id).ElementAt(0).endereco_numero;
            lblModalCEP.Text = aDALPonto_recarga.Select(id).ElementAt(0).endereco_cep;
        }*/
    }
}