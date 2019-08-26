using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Ecardmark1.DAL
{
    public class DALLista_alunos
    {
        string connectionString = "";



        public DALLista_alunos()
        {
            connectionString = ConfigurationManager.ConnectionStrings["PubsConnectionString"].ConnectionString;
        }



        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Lista_alunos> SelectAll()
        {
            List<Modelo.Lista_alunos> aListLista_alunos = new List<Modelo.Lista_alunos>();

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Lista_alunos";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Modelo.Lista_alunos aLista_alunos = new Modelo.Lista_alunos(
                        Convert.ToInt32(dr["id"].ToString()),
                        dr["caminho_arquivo"].ToString(),
                        Convert.ToInt32(dr["ano"].ToString()),
                        Convert.ToBoolean(dr["processada"].ToString())
                    );
                    aListLista_alunos.Add(aLista_alunos);
                }
            }
            dr.Close();
            conn.Close();

            return aListLista_alunos;
        }



        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(Modelo.Lista_alunos obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("DELETE FROM Lista_alunos WHERE Id = @Id", conn);

            cmd.Parameters.AddWithValue("@Id", obj.id);

            cmd.ExecuteNonQuery();

        }



        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Lista_alunos obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("INSERT INTO Lista_alunos (Id, caminho_arquivo, ano, processada) VALUES (@Id, @caminho_arquivo, @ano, @processada)", conn);

            cmd.Parameters.AddWithValue("@Id", obj.id);
            cmd.Parameters.AddWithValue("@caminho_arquivo", obj.caminho_arquivo);
            cmd.Parameters.AddWithValue("@ano", obj.ano);
            cmd.Parameters.AddWithValue("processada", obj.processada);

            cmd.ExecuteNonQuery();

        }



        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Lista_alunos obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("UPDATE Lista_alunos SET caminho_arquivo = @caminho_arquivo, ano = @ano, processada = @processada WHERE Id = @Id", conn);

            cmd.Parameters.AddWithValue("@Id", obj.id);
            cmd.Parameters.AddWithValue("@caminho_arquivo", obj.caminho_arquivo);
            cmd.Parameters.AddWithValue("@ano", obj.ano);
            cmd.Parameters.AddWithValue("@processada", obj.processada);

            cmd.ExecuteNonQuery();
        }



        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Lista_alunos> Select(string Id)
        {
            Modelo.Lista_alunos aLista_alunos;
            List<Modelo.Lista_alunos> aListLista_alunos = new List<Modelo.Lista_alunos>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Lista_alunos Where Id = @Id";
            cmd.Parameters.AddWithValue("@Id", Id);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aLista_alunos = new Modelo.Lista_alunos(
                        Convert.ToInt32(dr["id"].ToString()),
                        dr["caminho_arquivo"].ToString(),
                        Convert.ToInt32(dr["ano"].ToString()),
                        Convert.ToBoolean(dr["processada"].ToString())
                    );
                    aListLista_alunos.Add(aLista_alunos);
                }
            }

            dr.Close();
            conn.Close();

            return aListLista_alunos;
        }
    }
}