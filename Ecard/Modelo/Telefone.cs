using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecard.Modelo
{
    public class Telefone
    {
        public int Id { get; set; }
        public string Numero { get; set; }

        public Telefone()
        {
            this.Id = 0;
            this.Numero = "";
        }

        public Telefone(int id, string numero)
        {
            this.Id = id;
            this.Numero = numero;
        }
    }
}