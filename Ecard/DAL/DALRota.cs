using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Ecardmark1.DAL
{
    public class DALRota
    {
        string connectionString = "";


        public DALRota()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ecard"].ConnectionString;
        }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Rota> SelectAll()
        {
            List<Modelo.Rota> aListRota = new List<Modelo.Rota>();

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from rota";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {

                while (dr.Read())
                {
                    Modelo.Rota aRota = new Modelo.Rota(
                        dr["nome"].ToString()
                        );
                    aRota.id = Convert.ToInt32(dr["id"].ToString());
                    aListRota.Add(aRota);
                }
            }
            dr.Close();
            conn.Close();

            return aListRota;
        }



        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(Modelo.Rota obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("DELETE FROM rota WHERE id = @id", conn);

            cmd.Parameters.AddWithValue("@id", obj.id);

            cmd.ExecuteNonQuery();

        }



        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Rota obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("INSERT INTO rota (nome, administrador_id) VALUES (@nome, 1)", conn);

            cmd.Parameters.AddWithValue("@nome", obj.nome);

            cmd.ExecuteNonQuery();

        }



        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Rota obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("UPDATE rota SET nome = @nome WHERE id = @id", conn);

            cmd.Parameters.AddWithValue("@id", obj.id);
            cmd.Parameters.AddWithValue("@nome", obj.nome);

            cmd.ExecuteNonQuery();
        }



        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Rota> Select(string id)
        {
            List<Modelo.Rota> aListRota = new List<Modelo.Rota>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from rota Where id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Modelo.Rota aRota = new Modelo.Rota(
                        dr["nome"].ToString()
                        );
                    aRota.id = Convert.ToInt32(dr["id"].ToString());
                    aListRota.Add(aRota);
                }
            }

            dr.Close();
            conn.Close();

            return aListRota;
        }
    }
}