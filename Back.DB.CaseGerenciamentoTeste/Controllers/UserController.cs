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
        [HttpPost]

        [Route("api/update/user")]
        public HttpResponseMessage UpdateUser(User user)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                new UserBusiness().UpdateUser(ref user);

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

        [HttpGet]
        [Route("api/select/user/forname/{userName}")]
        public HttpResponseMessage selectUserForName(string userName)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                string returnQuery= new UserBusiness().ConsUserForName(userName);

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
        [Route("api/select/user/all/{cod}")]
        public HttpResponseMessage selectUserAllData(int cod)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                string returnQuery = new UserBusiness().ConsUserAllData(cod);

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
