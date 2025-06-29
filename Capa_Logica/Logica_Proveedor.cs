using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
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
        public List<Entidad_Proveedor> ListarProveedor()
        {
            return Datos_Proveedor.Instancia.ListarProveedor();
        }
        //Busca
        public Entidad_Proveedor ObtenerClientePorRuc(string ruc)
        {
            return Datos_Proveedor.Instancia.BuscarProveedorPorRUC(ruc);
        }
        ///inserta
        public void InsertaProveedor(Entidad_Proveedor Prov)
        {
            Datos_Proveedor.Instancia.InsertarProveedor(Prov);
        }
        ///Edita
        public void EditaCliente(Entidad_Proveedor Prov)
        {
            Datos_Proveedor.Instancia.EditarProveedor(Prov);
        }
        //Deshabilita
        public void DeshabilitarProveedor(Entidad_Proveedor Prov)
        {
            Datos_Proveedor.Instancia.DeshabilitarProveedor(Prov);
        }
        #endregion metodos
    }
}
