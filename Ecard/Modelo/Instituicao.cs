using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecard.Modelo
{
    public class Instituicao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Codigo_inep_mec { get; set; }
        public bool Status { get; set; }
        public string Senha { get; set; }
        public string Endereco_bairro { get; set; }
        public string Endereco_CEP { get; set; }
        public string Endereco_municipio { get; set; }
        public string Endereco_logradouro { get; set; }
        public string Endereco_numero { get; set; }


        public Instituicao()
        {
            this.Id = 0;
            this.Nome = "";
            this.Email = "";
            this.Codigo_inep_mec = "";
            this.Status = false;
            this.Senha = "";
            this.Endereco_bairro = "";
            this.Endereco_CEP = "";
            this.Endereco_municipio = "";
            this.Endereco_logradouro = "";
            this.Endereco_numero = "";
        }

        public Instituicao(int id, string nome, string email, string codigo, bool status, string senha, string endereco_bairro, string endereco_CEP, string endereco_municipio, string endereco_logradouro, string endereco_numero)
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Codigo_inep_mec = codigo;
            this.Status = status;
            this.Senha = Senha;
            this.Endereco_bairro = endereco_bairro;
            this.Endereco_CEP = endereco_CEP;
            this.Endereco_municipio = endereco_municipio;
            this.Endereco_logradouro = endereco_logradouro;
            this.Endereco_numero = endereco_numero;
        }
    }
}