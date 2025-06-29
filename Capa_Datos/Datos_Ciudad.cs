using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace Capa_Datos
{
    public class Datos_Ciudad
    {
        #region Singleton
        private static readonly Datos_Ciudad _instancia = new Datos_Ciudad();
        public static Datos_Ciudad Instancia
        {
            get { return _instancia; }
        }
        #endregion

        #region Métodos

        public List<Entidad_ciudad> ListarCiudad()
        {
            SqlCommand cmd = null;
            List<Entidad_ciudad> lista = new List<Entidad_ciudad>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SELECT id_ciudad, nombre FROM Ciudad", cn);
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Entidad_ciudad c = new Entidad_ciudad
                    {
                        id_ciudad = Convert.ToInt32(dr["id_ciudad"]),
                        nombre = dr["nombre"].ToString()
                    };
                    lista.Add(c);
                }

                dr.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }

            return lista;
        }

        #endregion
    }
}
