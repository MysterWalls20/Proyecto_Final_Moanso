using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class Logica_DetalleOrdenCompra
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly Logica_DetalleOrdenCompra _instancia = new Logica_DetalleOrdenCompra();
        //privado para evitar la instanciación directa
        public static Logica_DetalleOrdenCompra Instancia
        {
            get
            {
                return Logica_DetalleOrdenCompra._instancia;
            }
        }
        #endregion singleton

        #region METODO

        public void RegistrarDetalleOrdenCompra(Entidad_DetalleOrdenCompra detalle)
        {
            Datos_DetalleOrdenCompra.Instancia.RegistrarDetalleOrdenCompra(detalle);
        }

        public List<KeyValuePair<int, string>> ListarProductos()
        {
            return Datos_DetalleOrdenCompra.Instancia.ListarProductos();
        }

        public List<KeyValuePair<int, string>> ListarProveedores()
        {
            return Datos_DetalleOrdenCompra.Instancia.ListarProveedores();
        }

        public List<KeyValuePair<int, string>> ListarTipoPago()
        {
            return Datos_DetalleOrdenCompra.Instancia.ListarTipoPago();
        }

        public List<KeyValuePair<int, string>> ListarFormaPago()
        {
            return Datos_DetalleOrdenCompra.Instancia.ListarFormaPago();
        }

        public List<Entidad_DetalleOrdenCompra> ListarDetallePorOrden(int idOrdenCompra)
        {
            return Datos_DetalleOrdenCompra.Instancia.ListarDetallePorOrden(idOrdenCompra);
        }
        #endregion
    }
}
