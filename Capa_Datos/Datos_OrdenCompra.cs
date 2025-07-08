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
    public class Datos_OrdenCompra
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly Datos_OrdenCompra _instancia = new Datos_OrdenCompra();
        //privado para evitar la instanciación directa
        public static Datos_OrdenCompra Instancia
        {
            get
            {
                return Datos_OrdenCompra._instancia;
            }
        }
        #endregion singleton

        #region METODO
        public int RegistrarOrdenCompra(Entidad_OrdenCompra orden)
        {
            int idGenerado = 0;

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("sp_RegistrarOrdenCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@fecha_orden", orden.FechaOrden);
                cmd.Parameters.AddWithValue("@id_proveedor", orden.IdProveedor);
                cmd.Parameters.AddWithValue("@id_TipoPago", orden.IdTipoPago);
                cmd.Parameters.AddWithValue("@id_FormaPago", orden.IdFormaPago);
                cmd.Parameters.AddWithValue("@estado", orden.Estado);
                cmd.Parameters.AddWithValue("@total", orden.Total);

                SqlParameter outputId = new SqlParameter("@id_generado", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputId);

                cn.Open();
                cmd.ExecuteNonQuery();

                idGenerado = Convert.ToInt32(outputId.Value);
            }
            return idGenerado;
        }

        public decimal ObtenerPrecioCompra(int idProducto)
        {
            decimal precio = 0;

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerPrecioCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_producto", idProducto);

                cn.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                    precio = Convert.ToDecimal(result);
            }
            return precio;
        }

        public string ObtenerNombreProducto(int idProducto)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerNombreProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_producto", idProducto);

                cn.Open();
                return Convert.ToString(cmd.ExecuteScalar());
            }
        }

        public List<Entidad_OrdenCompra> ListarOrdenesCompra()
        {
            List<Entidad_OrdenCompra> lista = new List<Entidad_OrdenCompra>();

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("sp_ListarOrdenesCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Entidad_OrdenCompra
                    {
                        IdOrdenCompra = Convert.ToInt32(dr["id_orden_compra"]),
                        FechaOrden = Convert.ToDateTime(dr["fecha_orden"]),
                        Proveedor = dr["proveedor"].ToString(),
                        TipoPago = dr["tipoPago"].ToString(),
                        FormaPago = dr["formaPago"].ToString(),
                        Total = Convert.ToDecimal(dr["total"]),
                        Estado = dr["estado"].ToString()
                    });
                }
            }
            return lista;
        }
        #endregion
    }
}
