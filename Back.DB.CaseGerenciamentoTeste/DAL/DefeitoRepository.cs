using Back.DB.CaseGerenciamentoTeste.Models;
using System.Data;
using System.Data.SqlClient;

namespace Back.DB.CaseGerenciamentoTeste.DAL
{
    public class DefeitoRepository
    {

        public SqlCommand addDefeito(Defeito defeito)
        {
            SqlCommand cmd = new SqlCommand("Back_DB_CGT_Create_Defeito");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@assunto_def", defeito.assunto_def);
            cmd.Parameters.AddWithValue("@descri_def", defeito.descri_def);
            cmd.Parameters.AddWithValue("@titulo_def", defeito.titulo_def);
            cmd.Parameters.AddWithValue("@gravidade_def", defeito.gravidade_def);
            cmd.Parameters.AddWithValue("@cod_status_def", defeito.cod_status_def);
            
            cmd.Parameters.Add("@cod_def", SqlDbType.Int).Direction = ParameterDirection.Output;
            return cmd;
        }
        public SqlCommand updateDefeito(Defeito defeito)
        {
            SqlCommand cmd = new SqlCommand("Back_DB_CGT_Update_Defeito");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@assunto_def", defeito.assunto_def);
            cmd.Parameters.AddWithValue("@descri_def", defeito.descri_def);
            cmd.Parameters.AddWithValue("@titulo_def", defeito.titulo_def);
            cmd.Parameters.AddWithValue("@gravidade_def", defeito.gravidade_def);
            cmd.Parameters.AddWithValue("@cod_status_def", defeito.cod_status_def);
            cmd.Parameters.AddWithValue("@cod_def", defeito.cod_def);
            return cmd;
        }

    
        public SqlCommand selectDefeitoAllData(int cod)
        {
            SqlCommand cmd = new SqlCommand("Back_DB_CGT_Select_DefeitoAll");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod_proj", cod);

            return cmd;
        }

        public SqlCommand selectDefeitoAllDataForCodCen(int cod)
        {
            SqlCommand cmd = new SqlCommand("Back_DB_CGT_Select_DefeitoAllForCodCen");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod_cen", cod);

            return cmd;
        }

    }
}