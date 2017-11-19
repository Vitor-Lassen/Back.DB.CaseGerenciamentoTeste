using Back.DB.CaseGerenciamentoTeste.DAL;
using Back.DB.CaseGerenciamentoTeste.DataBase;
using Back.DB.CaseGerenciamentoTeste.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Back.DB.CaseGerenciamentoTeste.Business
{
    public class AuthBusiness
    {
        public void Auth( ref Auth auth)
        {
            try
            {
                Connection conn = new Connection();
                DataSet ds = conn.execQuery(new UserRepository().auth(auth));
                if (ds.Tables[0].Rows.Count > 0)
                {
                    auth.auth = true;
                    auth.permissaoUser = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0]);
                    auth.trocasenha = Convert.ToBoolean(ds.Tables[0].Rows[0].ItemArray[1]);
                    auth.nomeUsu = ds.Tables[0].Rows[0].ItemArray[2].ToString();
                    auth.sobrenome = ds.Tables[0].Rows[0].ItemArray[3].ToString();
                }
                else
                {
                    auth.auth = false;
                }
            }
            catch(Exception ex)
            {
                throw ex;                
            }
        }
    }
}