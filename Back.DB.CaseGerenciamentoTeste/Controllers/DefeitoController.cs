using Back.DB.CaseGerenciamentoTeste.Business;
using Back.DB.CaseGerenciamentoTeste.Models;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Back.DB.CaseGerenciamentoTeste.Controllers
{
    public class DefeitoController : ApiController
    {
        [HttpPost]

        [Route("api/defeito/create")]
        public HttpResponseMessage CreateDefeito(Defeito defeito)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                new DefeitoBusiness().CreateDefeito(ref defeito);

                response.StatusCode = HttpStatusCode.OK;
                response.Content = new StringContent(JsonConvert.SerializeObject(defeito));
            }
            catch (Exception ex)
            {
                response.StatusCode = HttpStatusCode.InternalServerError;
                response.Content = new StringContent(ex.Message.ToString());
            }
            return response;
        }
        [HttpPost]

        [Route("api/defeito/update")]
        public HttpResponseMessage UpdateDefeito(Defeito defeito)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                new DefeitoBusiness().UpdateDefeito(ref defeito);

                response.StatusCode = HttpStatusCode.OK;
                response.Content = new StringContent(JsonConvert.SerializeObject(defeito));
            }
            catch (Exception ex)
            {
                response.StatusCode = HttpStatusCode.InternalServerError;
                response.Content = new StringContent(ex.Message.ToString());
            }
            return response;
        }

      
        [HttpGet]
        [Route("api/defeito/select/all/{cod}")]
        public HttpResponseMessage selectDefeitoAllData(int cod)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                string returnQuery = new DefeitoBusiness().ConsDefeitoAllData(cod);

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
        [Route("api/defeito/select/allForCodCenario/{cod}")]
        public HttpResponseMessage selectDefeitoAllDataForCodCenario(int cod)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                string returnQuery = new DefeitoBusiness().ConsDefeitoAllDataForCodCen(cod);

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
