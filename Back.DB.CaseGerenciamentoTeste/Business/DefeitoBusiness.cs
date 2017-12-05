using Back.DB.CaseGerenciamentoTeste.DAL;
using Back.DB.CaseGerenciamentoTeste.DataBase;
using Back.DB.CaseGerenciamentoTeste.Models;
using System;
using System.Collections.Generic;

namespace Back.DB.CaseGerenciamentoTeste.Business
{
    public class DefeitoBusiness
    {
        Connection conn = new Connection();
        public void CreateDefeito(ref Defeito defeito)
        {

            try
            {

                Dictionary<string, object> returnQuery = conn.execComand(new DefeitoRepository().addDefeito(defeito));
                conn.commit();
                defeito.cod_def = (int)returnQuery["@cod_def"];

            }
            catch (Exception ex)
            {
                conn.rollBack();
                throw ex;
            }
        }

        public void UpdateDefeito(ref Defeito defeito)
        {

            try
            {
                Dictionary<string, object> returnQuery = conn.execComand(new DefeitoRepository().updateDefeito(defeito));
                conn.commit();

            }
            catch (Exception ex)
            {
                conn.rollBack();
                throw ex;
            }
        }
     
        public string ConsDefeitoAllData(int cod)
        {
            try
            {
                return (conn.execQueryJson(new DefeitoRepository().selectDefeitoAllData(cod)));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string ConsDefeitoAllDataForCodCen(int cod)
        {
            try
            {
                return (conn.execQueryJson(new DefeitoRepository().selectDefeitoAllDataForCodCen(cod)));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}