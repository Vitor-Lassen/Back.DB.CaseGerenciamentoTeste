using Back.DB.CaseGerenciamentoTeste.DAL;
using Back.DB.CaseGerenciamentoTeste.DataBase;
using Back.DB.CaseGerenciamentoTeste.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Back.DB.CaseGerenciamentoTeste.Business
{
    public class UserBusiness
    {
        Connection conn = new Connection();
        public void CreateUser (ref User user)
        {

            try
            {
                UserRepository userRepository = new UserRepository();
                user.loginUsu = (user.nomeUsu.Substring(0, 3) + "." + user.sobrenomeUsu.Split(' ').Last()).ToLower();
                int count = 1;
                while ((int)(conn.execQuery(userRepository.checkLogin(user)).Tables[0].Rows[0].ItemArray[0]) > 0)
                {
                    user.loginUsu = (user.nomeUsu.Substring(0, 3) + "." + user.sobrenomeUsu.Split(' ').Last() + count.ToString()).ToLower();
                    count++;
                }
                

                Dictionary<string, object> returnQuery = conn.execComand(new UserRepository().addUser(user));
                conn.commit();
                user.cod = (int)returnQuery["@codUser"];
                    
            }
            catch (Exception ex)
            {
                conn.rollBack();
                throw ex;
            }
        }
    }
}