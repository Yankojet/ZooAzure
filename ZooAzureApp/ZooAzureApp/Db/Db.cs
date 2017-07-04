using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ZooAzureApp
{
    public static class Db
    {
        private static SqlConnection conexion = null;

        public static void Conectar()
        {
            try
            {



                string cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
                conexion = new SqlConnection();
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();

            }
            catch (Exception)
            {
                if (conexion != null)
                {
                    if (conexion.State != ConnectionState.Closed)
                    {
                        conexion.Close();
                    }
                    conexion.Dispose();
                    conexion = null;
                }
            }
            finally
            {

            }
        }

        public static bool EstaLaConexionAbierta()
        {
            return conexion.State == ConnectionState.Open;
        }

        public static void Desconectar()
        {
            if (conexion != null)
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
        }

        public static List<Clasificacion> GetClasificaciones()
        {
            List<Clasificacion> listaClasificacion = new List<Clasificacion>();

            string procedimiento = "dbo.GetClasificaciones";
            SqlCommand comando = new SqlCommand(procedimiento, conexion);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Clasificacion clasificacion = new Clasificacion();
                clasificacion.IdClasificacion = (long)reader["IdClasificacion"];
                clasificacion.denominacion = reader["denominacion"].ToString();
                listaClasificacion.Add(clasificacion);
            }

            return listaClasificacion;
        }


    }

}