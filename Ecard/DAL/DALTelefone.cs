using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Ecardmark1.DAL
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
                    Modelo.Telefone aTelefone = new Modelo.Telefone(
                        dr["numero"].ToString()
                        );
                    aTelefone.id = Convert.ToInt32(dr["id"].ToString());
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
            SqlCommand cmd = new SqlCommand("DELETE FROM Telefone WHERE id = @id", conn);

            cmd.Parameters.AddWithValue("@id", obj.id);

            cmd.ExecuteNonQuery();

        }



        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Telefone obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("INSERT INTO Telefone (numero, instituicao_id) VALUES (@numero, 1)", conn);

            cmd.Parameters.AddWithValue("@numero", obj.numero);

            cmd.ExecuteNonQuery();

        }



        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Telefone obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("UPDATE Telefone SET numero = @numero WHERE id = @id", conn);

            cmd.Parameters.AddWithValue("@id", obj.id);
            cmd.Parameters.AddWithValue("@numero", obj.numero);

            cmd.ExecuteNonQuery();
        }



        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Telefone> Select(string id)
        {
            List<Modelo.Telefone> aListTelefone = new List<Modelo.Telefone>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Telefone Where id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Modelo.Telefone aTelefone = new Modelo.Telefone(
                        dr["numero"].ToString()
                        );
                    aTelefone.id = Convert.ToInt32(dr["id"].ToString());
                    aListTelefone.Add(aTelefone);
                }
            }

            dr.Close();
            conn.Close();

            return aListTelefone;
        }
    }
}