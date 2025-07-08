using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Entidad_DetalleOrdenCompra
    {
        public int IdDetalleOrden { get; set; }
        public int IdOrdenCompra { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal => Cantidad * PrecioUnitario;
        public string NombreProducto { get; set; } 
        public decimal SubtotalFinal { get; set; }
    }
}
