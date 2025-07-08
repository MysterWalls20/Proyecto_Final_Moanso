using Capa_Datos;
using Capa_Entidad;
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

        public List<Entidad_Ubigeo.Entidad_Departamento> ObtenerDepartamentos() => Datos_Ubigeo.Instancia.ListarDepartamentos();

        public List<Entidad_Ubigeo.Entidad_Provincia> ObtenerProvincias(int idDepartamento) => Datos_Ubigeo.Instancia.ListarProvinciasPorDepartamento(idDepartamento);

        public List<Entidad_Ubigeo.Entidad_Distrito> ObtenerDistritos(int idProvincia) => Datos_Ubigeo.Instancia.ListarDistritosPorProvincia(idProvincia);

        public int ObtenerIdUbigeo(int idDepartamento, int idProvincia, int idDistrito) =>
            Datos_Ubigeo.Instancia.ObtenerIdUbigeo(idDepartamento, idProvincia, idDistrito);






        //Proveedor

        public (int idDepartamento, int idProvincia, int idDistrito) ObtenerUbigeoCompleto(int idUbigeo)
        {
            return Datos_Ubigeo.Instancia.ObtenerUbigeoCompleto(idUbigeo);
        }
    }
}
