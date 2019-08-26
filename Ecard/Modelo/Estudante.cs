using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecardmark1.Modelo
{
    public class Estudante
    {
        public int id;
        public string nome;
        public string cpf;
        public string email;
        public bool status;
        public string carteira_foto;
        public double carteira_saldo;
        public int carteira_numero;
        public DateTime carteira_validade;

        public Estudante(int id, string nome, string cpf, string email, string senha, bool status, string carteira_foto, double carteira_saldo, int carteira_numero, DateTime carteira_validade)
        {
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
            this.email = email;
            this.status = status;
            this.carteira_foto = carteira_foto;
            this.carteira_saldo = carteira_saldo;
            this.carteira_numero = carteira_numero;
            this.carteira_validade = carteira_validade;
        }
    }
}