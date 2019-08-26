using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecardmark1.Modelo
{
    public class Ponto_referencia
    {
        public int Id { get; set; }
        public string Nome { get; set; }


        public Ponto_referencia()
        {
            this.Id = 0;
            this.Nome = "";
        }

        public Ponto_referencia(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;
        }
    }
}