using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecard.Modelo
{
    public class Estudante
    {
        public int id;
        public string nome;
        public string cpf;
        public string rg;
        public string email;
        public int status;
        /* status:  
            0: sem carteira
            1: carteira solicitada
            2: carteira existente
             
        */
        public int carteira_status;
        /*  excluir carteira_status depois*/
        public string carteira_foto;
        public double carteira_saldo;
        public int carteira_numero;
        public DateTime carteira_validade;
        public string senha;

        public Estudante()
        {
            id = 0;
        }
        public Estudante(string nome, string cpf, string rg, string email, string senha, int status, string carteira_foto, double carteira_saldo, int carteira_numero, DateTime carteira_validade)
        {
            
            this.nome = nome;
            this.cpf = cpf;
            this.rg = rg;
            this.email = email;
            this.status = status;
            this.senha = senha;
            this.carteira_foto = carteira_foto;
            this.carteira_saldo = carteira_saldo;
            this.carteira_numero = carteira_numero;
            this.carteira_validade = carteira_validade;
            carteira_status = 0;
        }
    }
}