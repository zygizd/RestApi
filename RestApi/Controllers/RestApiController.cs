using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestApi.Shared;

namespace RestApi.Controllers
{
    public class RestApiController : ApiController
    {
        // GET: api/RestApi/get
        public IHttpActionResult Get(string date)
        {
            List<Item> res = new List<Item>();
            try
            {
                res = SortList.SortedList(date);
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(res);
        }
    }
}