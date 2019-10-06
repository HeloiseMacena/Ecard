using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Ecard.DAL
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
            Modelo.Bairro aBairro;
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
                    aBairro = new Modelo.Bairro(
                        dr["Nome"].ToString()
                        );
                    aBairro.Id = int.Parse(dr["id"].ToString());
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
            SqlCommand cmd = new SqlCommand("DELETE FROM Bairro WHERE Id = @Id", conn);
            cmd.Parameters.AddWithValue("@Id", obj.Id);
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand("DELETE FROM Rotas_Bairro where rotas_id = @id");
            cmd.Parameters.AddWithValue("@id", obj.Id);
            cmd.ExecuteNonQuery();

        }



        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Bairro obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("INSERT INTO Bairro (Nome) VALUES (@Nome)", conn);

            cmd.Parameters.AddWithValue("@Nome", obj.Nome);

            cmd.ExecuteNonQuery();

        }



        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Bairro obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("UPDATE Bairro SET Nome = @Nome WHERE Id = @Id", conn);

            cmd.Parameters.AddWithValue("@Id", obj.Id);
            cmd.Parameters.AddWithValue("@Nome", obj.Nome);

            cmd.ExecuteNonQuery();
        }



        [DataObjectMethod(DataObjectMethodType.Select)]
        public Modelo.Bairro Select(int Id)
        {
            Modelo.Bairro aBairro;
            Modelo.Bairro aListBairro = new Modelo.Bairro();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Bairro Where Id = @Id";
            cmd.Parameters.AddWithValue("@Id", Id);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aBairro = new Modelo.Bairro(
                        dr["Nome"].ToString()

                        );
                    aBairro.Id = int.Parse(dr["id"].ToString());
                    aListBairro = aBairro;
                }
            }

            dr.Close();
            conn.Close();

            return aListBairro;
        }
    }
}