using Back.DB.CaseGerenciamentoTeste.DAL;
using Back.DB.CaseGerenciamentoTeste.DataBase;
using System;

namespace Back.DB.CaseGerenciamentoTeste.Business
{
    public class StatusTypeBusiness
    {
        Connection conn = new Connection();
        public string ConsListAllStatusType()
        {
            try
            {
                return conn.execQueryJson(new StatusTypeRepository().selectListAllStatusType());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string ConsListAllStatusTypeForCod(int codStatus)
        {
            try
            {
                return conn.execQueryJson(new StatusTypeRepository().selectListAllStatusTypeForCod(codStatus));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}