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
            connectionString = ConfigurationManager.ConnectionStrings["ecard"].ConnectionString;
        }



        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Ponto_referencia> SelectAll()
        {
            List<Modelo.Ponto_referencia> ListPonto_referencias = new List<Modelo.Ponto_referencia>();
            SqlConnection a = new SqlConnection(connectionString);
            a.Open();
            SqlCommand b = a.CreateCommand();
            b.CommandText = "Select * from Ponto_Referencia";
            SqlDataReader c = b.ExecuteReader();
            if (c.HasRows)
            {
                while (c.Read())
                {
                    Modelo.Ponto_referencia Ponto_referencia = new Modelo.Ponto_referencia(
                        c["nome"].ToString()
                        );
                    Ponto_referencia.id = Convert.ToInt32(c["id"].ToString());
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
            SqlCommand cmd = new SqlCommand("DELETE FROM Ponto_Referencia WHERE id = @id", conn);

            cmd.Parameters.AddWithValue("@id", obj.id);

            cmd.ExecuteNonQuery();

        }



        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Ponto_referencia obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("INSERT INTO Ponto_Referencia (nome, rotas_id) VALUES (@nome, 1)", conn);

            cmd.Parameters.AddWithValue("@nome", obj.nome);

            cmd.ExecuteNonQuery();

        }



        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Ponto_referencia obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("UPDATE Ponto_Referencia SET nome = @nome WHERE id = @id", conn);

            cmd.Parameters.AddWithValue("@id", obj.id);
            cmd.Parameters.AddWithValue("@nome", obj.nome);

            cmd.ExecuteNonQuery();
        }



        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Ponto_referencia> Select(int id)
        {
            List<Modelo.Ponto_referencia> aListPonto_referencia = new List<Modelo.Ponto_referencia>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Ponto_Referencia Where id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Modelo.Ponto_referencia aPonto_referencia = new Modelo.Ponto_referencia(
                        dr["nome"].ToString()
                        );
                    aPonto_referencia.id = Convert.ToInt32(dr["id"].ToString());
                    aListPonto_referencia.Add(aPonto_referencia);
                }
            }

            dr.Close();
            conn.Close();

            return aListPonto_referencia;
        }
    }
}