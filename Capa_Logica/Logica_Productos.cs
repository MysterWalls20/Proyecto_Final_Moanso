using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Capa_Datos.Datos_Productos;

namespace Capa_Logica
{
    public class Logica_Productos
    {
        Datos_Productos datos = new Datos_Productos();

        public static DataTable ListadoPR(string cTexto)
        {
            Datos_Productos dato = new Datos_Productos();
            return dato.ListadoPR(cTexto);
        }

        public static string Guardado_PR(int nOpcion, Entidad_Productos epr)
        {
            Datos_Productos dato = new Datos_Productos();
            return dato.Guardar_pr(nOpcion, epr);
        }

        public static string Eliminar_PR(int id)
        {
            Datos_Productos dato = new Datos_Productos();
            return dato.Eliminar_pr(id);
        }
    }
}
