using System;
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
        public string SelectValorInteiro(string local)
        {

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select valor from ValorPassagem where local = @local";
            cmd.Parameters.AddWithValue("@local", local);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            double v = double.Parse(dr["valor"].ToString());

            string valor = v.ToString();

            return valor;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public string SelectValor(string local)
        {

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select valor from ValorPassagem where local = @local";
            cmd.Parameters.AddWithValue("@local", local);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            double v = double.Parse(dr["valor"].ToString());

            string valor = (v / 2).ToString();

            return valor;
        }


        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(double valor, string local)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("delete from ValorPassagem where local = @local", conn);
            SqlCommand cmd2 = new SqlCommand("insert into ValorPassagem (valor, local) VALUES (@valor,@local)", conn);

            cmd.Parameters.AddWithValue("@valor", valor);
            cmd.Parameters.AddWithValue("@local", local);

            cmd2.Parameters.AddWithValue("@valor", valor);
            cmd2.Parameters.AddWithValue("@local", local);

            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
        }
    }
}