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
    public class UserController : ApiController
    {
        [HttpPost]
        // [AllowAnonymous]
        [Route("api/create/user")]
        public HttpResponseMessage CreateUser(User user)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                new UserBusiness().CreateUser(ref user);

                response.StatusCode = HttpStatusCode.OK;
                response.Content = new StringContent(JsonConvert.SerializeObject(user));
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
