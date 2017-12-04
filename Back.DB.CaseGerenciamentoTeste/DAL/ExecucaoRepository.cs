using Back.DB.CaseGerenciamentoTeste.Models;
using System.Data;
using System.Data.SqlClient;

namespace Back.DB.CaseGerenciamentoTeste.DAL
{
    public class ExecucaoRepository
    {

        public SqlCommand addExecucao(Execucao execucao)
        {
            SqlCommand cmd = new SqlCommand("Back_DB_CGT_Create_Execucao");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod_usu_exec", execucao.cod_usu_exec);
            cmd.Parameters.AddWithValue("@cod_caso_exec", execucao.cod_caso_exec);
            cmd.Parameters.AddWithValue("@cod_status_exec", execucao.cod_status_exec);
            cmd.Parameters.AddWithValue("@observacao_exec", execucao.observacao_exec);
            cmd.Parameters.Add("@cod_exec", SqlDbType.Int).Direction = ParameterDirection.Output;
            return cmd;
        }
        public SqlCommand updateExecucao(Execucao execucao)
        {
            SqlCommand cmd = new SqlCommand("Back_DB_CGT_Update_Execucao");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod_usu_exec", execucao.cod_usu_exec);
            cmd.Parameters.AddWithValue("@cod_caso_exec", execucao.cod_caso_exec);
            cmd.Parameters.AddWithValue("@cod_status_exec", execucao.cod_status_exec);
            cmd.Parameters.AddWithValue("@observacao_exec", execucao.observacao_exec);
            cmd.Parameters.AddWithValue("@cod_exec", execucao.cod_exec);
            return cmd;
        }

        public SqlCommand selectExecucaoAllData(int cod)
        {
            SqlCommand cmd = new SqlCommand("Back_DB_CGT_Select_ExecucaoAll");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod_exec", cod);

            return cmd;
        }

    }
}