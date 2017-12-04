using Back.DB.CaseGerenciamentoTeste.Business;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Back.DB.CaseGerenciamentoTeste.Controllers
{
    public class StatusTypeController : ApiController
    {
        [HttpGet]
        [Route("api/statustype/select/listall/")]
        public HttpResponseMessage selectProjetoListAll()
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                string returnQuery = new StatusTypeBusiness().ConsListAllStatusType();

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
        [Route("api/statustype/select/statustypeforcod/{cod}")]
        public HttpResponseMessage selectProjetoStatusCodForCod(int cod)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                string returnQuery = new StatusTypeBusiness().ConsListAllStatusTypeForCod(cod);

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
