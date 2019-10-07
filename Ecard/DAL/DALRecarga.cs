using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Ecard.DAL
{
    public class DALRecarga
    {
        string connectionString = "";



        public DALRecarga()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ecard"].ConnectionString;
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
                        Convert.ToDouble(dr["valor"].ToString())
                        );
                    aRecarga.id = Convert.ToInt32(dr["id"].ToString());
                    aRecarga.data = Convert.ToDateTime(dr["data"].ToString());
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
        public void Insert(Modelo.Recarga obj, int estudante_id, int ponto_recarga_id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("INSERT INTO Recarga (data_recarga, valor, estudante_id, ponto_recarga_id) VALUES (@data, @valor, @estudante_id, @ponto_recarga_id)", conn);

            cmd.Parameters.AddWithValue("@data", obj.data);
            cmd.Parameters.AddWithValue("@valor", obj.valor);
            cmd.Parameters.AddWithValue("@estudante_id",estudante_id);
            cmd.Parameters.AddWithValue("@ponto_recarga_id", ponto_recarga_id);

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
        public Modelo.Recarga Select(string Id)
        {
            Modelo.Recarga aRecarga = new Modelo.Recarga();
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
                         Convert.ToDouble(dr["valor"].ToString())
                        );
                    aRecarga.id = Convert.ToInt32(dr["id"].ToString());
                    aRecarga.data = Convert.ToDateTime(dr["data"].ToString());
                }
            }

            dr.Close();
            conn.Close();

            return aRecarga;
        }
    }
}