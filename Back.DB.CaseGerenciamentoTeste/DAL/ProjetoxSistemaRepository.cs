using Back.DB.CaseGerenciamentoTeste.Models;
using System.Data;
using System.Data.SqlClient;

namespace Back.DB.CaseGerenciamentoTeste.DAL
{
    public class ProjetoxSistemaRepository
    {
        
        public SqlCommand addProjetoxSistema(ProjetoxSistema ProjetoxSistema)
        {
            SqlCommand cmd = new SqlCommand("Back_DB_CGT_Create_ProjetoXSistema");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod_proj_projxsis", ProjetoxSistema.cod_proj_projxsis);
            cmd.Parameters.AddWithValue("@cod_sis_projxsis", ProjetoxSistema.cod_sis_projxsis);
            cmd.Parameters.Add("@cod_projxsis", SqlDbType.Int).Direction = ParameterDirection.Output;
            return cmd;
        }
        public SqlCommand deleteProjetoxSistema(ProjetoxSistema ProjetoxSistema)
        {
            SqlCommand cmd = new SqlCommand("Back_DB_CGT_Delete_ProjetoXSistema");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod_projxsis", ProjetoxSistema.cod_projxsis);
            return cmd;
        }
    }
}