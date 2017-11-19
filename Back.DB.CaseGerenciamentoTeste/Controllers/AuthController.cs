﻿using Back.DB.CaseGerenciamentoTeste.Business;
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
    }
}
