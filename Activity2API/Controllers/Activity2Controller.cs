using Activity2BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Activity2API.Controllers
{
    public class Activity2Controller : ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetProductDetailsByPrice()
        {
            try
            {

                BL blObj = new BL();

                var result = blObj.GetProductsByPrice();
                if (result != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, result);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NoContent, "No Data Exists");
                }

            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
