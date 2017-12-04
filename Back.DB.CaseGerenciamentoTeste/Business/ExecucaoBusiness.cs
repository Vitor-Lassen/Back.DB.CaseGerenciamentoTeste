using Back.DB.CaseGerenciamentoTeste.DAL;
using Back.DB.CaseGerenciamentoTeste.DataBase;
using Back.DB.CaseGerenciamentoTeste.Models;
using System;
using System.Collections.Generic;

namespace Back.DB.CaseGerenciamentoTeste.Business
{
    public class ExecucaoBusiness
    {
        Connection conn = new Connection();
        public void CreateExecucao(ref Execucao execucao)
        {

            try
            {

                Dictionary<string, object> returnQuery = conn.execComand(new ExecucaoRepository().addExecucao(execucao));
                conn.commit();
                execucao.cod_exec = (int)returnQuery["@cod_exec"];

            }
            catch (Exception ex)
            {
                conn.rollBack();
                throw ex;
            }
        }

        public void UpdateExecucao(ref Execucao execucao)
        {

            try
            {
                Dictionary<string, object> returnQuery = conn.execComand(new ExecucaoRepository().updateExecucao(execucao));
                conn.commit();

            }
            catch (Exception ex)
            {
                conn.rollBack();
                throw ex;
            }
        }
 
        public string ConsExecucaoAllData(int cod)
        {
            try
            {
                return (conn.execQueryJson(new ExecucaoRepository().selectExecucaoAllData(cod)));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }  
    }
}