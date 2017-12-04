using System.Data;
using System.Data.SqlClient;

namespace Back.DB.CaseGerenciamentoTeste.DAL
{
    public class StatusTypeRepository
    {
        public SqlCommand selectListAllStatusType()
        {

            SqlCommand cmd = new SqlCommand("Back_DB_CGT_Select_StatusTypeListAll");
            cmd.CommandType = CommandType.StoredProcedure;

            return cmd;
        }
        public SqlCommand selectListAllStatusTypeForCod(int codStatus)
        {

            SqlCommand cmd = new SqlCommand("Back_DB_CGT_Select_StatusTypeForCod");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod_status",codStatus);

            return cmd;
        }
    }
}