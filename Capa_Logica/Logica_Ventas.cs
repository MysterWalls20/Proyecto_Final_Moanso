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

        
        Datos_Ventas datos = new Datos_Ventas();

        public int RegistrarVenta(int idCliente, int idFormaPago, decimal total)
        {
            return datos.RegistrarVenta(idCliente, idFormaPago, total);
        }

        public void RegistrarDetalleVenta(int idVenta, int idProducto, int cantidad, decimal precioUnitario, decimal subtotal)
        {
            datos.RegistrarDetalleVenta(idVenta, idProducto, cantidad, precioUnitario, subtotal);
        }
        public void ActualizarStock(int idProducto, int cantidadVendida)
        {
            datos.ActualizarStock(idProducto, cantidadVendida);
        }

        // Obtener Formas de Pago
        public DataTable ObtenerFormasPago()
        {
            return new Datos_Ventas().ListarFormasPago();
        }
    }
}
