using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Back.DB.CaseGerenciamentoTeste.Models
{
    public class User
    {
        public int cod_usu { get; set; }
        public string nome_usu { get; set; }
        public string sobrenome_usu { get; set; }
        public string email_usu { get; set; }
        public string login_usu { get; set; }
        public string senha_usu { get; set; }
        public int permissao_usu { get; set; }
        public bool troca_senha { get; set; }
    }
}