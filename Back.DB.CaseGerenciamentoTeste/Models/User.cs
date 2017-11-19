using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Back.DB.CaseGerenciamentoTeste.Models
{
    public class User
    {
        public int cod { get; set; }
        public string nomeUsu { get; set; }
        public string sobrenomeUsu { get; set; }
        public string email { get; set; }
        public string loginUsu { get; set; }
        public string senhaUsu { get; set; }
        public int permissaoUsu { get; set; }
        public bool trocaSenha { get; set; }
    }
}