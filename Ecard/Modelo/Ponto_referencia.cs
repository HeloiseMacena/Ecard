using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecardmark1.Modelo
{
    public class Ponto_referencia
    {
        public int id { get; set; }
        public string nome { get; set; }


        public Ponto_referencia()
        {
            this.nome = "";
        }

        public Ponto_referencia(string nome)
        {
            this.nome = nome;
        }
    }
}