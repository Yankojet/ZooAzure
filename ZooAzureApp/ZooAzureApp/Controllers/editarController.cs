﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ZooAzureApp.Controllers
{
    public class editarController : ApiController
    {
        // GET: api/editar
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/editar/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/editar
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/editar/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/editar/5
        public void Delete(int id)
        {
        }
    }
}