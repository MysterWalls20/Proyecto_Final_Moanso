using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class Logica_OrdenCompra
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly Logica_OrdenCompra _instancia = new Logica_OrdenCompra();
        //privado para evitar la instanciación directa
        public static Logica_OrdenCompra Instancia
        {
            get
            {
                return Logica_OrdenCompra._instancia;
            }
        }
        #endregion singleton

        #region Metodo
        public int RegistrarOrdenCompra(Entidad_OrdenCompra orden)
        {
            return Datos_OrdenCompra.Instancia.RegistrarOrdenCompra(orden);
        }

        public decimal ObtenerPrecioCompra(int idProducto)
        {
            return Datos_OrdenCompra.Instancia.ObtenerPrecioCompra(idProducto);
        }

        public List<Entidad_OrdenCompra> ListarOrdenesCompra()
        {
            return Datos_OrdenCompra.Instancia.ListarOrdenesCompra();
        }
        #endregion
    }
}
