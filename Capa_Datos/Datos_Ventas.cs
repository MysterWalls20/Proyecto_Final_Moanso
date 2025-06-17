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
    public class Datos_Ventas
    {
        private static readonly Datos_Ventas _instancia = new Datos_Ventas();
        public static Datos_Ventas Instancia => _instancia;

        public int RegistrarVenta(Entidad_Venta venta, List<Entidad_DetalleVenta> detalles)
        {
            int idVentaGenerado = 0;
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                cn.Open();
                SqlTransaction trans = cn.BeginTransaction();
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_RegistrarVenta", cn, trans);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cliente_id", venta.IdCliente);
                    cmd.Parameters.AddWithValue("@total", venta.Total);
                    SqlParameter pId = new SqlParameter("@idGenerado", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    cmd.Parameters.Add(pId);
                    cmd.ExecuteNonQuery();
                    idVentaGenerado = Convert.ToInt32(pId.Value);

                    foreach (var det in detalles)
                    {
                        SqlCommand cmdDet = new SqlCommand("sp_RegistrarDetalleVenta", cn, trans);
                        cmdDet.CommandType = CommandType.StoredProcedure;
                        cmdDet.Parameters.AddWithValue("@venta_id", idVentaGenerado);
                        cmdDet.Parameters.AddWithValue("@producto_id", det.IdProducto);
                        cmdDet.Parameters.AddWithValue("@cantidad", det.Cantidad);
                        cmdDet.Parameters.AddWithValue("@precio_unitario", det.PrecioUnidad);
                        cmdDet.ExecuteNonQuery();
                    }

                    trans.Commit();
                }
                catch
                {
                    trans.Rollback();
                    throw;
                }
            }
            return idVentaGenerado;
        }
        public bool RegistrarVentaDesdePedido(Entidad_PedidoTemp pedido)
        {
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    cn.Open();
                    SqlTransaction transaction = cn.BeginTransaction();

                    try
                    {
                        SqlCommand cmdVenta = new SqlCommand("sp_RegistrarVentaDesdePedido", cn, transaction);
                        cmdVenta.CommandType = CommandType.StoredProcedure;

                        cmdVenta.Parameters.AddWithValue("@ClienteId", pedido.ClienteId);
                        cmdVenta.Parameters.AddWithValue("@DireccionEntrega", pedido.DireccionEntrega);
                        cmdVenta.Parameters.AddWithValue("@MetodoPago", "Pedido"); // o el método real
                        cmdVenta.Parameters.AddWithValue("@Fecha", pedido.FechaPedido);

                        SqlParameter idVentaOutput = new SqlParameter("@IdVenta", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmdVenta.Parameters.Add(idVentaOutput);

                        cmdVenta.ExecuteNonQuery();

                        int idVenta = (int)idVentaOutput.Value;

                        foreach (Entidad_DetalleVenta det in pedido.Detalles)
                        {
                            SqlCommand cmdDetalle = new SqlCommand("sp_RegistrarDetalleVenta", cn, transaction);
                            cmdDetalle.CommandType = CommandType.StoredProcedure;

                            cmdDetalle.Parameters.AddWithValue("@IdVenta", idVenta);
                            cmdDetalle.Parameters.AddWithValue("@IdProducto", det.IdProducto);
                            cmdDetalle.Parameters.AddWithValue("@Cantidad", det.Cantidad);
                            cmdDetalle.Parameters.AddWithValue("@PrecioUnidad", det.PrecioUnidad);
                            cmdDetalle.Parameters.AddWithValue("@Subtotal", det.Subtotal);

                            cmdDetalle.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Error al registrar venta desde pedido: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexión o ejecución del procedimiento: " + ex.Message);
            }
        }
        public List<string> ObtenerMetodosPago()
        {
            List<string> lista = new List<string>();

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("SELECT metodoPag FROM MetodoPago ORDER BY id", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(dr["metodoPag"].ToString());
                }
            }
            return lista;
        }

    }
}
