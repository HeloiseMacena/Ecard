using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Ecard.DAL
{
    public class DALAdministrador
    {
        string connectionString = "";

        public DALAdministrador()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ecard"].ConnectionString;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Administrador> SelectAll()
        {
            List<Modelo.Administrador> aListAdministrador = new List<Modelo.Administrador>();

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Administrador";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Modelo.Administrador aAdministrador = new Modelo.Administrador(
                        Convert.ToInt32(dr["id"].ToString()),
                        dr["nome"].ToString(),
                        dr["email"].ToString(),
                        dr["senha"].ToString(),
                        dr["cpf"].ToString()
            );
                    aListAdministrador.Add(aAdministrador);
                }
            }
            dr.Close();
            conn.Close();

            return aListAdministrador;
        }



        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(Modelo.Administrador obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("DELETE FROM Administrador WHERE Id = @Id", conn);

            cmd.Parameters.AddWithValue("@id", obj.id);

            cmd.ExecuteNonQuery();

        }



        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Administrador obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("INSERT INTO Administrador (Id, Nome, email, senha, cpf) VALUES (@Id, @Nome, @email, @senha, @cpf)", conn);

            cmd.Parameters.AddWithValue("@Id", obj.id);
            cmd.Parameters.AddWithValue("@Nome", obj.nome);
            cmd.Parameters.AddWithValue("@email", obj.email);
            cmd.Parameters.AddWithValue("@senha", obj.senha);
            cmd.Parameters.AddWithValue("@cpf", obj.cpf);

            cmd.ExecuteNonQuery();

        }



        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Administrador obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("UPDATE Administrador SET Nome = @Nome, email = @email, senha = @senha, cpf = @cpf WHERE Id = @Id", conn);

            cmd.Parameters.AddWithValue("@Id", obj.id);
            cmd.Parameters.AddWithValue("@Nome", obj.nome);
            cmd.Parameters.AddWithValue("@email", obj.email);
            cmd.Parameters.AddWithValue("@senha", obj.senha);
            cmd.Parameters.AddWithValue("@cpf", obj.cpf);


            cmd.ExecuteNonQuery();
        }



        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Administrador> Select(string Id)
        {
            Modelo.Administrador aAdministrador;
            List<Modelo.Administrador> aListAdministrador = new List<Modelo.Administrador>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Administrador Where Id = @Id";
            cmd.Parameters.AddWithValue("@Id", Id);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aAdministrador = new Modelo.Administrador(
                        Convert.ToInt32(dr["Id"].ToString()),
                        dr["nome"].ToString(),
                        dr["email"].ToString(),
                        dr["senha"].ToString(),
                        dr["cpf"].ToString()
                        );
                    aListAdministrador.Add(aAdministrador);
                }
            }

            dr.Close();
            conn.Close();

            return aListAdministrador;
        }

    }
}