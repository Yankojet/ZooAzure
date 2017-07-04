using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ZooAzureApp.Controllers
{
    public class ClasificacionController : ApiController
    {
        // GET: api/Clasificacion
        public RespuestaApi Get()
        {
            RespuestaApi respuestaApi = new RespuestaApi();
            List<Clasificacion> dataClasificacion = new List<Clasificacion>();

            try
            {
                Db.Conectar();
                if (Db.EstaLaConexionAbierta())
                {
                    dataClasificacion = Db.GetClasificaciones();

                }

                respuestaApi.error = "";
                Db.Desconectar();
                    
            }

            catch
            {
                respuestaApi.totalElementos = 0;
                respuestaApi.error = "dame error";
            }

            respuestaApi.totalElementos = dataClasificacion.Count;
            respuestaApi.dataClasificacion = dataClasificacion;
            return respuestaApi;

    }

    // GET: api/Clasificacion/5
    public string Get(int id)
        {
            return "value";
        }

        // POST: api/Clasificacion
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Clasificacion/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Clasificacion/5
        public void Delete(int id)
        {
        }
    }
}
