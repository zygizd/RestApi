using System;
using System.Collections.Generic;
using System.Web.Http;
using RestApi.Shared;

namespace RestApi.Controllers
{
    public class RestApiController : ApiController
    {
        public IHttpActionResult Get(string date)
        {
            List<Item> response = new List<Item>();
            try
            {
                response = SortList.SortedList(date);
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(response);
        }
    }
}