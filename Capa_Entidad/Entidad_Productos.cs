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
        public string tallas { get; set; }
        public double precio_unidad { get; set; }
        public double precio_Compra { get; set; }
        public DateTime fecha_registro { get; set; }
        public bool estado { get; set; }

        //ID

        public int id_talla { get; set; }
        public int id_marca { get; set; }
        public int id_color { get; set; }
        public int id_categoria { get; set; }
    }
}
