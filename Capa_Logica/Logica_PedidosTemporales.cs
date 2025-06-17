using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class Logica_PedidosTemporales
    {
        private static readonly Logica_PedidosTemporales _instancia = new Logica_PedidosTemporales();
        public static Logica_PedidosTemporales Instancia
        {
            get { return _instancia; }
        }

        // Lista de pedidos temporales
        public List<Entidad_PedidoTemp> PedidosPendientes { get; set; }

        private Logica_PedidosTemporales()
        {
            PedidosPendientes = new List<Entidad_PedidoTemp>();
        }
        public bool FinalizarPedidoYRegistrarVenta(Entidad_PedidoTemp pedido)
        {
            try
            {
                return Datos_Ventas.Instancia.RegistrarVentaDesdePedido(pedido);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al finalizar y registrar el pedido como venta: " + ex.Message);
            }
        }
    }
}
