using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Ecard.DAL
{
    public class DALSolicitacao_carteira
    {
        string connectionString = "";

        public DALSolicitacao_carteira() => connectionString = ConfigurationManager.ConnectionStrings["ecard"].ConnectionString;



        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Solicitacao_carteira> SelectAll()
        {
            List<Modelo.Solicitacao_carteira> aListSolicitacao_carteira = new List<Modelo.Solicitacao_carteira>();

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Solicitacao_carteira";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Modelo.Solicitacao_carteira aSolicitacao_carteira = new Modelo.Solicitacao_carteira();
                    aSolicitacao_carteira.descricao_erro = dr["descricao_erro"].ToString();
                    aSolicitacao_carteira.id = int.Parse(dr["id"].ToString());
                    aSolicitacao_carteira.status = int.Parse(dr["status"].ToString());
                    aSolicitacao_carteira.data = DateTime.Parse(dr["data"].ToString());
                    aListSolicitacao_carteira.Add(aSolicitacao_carteira);
                }
            }
            dr.Close();
            conn.Close();

            return aListSolicitacao_carteira;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Solicitacao_carteira> SelectPendentes()
        {
            List<Modelo.Solicitacao_carteira> aListSolicitacao_carteira = new List<Modelo.Solicitacao_carteira>();

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Solicitacao_carteira where status = 0";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Modelo.Solicitacao_carteira aSolicitacao_carteira = new Modelo.Solicitacao_carteira();
                    aSolicitacao_carteira.descricao_erro = dr["descricao_erro"].ToString();
                    aSolicitacao_carteira.id = int.Parse(dr["id"].ToString());
                    aSolicitacao_carteira.status = int.Parse(dr["status"].ToString());
                    aSolicitacao_carteira.data = DateTime.Parse(dr["data"].ToString());
                    aListSolicitacao_carteira.Add(aSolicitacao_carteira);
                }
            }
            dr.Close();
            conn.Close();

            return aListSolicitacao_carteira;
        }



        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(Modelo.Solicitacao_carteira obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("DELETE FROM Solicitacao_carteira WHERE Id = @Id", conn);

            cmd.Parameters.AddWithValue("@id", obj.id);

            cmd.ExecuteNonQuery();

        }



        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(int estudante_id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("INSERT INTO Solicitacao_carteira (data, status, estudante_id) VALUES (@data, @status, @estudante_id)", conn);

            cmd.Parameters.AddWithValue("@data", DateTime.Now);
            cmd.Parameters.AddWithValue("@status", 0);
            cmd.Parameters.AddWithValue("@estudante_id", estudante_id);

            cmd.ExecuteNonQuery();

        }



        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Solicitacao_carteira obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("UPDATE Solicitacao_carteira SET data = @data, status = @status, descricao_erro = @descricao_erro WHERE Id = @Id", conn);

            cmd.Parameters.AddWithValue("@Id", obj.id);
            cmd.Parameters.AddWithValue("@data", obj.data);
            cmd.Parameters.AddWithValue("@status", obj.status);
            cmd.Parameters.AddWithValue("@descricao_erro", obj.descricao_erro);

            cmd.ExecuteNonQuery();
        }



        [DataObjectMethod(DataObjectMethodType.Select)]
        public Modelo.Solicitacao_carteira Select(int Id)
        {
            Modelo.Solicitacao_carteira aSolicitacao_carteira = new Modelo.Solicitacao_carteira();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Solicitacao_carteira Where Id = @Id";
            cmd.Parameters.AddWithValue("@Id", Id);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aSolicitacao_carteira.descricao_erro = dr["descricao_erro"].ToString();
                    aSolicitacao_carteira.id = int.Parse(dr["id"].ToString());
                    aSolicitacao_carteira.status = int.Parse(dr["status"].ToString());
                    aSolicitacao_carteira.data = DateTime.Parse(dr["data"].ToString());
                }
            }

            dr.Close();
            conn.Close();

            return aSolicitacao_carteira;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public int SelectEstudante(int Id)
        {
            Modelo.Solicitacao_carteira aSolicitacao_carteira = new Modelo.Solicitacao_carteira();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Solicitacao_carteira Where Id = @Id";
            cmd.Parameters.AddWithValue("@Id", Id);
            SqlDataReader dr = cmd.ExecuteReader();
            int estudante_id = 0;
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    estudante_id = int.Parse(dr["estudante_id"].ToString());
                }
            }

            dr.Close();
            conn.Close();

            return estudante_id;
        }


    }
}