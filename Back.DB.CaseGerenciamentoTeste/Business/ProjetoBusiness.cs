using Back.DB.CaseGerenciamentoTeste.DAL;
using Back.DB.CaseGerenciamentoTeste.DataBase;
using Back.DB.CaseGerenciamentoTeste.Models;
using System;
using System.Collections.Generic;

namespace Back.DB.CaseGerenciamentoTeste.Business
{
    public class ProjetoBusiness
    {
        Connection conn = new Connection();
        public void CreateProjeto(ref Projeto projeto)
        {

            try
            {
               
                Dictionary<string, object> returnQuery = conn.execComand(new ProjetoRepository().addProjeto(projeto));
                conn.commit();
                projeto.cod_proj = (int)returnQuery["@cod_proj"];

            }
            catch (Exception ex)
            {
                conn.rollBack();
                throw ex;
            }
        }

        public void UpdateProjeto(ref Projeto projeto)
        {

            try
            {
                Dictionary<string, object> returnQuery = conn.execComand(new ProjetoRepository().updateProjeto(projeto));
                conn.commit();

            }
            catch (Exception ex)
            {
                conn.rollBack();
                throw ex;
            }
        }
        public string ConsProjetoForName(string name)
        {
            try
            {
                return (conn.execQueryJson(new ProjetoRepository().selectProjetoForName(name)));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string ConsProjetoAllData(int cod)
        {
            try
            {
                return (conn.execQueryJson(new ProjetoRepository().selectProjetoAllData(cod)));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string ConsListAllProjetos()
        {
            try
            {
                return conn.execQueryJson(new ProjetoRepository().selectListAllProjetos());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}