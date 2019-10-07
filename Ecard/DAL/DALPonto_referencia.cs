using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Ecard.DAL
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
                        c["Nome"].ToString()
                        );
                    Ponto_referencia.Id = int.Parse(c["Id"].ToString());
                    ListPonto_referencias.Add(Ponto_referencia);
                }
            }
            c.Close();
            a.Close();

            return ListPonto_referencias;
        }

        public List<Modelo.Ponto_referencia> SearchSelect(string value, string option)
        {
            if(value == "" || value == null) { value = "%"; }

            Modelo.Ponto_referencia Ponto_referencia;
            List<Modelo.Ponto_referencia> ListPonto_referencias = new List<Modelo.Ponto_referencia>();

            SqlConnection a = new SqlConnection(connectionString);
            a.Open();
            SqlCommand b = a.CreateCommand();
            b.CommandText = "Select * from Ponto_referencia WHERE Nome LIKE'" + value + "'";
            SqlDataReader c = b.ExecuteReader();
            if (c.HasRows)
            {
                while (c.Read())
                {
                    Ponto_referencia = new Modelo.Ponto_referencia(
                        c["Nome"].ToString()
                        );
                    Ponto_referencia.Id = int.Parse(c["Id"].ToString());
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

            cmd = new SqlCommand("DELETE FROM rota_referencia where ponto_referencia_id = @id");
            cmd.Parameters.AddWithValue("@id", obj.Id);
            cmd.ExecuteNonQuery();

        }



        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Ponto_referencia obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("INSERT INTO Ponto_referencia (Nome) VALUES (@Nome)", conn);
        
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
        public Modelo.Ponto_referencia Select(int Id)
        {
            Modelo.Ponto_referencia aPonto_referencia = new Modelo.Ponto_referencia();
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
                        dr["Nome"].ToString()
                        );
                    aPonto_referencia.Id = int.Parse(dr["Id"].ToString());
                }
            }

            dr.Close();
            conn.Close();
            return aPonto_referencia;
        }
    }
}