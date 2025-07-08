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

        public int RegistrarVenta(int idCliente, int idFormaPago, decimal total)
        {
            int idVenta = 0;

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                if (cn.State != ConnectionState.Open)
                    cn.Open();

                SqlCommand cmd = new SqlCommand("sp_RegistrarVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_Cliente", idCliente);
                cmd.Parameters.AddWithValue("@id_FormaPago", idFormaPago);
                cmd.Parameters.AddWithValue("@total", total);

                SqlParameter pIdVenta = new SqlParameter("@id_Venta", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(pIdVenta);

                cmd.ExecuteNonQuery();

                idVenta = Convert.ToInt32(pIdVenta.Value);
            }

            return idVenta;
        }

        public void RegistrarDetalleVenta(int idVenta, int idProducto, int cantidad, decimal precioUnitario, decimal subtotal)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                if (cn.State != ConnectionState.Open)
                    cn.Open();

                SqlCommand cmd = new SqlCommand("sp_RegistrarDetalleVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_Venta", idVenta);
                cmd.Parameters.AddWithValue("@id_Producto", idProducto);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@precio_unitario", precioUnitario);
                cmd.Parameters.AddWithValue("@subtotal", subtotal);

                cmd.ExecuteNonQuery();
            }
        }
        public void ActualizarStock(int idProducto, int cantidadVendida)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                if (cn.State != ConnectionState.Open)
                    cn.Open();

                SqlCommand cmd = new SqlCommand("sp_ActualizarStock", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_Producto", idProducto);
                cmd.Parameters.AddWithValue("@cantidadVendida", cantidadVendida);

                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ListarFormasPago()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                if (cn.State != ConnectionState.Open)
                    cn.Open();

                SqlCommand cmd = new SqlCommand("sp_ListarFormasPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
            }

            return tabla;
        }
    }
}
