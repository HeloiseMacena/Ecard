﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecard.Modelo
{
    public class Bairro
    {
        public int Id { get; set; }
        public string Nome { get; set; }


        public Bairro()
        {
            this.Id = 0;
            this.Nome = "";
        }

        public Bairro(string nome)
        {
            this.Nome = nome;
        }
    }
}