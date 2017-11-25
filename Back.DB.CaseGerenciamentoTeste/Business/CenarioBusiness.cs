using Back.DB.CaseGerenciamentoTeste.DAL;
using Back.DB.CaseGerenciamentoTeste.DataBase;
using Back.DB.CaseGerenciamentoTeste.Models;
using System;
using System.Collections.Generic;

namespace Back.DB.CaseGerenciamentoTeste.Business
{
    public class CenarioBusiness
    {
        Connection conn = new Connection();
        public void CreateCenario(ref Cenario cenario)
        {

            try
            {
                UserRepository userRepository = new UserRepository();

                Dictionary<string, object> returnQuery = conn.execComand(new CenarioRepository().addCenario(cenario));
                conn.commit();
                cenario.cod_cen = (int)returnQuery["@cod_cen"];

            }
            catch (Exception ex)
            {
                conn.rollBack();
                throw ex;
            }
        }

        public void UpdateCenario(ref Cenario cenario)
        {
            try
            {
                Dictionary<string, object> returnQuery = conn.execComand(new CenarioRepository().updateCenario(cenario));
                conn.commit();
            }
            catch (Exception ex)
            {
                conn.rollBack();
                throw ex;
            }
        }

        public string ConsCenarioForName(string name,int codProj)
        {
            try
            {
                return (conn.execQueryJson(new CenarioRepository().selectCenarioForName(name,codProj)));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string ConsCenarioAllData(int cod)
        {
            try
            {
                return (conn.execQueryJson(new CenarioRepository().selectCenarioAllData(cod)));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
  
    }
}