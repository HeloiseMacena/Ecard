using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecardmark1.Modelo
{
    public class Telefone
    {
        public int id { get; set; }
        public string numero { get; set; }

        public Telefone()
        {
            this.numero = "";
        }

        public Telefone(string numero)
        {
            this.numero = numero;
        }
    }
}