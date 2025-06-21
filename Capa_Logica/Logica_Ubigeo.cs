using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Capa_Entidad.Entidad_Ubigeo;

namespace Capa_Logica
{
    public class Logica_Ubigeo
    {
        private static readonly Logica_Ubigeo _instancia = new Logica_Ubigeo();
        public static Logica_Ubigeo Instancia => _instancia;
        public List<Entidad_Departamento> ListarDepartamentos()
        {
            return Datos_Ubigeo.Instancia.ObtenerDepartamentos();
        }
        public List<Entidad_Provincia> ListarProvinciasPorDepartamento(int idDepartamento)
        {
            return Datos_Ubigeo.Instancia.ObtenerProvinciasPorDepartamento(idDepartamento);
        }
        public List<Entidad_Distrito> ListarDistritosPorProvincia(int idProvincia)
        {
            return Datos_Ubigeo.Instancia.ObtenerDistritosPorProvincia(idProvincia);
        }
    }
}
