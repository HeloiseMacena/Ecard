using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Ecardmark1.DAL
{
    public class DALRecarga
    {
        string connectionString = "";



        public DALRecarga()
        {
            connectionString = ConfigurationManager.ConnectionStrings["PubsConnectionString"].ConnectionString;
        }



        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Recarga> SelectAll()
        {
            List<Modelo.Recarga> aListRecarga = new List<Modelo.Recarga>();

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Recarga";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Modelo.Recarga aRecarga = new Modelo.Recarga(
                        Convert.ToInt32(dr["id"].ToString()),
                        Convert.ToDateTime(dr["data"].ToString()),
                         (float)Convert.ToDouble(dr["valor"].ToString())
                        );
                    aListRecarga.Add(aRecarga);
                }
            }
            dr.Close();
            conn.Close();

            return aListRecarga;
        }



        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(Modelo.Recarga obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("DELETE FROM Recarga WHERE Id = @Id", conn);

            cmd.Parameters.AddWithValue("@Id", obj.id);

            cmd.ExecuteNonQuery();

        }



        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Recarga obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("INSERT INTO Recarga (Id, data, valor) VALUES (@Id, @data, @valor)", conn);

            cmd.Parameters.AddWithValue("@Id", obj.id);
            cmd.Parameters.AddWithValue("@data", obj.data);
            cmd.Parameters.AddWithValue("@valor", obj.valor);

            cmd.ExecuteNonQuery();

        }



        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Recarga obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("UPDATE Recarga SET data = @data, valor = @valor WHERE Id = @Id", conn);

            cmd.Parameters.AddWithValue("@Id", obj.id);
            cmd.Parameters.AddWithValue("@data", obj.data);
            cmd.Parameters.AddWithValue("@valor", obj.valor);

            cmd.ExecuteNonQuery();
        }



        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Recarga> Select(string Id)
        {
            Modelo.Recarga aRecarga;
            List<Modelo.Recarga> aListRecarga = new List<Modelo.Recarga>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Recarga Where Id = @Id";
            cmd.Parameters.AddWithValue("@Id", Id);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aRecarga = new Modelo.Recarga(
                        Convert.ToInt32(dr["id"].ToString()),
                        Convert.ToDateTime(dr["data"].ToString()),
                        (float) Convert.ToDouble(dr["valor"].ToString())
                        );
                    aListRecarga.Add(aRecarga);
                }
            }

            dr.Close();
            conn.Close();

            return aListRecarga;
        }
    }
}