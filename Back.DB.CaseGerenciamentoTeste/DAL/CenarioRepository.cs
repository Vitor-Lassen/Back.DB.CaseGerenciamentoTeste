using Back.DB.CaseGerenciamentoTeste.Models;
using System.Data;
using System.Data.SqlClient;

namespace Back.DB.CaseGerenciamentoTeste.DAL
{
    public class CenarioRepository
    {
        public SqlCommand addCenario(Cenario cenario)
        {
            SqlCommand cmd = new SqlCommand("Back_DB_CGT_Create_Cenario");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod_proj_cen", cenario.cod_proj_cen);
            cmd.Parameters.AddWithValue("@nome_cen", cenario.nome_cen);
            cmd.Parameters.AddWithValue("@descri_cen", cenario.descri_cen);
            cmd.Parameters.AddWithValue("@cod_status_cen", cenario.cod_status_cen);
            cmd.Parameters.Add("@cod_cen", SqlDbType.Int).Direction = ParameterDirection.Output;
            return cmd;
        }
        public SqlCommand updateCenario(Cenario cenario)
        {
            SqlCommand cmd = new SqlCommand("Back_DB_CGT_Update_Cenario");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod_proj_cen", cenario.cod_proj_cen);
            cmd.Parameters.AddWithValue("@nome_cen", cenario.nome_cen);
            cmd.Parameters.AddWithValue("@descri_cen", cenario.descri_cen);
            cmd.Parameters.AddWithValue("@cod_status_cen", cenario.cod_status_cen);
            cmd.Parameters.AddWithValue("@cod_cen", cenario.cod_cen);


            return cmd;
        }
        public SqlCommand selectCenarioForName(string cenarioName, int codProj)
        {
            SqlCommand cmd = new SqlCommand("Back_DB_CGT_Select_CenarioForName");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nome_cen", cenarioName);
            cmd.Parameters.AddWithValue("@cod_proj_cen", codProj);

            return cmd;
        }


        public SqlCommand selectCenarioAllData(int cod)
        {

            SqlCommand cmd = new SqlCommand("Back_DB_CGT_Select_CenarioAll");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod_cen",cod);
            return cmd;
        }
    }
}