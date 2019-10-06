using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Ecard.DAL
{
    public class DALPonto_recarga
    {
        string connectionString = "";



        public DALPonto_recarga()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ecard"].ConnectionString;
        }



        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Ponto_recarga> SelectAll()
        {
            List<Modelo.Ponto_recarga> aListPonto_recarga = new List<Modelo.Ponto_recarga>();

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Ponto_Recarga";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Modelo.Ponto_recarga aPonto_recarga = new Modelo.Ponto_recarga(
                         int.Parse(dr["id"].ToString()),
                        dr["nome_ponto"].ToString(),
                        dr["endereco_numero"].ToString(),
                        dr["endereco_logradouro"].ToString(),
                        dr["endereco_cep"].ToString(),
                        dr["endereco_bairro"].ToString(),
                        dr["endereco_municipio"].ToString()
                    );
                    aPonto_recarga.id = Convert.ToInt32(dr["id"].ToString());
                    aListPonto_recarga.Add(aPonto_recarga);
                }
            }
            dr.Close();
            conn.Close();

            return aListPonto_recarga;
        }

        public List<Modelo.Ponto_recarga> SearchSelect(string value, string option)
        {
            if (value == "" || value == null) { value = "%"; }

            List<Modelo.Ponto_recarga> aListPonto_recarga = new List<Modelo.Ponto_recarga>();

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            if (option == "Nome") cmd.CommandText = "SELECT * FROM Ponto_Recarga WHERE nome_ponto LIKE '" + value + "'";
            else if (option == "Logradouro") cmd.CommandText = "SELECT * FROM Ponto_Recarga WHERE endereco_logradouro LIKE '" + value + "'";
            else if (option == "Bairro") cmd.CommandText = "SELECT * FROM Ponto_Recarga WHERE endereco_bairro LIKE '" + value + "'";
            else if (option == "CEP") cmd.CommandText = "SELECT * FROM Ponto_Recarga WHERE endereco_cep LIKE '" + value + "'";

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Modelo.Ponto_recarga aPonto_recarga = new Modelo.Ponto_recarga(
                         int.Parse(dr["id"].ToString()),
                        dr["nome_ponto"].ToString(),
                        dr["endereco_numero"].ToString(),
                        dr["endereco_logradouro"].ToString(),
                        dr["endereco_cep"].ToString(),
                        dr["endereco_bairro"].ToString(),
                        dr["endereco_municipio"].ToString()
                    );
                    aPonto_recarga.id = Convert.ToInt32(dr["id"].ToString());
                    aListPonto_recarga.Add(aPonto_recarga);
                }
            }
            dr.Close();
            conn.Close();

            return aListPonto_recarga;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(Modelo.Ponto_recarga obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("DELETE FROM Ponto_Recarga WHERE id = @id", conn);

            cmd.Parameters.AddWithValue("@id", obj.id);

            cmd.ExecuteNonQuery();

        }



        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Ponto_recarga obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("INSERT INTO Ponto_Recarga (nome_ponto, endereco_numero, endereco_logradouro, endereco_cep, endereco_bairro, endereco_municipio, administrador_id) VALUES (@nome_ponto, @endereco_numero, @endereco_logradouro, @endereco_cep, @endereco_bairro, @endereco_municipio, 1)", conn);

            cmd.Parameters.AddWithValue("@nome_ponto", obj.nome_ponto);
            cmd.Parameters.AddWithValue("@endereco_numero", obj.endereco_numero);
            cmd.Parameters.AddWithValue("@endereco_logradouro", obj.endereco_logradouro);
            cmd.Parameters.AddWithValue("@endereco_cep", obj.endereco_cep);
            cmd.Parameters.AddWithValue("@endereco_bairro", obj.endereco_bairro);
            cmd.Parameters.AddWithValue("@endereco_municipio", obj.endereco_municipio);

            cmd.ExecuteNonQuery();

        }



        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Ponto_recarga obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("UPDATE Ponto_Recarga SET nome_ponto = @nome_ponto, endereco_numero = @endereco_numero, endereco_logradouro = @endereco_logradouro, endereco_cep = @endereco_cep, endereco_bairro =  @endereco_bairro, endereco_municipio = @endereco_municipio  WHERE id = @id", conn);

            cmd.Parameters.AddWithValue("@id", obj.id);
            cmd.Parameters.AddWithValue("@nome_ponto", obj.nome_ponto);
            cmd.Parameters.AddWithValue("@endereco_numero", obj.endereco_numero);
            cmd.Parameters.AddWithValue("@endereco_logradouro", obj.endereco_logradouro);
            cmd.Parameters.AddWithValue("@endereco_cep", obj.endereco_cep);
            cmd.Parameters.AddWithValue("@endereco_bairro", obj.endereco_bairro);
            cmd.Parameters.AddWithValue("@endereco_municipio", obj.endereco_municipio);

            cmd.ExecuteNonQuery();
        }



        [DataObjectMethod(DataObjectMethodType.Select)]
        public Modelo.Ponto_recarga Select(int Id)
        {
            Modelo.Ponto_recarga aPonto_recarga;
            Modelo.Ponto_recarga aListPonto_recarga = new Modelo.Ponto_recarga();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Ponto_recarga Where id = @id";
            cmd.Parameters.AddWithValue("@id", Id);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aPonto_recarga = new Modelo.Ponto_recarga(
                        int.Parse(dr["id"].ToString()),
                        dr["nome_ponto"].ToString(),
                        dr["endereco_numero"].ToString(),
                        dr["endereco_logradouro"].ToString(),
                        dr["endereco_cep"].ToString(),
                        dr["endereco_bairro"].ToString(),
                        dr["endereco_municipio"].ToString()
                        );
                    aPonto_recarga.id = Convert.ToInt32(dr["id"].ToString());
                    aListPonto_recarga = aPonto_recarga;
                }
            }

            dr.Close();
            conn.Close();
            return aListPonto_recarga;
        }
    }
}