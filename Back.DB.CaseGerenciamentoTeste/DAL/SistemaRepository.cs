using Back.DB.CaseGerenciamentoTeste.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Back.DB.CaseGerenciamentoTeste.DAL
{
    public class SistemaRepository
    {
        public SqlCommand addSistema(Sistema sistema)
        {
            SqlCommand cmd = new SqlCommand("Back_DB_CGT_Create_Sistema");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nome_sis", sistema.nome_sis);
            cmd.Parameters.AddWithValue("@sigla_sis", sistema.sigla_sis);
            cmd.Parameters.AddWithValue("@cod_status_sis", sistema.cod_status_sis);
            cmd.Parameters.Add("@cod_sis", SqlDbType.Int).Direction = ParameterDirection.Output;
            return cmd;
        }
        public SqlCommand updateSistema(Sistema sistema)
        {
            SqlCommand cmd = new SqlCommand("Back_DB_CGT_Update_Sistema");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nome_sis", sistema.nome_sis);
            cmd.Parameters.AddWithValue("@sigla_sis", sistema.sigla_sis);
            cmd.Parameters.AddWithValue("@cod_status_sis", sistema.cod_status_sis); ;
            cmd.Parameters.AddWithValue("@cod_sis", sistema.cod_sis);

            return cmd;
        }
        public SqlCommand selectSistemaForName(string sistemaName)
        {
            SqlCommand cmd = new SqlCommand("Back_DB_CGT_Select_SistemaForName");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nome_sis", sistemaName);

            return cmd;
        }
        public SqlCommand selectSistemaForSigla(string sigla)
        {
            SqlCommand cmd = new SqlCommand("Back_DB_CGT_Select_SistemaForSigla");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sigla_sis", sigla);

            return cmd;
        }

        public SqlCommand selectSistemaAllData(int cod)
        {
            SqlCommand cmd = new SqlCommand("Back_DB_CGT_Select_SistemaAll");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod_sis", cod);

            return cmd;
        }
    }
}