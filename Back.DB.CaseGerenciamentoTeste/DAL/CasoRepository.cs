using Back.DB.CaseGerenciamentoTeste.Models;
using System.Data;
using System.Data.SqlClient;

namespace Back.DB.CaseGerenciamentoTeste.DAL
{
    public class CasoRepository
    {

        public SqlCommand addCaso(Caso caso)
        {
            SqlCommand cmd = new SqlCommand("Back_DB_CGT_Create_Caso");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nome_caso", caso.nome_caso);
            cmd.Parameters.AddWithValue("@precond_caso", caso.precond_caso);
            cmd.Parameters.AddWithValue("@massadados_caso", caso.massadados_caso);
            cmd.Parameters.AddWithValue("@resultadoesp_caso", caso.resultadoesp_caso);
            cmd.Parameters.AddWithValue("@resultadoobt_caso", caso.resultadoobt_caso);
            cmd.Parameters.AddWithValue("@cod_cen_caso", caso.cod_cen_caso);
            cmd.Parameters.AddWithValue("@cod_def_caso", caso.cod_def_caso);
            cmd.Parameters.AddWithValue("@cod_status_caso", caso.cod_status_caso);
            cmd.Parameters.AddWithValue("@cod_usu_caso", caso.cod_usu_caso);
            cmd.Parameters.AddWithValue("@motivo_bloq", caso.motivo_bloq);
            
            cmd.Parameters.Add("@cod_caso", SqlDbType.Int).Direction = ParameterDirection.Output;
            return cmd;
        }
        public SqlCommand updateCaso(Caso caso)
        {
            SqlCommand cmd = new SqlCommand("Back_DB_CGT_Update_Caso");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nome_caso", caso.nome_caso);
            cmd.Parameters.AddWithValue("@precond_caso", caso.precond_caso);
            cmd.Parameters.AddWithValue("@massadados_caso", caso.massadados_caso);
            cmd.Parameters.AddWithValue("@resultadoesp_caso", caso.resultadoesp_caso);
            cmd.Parameters.AddWithValue("@resultadoobt_caso", caso.resultadoobt_caso);
            cmd.Parameters.AddWithValue("@cod_cen_caso", caso.cod_cen_caso);
            cmd.Parameters.AddWithValue("@cod_def_caso", caso.cod_def_caso);
            cmd.Parameters.AddWithValue("@cod_status_caso", caso.cod_status_caso);
            cmd.Parameters.AddWithValue("@cod_usu_caso", caso.cod_usu_caso);
            cmd.Parameters.AddWithValue("@motivo_bloq", caso.motivo_bloq);
            cmd.Parameters.AddWithValue("@cod_caso", caso.cod_caso);

            return cmd;
        }



        public SqlCommand selectCasoForName(string nomeCaso)
        {
            SqlCommand cmd = new SqlCommand("Back_DB_CGT_Select_CasoForName");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nome_caso", nomeCaso);

            return cmd;
        }
        public SqlCommand selectCasoForCenario(int codCen)
        {
            SqlCommand cmd = new SqlCommand("Back_DB_CGT_Select_CasoForName");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod_cen", codCen);

            return cmd;
        }
        public SqlCommand selectCasoAllData(int cod)
        {
            SqlCommand cmd = new SqlCommand("Back_DB_CGT_Select_CasoAll");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod_caso", cod);

            return cmd;
        }

    }
}