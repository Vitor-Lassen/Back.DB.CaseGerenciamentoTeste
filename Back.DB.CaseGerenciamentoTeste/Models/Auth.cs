using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Back.DB.CaseGerenciamentoTeste.Models
{
    public class Auth
    {
        public string user { get; set; }
        public string password { get; set; }
        public bool auth { get; set; }
        public int permissaoUser { get;  set; }
        public bool trocasenha { get; set; }
        public string nomeUsu { get; set; }
        public string sobrenome { get; set; }
    }
}