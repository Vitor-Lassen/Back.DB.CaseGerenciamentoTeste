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
                user.login_usu = (user.nome_usu.Substring(0, 3) + "." + user.sobrenome_usu.Split(' ').Last()).ToLower();
                int count = 1;
                while ((int)(conn.execQuery(userRepository.checkLogin(user)).Tables[0].Rows[0].ItemArray[0]) > 0)
                {
                    user.login_usu = (user.nome_usu.Substring(0, 3) + "." + user.sobrenome_usu.Split(' ').Last() + count.ToString()).ToLower();
                    count++;
                }
                
                Dictionary<string, object> returnQuery = conn.execComand(new UserRepository().addUser(user));
                conn.commit();
                user.cod_usu = (int)returnQuery["@codUser"];
                    
            }
            catch (Exception ex)
            {
                conn.rollBack();
                throw ex;
            }
        }

        public void UpdateUser(ref User user)
        {

            try
            {
                UserRepository userRepository = new UserRepository();

                Dictionary<string, object> returnQuery = conn.execComand(new UserRepository().updateUser(user));
                conn.commit();


            }
            catch (Exception ex)
            {
                conn.rollBack();
                throw ex;
            }
        }
        public string ConsUserForName(string name)
        {
            try
            {
                return (conn.execQueryJson(new UserRepository().selectUserForName(name)));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string ConsUserAllData(int cod)
        {
            try
            {
                return (conn.execQueryJson(new UserRepository().selectUserAllData(cod)));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}