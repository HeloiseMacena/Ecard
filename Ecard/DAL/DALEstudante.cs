﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Ecardmark1.DAL
{
    public class DALEstudante
    {
        string connectionString = "";



        public DALEstudante()
        {
            connectionString = ConfigurationManager.ConnectionStrings["PubsConnectionString"].ConnectionString;
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
                        Convert.ToInt32(dr["id"].ToString()),
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
            SqlCommand cmd = new SqlCommand("INSERT INTO Estudante (Id, Nome, cpf, email, status, carteira_foto, carteira_saldo, carteira_numero, carteira_validade) VALUES (@Id, @Nome, @cpf, @email, @status, @carteira_foto, @carteira_numero, @carteira_validade)", conn);

            cmd.Parameters.AddWithValue("@Id", obj.id);
            cmd.Parameters.AddWithValue("@Nome", obj.nome);
            cmd.Parameters.AddWithValue("@cpf", obj.cpf);
            cmd.Parameters.AddWithValue("@email", obj.email);
            cmd.Parameters.AddWithValue("@status", obj.status);
            cmd.Parameters.AddWithValue("@carteira_foto", obj.carteira_foto);
            cmd.Parameters.AddWithValue("@carteira_saldo", obj.carteira_saldo);
            cmd.Parameters.AddWithValue("@carteira_numero", obj.carteira_numero);
            cmd.Parameters.AddWithValue("@carteira_validade", obj.carteira_validade);

            cmd.ExecuteNonQuery();

        }



        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Estudante obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("UPDATE Estudante SET Nome = @Nome WHERE Id = @Id", conn);

            cmd.Parameters.AddWithValue("@Id", obj.id);
            cmd.Parameters.AddWithValue("@Nome", obj.nome);
            cmd.Parameters.AddWithValue("@cpf", obj.cpf);
            cmd.Parameters.AddWithValue("@email", obj.email);
            cmd.Parameters.AddWithValue("@status", obj.status);
            cmd.Parameters.AddWithValue("@carteira_foto", obj.carteira_foto);
            cmd.Parameters.AddWithValue("@carteira_saldo", obj.carteira_saldo);
            cmd.Parameters.AddWithValue("@carteira_numero", obj.carteira_numero);
            cmd.Parameters.AddWithValue("@carteira_validade", obj.carteira_validade);

            cmd.ExecuteNonQuery();
        }



        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Estudante> Select(string Id)
        {
            Modelo.Estudante aEstudante;
            List<Modelo.Estudante> aListEstudante = new List<Modelo.Estudante>();
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
                        Convert.ToInt32(dr["id"].ToString()),
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
                    aListEstudante.Add(aEstudante);
                }
            }

            dr.Close();
            conn.Close();

            return aListEstudante;
        }
    }
}