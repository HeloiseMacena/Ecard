using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace Ecard.Modelo
{
    public class Rota
    {
        public int id { get; set; }
        public string nome { get; set; }

        public static int globalRotaId;

        public Rota()
        {
            this.nome = "";
        }

        public Rota(string nome)
        {
          
            this.nome = nome;
        }
    }
}