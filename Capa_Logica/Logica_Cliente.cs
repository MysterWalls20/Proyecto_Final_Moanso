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
    public class Logica_Cliente
    {
        Datos_Cliente datos = new Datos_Cliente();

        public static DataTable Listadocl(string cTexto)
        {
            Datos_Cliente datos = new Datos_Cliente();
            return datos.Listadocl(cTexto);
        }

        public static string Guardado_cl(int nOpcion, Entidad_Cliente ecl)
        {
            Datos_Cliente datos = new Datos_Cliente();
            return datos.Guardar_cl(nOpcion, ecl);
        }

        public static string Eliminar_cl(int id)
        {
            Datos_Cliente datos = new Datos_Cliente();
            return datos.Eliminar_cl(id);
        }
    }
}
