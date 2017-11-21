using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Back.DB.CaseGerenciamentoTeste.Models
{
    public class AuthTrocaSenha
    {
        public string user { get; set; }
        public string password { get; set; }
        public string newPassword { get; set; }
        public string ConfirmNewPassword { get; set; }
        public bool auth { get; set; }
        public bool novaSenhaCoincide { get; set; }
    }
}