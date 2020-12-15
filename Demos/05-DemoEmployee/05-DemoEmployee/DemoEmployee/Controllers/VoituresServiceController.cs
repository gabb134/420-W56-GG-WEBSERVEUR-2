using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoEmployee.Controllers
{
    public class VoituresServiceController : ApiController
    {
        // GET: api/VoituresService
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/VoituresService/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/VoituresService
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/VoituresService/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/VoituresService/5
        public void Delete(int id)
        {
        }
    }
}
