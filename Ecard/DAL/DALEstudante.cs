using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using Ecard.Modelo;

namespace Ecard.DAL
{
    public class DALEstudante
    {
        string connectionString = "";



        public DALEstudante()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ecard"].ConnectionString;
        }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public double SelectStatusCarteira(int id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select carteira_status from Estudante where id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            int status = int.Parse(dr["carteira_status"].ToString());

            conn.Close();

            return status;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public int SelectStatus(int id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select status from Estudante where id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            int status = int.Parse(dr["status"].ToString());

            conn.Close();

            return status;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public void MudarSituacaoEstudante(int a, string cpf)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            if (a == 0) //Apto
            {
                SqlCommand cmd = new SqlCommand("UPDATE Estudante SET status = 0 where cpf = " + cpf, conn);
            }
            if (a == 1) //Inapto
            {
                SqlCommand cmd = new SqlCommand("UPDATE Estudante SET status = 1  where cpf = " + cpf, conn);
            }
            if (a == 2) //Cadastrado pela instituição
            {
                SqlCommand cmd = new SqlCommand("UPDATE Estudante SET status = 2  where cpf = " + cpf, conn);
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public bool ExisteEstudante(string cpf)
        {
            bool a = false;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Estudante where cpf = @cpf";
            cmd.Parameters.AddWithValue("@cpf", cpf);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            if (dr.HasRows)
            {
                a = true;
            }

            conn.Close();
            return a;
        }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public double SelectSaldo(int id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select carteira_saldo from Estudante where id =" + id;
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            double valor = double.Parse(dr["carteira_saldo"].ToString());

            conn.Close();

            return valor;
        }


        [DataObjectMethod(DataObjectMethodType.Update)]
        public void MudarSituacaoTrue(string cpf, int id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("UPDATE Estudante SET status = 0, instituicao_id = @id where cpf = @cpf", conn);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();

        }



        [DataObjectMethod(DataObjectMethodType.Update)]
        public void MudarSituacaoFalse()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("UPDATE Estudante SET status = 1", conn);
            cmd.ExecuteNonQuery();
        }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Estudante> SelectArquivoCsv(string arquivo)
        {
            StreamReader sr;
            string Linha;
            string[] linha;

            List<Modelo.Estudante> aListEstudante = new List<Modelo.Estudante>();

            // Le arquivo com nome de imagens
            if (System.IO.File.Exists(arquivo))
            {
                sr = new StreamReader(System.IO.File.OpenRead(arquivo));
                try
                {
                    while (sr.Peek() > -1)
                    {
                        Linha = sr.ReadLine(); // Le uma Linha

                        // Separa os dados em cada linha
                        linha = Linha.Split(';');

                        Modelo.Estudante aEstudante = new Modelo.Estudante(
                            linha[0],
                            linha[2],
                            linha[1],
                            "",
                            "",
                            0,
                            "",
                            0,
                            0,
                            Convert.ToDateTime("01/01/2000")
                        );

                        aListEstudante.Add(aEstudante);
                    }
                }
                finally
                {
                    sr.Close();
                }
            }

            return aListEstudante;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Estudante> SelectRetorno(int id)
        {
            List<Modelo.Estudante> aListEstudante = new List<Modelo.Estudante>();

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Estudante where status = true and instituicao_id = " + id;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Modelo.Estudante aEstudante = new Modelo.Estudante(
                        dr["nome"].ToString(),
                        dr["cpf"].ToString(),
                        dr["rg"].ToString(),
                        dr["email"].ToString(),
                        dr["senha"].ToString(),
                        int.Parse(dr["status"].ToString()),
                        dr["carteira_foto"].ToString(),
                        double.Parse(dr["carteira_saldo"].ToString()),
                        int.Parse(dr["carteira_numero"].ToString()),
                        Convert.ToDateTime(dr["carteira_validade"].ToString())
                    );
                    aEstudante.id = Convert.ToInt32(dr["id"].ToString());
                    aListEstudante.Add(aEstudante);
                }
            }
            dr.Close();
            conn.Close();

            return aListEstudante;
        }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Estudante> SelectSolicitacoes()
        {
            List<Modelo.Estudante> aListEstudante = new List<Modelo.Estudante>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Estudante where carteira_status = 1";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Modelo.Estudante aEstudante = new Modelo.Estudante(
                        dr["nome"].ToString(),
                        dr["cpf"].ToString(),
                        dr["rg"].ToString(),
                        dr["email"].ToString(),
                        dr["senha"].ToString(),
                        int.Parse(dr["status"].ToString()),
                        dr["carteira_foto"].ToString(),
                        double.Parse(dr["carteira_saldo"].ToString()),
                        int.Parse(dr["carteira_numero"].ToString()),
                        Convert.ToDateTime(dr["carteira_validade"].ToString())
                    );
                    aEstudante.id = Convert.ToInt32(dr["id"].ToString());
                    aEstudante.carteira_status = Convert.ToInt32(dr["carteira_status"].ToString());
                    aListEstudante.Add(aEstudante);
                }
            }
            dr.Close();
            conn.Close();

            return aListEstudante;
        }


        ////[DataObjectMethod(DataObjectMethodType.Update)]
        ///public void MudarValorPassagem(int id, double valor)
        //{

        //SqlConnection conn = new SqlConnection(connectionString);
        ///conn.Open();
        // SqlCommand com = conn.CreateCommand();
        // SqlCommand cmd = new SqlCommand("UPDATE Estudante SET carteira_saldo = @valor where id = @id", conn);
        // cmd.Parameters.AddWithValue("@id", id);
        //cmd.Parameters.AddWithValue("@valor", valor);
        //SqlDataReader dr = cmd.ExecuteReader();
        // dr.Close();
        // conn.Close();

        //}


        [DataObjectMethod(DataObjectMethodType.Update)]
        public void MudarSituacaoCarteira1(string cpf)
        {

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("UPDATE Estudante SET carteira_status = 1 where cpf = @cpf", conn);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Close();
            conn.Close();

        }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Estudante> SelectAll()
        {
            List<Modelo.Estudante> aListEstudante = new List<Modelo.Estudante>();

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Estudante";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Modelo.Estudante aEstudante = new Modelo.Estudante(
                        dr["nome"].ToString(),
                        dr["cpf"].ToString(),
                        dr["rg"].ToString(),
                        dr["email"].ToString(),
                        dr["senha"].ToString(),
                        int.Parse(dr["status"].ToString()),
                        dr["carteira_foto"].ToString(),
                        double.Parse(dr["carteira_saldo"].ToString()),
                        int.Parse(dr["carteira_numero"].ToString()),
                        Convert.ToDateTime(dr["carteira_validade"].ToString())
                    );
                    aEstudante.id = Convert.ToInt32(dr["id"].ToString());
                    aEstudante.carteira_status = Convert.ToInt32(dr["carteira_status"].ToString());
                    aListEstudante.Add(aEstudante);
                }
            }
            dr.Close();
            conn.Close();

            return aListEstudante;
        }


        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Estudante obj, int instituicao_id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("INSERT INTO Estudante (Nome, cpf, rg, email, status, carteira_foto, carteira_saldo, carteira_numero, carteira_validade, senha, administrador_id, carteira_status, instituicao_id) VALUES (@Nome, @cpf, @rg, @email, 2, @carteira_foto, @carteira_saldo, @carteira_numero, @carteira_validade, @senha, 1, 0, @instituicao_id)", conn);

            cmd.Parameters.AddWithValue("@Nome", obj.nome);
            cmd.Parameters.AddWithValue("@cpf", obj.cpf);
            cmd.Parameters.AddWithValue("@rg", obj.rg);
            cmd.Parameters.AddWithValue("@email", obj.email);
            cmd.Parameters.AddWithValue("@status", obj.status);
            cmd.Parameters.AddWithValue("@carteira_foto", obj.carteira_foto);
            cmd.Parameters.AddWithValue("@carteira_saldo", obj.carteira_saldo);
            cmd.Parameters.AddWithValue("@carteira_numero", obj.carteira_numero);
            cmd.Parameters.AddWithValue("@carteira_validade", obj.carteira_validade);
            cmd.Parameters.AddWithValue("@senha", obj.senha);
            cmd.Parameters.AddWithValue("@instituicao_id", instituicao_id);

            cmd.ExecuteNonQuery();

        }



        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Estudante obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("UPDATE Estudante SET Nome = @Nome, cpf = @cpf, senha = @senha, email = @email, status = @status, carteira_foto = @carteira_foto, carteira_saldo = @carteira_saldo, carteira_numero = @carteira_numero, carteira_validade = @carteira_validade, carteira_status = @carteira_status WHERE cpf = @cpf", conn);

            cmd.Parameters.AddWithValue("@Id", obj.id);
            cmd.Parameters.AddWithValue("@Nome", obj.nome);
            cmd.Parameters.AddWithValue("@cpf", obj.cpf);
            cmd.Parameters.AddWithValue("@rg", obj.rg);
            cmd.Parameters.AddWithValue("@email", obj.email);
            cmd.Parameters.AddWithValue("@status", obj.status);
            cmd.Parameters.AddWithValue("@senha", obj.senha);
            cmd.Parameters.AddWithValue("@carteira_foto", obj.carteira_foto);
            cmd.Parameters.AddWithValue("@carteira_saldo", obj.carteira_saldo);
            cmd.Parameters.AddWithValue("@carteira_numero", obj.carteira_numero);
            cmd.Parameters.AddWithValue("@carteira_validade", obj.carteira_validade);
            cmd.Parameters.AddWithValue("@carteira_status", obj.carteira_status);

            cmd.ExecuteNonQuery();
        }



        [DataObjectMethod(DataObjectMethodType.Select)]
        public Modelo.Estudante Select(int Id)
        {
            Modelo.Estudante aEstudante = new Modelo.Estudante();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Estudante Where Id = @Id";
            cmd.Parameters.AddWithValue("@Id", Id);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aEstudante = new Modelo.Estudante(
                        dr["nome"].ToString(),
                        dr["cpf"].ToString(),
                        dr["rg"].ToString(),
                        dr["email"].ToString(),
                        dr["senha"].ToString(),
                        int.Parse(dr["status"].ToString()),
                        dr["carteira_foto"].ToString(),
                        double.Parse(dr["carteira_saldo"].ToString()),
                        int.Parse(dr["carteira_numero"].ToString()),
                        Convert.ToDateTime(dr["carteira_validade"].ToString())
                    );
                    aEstudante.id = Convert.ToInt32(dr["id"].ToString());
                    aEstudante.carteira_status = Convert.ToInt32(dr["carteira_status"].ToString());
                }
            }

            dr.Close();
            conn.Close();

            return aEstudante;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public int instituicao_id(int Id)
        {
            Modelo.Estudante aEstudante = new Modelo.Estudante();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Estudante Where Id = @Id";
            cmd.Parameters.AddWithValue("@Id", Id);
            SqlDataReader dr = cmd.ExecuteReader();
            int id_instituicao = 0;
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    id_instituicao = int.Parse(dr["instituicao_id"].ToString());
                }
            }

            dr.Close();
            conn.Close();

            return id_instituicao;
        }

        public int estudante_id(string cpf)
        {
            Modelo.Estudante aEstudante = new Modelo.Estudante();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Estudante Where cpf = @cpf";
            cmd.Parameters.AddWithValue("@cpf", cpf);
            SqlDataReader dr = cmd.ExecuteReader();
            int id_estudante = 0;
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    id_estudante = int.Parse(dr["id"].ToString());
                }
            }

            dr.Close();
            conn.Close();

            return id_estudante;
        }

        public Modelo.Estudante Login(string cpf, string senha)
        {
            Modelo.Estudante aEstudante = new Modelo.Estudante();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Estudante Where cpf = @cpf and senha = @senha";
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@senha", senha);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aEstudante = new Modelo.Estudante(
                        dr["nome"].ToString(),
                        dr["cpf"].ToString(),
                        dr["rg"].ToString(),
                        dr["email"].ToString(),
                        dr["senha"].ToString(),
                        int.Parse(dr["status"].ToString()),
                        dr["carteira_foto"].ToString(),
                        double.Parse(dr["carteira_saldo"].ToString()),
                        int.Parse(dr["carteira_numero"].ToString()),
                        Convert.ToDateTime(dr["carteira_validade"].ToString())
                    );
                    aEstudante.id = Convert.ToInt32(dr["id"].ToString());
                    aEstudante.carteira_status = Convert.ToInt32(dr["carteira_status"].ToString());
                }
            }

            dr.Close();
            conn.Close();

            return aEstudante;
        }
    }
}