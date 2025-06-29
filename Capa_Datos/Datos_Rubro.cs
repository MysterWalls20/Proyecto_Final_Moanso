using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class Datos_Rubro
    {
        #region Singleton
        private static readonly Datos_Rubro _instancia = new Datos_Rubro();
        public static Datos_Rubro Instancia
        {
            get { return _instancia; }
        }
        #endregion

        #region Métodos

        public List<Entidad_rubro> ListarRubro()
        {
            SqlCommand cmd = null;
            List<Entidad_rubro> lista = new List<Entidad_rubro>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SELECT id_rubro, descripcion FROM Rubro", cn);
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Entidad_rubro r = new Entidad_rubro
                    {
                        id_rubro = Convert.ToInt32(dr["id_rubro"]),
                        descripcion = dr["descripcion"].ToString()
                    };
                    lista.Add(r);
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
