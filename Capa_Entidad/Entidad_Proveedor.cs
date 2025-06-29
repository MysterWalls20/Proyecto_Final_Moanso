using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Entidad_Proveedor
    {
        public int id { get; set; }
        public string razon_social { get; set; }
        public int ruc { get; set; }
        public string direccion { get; set; }
        public int telefono { get; set; }
        public string email { get; set; }
        public bool estado { get; set; }

        // Relación con Ciudad y Rubro
        public Entidad_ciudad Ciudad { get; set; }
        public Entidad_rubro Rubro { get; set; }
    }
}
