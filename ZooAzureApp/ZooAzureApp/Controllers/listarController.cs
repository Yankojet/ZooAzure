using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ZooAzureApp.Controllers
{
    public class listarController : ApiController
    {
        // GET: api/listar
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/listar/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/listar
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/listar/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/listar/5
        public void Delete(int id)
        {
        }
    }
}
