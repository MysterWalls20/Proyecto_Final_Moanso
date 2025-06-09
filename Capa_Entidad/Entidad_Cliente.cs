using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Entidad_Cliente
    {
        public int id { get; set; }
        public string nombre { get; set; }  
        public string apellido { get; set;}
        public int numero { get; set; }
        public char dni { get; set; }
        public DateTime fecha_registro { get; set; }
    }
}
