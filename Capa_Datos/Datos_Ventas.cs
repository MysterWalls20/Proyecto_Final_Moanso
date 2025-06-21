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
