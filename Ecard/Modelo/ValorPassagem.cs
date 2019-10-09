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


        public ValorPassagem()
        {
            this.id = 0;
            this.valor = 0.00;
        }

        public ValorPassagem(double valor)
        {
            this.valor = valor;
        }
    }
}