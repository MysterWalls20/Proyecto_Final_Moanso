using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Entidad_Empleado
    {
        public string nombre { get; set; }
        public string usuario { get; set; }
        public string contrasena { get; set; }
        public int numero { get; set; }
        public int salario { get; set; }
        public bool estado { get; set; }
        public bool disponible { get; set; }
    }
}
