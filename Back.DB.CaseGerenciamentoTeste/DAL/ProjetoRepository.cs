using Back.DB.CaseGerenciamentoTeste.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Back.DB.CaseGerenciamentoTeste.DAL
{
    public class ProjetoRepository
    {
        
        public SqlCommand addProjeto(Projeto projeto)
        {
            SqlCommand cmd = new SqlCommand("Back_DB_CGT_Create_Projeto");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nome_proj", projeto.nome_proj);
            cmd.Parameters.AddWithValue("@objetivo_proj", projeto.objetivo_proj);
            cmd.Parameters.AddWithValue("@cod_status_proj", projeto.cod_status_proj);
            cmd.Parameters.Add("@cod_proj", SqlDbType.Int).Direction = ParameterDirection.Output;
            return cmd;
        }
        public SqlCommand updateProjeto(Projeto  projeto)
        {
            SqlCommand cmd = new SqlCommand("Back_DB_CGT_Update_Projeto");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nome_proj", projeto.nome_proj);
            cmd.Parameters.AddWithValue("@objetivo_proj", projeto.objetivo_proj);
            cmd.Parameters.AddWithValue("@cod_status_proj", projeto.cod_status_proj);
            cmd.Parameters.AddWithValue("@cod_proj", projeto.cod_proj);
            return cmd;
        }

        public SqlCommand selectListAllProjetos()
        {

            SqlCommand cmd = new SqlCommand("Back_DB_CGT_Select_ProjetoListAll");
            cmd.CommandType = CommandType.StoredProcedure;

            return cmd;
        }


        public SqlCommand selectProjetoForName(string nomeProj)
        {
            SqlCommand cmd = new SqlCommand("Back_DB_CGT_Select_ProjetoForName");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nome_usu", nomeProj);

            return cmd;
        }
        public SqlCommand selectProjetoAllData(int cod)
        {
            SqlCommand cmd = new SqlCommand("Back_DB_CGT_Select_ProjetoAll");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod_proj", cod);

            return cmd;
        }

    }
}