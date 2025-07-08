using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Entidad_OrdenCompra
    {
        public int IdOrdenCompra { get; set; }
        public DateTime FechaOrden { get; set; }
        public int IdProveedor { get; set; }
        public int IdTipoPago { get; set; }
        public int IdFormaPago { get; set; }
        public string Estado { get; set; }
        public decimal Total { get; set; }

        public List<Entidad_DetalleOrdenCompra> Detalles { get; set; }

        // Campos solo para visualización
        public string Proveedor { get; set; }
        public string TipoPago { get; set; }
        public string FormaPago { get; set; }
    }
}
