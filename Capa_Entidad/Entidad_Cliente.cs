using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Entidad_Cliente
    {
        public int ID { get; set; }
        public string TipoCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public long Ruc { get; set; }
        public string RazonSocial { get; set; }
        public string Rubro { get; set; }
        public int Numero { get; set; }
        public string Direccion { get; set; }
        public string Ubigeo { get; set; }
    }
}
