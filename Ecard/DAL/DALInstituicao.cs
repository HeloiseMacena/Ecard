using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Ecard.DAL
{
    public class DALInstituicao
    {
        string connectionString = "";



        public DALInstituicao()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ecard"].ConnectionString;
        }



        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Instituicao> SelectAll()
        {
            Modelo.Instituicao aInstituicao;
            List<Modelo.Instituicao> aListInstituicao = new List<Modelo.Instituicao>();

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Instituicao";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aInstituicao = new Modelo.Instituicao(
                        Convert.ToInt32(dr["Id"].ToString()),
                        dr["Nome"].ToString(),
                        dr["Email"].ToString(),
                        dr["Codigo_inep_mec"].ToString(),
                        Convert.ToBoolean(dr["Status"].ToString()),
                        dr["Senha"].ToString(),
                        dr["Endereco_bairro"].ToString(),
                        dr["Endereco_CEP"].ToString(),
                        dr["Endereco_municipio"].ToString(),
                        dr["Endereco_logradouro"].ToString(),
                        dr["Endereco_numero"].ToString()
                        );
                    aListInstituicao.Add(aInstituicao);
                }
            }
            dr.Close();
            conn.Close();

            return aListInstituicao;
        }



        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(Modelo.Instituicao obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("DELETE FROM Instituicao WHERE Id = @Id", conn);

            cmd.Parameters.AddWithValue("@Id", obj.Id);

            cmd.ExecuteNonQuery();

        }



        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Instituicao obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("INSERT INTO Instituicao (Id, Nome, email, codigo_inep_mec, status, senha, endereco_bairro, endereco_cep, endereco_municipio, endereco_logradouro, endereco_numero) VALUES (@Id, @Nome, @Email, @Codigo_inep_mec, @Status, @Senha, @Endereco_bairro, @Endereco_CEP, @Endereco_municipio, @Endereco_logradouro, @Endereco_numero)", conn);

            cmd.Parameters.AddWithValue("@Id", obj.Id);
            cmd.Parameters.AddWithValue("@Nome", obj.Nome);
            cmd.Parameters.AddWithValue("@Email", obj.Email);
            cmd.Parameters.AddWithValue("@Codigo_inep_mec", obj.Codigo_inep_mec);
            cmd.Parameters.AddWithValue("@Status", obj.Status);
            cmd.Parameters.AddWithValue("@Senha", obj.Senha);
            cmd.Parameters.AddWithValue("@Endereco_bairro", obj.Endereco_bairro);
            cmd.Parameters.AddWithValue("@Endereco_CEP", obj.Endereco_CEP);
            cmd.Parameters.AddWithValue("@Endereco_municipio", obj.Endereco_municipio);
            cmd.Parameters.AddWithValue("@Endereco_logradouro", obj.Endereco_logradouro);
            cmd.Parameters.AddWithValue("@Endereco_numero", obj.Endereco_numero);

            cmd.ExecuteNonQuery();

        }



        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Instituicao obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("UPDATE Instituicao SET Nome = @Nome; Email=@Email, Codigo_inep_mec = @Codigo_inep_mec, Status = @Status, Senha = @Senha, Endereco_bairro = @Endereco_bairro, Endereco_CEP = @Endereco_CEP, Endereco_municipio = @Endereco_municipio, Endereco_logradouro = @Endereco_logradouro, Endereco_numero = @Endereco_numero  WHERE Id = @Id", conn);

            cmd.Parameters.AddWithValue("@Id", obj.Id);
            cmd.Parameters.AddWithValue("@Nome", obj.Nome);
            cmd.Parameters.AddWithValue("@Email", obj.Email);
            cmd.Parameters.AddWithValue("@Codigo_inep_mec", obj.Codigo_inep_mec);
            cmd.Parameters.AddWithValue("@Status", obj.Status);
            cmd.Parameters.AddWithValue("@Senha", obj.Senha);
            cmd.Parameters.AddWithValue("@Endereco_bairro", obj.Endereco_bairro);
            cmd.Parameters.AddWithValue("@Endereco_CEP", obj.Endereco_CEP);
            cmd.Parameters.AddWithValue("@Endereco_municipio", obj.Endereco_municipio);
            cmd.Parameters.AddWithValue("@Endereco_logradouro", obj.Endereco_logradouro);
            cmd.Parameters.AddWithValue("@Endereco_numero", obj.Endereco_numero);

            cmd.ExecuteNonQuery();
        }



        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Instituicao> Select(string Id)
        {
            Modelo.Instituicao aInstituicao;
            List<Modelo.Instituicao> aListInstituicao = new List<Modelo.Instituicao>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Instituicao Where Id = @Id";
            cmd.Parameters.AddWithValue("@Id", Id);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aInstituicao = new Modelo.Instituicao(
                        Convert.ToInt32(dr["Id"].ToString()),
                        dr["Nome"].ToString(),
                        dr["Email"].ToString(),
                        dr["Codigo_inep_mec"].ToString(),
                        Convert.ToBoolean(dr["Status"].ToString()),
                        dr["Senha"].ToString(),
                        dr["Endereco_bairro"].ToString(),
                        dr["Endereco_CEP"].ToString(),
                        dr["Endereco_municipio"].ToString(),
                        dr["Endereco_logradouro"].ToString(),
                        dr["Endereco_numero"].ToString()
                        );
                    aListInstituicao.Add(aInstituicao);
                }
            }

            dr.Close();
            conn.Close();

            return aListInstituicao;
        }
    }
}