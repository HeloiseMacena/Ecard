﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecard.Modelo
{
    public class Administrador
    {
        public int id;
        public string nome;
        public string email;
        public string senha;
        public string cpf;

        public Administrador()
        {
            id = 0;
        }
        public Administrador(int id, string nome, string email, string senha, string cpf)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.senha = senha;
            this.cpf = cpf;
        }
    }
}