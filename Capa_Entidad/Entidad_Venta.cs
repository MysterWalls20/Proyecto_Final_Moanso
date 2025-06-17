using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Entidad_Venta
    {
        public int IdVenta { get; set; }
        public int IdCliente { get; set; }
        public DateTime Fecha { get; set; }
        public string metodoPago { get; set; }
        public decimal Total { get; set; }
        public bool EsPedido { get; set; } = false;
        public string Direccion { get; set; } = string.Empty;
        public List<Entidad_DetalleVenta> Detalles { get; set; }
    }
}
