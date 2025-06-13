using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class Logica_Empleado
    {
        private static readonly Logica_Empleado _instancia = new Logica_Empleado();
        public static Logica_Empleado Instancia => _instancia;

        public bool Login(Entidad_Empleado emp)
        {
            return Datos_Empleado.Instancia.Login(emp);
        }
    }
}
