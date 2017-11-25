using Back.DB.CaseGerenciamentoTeste.Business;
using Back.DB.CaseGerenciamentoTeste.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Back.DB.CaseGerenciamentoTeste.Controllers
{
    public class SistemaController : ApiController
    {

        [HttpPost]
        [Route("api/sistema/create")]
        public HttpResponseMessage CreateSistema(Sistema sistema)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                new SistemaBusiness().CreateSistema(ref sistema);

                response.StatusCode = HttpStatusCode.OK;
                response.Content = new StringContent(JsonConvert.SerializeObject(sistema));
            }
            catch (Exception ex)
            {
                response.StatusCode = HttpStatusCode.InternalServerError;
                response.Content = new StringContent(ex.Message.ToString());
            }
            return response;
        }

        [HttpPost]
        [Route("api/sistema/update")]
        public HttpResponseMessage UpdateSistema(Sistema sistema)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                new SistemaBusiness().UpdateSistema(ref sistema);

                response.StatusCode = HttpStatusCode.OK;
                response.Content = new StringContent(JsonConvert.SerializeObject(sistema));
            }
            catch (Exception ex)
            {
                response.StatusCode = HttpStatusCode.InternalServerError;
                response.Content = new StringContent(ex.Message.ToString());
            }
            return response;
        }

        [HttpGet]
        [Route("api/sistema/select/forname/{name}")]
        public HttpResponseMessage selectSistemaForName(string name)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                string returnQuery = new SistemaBusiness().ConsSistemaForName(name);

                response.StatusCode = HttpStatusCode.OK;
                response.Content = new StringContent(returnQuery);
            }
            catch (Exception ex)
            {
                response.StatusCode = HttpStatusCode.InternalServerError;
                response.Content = new StringContent(ex.Message.ToString());
            }
            return response;
        }

        [HttpGet]
        [Route("api/sistema/select/forsigla/{sigla}")]
        public HttpResponseMessage selectSistemaForSigla(string sigla)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                string returnQuery = new SistemaBusiness().ConsSistemaForSigla(sigla);

                response.StatusCode = HttpStatusCode.OK;
                response.Content = new StringContent(returnQuery);
            }
            catch (Exception ex)
            {
                response.StatusCode = HttpStatusCode.InternalServerError;
                response.Content = new StringContent(ex.Message.ToString());
            }
            return response;
        }
        [HttpGet]
        [Route("api/sistema/select/all/{cod}")]
        public HttpResponseMessage selectSistemaAllData(int cod)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                string returnQuery = new SistemaBusiness().ConsSistemaAllData(cod);

                response.StatusCode = HttpStatusCode.OK;
                response.Content = new StringContent(returnQuery.Replace('[', ' ').Replace(']', ' '));
            }
            catch (Exception ex)
            {
                response.StatusCode = HttpStatusCode.InternalServerError;
                response.Content = new StringContent(ex.Message.ToString());
            }
            return response;
        }
        [HttpGet]
        [Route("api/sistema/select/listall/")]
        public HttpResponseMessage selectProjetoListAll()
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                string returnQuery = new SistemaBusiness().ConsListAllSistemas();

                response.StatusCode = HttpStatusCode.OK;
                response.Content = new StringContent(returnQuery);
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
