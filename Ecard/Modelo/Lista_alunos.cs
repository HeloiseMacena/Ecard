using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecardmark1.Modelo
{
    public class Lista_alunos
    {
        public int id;
        public string caminho_arquivo;
        public int ano;
        public bool processada;

        public Lista_alunos(int id, string caminho_arquivo, int ano, bool processada)
        {
            this.id = id;
            this.caminho_arquivo = caminho_arquivo;
            this.ano = ano;
            this.processada = processada;
        }
    }
}