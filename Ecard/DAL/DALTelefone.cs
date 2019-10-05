using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Ecard.DAL
{
    public class DALTelefone
    {
        string connectionString = "";



        public DALTelefone()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ecard"].ConnectionString;
        }



        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Telefone> SelectAll()
        {
            Modelo.Telefone aTelefone;
            List<Modelo.Telefone> aListTelefone = new List<Modelo.Telefone>();

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Telefone";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aTelefone = new Modelo.Telefone(
                        Convert.ToInt32(dr["Id"].ToString()),
                        dr["Numero"].ToString()
                        );
                    aListTelefone.Add(aTelefone);
                }
            }
            dr.Close();
            conn.Close();

            return aListTelefone;
        }



        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(Modelo.Telefone obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("DELETE FROM Telefone WHERE Id = @Id", conn);

            cmd.Parameters.AddWithValue("@Id", obj.Id);

            cmd.ExecuteNonQuery();

        }



        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Telefone obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("INSERT INTO Telefone (Id, Numero) VALUES (@Id, @Numero)", conn);

            cmd.Parameters.AddWithValue("@Id", obj.Id);
            cmd.Parameters.AddWithValue("@Numero", obj.Numero);

            cmd.ExecuteNonQuery();

        }



        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Telefone obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("UPDATE Telefone SET Numero = @Numero WHERE Id = @Id", conn);

            cmd.Parameters.AddWithValue("@Id", obj.Id);
            cmd.Parameters.AddWithValue("@Numero", obj.Numero);

            cmd.ExecuteNonQuery();
        }



        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Telefone> Select(string Id)
        {
            Modelo.Telefone aTelefone;
            List<Modelo.Telefone> aListTelefone = new List<Modelo.Telefone>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Telefone Where Id = @Id";
            cmd.Parameters.AddWithValue("@Id", Id);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aTelefone = new Modelo.Telefone(
                        Convert.ToInt32(dr["Id"].ToString()),
                        dr["Nome"].ToString()
                        );
                    aListTelefone.Add(aTelefone);
                }
            }

            dr.Close();
            conn.Close();

            return aListTelefone;
        }
    }
}