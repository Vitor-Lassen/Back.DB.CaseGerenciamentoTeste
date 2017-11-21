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
    public class AuthController : ApiController
    {
        [HttpPost]
       // [AllowAnonymous]
        [Route("api/auth")]
        public HttpResponseMessage Auth(Auth auth)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                new AuthBusiness().Auth(ref auth);

                response.StatusCode = HttpStatusCode.OK;
                response.Content = new StringContent(JsonConvert.SerializeObject(auth));
            }
            catch(Exception ex)
            {
                response.StatusCode = HttpStatusCode.InternalServerError;
                response.Content = new StringContent(ex.Message.ToString());
            }
            return response;  
        }
        [HttpPost]
       
        [Route("api/auth/trocasenha")]
        public HttpResponseMessage trocaSenha(AuthTrocaSenha authTrocaSenha)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                new AuthBusiness().AuthTrocaSenha(ref authTrocaSenha);
                if (authTrocaSenha.auth)
                {
                    response.StatusCode = HttpStatusCode.OK;
                    response.Content = new StringContent("Senha Alterada!");
                }
                else
                {
                    if (authTrocaSenha.novaSenhaCoincide)
                    {
                        response.StatusCode = HttpStatusCode.NotAcceptable;
                        response.Content = new StringContent("Senha  Antiga Incorreta");
                    }
                    else
                    {
                        response.StatusCode = HttpStatusCode.NotAcceptable;
                        response.Content = new StringContent("Senhas não Coincedem");

                    }
                }
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
