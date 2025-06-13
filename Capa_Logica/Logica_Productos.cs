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

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly Logica_Productos _instancia = new Logica_Productos();
        //privado para evitar la instanciación directa
        public static Logica_Productos Instancia
        {
            get
            {
                return Logica_Productos._instancia;
            }
        }
        #endregion singleton


        #region metodos

        //listado

        public List<Entidad_Productos> ListarProductos()
        {
            return Datos_Productos.Instancia.ListarProductos();
        }
        //inserta
        public void InsertaProducto(Entidad_Productos Pro)
        {
            Datos_Productos.Instancia.InsertarProductos(Pro);
        }

        //edita
        public void EditaProducto(Entidad_Productos Pro)
        {
            Datos_Productos.Instancia.EditarProductos(Pro);
        }
        public void DeshabilitarProducto(Entidad_Productos Pro)
        {
            Datos_Productos.Instancia.DeshabilitarProductos(Pro);
        }
        #endregion metodos

    }
}
