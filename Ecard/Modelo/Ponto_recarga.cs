using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace Ecardmark1.Modelo
{
    public class Ponto_recarga
    {
        public int id { get; set; }
        public string nome_ponto { get; set; }
        public string endereco_numero { get; set; }
        public string endereco_logradouro { get; set; }
        public string endereco_cep { get; set; }
        public string endereco_bairro { get; set; }
        public string endereco_municipio { get; set; }

        public static int globalPrId;

        public Ponto_recarga()
        {
            this.id = 0;
            this.nome_ponto = "";
            this.endereco_numero = "";
            this.endereco_logradouro = "";
            this.endereco_cep = "";
            this.endereco_bairro = "";
            this.endereco_municipio = "";
        }

        public Ponto_recarga(int id, string nome_ponto, string endereco_numero, string endereco_logradouro, string endereco_cep, string endereco_bairro, string endereco_municipio)
        {
            this.id = id;
            this.nome_ponto = nome_ponto;
            this.endereco_numero = endereco_numero;
            this.endereco_logradouro = endereco_logradouro;
            this.endereco_cep = endereco_cep;
            this.endereco_bairro = endereco_bairro;
            this.endereco_municipio = endereco_municipio;
        }
    }
}