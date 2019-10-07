using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecard.Modelo
{
    public class Recarga
    {
        public int id;
        public DateTime data;
        public double valor;

        public Recarga()
        {
            id = 0;
        }
        public Recarga(double valor)
        {
            data = DateTime.Now;
            this.valor = valor;
        }
    }
}