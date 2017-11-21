using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Back.DB.CaseGerenciamentoTeste.Models;
using System.Data;

namespace Back.DB.CaseGerenciamentoTeste.DAL
{
    public class UserRepository
    {
        public SqlCommand auth (Auth auth)
        {
            SqlCommand cmd = new SqlCommand("exec Back_DB_CGT_Auth @login, @senha");
            cmd.Parameters.AddWithValue("@login", auth.user);
            cmd.Parameters.AddWithValue("@senha", auth.password);
            return cmd;
        }
        public SqlCommand addUser(User user)
        {
            SqlCommand cmd = new SqlCommand("Back_DB_CGT_Create_User");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@permissao_usu", user.permissao_usu);
            cmd.Parameters.AddWithValue("@nome_usu", user.nome_usu);
            cmd.Parameters.AddWithValue("@sobrenome_usu", user.sobrenome_usu);
            cmd.Parameters.AddWithValue("@email_usu", user.email_usu);
            cmd.Parameters.AddWithValue("@login_usu", user.login_usu);
            cmd.Parameters.AddWithValue("@senha_usu", user.senha_usu);
            cmd.Parameters.AddWithValue("@troca_senha", user.troca_senha);
            cmd.Parameters.Add("@codUser", SqlDbType.Int).Direction = ParameterDirection.Output;
            return cmd;  
        }
        public SqlCommand updateUser(User user)
        {
            SqlCommand cmd = new SqlCommand("Back_DB_CGT_Update_User");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@permissao_usu", user.permissao_usu);
            cmd.Parameters.AddWithValue("@nome_usu", user.nome_usu);
            cmd.Parameters.AddWithValue("@sobrenome_usu", user.sobrenome_usu);
            cmd.Parameters.AddWithValue("@email_usu", user.email_usu);
            cmd.Parameters.AddWithValue("@cod_usu", user.cod_usu);
            cmd.Parameters.AddWithValue("@senha_usu", user.senha_usu);
            cmd.Parameters.AddWithValue("@troca_senha", user.troca_senha);
            return cmd;
        }

        public SqlCommand TrocaSenha(AuthTrocaSenha authTrocaSenha)
        {

            SqlCommand cmd = new SqlCommand("Back_DB_CGT_ChangePassword");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@login", authTrocaSenha.user);
            cmd.Parameters.AddWithValue("@newSenha", authTrocaSenha.newPassword);
            cmd.Parameters.AddWithValue("@senha", authTrocaSenha.password);
            cmd.Parameters.Add("@auth", SqlDbType.Int).Direction = ParameterDirection.Output;

            return cmd;
        }

        public SqlCommand checkLogin (User user)
        {
            SqlCommand cmd = new SqlCommand("Back_DB_CGT_Select_ChekUserName");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@login_usu", user.login_usu);

            return cmd;
        }
        public SqlCommand selectUserForName(string userName)
        {
            SqlCommand cmd = new SqlCommand("Back_DB_CGT_Select_UserForName");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nome_usu", userName);

            return cmd;
        }
        public SqlCommand selectUserAllData(int cod)
        {
            SqlCommand cmd = new SqlCommand("Back_DB_CGT_Select_UserAll");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod_usu", cod);

            return cmd;
        }
        
    }
}