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
    public class Logica_Proveedor
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly Logica_Proveedor _instancia = new Logica_Proveedor();
        //privado para evitar la instanciación directa
        public static Logica_Proveedor Instancia
        {
            get
            {
                return Logica_Proveedor._instancia;
            }
        }
        #endregion singleton

        #region metodos

        //listado
        public DataTable ListarProveedoresActivos()
        {
            return Datos_Proveedor.Instancia.ListarProveedoresActivos();
        }

        public DataTable ListarProveedoresInactivos()
        {
            return Datos_Proveedor.Instancia.ListarProveedoresInactivos();
        }

        //inserta
        public void RegistrarProveedor(Entidad_Proveedor proveedor,
                                int idDepartamento,
                                int idProvincia,
                                int idDistrito)
        {
            Datos_Proveedor.Instancia.RegistrarProveedor(proveedor, idDepartamento, idProvincia, idDistrito);
        }

        //Edita
        public void EditaProveedor(Entidad_Proveedor proveedor)
        {
            Datos_Proveedor.Instancia.EditarProveedor(proveedor);
        }

        //Deshabilita
        public void DeshabilitarProveedor(Entidad_Proveedor Prov)
        {
            Datos_Proveedor.Instancia.DeshabilitarProveedor(Prov);
        }

        //Habilita
        public void habilitarProveedor(Entidad_Proveedor Prov)
        {
            Datos_Proveedor.Instancia.habilitarProveedor(Prov);
        }

        //BuscarPorID
        public Entidad_Proveedor BuscarProveedorPorID(int id)
        {
            return Datos_Proveedor.Instancia.BuscarProveedorPorID(id);
        }

        //BuscarPorNombre
        public DataTable BuscarProveedorPorNombre(string nombre)
        {
            return Datos_Proveedor.Instancia.BuscarProveedorPorNombre(nombre);
        }
        #endregion metodos
    }
}
