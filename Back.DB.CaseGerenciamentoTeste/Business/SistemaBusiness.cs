using Back.DB.CaseGerenciamentoTeste.DAL;
using Back.DB.CaseGerenciamentoTeste.DataBase;
using Back.DB.CaseGerenciamentoTeste.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Back.DB.CaseGerenciamentoTeste.Business
{
    public class SistemaBusiness
    {
        Connection conn = new Connection();
        public void CreateSistema(ref Sistema sistema)
        {

            try
            {
                UserRepository userRepository = new UserRepository();

                Dictionary<string, object> returnQuery = conn.execComand(new SistemaRepository().addSistema(sistema));
                conn.commit();
                sistema.cod_sis = (int)returnQuery["@cod_sis"];

            }
            catch (Exception ex)
            {
                conn.rollBack();
                throw ex;
            }
        }

        public void UpdateSistema(ref Sistema sistema)
        {
            try
            {
                Dictionary<string, object> returnQuery = conn.execComand(new SistemaRepository().updateSistema(sistema));
                conn.commit();
            }
            catch (Exception ex)
            {
                conn.rollBack();
                throw ex;
            }
        }

        public string ConsSistemaForName(string sigla)
        {
            try
            {
                return (conn.execQueryJson(new SistemaRepository().selectSistemaForName(sigla)));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string ConsSistemaForSigla(string sigla)
        {
            try
            {
                return (conn.execQueryJson(new SistemaRepository().selectSistemaForSigla(sigla)));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string ConsSistemaAllData(int cod)
        {
            try
            {
                return (conn.execQueryJson(new SistemaRepository().selectSistemaAllData(cod)));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string ConsListAllSistemas()
        {
            try
            {
                return conn.execQueryJson(new SistemaRepository().selectListAllSistemas());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}