using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecardmark1.Modelo
{
    public class Instituicao
    {
        public class Instituicao
        {
            public int id { get; set; }
            public string nome { get; set; }
            public string email { get; set; }
            public string codigo_inep { get; set; }
            public string cnpj { get; set; }
            public bool status { get; set; }
            public string senha { get; set; }
            public string endereco_bairro { get; set; }
            public string endereco_CEP { get; set; }
            public string endereco_municipio { get; set; }
            public string endereco_logradouro { get; set; }
            public string endereco_numero { get; set; }


            public Instituicao()
            {
                this.nome = "";
                this.email = "";
                this.codigo_inep = "";
                this.cnpj = "";
                this.status = false;
                this.senha = "";
                this.endereco_bairro = "";
                this.endereco_CEP = "";
                this.endereco_municipio = "";
                this.endereco_logradouro = "";
                this.endereco_numero = "";
            }

            public Instituicao(string nome, string email, string codigo, string cnpj, bool status, string senha, string endereco_bairro, string endereco_CEP, string endereco_municipio, string endereco_logradouro, string endereco_numero)
            {
                this.nome = nome;
                this.email = email;
                this.codigo_inep = codigo;
                this.cnpj = cnpj;
                this.status = status;
                this.senha = senha;
                this.endereco_bairro = endereco_bairro;
                this.endereco_CEP = endereco_CEP;
                this.endereco_municipio = endereco_municipio;
                this.endereco_logradouro = endereco_logradouro;
                this.endereco_numero = endereco_numero;
            }
        }
}