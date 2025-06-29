using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class Datos_Proveedor
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly Datos_Proveedor _instancia = new Datos_Proveedor();
        //privado para evitar la instanciación directa
        public static Datos_Proveedor Instancia
        {
            get
            {
                return Datos_Proveedor._instancia;
            }
        }
        #endregion singleton

        #region Metodo


        //Listar Proveedor
        public List<Entidad_Proveedor> ListarProveedor()
        {
            SqlCommand cmd = null;
            List<Entidad_Proveedor> lista = new List<Entidad_Proveedor>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Entidad_Proveedor prov = new Entidad_Proveedor
                    {
                        id = Convert.ToInt32(dr["id_proveedor"]),
                        razon_social = dr["razon_social"].ToString(),
                        ruc = Convert.ToInt32(dr["ruc"]),
                        direccion = dr["direccion"].ToString(),
                        telefono = Convert.ToInt32(dr["telefono"]),
                        email = dr["email"].ToString(),

                        Ciudad = new Entidad_ciudad
                        {
                            nombre = dr["ciudad"].ToString()
                        },
                        Rubro = new Entidad_rubro
                        {
                            descripcion = dr["rubro"].ToString()
                        }
                    };
                    lista.Add(prov);
                }
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


        //Insertar Proveedor

        // Insertar proveedor
        public bool InsertarProveedor(Entidad_Proveedor p)
        {
            SqlCommand cmd = null;
            bool inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@razon_social", p.razon_social);
                cmd.Parameters.AddWithValue("@ruc", p.ruc);
                cmd.Parameters.AddWithValue("@direccion", p.direccion);
                cmd.Parameters.AddWithValue("@telefono", p.telefono);
                cmd.Parameters.AddWithValue("@email", p.email);
                cmd.Parameters.AddWithValue("@estado", p.estado);
                cmd.Parameters.AddWithValue("@id_ciudad", p.Ciudad.id_ciudad);
                cmd.Parameters.AddWithValue("@id_rubro", p.Rubro.id_rubro);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) inserta = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return inserta;
        }

        // Editar proveedor
        public bool EditarProveedor(Entidad_Proveedor p)
        {
            SqlCommand cmd = null;
            bool edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_proveedor", p.id);
                cmd.Parameters.AddWithValue("@razon_social", p.razon_social);
                cmd.Parameters.AddWithValue("@ruc", p.ruc);
                cmd.Parameters.AddWithValue("@direccion", p.direccion);
                cmd.Parameters.AddWithValue("@telefono", p.telefono);
                cmd.Parameters.AddWithValue("@email", p.email);
                cmd.Parameters.AddWithValue("@id_ciudad", p.Ciudad.id_ciudad);
                cmd.Parameters.AddWithValue("@id_rubro", p.Rubro.id_rubro);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) edita = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return edita;
        }

        // Deshabilitar proveedor 
        public bool DeshabilitarProveedor(Entidad_Proveedor Prov)
        {
            SqlCommand cmd = null;
            bool delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_proveedor", Prov.id);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) delete = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return delete;
        }

        //Buscar Proveedor
        public Entidad_Proveedor BuscarProveedorPorRUC(string ruc)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            Entidad_Proveedor proveedor = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_ObtenerProveedorPorRUC", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ruc", ruc);
                cn.Open();

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    proveedor = new Entidad_Proveedor
                    {
                        id = Convert.ToInt32(dr["id_proveedor"]),
                        razon_social = dr["razon_social"].ToString(),
                        ruc = Convert.ToInt32(dr["ruc"]),
                        direccion = dr["direccion"].ToString(),
                        telefono = Convert.ToInt32(dr["telefono"]),
                        email = dr["email"].ToString(),

                        Ciudad = new Entidad_ciudad
                        {
                            id_ciudad = Convert.ToInt32(dr["id_ciudad"]),
                            nombre = dr["nombre_ciudad"].ToString()
                        },
                        Rubro = new Entidad_rubro
                        {
                            id_rubro = Convert.ToInt32(dr["id_rubro"]),
                            descripcion = dr["descripcion_rubro"].ToString()
                        }
                    };
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dr != null) dr.Close();
                if (cmd != null) cmd.Connection.Close();
            }

            return proveedor;
        }
        #endregion
    }
}
