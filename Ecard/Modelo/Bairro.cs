using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecardmark1.Modelo
{
    public class Bairro
    {
        public int id { get; set; }
        public string nome { get; set; }


        public Bairro()
        {
            this.id = 0;
            this.nome = "";
        }

        public Bairro(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }
    }
}