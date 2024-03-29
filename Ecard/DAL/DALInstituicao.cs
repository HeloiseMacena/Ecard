﻿using System;
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
        public double SelectStatus(int id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select status from Instituicao where id =@id";
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            int status = int.Parse(dr["status"].ToString());

            conn.Close();

            return status;
        }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public bool StatusInstituicao(int id)
        {
            bool a = false;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select status from Instituicao where id =@id";
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            string b = dr["status"].ToString();

            conn.Close();
            return a;
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
                        dr["Nome"].ToString(),
                        dr["Email"].ToString(),
                        dr["codigo_inep"].ToString(),
                        int.Parse(dr["Status"].ToString()),
                        dr["Senha"].ToString(),
                        dr["Endereco_bairro"].ToString(),
                        dr["Endereco_CEP"].ToString(),
                        dr["Endereco_municipio"].ToString(),
                        dr["Endereco_logradouro"].ToString(),
                        dr["Endereco_numero"].ToString(),
                        dr["cnpj"].ToString()
                        );
                    aInstituicao.Id = int.Parse(dr["id"].ToString());
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
            SqlCommand cmd = new SqlCommand("INSERT INTO Instituicao (Nome, email, codigo_inep, status, senha, endereco_bairro, endereco_cep, endereco_municipio, endereco_logradouro, endereco_numero, cnpj, administrador_id) VALUES (@Nome, @Email, @Codigo_inep_mec, @Status, @Senha, @Endereco_bairro, @Endereco_CEP, @Endereco_municipio, @Endereco_logradouro, @Endereco_numero, @cnpj, 1)", conn);

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
            cmd.Parameters.AddWithValue("@cnpj", obj.cnpj);

            

            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("Select @@identity as id", conn);
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            DALSolicitacao_instituicao dal = new DALSolicitacao_instituicao();
            dal.Insert(id);

        }



        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Instituicao obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("UPDATE Instituicao SET Nome = @Nome, Email=@Email, codigo_inep = @Codigo_inep_mec, Status = @Status, Senha = @Senha, Endereco_bairro = @Endereco_bairro, Endereco_CEP = @Endereco_CEP, Endereco_municipio = @Endereco_municipio, Endereco_logradouro = @Endereco_logradouro, Endereco_numero = @Endereco_numero, cnpj = @cnpj  WHERE Id = @Id", conn);

            cmd.Parameters.AddWithValue("@Id", obj.Id);
            cmd.Parameters.AddWithValue("@Nome", obj.Nome);
            cmd.Parameters.AddWithValue("@Email", obj.Email);
            cmd.Parameters.AddWithValue("@Codigo_inep_mec", obj.Codigo_inep_mec);
            cmd.Parameters.AddWithValue("@cnpj", obj.cnpj);
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
        public void AlterarStatus(Modelo.Instituicao obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("UPDATE Instituicao SET status = @status WHERE Id = @Id", conn);
            cmd.Parameters.AddWithValue("@id", obj.Id);
            cmd.Parameters.AddWithValue("@Status", obj.Status);
            cmd.ExecuteNonQuery();
        }



        [DataObjectMethod(DataObjectMethodType.Select)]
        public Modelo.Instituicao Select(int Id)
        {
            Modelo.Instituicao Instituicao = new Modelo.Instituicao();
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
                    Instituicao = new Modelo.Instituicao(
                        dr["Nome"].ToString(),
                        dr["Email"].ToString(),
                        dr["codigo_inep"].ToString(),
                        int.Parse(dr["Status"].ToString()),
                        dr["Senha"].ToString(),
                        dr["Endereco_bairro"].ToString(),
                        dr["Endereco_CEP"].ToString(),
                        dr["Endereco_municipio"].ToString(),
                        dr["Endereco_logradouro"].ToString(),
                        dr["Endereco_numero"].ToString(),
                        dr["cnpj"].ToString()
                        );
                    Instituicao.Id = int.Parse(dr["id"].ToString());
                }
            }

            dr.Close();
            conn.Close();

            return Instituicao;
        }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public Modelo.Instituicao Login(string email, string senha)
        {
            Modelo.Instituicao Instituicao = new Modelo.Instituicao();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Instituicao Where email = @email and senha = @senha";
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Instituicao = new Modelo.Instituicao(
                      dr["nome"].ToString(),
                      dr["email"].ToString(),
                      dr["codigo_inep"].ToString(),
                      Convert.ToInt32(dr["status"].ToString()),
                      dr["senha"].ToString(),
                      dr["endereco_bairro"].ToString(),
                      dr["endereco_cep"].ToString(),
                      dr["endereco_municipio"].ToString(),
                      dr["endereco_logradouro"].ToString(),
                      dr["endereco_numero"].ToString(),
                      dr["cnpj"].ToString()
                      );
                    Instituicao.Id = int.Parse(dr["id"].ToString());
                }
            }

            dr.Close();
            conn.Close();
 
            return Instituicao;
        }

        public bool ExisteCNPJ(string cnpj)
        {
            bool a = false;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Instituicao where cnpj = @cnpj";
            cmd.Parameters.AddWithValue("@cnpj", cnpj);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            if (dr.HasRows)
            {
                a = true;
            }

            conn.Close();
            return a;
        }

        public bool ExisteCodigo(string codigo)
        {
            bool a = false;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Instituicao where codigo_inep = @codigo";
            cmd.Parameters.AddWithValue("@codigo",codigo);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            if (dr.HasRows)
            {
                a = true;
            }

            conn.Close();
            return a;
        }
    }
}