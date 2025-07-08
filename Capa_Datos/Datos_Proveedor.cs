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

        //Listar Proveedor Activo
        public DataTable ListarProveedoresActivos()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("sp_ListarProveedoresActivos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
            }
            return tabla;
        }

        //Listar Proveedor Inactivo
        public DataTable ListarProveedoresInactivos()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("sp_ListarProveedoresInactivos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
            }
            return tabla;
        }

        //Insertar Proveedor

        public void RegistrarProveedor(Entidad_Proveedor proveedor,
                               int idDepartamento,
                               int idProvincia,
                               int idDistrito)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@razon_social", proveedor.razon_social);
                cmd.Parameters.AddWithValue("@ruc", proveedor.ruc);
                cmd.Parameters.AddWithValue("@direccion", proveedor.direccion);
                cmd.Parameters.AddWithValue("@telefono", proveedor.telefono);
                cmd.Parameters.AddWithValue("@estado", proveedor.estado);
                cmd.Parameters.AddWithValue("@id_rubro", proveedor.Rubro.id_rubro);
                cmd.Parameters.AddWithValue("@idDepartamento", idDepartamento);
                cmd.Parameters.AddWithValue("@idProvincia", idProvincia);
                cmd.Parameters.AddWithValue("@idDistrito", idDistrito);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Editar proveedor
        public void EditarProveedor(Entidad_Proveedor proveedor)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("sp_EditarProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_proveedor", proveedor.id);
                cmd.Parameters.AddWithValue("@razon_social", (object)proveedor.razon_social ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ruc", proveedor.ruc != 0 ? (object)proveedor.ruc : DBNull.Value);
                cmd.Parameters.AddWithValue("@direccion", (object)proveedor.direccion ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@telefono", proveedor.telefono != 0 ? (object)proveedor.telefono : DBNull.Value);
                cmd.Parameters.AddWithValue("@id_rubro", proveedor.Rubro?.id_rubro ?? (object)DBNull.Value);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
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

        //Habilitar
        public bool habilitarProveedor(Entidad_Proveedor Prov)
        {
            SqlCommand cmd = null;
            bool agregar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spHabilitaProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_proveedor", Prov.id);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) agregar = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return agregar;
        }

        //Buscar Proveedor Por ID
        public Entidad_Proveedor BuscarProveedorPorID(int id)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            Entidad_Proveedor prov = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_BuscarProveedorPorID", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProveedor", id);
                cn.Open();

                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    prov = new Entidad_Proveedor
                    {
                        id = Convert.ToInt32(dr["id_proveedor"]),
                        razon_social = dr["razon_social"].ToString(),
                        ruc = Convert.ToInt32(dr["ruc"]),
                        direccion = dr["direccion"].ToString(),
                        telefono = Convert.ToInt32(dr["telefono"]),
                        Rubro = new Entidad_rubro
                        {
                            id_rubro = Convert.ToInt32(dr["id_rubro"])
                        },
                        id_ubigeo = Convert.ToInt32(dr["id_ubigeo"])
                    };
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

            return prov;
        }

        //Buscar Proveedor por nombre
        public DataTable BuscarProveedorPorNombre(string nombre)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("sp_BuscarProveedorPorNombre", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", nombre);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                da.Fill(tabla);
                return tabla;
            }
        }
        #endregion
    }
}
