using Back.DB.CaseGerenciamentoTeste.Business;
using Back.DB.CaseGerenciamentoTeste.Models;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Back.DB.CaseGerenciamentoTeste.Controllers
{
    public class ProjetoxSistemaController : ApiController
    {
        [HttpPost]
        [Route("api/projetoxsistema/create")]
        public HttpResponseMessage CreateProjetoxSistema(ProjetoxSistema projetoxSistema)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                new ProjetoxSistemaBusiness().CreateProjetoxSistema(ref projetoxSistema);

                response.StatusCode = HttpStatusCode.OK;
                response.Content = new StringContent(JsonConvert.SerializeObject(projetoxSistema));
            }
            catch (Exception ex)
            {
                response.StatusCode = HttpStatusCode.InternalServerError;
                response.Content = new StringContent(ex.Message.ToString());
            }
            return response;
        }

        [HttpPost]
        [Route("api/projetoxsistema/delete")]
        public HttpResponseMessage DeleteProjetoxSistema(ProjetoxSistema projetoxSistema)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                new ProjetoxSistemaBusiness().DeleteProjetoxSistema(ref projetoxSistema);

                response.StatusCode = HttpStatusCode.OK;
                response.Content = new StringContent("sucesso");
            }
            catch (Exception ex)
            {
                response.StatusCode = HttpStatusCode.InternalServerError;
                response.Content = new StringContent(ex.Message.ToString());
            }
            return response;
        }
    }

}
