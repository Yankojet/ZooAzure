using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZooAzureApp
{
    public class RespuestaApi
    {
        public int totalElementos { get; set; }

        public string error { get; set; }

        public List<Clasificacion> dataClasificacion { get; set; }

        //public List<Especies> data { get; set; }

        //public List<TiposAnimales> dataTiposAnimales { get; set; }

    }
}