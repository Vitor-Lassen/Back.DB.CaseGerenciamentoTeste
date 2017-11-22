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
    public class ProjetoController : ApiController
    {
        [HttpPost]
       
        [Route("api/projeto/create")]
        public HttpResponseMessage CreateProjeto(Projeto projeto)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                new ProjetoBusiness().CreateProjeto(ref projeto);

                response.StatusCode = HttpStatusCode.OK;
                response.Content = new StringContent(JsonConvert.SerializeObject(projeto));
            }
            catch (Exception ex)
            {
                response.StatusCode = HttpStatusCode.InternalServerError;
                response.Content = new StringContent(ex.Message.ToString());
            }
            return response;
        }
        [HttpPost]

        [Route("api/projeto/update")]
        public HttpResponseMessage UpdateProjeto(Projeto projeto)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                new ProjetoBusiness().UpdateProjeto(ref projeto);

                response.StatusCode = HttpStatusCode.OK;
                response.Content = new StringContent(JsonConvert.SerializeObject(projeto));
            }
            catch (Exception ex)
            {
                response.StatusCode = HttpStatusCode.InternalServerError;
                response.Content = new StringContent(ex.Message.ToString());
            }
            return response;
        }

        [HttpGet]
        [Route("api/projeto/select/forname/{projetoName}")]
        public HttpResponseMessage selectProjetoForName(string projetoName)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                string returnQuery = new ProjetoBusiness().ConsProjetoForName(projetoName);

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
        [Route("api/projeto/select/all/{cod}")]
        public HttpResponseMessage selectProjetoAllData(int cod)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                string returnQuery = new ProjetoBusiness().ConsProjetoAllData(cod);

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
        [Route("api/projeto/select/listall/")]
        public HttpResponseMessage selectProjetoListAll()
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                string returnQuery = new ProjetoBusiness().ConsListAllProjetos();

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
