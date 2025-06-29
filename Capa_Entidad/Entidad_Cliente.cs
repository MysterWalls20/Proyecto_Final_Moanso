using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class ECliente
    {
        public int IdCliente { get; set; }
        public string Direccion { get; set; }
        public int IdDistrito { get; set; }
        public int IdTipoCliente { get; set; }
        public bool Estado { get; set; }
    }

    
}
