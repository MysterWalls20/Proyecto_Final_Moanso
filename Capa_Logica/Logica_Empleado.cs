using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class Logica_Empleado
    {
        private static readonly Logica_Empleado _instancia = new Logica_Empleado();
        public static Logica_Empleado Instancia => _instancia;

        public bool ValidarAcceso(string usuario, string contraseña)
        {
            return Datos_Empleado.Instancia.VerificarLogin(usuario, contraseña);
        }
        public List<string> ObtenerRoles()
        {
            return Datos_Empleado.Instancia.ObtenerRoles();
        }

    }
}
