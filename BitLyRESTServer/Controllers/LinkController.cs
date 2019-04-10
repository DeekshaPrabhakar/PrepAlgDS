using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BitLyRESTServer.Controllers
{
    public class LinkController : ApiController
    {
        // GET api/link
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/link/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/link
        public void Post([FromBody]string value)
        {
        }

        // PUT api/link/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/link/5
        public void Delete(int id)
        {
        }
    }
}
