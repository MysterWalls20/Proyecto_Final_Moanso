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
        public int Id_FormaPago { get; set; }
        public DateTime Fecha { get; set; }
        public double Total { get; set; }
        public List<Entidad_DetalleVenta> Detalles { get; set; }
    }
}
