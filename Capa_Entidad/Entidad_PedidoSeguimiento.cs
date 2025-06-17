using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Entidad_PedidoSeguimiento
    {
        public int IdPedido { get; set; }
        public string Cliente { get; set; }
        public string Direccion { get; set; }
        public string Almacen { get; set; }
        public string Repartidor { get; set; }
        public string Estado { get; set; }
    }
}
