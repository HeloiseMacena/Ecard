using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Ecardmark1.DAL
{
    public class DALPonto_referencia
    {
        string connectionString = "";


        public DALPonto_referencia()
        {
            connectionString = ConfigurationManager.ConnectionStrings[""].ConnectionString;
        }



        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Ponto_referencia> SelectAll()
        {
            Modelo.Ponto_referencia Ponto_referencia;
            List<Modelo.Ponto_referencia> ListPonto_referencias = new List<Modelo.Ponto_referencia>();
            SqlConnection a = new SqlConnection(connectionString);
            a.Open();
            SqlCommand b = a.CreateCommand();
            b.CommandText = "Select * from Ponto_referencia";
            SqlDataReader c = b.ExecuteReader();
            if (c.HasRows)
            {
                while (c.Read())
                {
                    Ponto_referencia = new Modelo.Ponto_referencia(
                        Convert.ToInt32(c["Id"].ToString()),
                        c["Nome"].ToString()
                        );
                    ListPonto_referencias.Add(Ponto_referencia);
                }
            }
            c.Close();
            a.Close();

            return ListPonto_referencias;
        }



        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(Modelo.Ponto_referencia obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("DELETE FROM Ponto_referencia WHERE Id = @Id", conn);

            cmd.Parameters.AddWithValue("@Id", obj.Id);

            cmd.ExecuteNonQuery();

        }



        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Ponto_referencia obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("INSERT INTO Ponto_referencia (Id, Nome) VALUES (@Id, @Nome)", conn);

            cmd.Parameters.AddWithValue("@Id", obj.Id);
            cmd.Parameters.AddWithValue("@Nome", obj.Nome);

            cmd.ExecuteNonQuery();

        }



        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Ponto_referencia obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("UPDATE Ponto_referencia SET Nome = @Nome WHERE Id = @Id", conn);

            cmd.Parameters.AddWithValue("@Id", obj.Id);
            cmd.Parameters.AddWithValue("@Nome", obj.Nome);

            cmd.ExecuteNonQuery();
        }



        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Ponto_referencia> Select(string Id)
        {
            Modelo.Ponto_referencia aPonto_referencia;
            List<Modelo.Ponto_referencia> aListPonto_referencia = new List<Modelo.Ponto_referencia>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Ponto_referencia Where Id = @Id";
            cmd.Parameters.AddWithValue("@Id", Id);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aPonto_referencia = new Modelo.Ponto_referencia(
                        Convert.ToInt32(dr["Id"].ToString()),
                        dr["Nome"].ToString()
                        );
                    aListPonto_referencia.Add(aPonto_referencia);
                }
            }

            dr.Close();
            conn.Close();

            return aListPonto_referencia;
        }
    }
}