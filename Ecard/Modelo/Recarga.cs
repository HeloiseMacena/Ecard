using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecardmark1.Modelo
{
    public class Recarga
    {
        public int id;
        public DateTime data;
        public float valor;

        public Recarga(int id, DateTime data, float valor)
        {
            this.id = id;
            this.data = data;
            this.valor = valor;
        }
    }
}