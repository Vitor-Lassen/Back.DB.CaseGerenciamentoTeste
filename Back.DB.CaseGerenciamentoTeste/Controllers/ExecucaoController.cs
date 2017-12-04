using Back.DB.CaseGerenciamentoTeste.Business;
using Back.DB.CaseGerenciamentoTeste.Models;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Back.DB.CaseGerenciamentoTeste.Controllers
{
    public class ExecucaoController : ApiController
    {
        [HttpPost]

        [Route("api/execucao/create")]
        public HttpResponseMessage CreateExecucao(Execucao execucao)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                new ExecucaoBusiness().CreateExecucao(ref execucao);

                response.StatusCode = HttpStatusCode.OK;
                response.Content = new StringContent(JsonConvert.SerializeObject(execucao));
            }
            catch (Exception ex)
            {
                response.StatusCode = HttpStatusCode.InternalServerError;
                response.Content = new StringContent(ex.Message.ToString());
            }
            return response;
        }
        [HttpPost]

        [Route("api/execucao/update")]
        public HttpResponseMessage UpdateExecucao(Execucao execucao)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                new ExecucaoBusiness().UpdateExecucao(ref execucao);

                response.StatusCode = HttpStatusCode.OK;
                response.Content = new StringContent(JsonConvert.SerializeObject(execucao));
            }
            catch (Exception ex)
            {
                response.StatusCode = HttpStatusCode.InternalServerError;
                response.Content = new StringContent(ex.Message.ToString());
            }
            return response;
        }

        [HttpGet]
        [Route("api/execucao/select/all/{cod}")]
        public HttpResponseMessage selectExecucaoAllData(int cod)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                string returnQuery = new ExecucaoBusiness().ConsExecucaoAllData(cod);

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
