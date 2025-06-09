using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class Logica_Empleado
    {
        private Capa_Datos.Datos_Empleado loginDAO = new Capa_Datos.Datos_Empleado();

        public bool ValidarLogin(Capa_Entidad.Entidad_Empleado login)
        {
            return loginDAO.VerificarLogin(login);
        }
    }
}
