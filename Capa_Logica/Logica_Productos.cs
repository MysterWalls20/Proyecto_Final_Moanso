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
        //Buscar por categoria
        public List<Entidad_Productos> BuscarProductoPorCategoria(int idCategoria)
        {
            return Datos_Productos.Instancia.BuscarProductoPorCategoria(idCategoria);
        }

        //Buscar por ID
        public Entidad_Productos ObtenerProductoPorId(int id)
        {
            return Datos_Productos.Instancia.ObtenerProductoPorId(id);
        }

        //Buscar por nombre
        public List<Entidad_Productos> BuscarProductoPorNombre(string nombre)
        {
            return Datos_Productos.Instancia.BuscarProductoPorNombre(nombre);
        }

        // Llenar Categorías
        public List<KeyValuePair<int, string>> ObtenerCategorias()
        {
            return Datos_Productos.Instancia.ObtenerCategorias();
        }

        // Llenar Marca
        public List<KeyValuePair<int, string>> ObtenerMarca()
        {
            return Datos_Productos.Instancia.ObtenerMarca();
        }

        // Llenar Talla
        public List<KeyValuePair<int, string>> ObtenerTalla()
        {
            return Datos_Productos.Instancia.ObtenerTalla();
        }

        // Llenar Colores
        public List<KeyValuePair<int, string>> ObtenerColores()
        {
            return Datos_Productos.Instancia.ObtenerColores();
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
        //deshabilita
        public void DeshabilitarProducto(Entidad_Productos Pro)
        {
            Datos_Productos.Instancia.DeshabilitarProductos(Pro);
        }

        //habilita
        public void HabilitarProducto(Entidad_Productos Pro)
        {
            Datos_Productos.Instancia.HabilitarProductos(Pro);
        }

        //Listar cliente no activado
        public List<Entidad_Productos> ListarProductosNoListado()
        {
            return Datos_Productos.Instancia.ListarProductosNoListado();
        }

        public Entidad_Productos BuscarProductoPorID(int idProducto)
        {
            return Datos_Productos.Instancia.BuscarProductoPorID(idProducto);
        }
        #endregion metodos
    }
}
