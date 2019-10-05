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
        public string cnpj { get; set; }


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

        public Instituicao(string nome, string email, string codigo, bool status, string senha, string endereco_bairro, string endereco_CEP, string endereco_municipio, string endereco_logradouro, string endereco_numero, string cnpj)
        {
            Nome = nome;
            Email = email;
            Codigo_inep_mec = codigo;
            Status = status;
            Senha = senha;
            Endereco_bairro = endereco_bairro;
            Endereco_CEP = endereco_CEP;
            Endereco_municipio = endereco_municipio;
            Endereco_logradouro = endereco_logradouro;
            Endereco_numero = endereco_numero;
            this.cnpj = cnpj;
        }
    }
}