using Back.DB.CaseGerenciamentoTeste.DAL;
using Back.DB.CaseGerenciamentoTeste.DataBase;
using Back.DB.CaseGerenciamentoTeste.Models;
using System;
using System.Collections.Generic;

namespace Back.DB.CaseGerenciamentoTeste.Business
{
    public class ProjetoxSistemaBusiness
    {
        Connection conn = new Connection();
        public void CreateProjetoxSistema(ref ProjetoxSistema projetoxSistema)
        {

            try
            {
                UserRepository userRepository = new UserRepository();

                Dictionary<string, object> returnQuery = conn.execComand(new ProjetoxSistemaRepository().addProjetoxSistema(projetoxSistema));
                conn.commit();
                projetoxSistema.cod_projxsis = (int)returnQuery["@cod_projxsis"];

            }
            catch (Exception ex)
            {
                conn.rollBack();
                throw ex;
            }
        }
        public void DeleteProjetoxSistema(ref ProjetoxSistema projetoxSistema)
        {

            try
            {
                UserRepository userRepository = new UserRepository();

                Dictionary<string, object> returnQuery = conn.execComand(new ProjetoxSistemaRepository().deleteProjetoxSistema(projetoxSistema));
                conn.commit();


            }
            catch (Exception ex)
            {
                conn.rollBack();
                throw ex;
            }
        }

    }
}