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
            SqlDataReader dr = cmd.ExecuteReader();

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

        public List<Modelo.Rota> SearchSelect(string value, string option)
        {
            if (value == "" || value == null) { value = "%"; }
            Modelo.Rota aRota;
            List<Modelo.Rota> aListRota = new List<Modelo.Rota>();

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();

            if (option == "Nome") { cmd.CommandText = "SELECT r.id, r.nome From rota r WHERE r.nome LIKE '%" + value + "%'"; }
            else if (option == "Bairro") { cmd.CommandText = "SELECT r.id, r.nome FROM Rotas_Bairro rb INNER JOIN Bairro b ON rb.bairro_id = b.id INNER JOIN rota r ON rb.rotas_id = r.id WHERE b.nome LIKE '%" + value + "%'";}
            else
            {
                cmd.CommandText = "SELECT r.id, r.nome FROM rota r INNER JOIN rota_referencia rr ON r.id = rr.rota_id INNER JOIN Ponto_Referencia pr ON rr.ponto_referencia_id = pr.id WHERE pr.nome LIKE '%"+value +"%'";
            }
            SqlDataReader dr = cmd.ExecuteReader();
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

            SqlCommand cmd = new SqlCommand("DELETE FROM Rotas_Bairro where rotas_id = @id", conn);
            cmd.Parameters.AddWithValue("@id", obj.id);
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand("DELETE FROM rota_referencia where rota_id = @id", conn);
            cmd.Parameters.AddWithValue("@id", obj.id);
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand("DELETE FROM rota WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", obj.id);
            cmd.ExecuteNonQuery();

           
        }



        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Rota obj,List<int> ponto_referencia_id, List<int> bairro_id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("INSERT INTO rota (nome, administrador_id) VALUES (@nome, 1)", conn);
            cmd.Parameters.AddWithValue("@nome", obj.nome);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("Select @@identity as id", conn);
            int id = Convert.ToInt32(cmd.ExecuteScalar());

            for (int i=0;i < bairro_id.Count(); i++)
            {
                cmd = new SqlCommand("INSERT INTO Rotas_Bairro(rotas_id,bairro_id) VALUES (@rota_id,@bairro_id)", conn);
                cmd.Parameters.AddWithValue("@bairro_id", bairro_id[i]);
                cmd.Parameters.AddWithValue("@rota_id", id);
                cmd.ExecuteNonQuery();
            }
            
            for (int i=0;i < ponto_referencia_id.Count(); i++)
            {
                cmd = new SqlCommand("insert into rota_referencia(rota_id, ponto_referencia_id) values(@rota_id, @referencia_id)", conn);
                cmd.Parameters.AddWithValue("@rota_id", id);
                cmd.Parameters.AddWithValue("@referencia_id", ponto_referencia_id[i]);
                cmd.ExecuteNonQuery();
            }
            


        }



        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Rota obj, List<int> referencias_add, List<int> bairros_add)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();

            SqlCommand cmd = new SqlCommand("UPDATE rota SET nome = @nome WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", obj.id);
            cmd.Parameters.AddWithValue("@nome", obj.nome);
            cmd.ExecuteNonQuery();

            List<int> bairros_update = new List<int>();
            List<int> referencias_update = new List<int>();

            // Bairros antigos
            
            cmd = new SqlCommand("select * from rotas_bairro", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            List<int> bairros = new List<int>();
            List<int> referencias = new List<int>();
            if (dr.HasRows)
            {

                while (dr.Read())
                {
                    bairros.Add(Convert.ToInt32(dr["bairro_id"].ToString()));
                }
            }
            dr.Close();
            cmd = new SqlCommand("select * from rota_referencia", conn);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {

                while (dr.Read())
                {
                    referencias.Add(Convert.ToInt32(dr["ponto_referencia_id"].ToString()));
                }
            }
            dr.Close();

            // Inserir novos
            for (int i = 0; i < bairros_add.Count(); i++)
            {
                if (!HasBairro(bairros_add[i], obj.id))
                {
                    cmd = new SqlCommand("INSERT INTO Rotas_Bairro(rotas_id,bairro_id) VALUES (@rota_id,@bairro_id)", conn);
                    cmd.Parameters.AddWithValue("@bairro_id", bairros_add[i]);
                    cmd.Parameters.AddWithValue("@rota_id", obj.id);
                    cmd.ExecuteNonQuery();
                }
                else bairros_update.Add(bairros_add[i]);
            }

            for (int i = 0; i < referencias_add.Count(); i++)
            {
                if (!HasReferencia(referencias_add[i], obj.id))
                {
                    cmd = new SqlCommand("insert into rota_referencia(rota_id, ponto_referencia_id) values(@rota_id, @referencia_id)", conn);
                    cmd.Parameters.AddWithValue("@rota_id", obj.id);
                    cmd.Parameters.AddWithValue("@referencia_id", referencias_add[i]);
                    cmd.ExecuteNonQuery();
                }
                else referencias_update.Add(referencias_add[i]);
                
            }

            // Excluir

            
            for (int i = 0;i < bairros.Count(); i++)
            {
                if (bairros_update.IndexOf(bairros[i]) == -1)
                {
                    cmd = new SqlCommand("delete from rotas_bairro where rotas_id = @rota_id and bairro_id = @bairro_id", conn);
                    cmd.Parameters.AddWithValue("@rota_id", obj.id);
                    cmd.Parameters.AddWithValue("@bairro_id", bairros[i]);
                    cmd.ExecuteNonQuery();
                }
            }

            for (int i=0;i < referencias.Count(); i++)
            {
                if (referencias_update.IndexOf(referencias[i]) == -1)
                {
                    cmd = new SqlCommand("delete from rota_referencia where rota_id = @rota_id and ponto_referencia_id = @referencia_id", conn);
                    cmd.Parameters.AddWithValue("@rota_id", obj.id);
                    cmd.Parameters.AddWithValue("@referencia_id", referencias[i]);
                    cmd.ExecuteNonQuery();
                }
            }


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

        public bool HasReferencia(int referencia_id, int id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from rota_referencia Where ponto_referencia_id = @referencia_id and rota_id = @id";
            cmd.Parameters.AddWithValue("@referencia_id", referencia_id);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows) return true;
            return false;
        }

        public bool HasBairro(int bairro_id, int id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from rotas_bairro Where bairro_id = @bairro_id and rotas_id = @id";
            cmd.Parameters.AddWithValue("@bairro_id", bairro_id);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows) return true;
            return false;
        }

    }
}