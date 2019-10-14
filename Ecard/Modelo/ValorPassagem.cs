using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecard.Modelo
{
    public class ValorPassagem
    {
        public int id { get; set; }
        public double valor { get; set; }
        public string local { get; set; }


        public ValorPassagem()
        {
            this.id = 0;
            this.valor = 0.00;
            this.local = "";
        }

        public ValorPassagem(double valor, string local)
        {
            this.valor = valor;
            this.local = local;
        }
    }
}