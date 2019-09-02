using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Ecardmark1.DAL
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
                    string str = dr["status"].ToString();
                    bool status = str == "1";

                    Modelo.Instituicao aInstituicao = new Modelo.Instituicao(
                        dr["nome"].ToString(),
                        dr["email"].ToString(),
                        dr["codigo_inep"].ToString(),
                        dr["cnpj"].ToString(),
                        status,
                        dr["senha"].ToString(),
                        dr["endereco_bairro"].ToString(),
                        dr["endereco_CEP"].ToString(),
                        dr["endereco_municipio"].ToString(),
                        dr["endereco_logradouro"].ToString(),
                        dr["endereco_numero"].ToString()
                        );
                    aInstituicao.id = Convert.ToInt32(dr["id"].ToString());
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
            SqlCommand cmd = new SqlCommand("DELETE FROM Instituicao WHERE id = @id", conn);

            cmd.Parameters.AddWithValue("@id", obj.id);

            cmd.ExecuteNonQuery();

        }



        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Instituicao obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("INSERT INTO Instituicao (nome, email, codigo_inep, cnpj, status, senha, endereco_bairro, endereco_cep, endereco_municipio, endereco_logradouro, endereco_numero) VALUES (@nome, @email, @codigo_inep, @cnpj, @status, @senha, @endereco_bairro, @endereco_CEP, @endereco_municipio, @endereco_logradouro, @endereco_numero)", conn);

            cmd.Parameters.AddWithValue("@nome", obj.nome);
            cmd.Parameters.AddWithValue("@email", obj.email);
            cmd.Parameters.AddWithValue("@codigo_inep", obj.codigo_inep);
            cmd.Parameters.AddWithValue("@cnpj", obj.cnpj);
            cmd.Parameters.AddWithValue("@status", obj.status);
            cmd.Parameters.AddWithValue("@senha", obj.senha);
            cmd.Parameters.AddWithValue("@endereco_bairro", obj.endereco_bairro);
            cmd.Parameters.AddWithValue("@endereco_CEP", obj.endereco_CEP);
            cmd.Parameters.AddWithValue("@endereco_municipio", obj.endereco_municipio);
            cmd.Parameters.AddWithValue("@endereco_logradouro", obj.endereco_logradouro);
            cmd.Parameters.AddWithValue("@endereco_numero", obj.endereco_numero);

            cmd.ExecuteNonQuery();

        }



        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Instituicao obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("UPDATE Instituicao SET nome = @nome, email = @email, codigo_inep = @codigo_inep, cnpj = @cnpj, status = @status, senha = @senha, endereco_bairro = @endereco_bairro, endereco_CEP = @endereco_CEP, endereco_municipio = @endereco_municipio, endereco_logradouro = @endereco_logradouro, endereco_numero = @endereco_numero  WHERE id = @id", conn);

            cmd.Parameters.AddWithValue("@id", obj.id);
            cmd.Parameters.AddWithValue("@nome", obj.nome);
            cmd.Parameters.AddWithValue("@email", obj.email);
            cmd.Parameters.AddWithValue("@codigo_inep", obj.codigo_inep);
            cmd.Parameters.AddWithValue("@cnpj", obj.cnpj);
            cmd.Parameters.AddWithValue("@status", obj.status);
            cmd.Parameters.AddWithValue("@senha", obj.senha);
            cmd.Parameters.AddWithValue("@endereco_bairro", obj.endereco_bairro);
            cmd.Parameters.AddWithValue("@endereco_CEP", obj.endereco_CEP);
            cmd.Parameters.AddWithValue("@endereco_municipio", obj.endereco_municipio);
            cmd.Parameters.AddWithValue("@endereco_logradouro", obj.endereco_logradouro);
            cmd.Parameters.AddWithValue("@endereco_numero", obj.endereco_numero);

            cmd.ExecuteNonQuery();
        }



        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Instituicao> Select(string id)
        {
            List<Modelo.Instituicao> aListInstituicao = new List<Modelo.Instituicao>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Instituicao where id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                string str = dr["status"].ToString();
                bool status = str == "1";

                while (dr.Read())
                {
                    Modelo.Instituicao aInstituicao = new Modelo.Instituicao(
                        dr["nome"].ToString(),
                        dr["email"].ToString(),
                        dr["codigo_inep"].ToString(),
                        dr["cnpj"].ToString(),
                        status,
                        dr["senha"].ToString(),
                        dr["endereco_bairro"].ToString(),
                        dr["endereco_CEP"].ToString(),
                        dr["endereco_municipio"].ToString(),
                        dr["endereco_logradouro"].ToString(),
                        dr["endereco_numero"].ToString()
                        );
                    aInstituicao.id = Convert.ToInt32(dr["id"].ToString());
                    aListInstituicao.Add(aInstituicao);
                }
            }

            dr.Close();
            conn.Close();

            return aListInstituicao;
        }
    }
}