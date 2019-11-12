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
        public string data { get; set; }

        public Extrato()
        {
            this.id = 0;
            this.valor = 0;
            this.data = "";
        }

        public Extrato(string data, double valor)
        {
            this.data = data;
            this.valor = valor;
        }
    }
}