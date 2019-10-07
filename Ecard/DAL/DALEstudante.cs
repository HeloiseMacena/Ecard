﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace Ecard.DAL
{
    public class DALEstudante
    {
        string connectionString = "";



        public DALEstudante()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ecard"].ConnectionString;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        void SelectArquivoCsv(string arquivo)
        {
            StreamReader sr;
            string Linha;
            string[] linha;

            List<Modelo.Estudante> aListEstudante = new List<Modelo.Estudante>();

            // Le arquivo com nome de imagens
            if (System.IO.File.Exists(arquivo))
            {
                sr = new StreamReader(System.IO.File.OpenRead(arquivo));
                try
                {
                    while (sr.Peek() > -1)
                    {
                        Linha = sr.ReadLine(); // Le uma Linha

                        // Separa os dados em cada linha
                        linha = Linha.Split(';');

                        Modelo.Estudante aEstudante = new Modelo.Estudante(
                            linha[0],
                            linha[1],
                            linha[2],
                           "Ecard2019",
                            true,
                            "",
                            0,
                            0,
                            Convert.ToDateTime("01/01/2000")
                        );

                        aListEstudante.Add(aEstudante);
                    }
                }
                finally
                {
                    sr.Close();
                }
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Estudante> SelectAll()
        {
            List<Modelo.Estudante> aListEstudante = new List<Modelo.Estudante>();

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Estudante";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Modelo.Estudante aEstudante = new Modelo.Estudante(
                        dr["nome"].ToString(),
                        dr["cpf"].ToString(),
                        dr["email"].ToString(),
                        dr["senha"].ToString(),
                        Convert.ToBoolean(dr["status"].ToString()),
                        dr["carteira_foto"].ToString(),
                        double.Parse(dr["carteira_saldo"].ToString()),
                        int.Parse(dr["carteira_numero"].ToString()),
                        Convert.ToDateTime(dr["carteira_validade"].ToString())
                    );
                    aEstudante.id = Convert.ToInt32(dr["id"].ToString());
                    aListEstudante.Add(aEstudante);
                }
            }
            dr.Close();
            conn.Close();

            return aListEstudante;
        }



        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(Modelo.Estudante obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("DELETE FROM Estudante WHERE Id = @Id", conn);

            cmd.Parameters.AddWithValue("@Id", obj.id);

            cmd.ExecuteNonQuery();

        }



        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Estudante obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("INSERT INTO Estudante (Nome, cpf, email, status, carteira_foto, carteira_saldo, carteira_numero, carteira_validade, senha, instituicao_id) VALUES (@Nome, @cpf, @email, @status, @carteira_foto, @carteira_saldo, @carteira_numero, @carteira_validade, @senha, 1)", conn);

            cmd.Parameters.AddWithValue("@Nome", obj.nome);
            cmd.Parameters.AddWithValue("@cpf", obj.cpf);
            cmd.Parameters.AddWithValue("@email", obj.email);
            cmd.Parameters.AddWithValue("@status", obj.status);
            cmd.Parameters.AddWithValue("@carteira_foto", obj.carteira_foto);
            cmd.Parameters.AddWithValue("@carteira_saldo", obj.carteira_saldo);
            cmd.Parameters.AddWithValue("@carteira_numero", obj.carteira_numero);
            cmd.Parameters.AddWithValue("@carteira_validade", obj.carteira_validade);
            cmd.Parameters.AddWithValue("@senha", obj.senha);

            cmd.ExecuteNonQuery();

        }



        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Estudante obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("UPDATE Estudante SET Nome = @Nome, cpf = @cpf, senha = @senha, email = @email, status = @status, carteira_foto = @carteira_foto, carteira_saldo = @carteira_saldo, carteira_numero = @carteira_numero, carteira_validade = @carteira_validade WHERE Id = @Id", conn);

            cmd.Parameters.AddWithValue("@Id", obj.id);
            cmd.Parameters.AddWithValue("@Nome", obj.nome);
            cmd.Parameters.AddWithValue("@cpf", obj.cpf);
            cmd.Parameters.AddWithValue("@email", obj.email);
            cmd.Parameters.AddWithValue("@status", obj.status);
            cmd.Parameters.AddWithValue("@senha", obj.senha);
            cmd.Parameters.AddWithValue("@carteira_foto", obj.carteira_foto);
            cmd.Parameters.AddWithValue("@carteira_saldo", obj.carteira_saldo);
            cmd.Parameters.AddWithValue("@carteira_numero", obj.carteira_numero);
            cmd.Parameters.AddWithValue("@carteira_validade", obj.carteira_validade);

            cmd.ExecuteNonQuery();
        }



        [DataObjectMethod(DataObjectMethodType.Select)]
        public Modelo.Estudante Select(int Id)
        {
            Modelo.Estudante aEstudante = new Modelo.Estudante();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Estudante Where Id = @Id";
            cmd.Parameters.AddWithValue("@Id", Id);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aEstudante = new Modelo.Estudante(
                        dr["nome"].ToString(),
                        dr["cpf"].ToString(),
                        dr["email"].ToString(),
                        dr["senha"].ToString(),
                        Convert.ToBoolean(int.Parse(dr["status"].ToString())),
                        dr["carteira_foto"].ToString(),
                        double.Parse(dr["carteira_saldo"].ToString()),
                        int.Parse(dr["carteira_numero"].ToString()),
                        Convert.ToDateTime(dr["carteira_validade"].ToString())
                        );
                    aEstudante.id = Convert.ToInt32(dr["id"].ToString());
                }
            }

            dr.Close();
            conn.Close();

            return aEstudante;
        }
        public Modelo.Estudante Login(string cpf, string senha)
        {
            Modelo.Estudante aEstudante = new Modelo.Estudante();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Estudante Where cpf = @cpf and senha = @senha";
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@senha", senha);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aEstudante = new Modelo.Estudante(
                        dr["nome"].ToString(),
                        dr["cpf"].ToString(),
                        dr["email"].ToString(),
                        dr["senha"].ToString(),
                        Convert.ToBoolean(Convert.ToInt32(dr["status"].ToString())),
                        dr["carteira_foto"].ToString(),
                        double.Parse(dr["carteira_saldo"].ToString()),
                        int.Parse(dr["carteira_numero"].ToString()),
                        Convert.ToDateTime(dr["carteira_validade"].ToString())
                        );
                    aEstudante.id = Convert.ToInt32(dr["id"].ToString());
                }
            }

            dr.Close();
            conn.Close();

            return aEstudante;
        }
    }
}