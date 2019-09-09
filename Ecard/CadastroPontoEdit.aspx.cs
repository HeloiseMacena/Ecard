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

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            Modelo.Ponto_recarga pr = new Modelo.Ponto_recarga(TextBox1.Text, TextBox4.Text, TextBox2.Text, TextBox5.Text, TextBox3.Text, TextBox6.Text);
            DAL.DALPonto_recarga dal = new DAL.DALPonto_recarga();
            dal.Insert(pr);
            Response.Redirect("~//CadastroPonto.aspx");

        }
        /* {
                DAL.DALBAtividades aDALBAtividades;
                aDALBAtividades = new DAL.DALBAtividades();
                atv_data.Text = aDALBAtividades.SelectByAtv(Session["ATV_ID"].ToString()).ElementAt(0).atv_data;
                atv_horario.Text = aDALBAtividades.SelectByAtv(Session["ATV_ID"].ToString()).ElementAt(0).atv_horario;
                atv_descricao.Text = aDALBAtividades.SelectByAtv(Session["ATV_ID"].ToString()).ElementAt(0).atv_descricao;
         }*/

}
}