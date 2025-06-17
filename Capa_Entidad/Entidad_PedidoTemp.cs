using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Entidad_PedidoTemp
    {
        public int Id { get; set; } // puede ser opcional
        public int ClienteId { get; set; }
        public string DireccionEntrega { get; set; }
        public int Almacen1_Id { get; set; }
        public int Almacen2_Id { get; set; }
        public int Repartidor_Id { get; set; }
        public DateTime FechaPedido { get; set; } = DateTime.Now;
        public DateTime HoraSalida { get; set; }
        public DateTime HoraEntrega { get; set; }
        public string estadoEnvio { get; set; }
        public bool RegistradoComoVenta { get; set; } = false;

        public List<Entidad_DetalleVenta> Detalles { get; set; } = new List<Entidad_DetalleVenta>();
    }
}
