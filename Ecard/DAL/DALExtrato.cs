using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Ecard.DAL
{
    public class DALExtrato
    {
        string connectionString = "";



        public DALExtrato()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ecard"].ConnectionString;
        }



        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Extrato> SelectAll(int estudante_id)
        {
            List<Modelo.Extrato> aListExtrato = new List<Modelo.Extrato>();

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Extrato where estudante_id = " + estudante_id;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Modelo.Extrato aExtrato = new Modelo.Extrato(
                        Convert.ToDouble(dr["valor"].ToString())
                        );
                    aExtrato.id = Convert.ToInt32(dr["id"].ToString());
                    aExtrato.data = Convert.ToDateTime(dr["data"].ToString());
                    aListExtrato.Add(aExtrato);
                }
            }
            dr.Close();
            conn.Close();

            return aListExtrato;
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Extrato obj, int estudante_id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("INSERT INTO Extrato (data, valor, estudante_id, recarga_id) VALUES (@data, @valor, @estudante_id," + 1 + ")", conn);

            cmd.Parameters.AddWithValue("@data", obj.data);
            cmd.Parameters.AddWithValue("@valor", obj.valor);
            cmd.Parameters.AddWithValue("@estudante_id", estudante_id);

            cmd.ExecuteNonQuery();

        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public Modelo.Extrato Select(string Id)
        {
            Modelo.Extrato aExtrato = new Modelo.Extrato();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Extrato Where Id = @Id";
            cmd.Parameters.AddWithValue("@Id", Id);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aExtrato = new Modelo.Extrato(
                         Convert.ToDouble(dr["valor"].ToString())
                        );
                    aExtrato.id = Convert.ToInt32(dr["id"].ToString());
                    aExtrato.data = Convert.ToDateTime(dr["data"].ToString());
                }
            }

            dr.Close();
            conn.Close();

            return aExtrato;
        }
    }
}