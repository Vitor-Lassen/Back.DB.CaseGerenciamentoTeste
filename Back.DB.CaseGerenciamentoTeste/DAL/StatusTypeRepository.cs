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
    }
}