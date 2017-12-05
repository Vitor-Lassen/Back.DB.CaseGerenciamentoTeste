using Back.DB.CaseGerenciamentoTeste.Business;
using Back.DB.CaseGerenciamentoTeste.Models;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Back.DB.CaseGerenciamentoTeste.Controllers
{
    public class CasoController : ApiController
    {
        [HttpPost]

        [Route("api/caso/create")]
        public HttpResponseMessage CreateCaso(Caso caso)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                new CasoBusiness().CreateCaso(ref caso);

                response.StatusCode = HttpStatusCode.OK;
                response.Content = new StringContent(JsonConvert.SerializeObject(caso));
            }
            catch (Exception ex)
            {
                response.StatusCode = HttpStatusCode.InternalServerError;
                response.Content = new StringContent(ex.Message.ToString());
            }
            return response;
        }
        [HttpPost]

        [Route("api/caso/update")]
        public HttpResponseMessage UpdateCaso(Caso caso)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                new CasoBusiness().UpdateCaso(ref caso);

                response.StatusCode = HttpStatusCode.OK;
                response.Content = new StringContent(JsonConvert.SerializeObject(caso));
            }
            catch (Exception ex)
            {
                response.StatusCode = HttpStatusCode.InternalServerError;
                response.Content = new StringContent(ex.Message.ToString());
            }
            return response;
        }

        [HttpGet]
        [Route("api/caso/select/forname/{casoName}")]
        public HttpResponseMessage selectCasoForName(string casoName)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                string returnQuery = new CasoBusiness().ConsCasoForName(casoName);

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
        [Route("api/caso/select/forcenario/{codCenario}")]
        public HttpResponseMessage selectCasoForCenario(int codCenario)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                string returnQuery = new CasoBusiness().ConsCasoForCenario(codCenario);

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
        [Route("api/caso/select/all/{cod}")]
        public HttpResponseMessage selectCasoAllData(int cod)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                string returnQuery = new CasoBusiness().ConsCasoAllData(cod);

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
    }
}
