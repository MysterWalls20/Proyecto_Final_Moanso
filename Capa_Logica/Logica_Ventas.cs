using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class Logica_Ventas
    {
        private static readonly Logica_Ventas _instancia = new Logica_Ventas();
        public static Logica_Ventas Instancia => _instancia;

        public int RegistrarVenta(Entidad_Venta venta, List<Entidad_DetalleVenta> detalles)
        {
            return Datos_Ventas.Instancia.RegistrarVenta(venta, detalles);
        }

        public bool RegistrarVenta(int clienteId, DateTime fecha, decimal total, List<Entidad_DetalleVenta> detalles, out int idVenta)
        {
            idVenta = 0;
            bool exito = false;

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                cn.Open();
                SqlTransaction tx = cn.BeginTransaction();

                try
                {
                    SqlCommand cmd = new SqlCommand("sp_RegistrarVenta", cn, tx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cliente_id", clienteId);
                    cmd.Parameters.AddWithValue("@fecha", fecha);
                    cmd.Parameters.AddWithValue("@total", total);

                    SqlParameter outputId = new SqlParameter("@idVenta", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputId);

                    cmd.ExecuteNonQuery();
                    idVenta = (int)outputId.Value;

                    foreach (var det in detalles)
                    {
                        SqlCommand cmdDet = new SqlCommand("sp_RegistrarDetalleVenta", cn, tx);
                        cmdDet.CommandType = CommandType.StoredProcedure;
                        cmdDet.Parameters.AddWithValue("@venta_id", idVenta);
                        cmdDet.Parameters.AddWithValue("@producto_id", det.IdProducto);
                        cmdDet.Parameters.AddWithValue("@cantidad", det.Cantidad);
                        cmdDet.Parameters.AddWithValue("@precio_unitario", det.PrecioUnidad);
                        cmdDet.Parameters.AddWithValue("@subtotal", det.Subtotal);
                        cmdDet.ExecuteNonQuery();
                    }

                    tx.Commit();
                    exito = true;
                }
                catch
                {
                    tx.Rollback();
                    exito = false;
                }
            }
            return exito;
        }
        public List<string> ObtenerMetodosPago()
        {
            return Datos_Ventas.Instancia.ObtenerMetodosPago();
        }
    }
}
