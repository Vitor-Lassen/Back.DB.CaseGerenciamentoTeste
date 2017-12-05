using Back.DB.CaseGerenciamentoTeste.DAL;
using Back.DB.CaseGerenciamentoTeste.DataBase;
using Back.DB.CaseGerenciamentoTeste.Models;
using System;
using System.Collections.Generic;

namespace Back.DB.CaseGerenciamentoTeste.Business
{
    public class CasoBusiness
    {
        Connection conn = new Connection();
        public void CreateCaso(ref Caso caso)
        {

            try
            {

                Dictionary<string, object> returnQuery = conn.execComand(new CasoRepository().addCaso(caso));
                conn.commit();
                caso.cod_caso = (int)returnQuery["@cod_caso"];

            }
            catch (Exception ex)
            {
                conn.rollBack();
                throw ex;
            }
        }

        public void UpdateCaso(ref Caso caso)
        {

            try
            {
                Dictionary<string, object> returnQuery = conn.execComand(new CasoRepository().updateCaso(caso));
                conn.commit();

            }
            catch (Exception ex)
            {
                conn.rollBack();
                throw ex;
            }
        }
        public string ConsCasoForName(string name)
        {
            try
            {
                return (conn.execQueryJson(new CasoRepository().selectCasoForName(name)));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string ConsCasoForCenario(int codCen)
        {
            try
            {
                return (conn.execQueryJson(new CasoRepository().selectCasoForCenario(codCen)));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string ConsCasoAllData(int cod)
        {
            try
            {
                return (conn.execQueryJson(new CasoRepository().selectCasoAllData(cod)));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}