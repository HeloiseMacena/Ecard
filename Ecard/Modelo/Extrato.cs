using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecard.Modelo
{
    public class Extrato
    {
        public int id { get; set; }
        public double valor { get; set; }
        public DateTime data { get; set; }


        public Extrato()
        {
            this.id = 0;
        }

        public Extrato(double valor)
        {
            data = DateTime.Now;
            this.valor = valor;
        }
    }
}