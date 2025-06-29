using Capa_Entidad;
using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class DCliente
    {
        public class NCliente
        {
            public static void Registrar(ECliente cliente)
            {
                if (cliente.IdTipoCliente == 1 && cliente is EClienteNatural natural)
                {
                    DCliente.RegistrarClienteNatural(natural);
                }
                else if (cliente.IdTipoCliente == 2 && cliente is EClienteJuridico juridico)
                {
                    DCliente.RegistrarClienteJuridico(juridico);
                }
            }
        }
    }
}