using Back.DB.CaseGerenciamentoTeste.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
                Back.DB.CaseGerenciamentoTeste.DataBase.Connection commm = new DataBase.Connection();
                //  SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[statustype] ([statustype]) VALUES ('@teste')");
                // cmd.Parameters.Add("@teste", SqlDbType.VarChar).Value = "oiii";
                //cmd.CommandText = "INSERT INTO [dbo].[statustype] ([statustype]) VALUES ('teste') ";
                // commm.execComand(cmd);
                // commm.commit();

                SqlCommand cmd = new SqlCommand("select * from [statustype] for json auto");
                
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
