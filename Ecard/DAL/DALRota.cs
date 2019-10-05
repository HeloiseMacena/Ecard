using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Ecard.DAL
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
            Modelo.Rota aRota;
            List<Modelo.Rota> aListRota = new List<Modelo.Rota>();

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from rota";


            if (dr.HasRows)
            {

                while (dr.Read())
                {
                    aRota = new Modelo.Rota(
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

            SqlCommand cmd = new SqlCommand("DELETE FROM Rotas_Bairro where rotas_id = @id");
            cmd.Parameters.AddWithValue("@id", obj.id);
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand("DELETE FROM rota WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", obj.id);
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand("DELETE FROM rota_referencia where rota_id = @id");
            cmd.Parameters.AddWithValue("@id", obj.id);
            cmd.ExecuteNonQuery();
        }



        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Rota obj,int ponto_referencia_id, int bairro_id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("INSERT INTO rota (nome, administrador_id, ponto_referencia_id) VALUES (@nome, 1,@ponto_referencia_id)", conn);
            cmd.Parameters.AddWithValue("@nome", obj.nome);
            cmd.Parameters.AddWithValue("@ponto_referencia_id", ponto_referencia_id);
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand("Select @@identity as id", conn);
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd = new SqlCommand("INSERT INTO Rotas_Bairro(rotas_id,bairro_id) VALUES (@rota_id,@bairro_id)", conn);
            cmd.Parameters.AddWithValue("@bairro_id",bairro_id);
            cmd.Parameters.AddWithValue("@rota_id", id);
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand("insert into rota_referencia(rota_id, ponto_referencia_id) values(@rota_id, @referencia_id0)", conn);
            cmd.Parameters.AddWithValue("@rota_id", id);
            cmd.Parameters.AddWithValue("@referencia_id", ponto_referencia_id);
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
        public Modelo.Rota Select(int id)
        {
            Modelo.Rota aRota;
            Modelo.Rota aListRota = new Modelo.Rota();
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
                    aRota = new Modelo.Rota(
                        dr["nome"].ToString()
                        );
                    aRota.id = Convert.ToInt32(dr["id"].ToString()); 
                    aListRota = aRota;
                }
            }

            dr.Close();
            conn.Close();
            return aListRota;
        }
    }
}