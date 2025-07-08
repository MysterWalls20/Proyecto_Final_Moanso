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
    public class Datos_DetalleOrdenCompra
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly Datos_DetalleOrdenCompra _instancia = new Datos_DetalleOrdenCompra();
        //privado para evitar la instanciación directa
        public static Datos_DetalleOrdenCompra Instancia
        {
            get
            {
                return Datos_DetalleOrdenCompra._instancia;
            }
        }
        #endregion singleton

        #region METODO

        public List<Entidad_DetalleOrdenCompra> ListarDetallePorOrden(int idOrdenCompra)
        {
            List<Entidad_DetalleOrdenCompra> lista = new List<Entidad_DetalleOrdenCompra>();

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("sp_ListarDetalleOrdenCompraPorIdOrden", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_orden_compra", idOrdenCompra);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Entidad_DetalleOrdenCompra
                    {
                        IdProducto = Convert.ToInt32(dr["id_producto"]),
                        NombreProducto = dr["nombre_producto"].ToString(),
                        Cantidad = Convert.ToInt32(dr["cantidad"]),
                        PrecioUnitario = Convert.ToDecimal(dr["precio_unitario"]),
                        SubtotalFinal = Convert.ToDecimal(dr["subtotal"])
                    });
                }
            }
            return lista;
        }


        public void RegistrarDetalleOrdenCompra(Entidad_DetalleOrdenCompra detalle)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("sp_RegistrarDetalleOrdenCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_orden_compra", detalle.IdOrdenCompra);
                cmd.Parameters.AddWithValue("@id_producto", detalle.IdProducto);
                cmd.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                cmd.Parameters.AddWithValue("@precio_unitario", detalle.PrecioUnitario);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        #endregion

        #region MÉTODOS PARA COMBOBOX

        public List<KeyValuePair<int, string>> ListarProductos()
        {
            List<KeyValuePair<int, string>> lista = new List<KeyValuePair<int, string>>();

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("sp_ListarProductosOrdenCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new KeyValuePair<int, string>((int)dr["id_Producto"], dr["nombre"].ToString()));
                }
            }

            return lista;
        }

        public List<KeyValuePair<int, string>> ListarProveedores()
        {
            List<KeyValuePair<int, string>> lista = new List<KeyValuePair<int, string>>();

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("sp_ListarProveedoresOrdenCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new KeyValuePair<int, string>((int)dr["id_proveedor"], dr["razon_social"].ToString()));
                }
            }

            return lista;
        }

        public List<KeyValuePair<int, string>> ListarTipoPago()
        {
            List<KeyValuePair<int, string>> lista = new List<KeyValuePair<int, string>>();

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("sp_ListarTipoPagoOrdenCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new KeyValuePair<int, string>((int)dr["id_TipoPago"], dr["tipoPago"].ToString()));
                }
            }

            return lista;
        }

        public List<KeyValuePair<int, string>> ListarFormaPago()
        {
            List<KeyValuePair<int, string>> lista = new List<KeyValuePair<int, string>>();

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("sp_ListarFormaPagoOrdenCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new KeyValuePair<int, string>((int)dr["id_FormaPago"], dr["Descripcion"].ToString()));
                }
            }

            return lista;
        }
        #endregion
    }
}
