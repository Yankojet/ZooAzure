using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ZooAzureApp.Controllers
{
    public class crearnuevoController : ApiController
    {
        // GET: api/crearnuevo
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/crearnuevo/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/crearnuevo
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/crearnuevo/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/crearnuevo/5
        public void Delete(int id)
        {
        }
    }
}
