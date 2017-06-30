using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ZooAzureApp.Controllers
{
    public class eliminarController : ApiController
    {
        // GET: api/eliminar
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/eliminar/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/eliminar
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/eliminar/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/eliminar/5
        public void Delete(int id)
        {
        }
    }
}
