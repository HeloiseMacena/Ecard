using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecard
{
    public partial class EditarBairro : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // PARA EVITAR QUE ATUALIZE OS DADOS COM O BOTÃO DE UPDATE 
            {
                string id;
                id = Request.QueryString["id"]; // GET ID PELA QUERYSTRING

                Ecardmark1.DAL.DALBairro aDALBairro; // INSTANCIA DO DALBairro
                aDALBairro = new Ecardmark1.DAL.DALBairro(); // ATRIBUIÇÂO DA INSTANCIA EM UMA VARIÁVEL

                txtNome.Text = aDALBairro.Select(id).ElementAt(0).nome; // SELECT DO NOME DO BAIRRO
            }
        }

        protected void Update_Click(object sender, EventArgs e)
        {
            string id;
            id = Request.QueryString["id"];

            Ecardmark1.DAL.DALBairro aDALBairro;
            aDALBairro = new Ecardmark1.DAL.DALBairro();

            Ecardmark1.Modelo.Bairro aBairro; // INSTANCIA DO MODELO (NECESSARIO PRO UPDATE)
            aBairro = new Ecardmark1.Modelo.Bairro(int.Parse(id), txtNome.Text); // CRIAÇÃO DO MODELO COM OS DADOS

            aDALBairro.Update(aBairro); // EXECUÇÃO DA AÇÂO (UPDATE) NO MODELO CRIADO

            Response.Redirect("CadastroBairro.aspx");
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            string id;
            id = Request.QueryString["id"];

            Ecardmark1.DAL.DALBairro aDALBairro;
            aDALBairro = new Ecardmark1.DAL.DALBairro();

            Ecardmark1.Modelo.Bairro aBairro; // INSTANCIA DO MODELO (NECESSARIO PRO DELETE)
            aBairro = new Ecardmark1.Modelo.Bairro(int.Parse(id), txtNome.Text);

            aDALBairro.Delete(aBairro); // EXECUÇÃO DA AÇÂO (DELETE) NO MODELO CRIADO
            Response.Redirect("CadastroBairro.aspx");
        }
    }
}