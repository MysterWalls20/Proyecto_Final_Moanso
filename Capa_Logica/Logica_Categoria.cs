using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class Logica_Categoria
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly Logica_Categoria _instancia = new Logica_Categoria();
        //privado para evitar la instanciación directa
        public static Logica_Categoria Instancia
        {
            get
            {
                return Logica_Categoria._instancia;
            }
        }
        #endregion singleton

        #region metodo

        //listado
        public List<Entidad_Categoria> ListarCategoria()
        {
            return Datos_Categoria.Instancia.ListarCategoria();
        }

        //Registrar
        public void InsertarCategoria(Entidad_Categoria Cat)
        {
            Datos_Categoria.Instancia.InsertarCategoria(Cat);
        }

        //Deshabilitar
        public void DeshabilitarCategoria(Entidad_Categoria Cat)
        {
            Datos_Categoria.Instancia.DeshabilitarCategoria(Cat);
        }

        //Editar
        public void EditarCategoria(Entidad_Categoria Cat)
        {
            Datos_Categoria.Instancia.EditarCategoria(Cat);
        }

        //Habilita
        public void HabilitarCategoria(Entidad_Categoria Cat)
        {
            Datos_Categoria.Instancia.HabilitarCategoria(Cat);
        }
        //Buscar
        public Entidad_Categoria BuscarCategoriaPorID(int id)
        {
            return Datos_Categoria.Instancia.BuscarCategoriaPorID(id);
        }
        #endregion
    }
}
