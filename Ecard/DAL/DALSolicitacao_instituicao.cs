using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Ecard.DAL
{
    public class DALSolicitacao_instituicao
    {
        string connectionString = "";

        public DALSolicitacao_instituicao() => connectionString = ConfigurationManager.ConnectionStrings["ecard"].ConnectionString;



        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Solicitacao_instituicao> SelectAll()
        {
            List<Modelo.Solicitacao_instituicao> aListSolicitacao_instituicao = new List<Modelo.Solicitacao_instituicao>();

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Solicitacao_instituicao";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Modelo.Solicitacao_instituicao aSolicitacao_instituicao = new Modelo.Solicitacao_instituicao();
                    aSolicitacao_instituicao.id = int.Parse(dr["id"].ToString());
                    aSolicitacao_instituicao.status = int.Parse(dr["status"].ToString());
                    aSolicitacao_instituicao.descricao_erro = dr["descricao_erro"].ToString();
                    aSolicitacao_instituicao.data = DateTime.Parse(dr["data"].ToString());
                    aListSolicitacao_instituicao.Add(aSolicitacao_instituicao);
                }
            }
            dr.Close();
            conn.Close();

            return aListSolicitacao_instituicao;
        }



        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(Modelo.Solicitacao_instituicao obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("DELETE FROM Solicitacao_instituicao WHERE Id = @Id", conn);

            cmd.Parameters.AddWithValue("@id", obj.id);

            cmd.ExecuteNonQuery();

        }



        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(int instituicao_id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("INSERT INTO SolicitacaoIinstituicao (data, status, instituicao_id) VALUES (@data, @status, @instituicao_id)", conn);

            cmd.Parameters.AddWithValue("@data", DateTime.Now.Date.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@status", 0);
            cmd.Parameters.AddWithValue("@instituicao_id", instituicao_id);

            cmd.ExecuteNonQuery();

        }



        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Solicitacao_instituicao obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("UPDATE Solicitacao_instituicao SET data = @data, status = @status, descricao_erro = @descricao_erro WHERE Id = @Id", conn);

            cmd.Parameters.AddWithValue("@Id", obj.id);
            cmd.Parameters.AddWithValue("@data", obj.data.Date.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@status", obj.status);
            cmd.Parameters.AddWithValue("@descricao_erro", obj.descricao_erro);

            cmd.ExecuteNonQuery();
        }



        [DataObjectMethod(DataObjectMethodType.Select)]
        public Modelo.Solicitacao_instituicao Select(int Id)
        {
            Modelo.Solicitacao_instituicao aSolicitacao_instituicao = new Modelo.Solicitacao_instituicao();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Solicitacao_instituicao Where Id = @Id";
            cmd.Parameters.AddWithValue("@Id", Id);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aSolicitacao_instituicao.id = int.Parse(dr["id"].ToString());
                    aSolicitacao_instituicao.status = int.Parse(dr["status"].ToString());
                    aSolicitacao_instituicao.descricao_erro = dr["descricao_erro"].ToString();
                    aSolicitacao_instituicao.data = DateTime.Parse(dr["data"].ToString());
                }
            }

            dr.Close();
            conn.Close();

            return aSolicitacao_instituicao;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public Modelo.Solicitacao_instituicao SelectInstituicao(int Id)
        {
            Modelo.Solicitacao_instituicao aSolicitacao_instituicao = new Modelo.Solicitacao_instituicao();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Solicitacao_instituicao Where instituicao_id = @Id";
            cmd.Parameters.AddWithValue("@Id", Id);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aSolicitacao_instituicao.id = int.Parse(dr["id"].ToString());
                    aSolicitacao_instituicao.status = int.Parse(dr["status"].ToString());
                    aSolicitacao_instituicao.descricao_erro = dr["descricao_erro"].ToString();
                    aSolicitacao_instituicao.data = DateTime.Parse(dr["data"].ToString());
                }
            }

            dr.Close();
            conn.Close();

            return aSolicitacao_instituicao;
        }


        public int CountSolicitacoes()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select count(*) from solicitacao_instituicao where status = 0";
            SqlDataReader dr = cmd.ExecuteReader();
            int count = 0;
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    count = dr.GetInt32(0);
                }
            }
            return count;
        }
    }
}