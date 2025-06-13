using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Entidad_Productos
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string marca { get; set; }
        public string color { get; set; }
        public int stock { get; set; }
        public string categoria { get; set; }
        public double precio_unidad { get; set; }
        public bool estado { get; set; }
    }
}
