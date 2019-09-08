using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Ecardmark1.DAL
{
    public class DALBairro
    {
        string connectionString = "";



        public DALBairro()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ecard"].ConnectionString;
        }



        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Bairro> SelectAll()
        {
            List<Modelo.Bairro> aListBairro = new List<Modelo.Bairro>();

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Bairro";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Modelo.Bairro aBairro = new Modelo.Bairro(
                        int.Parse(dr["id"].ToString()),
                        dr["nome"].ToString()
                        );
                    aBairro.id = Convert.ToInt32(dr["id"].ToString());
                    aListBairro.Add(aBairro);
                }
            }
            dr.Close();
            conn.Close();

            return aListBairro;
        }



        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(Modelo.Bairro obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("DELETE FROM Bairro WHERE id = @id", conn);

            cmd.Parameters.AddWithValue("@id", obj.id);

            cmd.ExecuteNonQuery();

        }



        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Bairro obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("INSERT INTO Bairro (nome) VALUES (@nome)", conn);

            cmd.Parameters.AddWithValue("@nome", obj.nome);

            cmd.ExecuteNonQuery();

        }



        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Bairro obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("UPDATE Bairro SET nome = @nome WHERE id = @id", conn);

            cmd.Parameters.AddWithValue("@id", obj.id);
            cmd.Parameters.AddWithValue("@nome", obj.nome);

            cmd.ExecuteNonQuery();
        }



        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Bairro> Select(string id)
        {
            List<Modelo.Bairro> aListBairro = new List<Modelo.Bairro>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Bairro Where id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Modelo.Bairro aBairro = new Modelo.Bairro(
                        int.Parse(dr["id"].ToString()),
                        dr["nome"].ToString()
                        );
                    aBairro.id = Convert.ToInt32(dr["id"].ToString());
                    aListBairro.Add(aBairro);
                }
            }

            dr.Close();
            conn.Close();

            return aListBairro;
        }
    }
}