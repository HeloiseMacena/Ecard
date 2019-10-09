using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecard.Modelo
{
    public class Solicitacao_instituicao
    {
        public int id;
        public DateTime data;
        public int status;
        /* Valores de "status"
         0: solicitação em andamento
         1: solicitação indeferida
         2: solicitação aceita
         */
        public string descricao_erro;

        public Solicitacao_instituicao()
        {
            id = 0;
            status = 0;
        }
    }
}