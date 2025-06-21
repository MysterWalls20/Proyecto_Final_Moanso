using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Entidad_Ubigeo
    {
        public class Entidad_Departamento
        {
            public int IdDepartamento { get; set; }
            public string NombreDepartamento { get; set; }
        }

        public class Entidad_Provincia
        {
            public int IdProvincia { get; set; }
            public string NombreProvincia { get; set; }
            public int IdDepart { get; set; }
        }

        public class Entidad_Distrito
        {
            public int IdDistrito { get; set; }
            public string NombreDistrito { get; set; }
            public int IdProvincia { get; set; }
        }
    }
}
