using Back.DB.CaseGerenciamentoTeste.Business;
using Back.DB.CaseGerenciamentoTeste.Models;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Back.DB.CaseGerenciamentoTeste.Controllers
{
    public class CenarioController : ApiController
    {

        [HttpPost]
        [Route("api/cenario/create")]
        public HttpResponseMessage CreateCenario(Cenario cenario)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                new CenarioBusiness().CreateCenario(ref cenario);

                response.StatusCode = HttpStatusCode.OK;
                response.Content = new StringContent(JsonConvert.SerializeObject(cenario));
            }
            catch (Exception ex)
            {
                response.StatusCode = HttpStatusCode.InternalServerError;
                response.Content = new StringContent(ex.Message.ToString());
            }
            return response;
        }

        [HttpPost]
        [Route("api/cenario/update")]
        public HttpResponseMessage UpdateCenario(Cenario cenario)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                new CenarioBusiness().UpdateCenario(ref cenario);

                response.StatusCode = HttpStatusCode.OK;
                response.Content = new StringContent(JsonConvert.SerializeObject(cenario));
            }
            catch (Exception ex)
            {
                response.StatusCode = HttpStatusCode.InternalServerError;
                response.Content = new StringContent(ex.Message.ToString());
            }
            return response;
        }

        [HttpGet]
        [Route("api/cenario/select/forname/{name}&{codProj}")]
        public HttpResponseMessage selectCenarioForName(string name,int codProj)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                string returnQuery = new CenarioBusiness().ConsCenarioForName(name,codProj);

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
        [Route("api/cenario/select/all/{cod}")]
        public HttpResponseMessage selectCenarioAllData(int cod)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                string returnQuery = new CenarioBusiness().ConsCenarioAllData(cod);

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
