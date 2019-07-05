using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebService.Controllers
{
    public class bbController : ApiController
    {
        // GET: api/bb
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/bb/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/bb
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/bb/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/bb/5
        public void Delete(int id)
        {
        }
    }
}
