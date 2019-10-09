﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Ecard.DAL
{
    public class DALValorPassagem
    {
        string connectionString = "";

        public DALValorPassagem()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ecard"].ConnectionString;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public string SelectValor(int id)
        {
            List<Modelo.ValorPassagem> aListValor = new List<Modelo.ValorPassagem>();

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from ValorPassagem where local_referencia = @id";
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = cmd.ExecuteReader();

            string valor = dr["valor"].ToString();

            return valor;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(Modelo.ValorPassagem obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("DELETE FROM ValorPassagem where rotas_id = @id", conn);
            cmd.Parameters.AddWithValue("@id", obj.id);
            cmd.ExecuteNonQuery();

            cmd.ExecuteNonQuery();

        }



        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(double valor, int id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("delete from ValorPassagem (valor, local_referencia) VALUES (@valor,@id)", conn);
            SqlCommand cmd2 = new SqlCommand("INSERT INTO ValorPassagem (valor, local_referencia) VALUES (@valor,@id)", conn);

            cmd.Parameters.AddWithValue("@valor", valor);
            cmd.Parameters.AddWithValue("@id", id);

            cmd2.Parameters.AddWithValue("@valor", valor);
            cmd2.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

        }



        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(double valor, int id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("UPDATE ValorPassagem SET valor = " + valor + " WHERE Id = " + id, conn);

            cmd.ExecuteNonQuery();
        }

    }
}