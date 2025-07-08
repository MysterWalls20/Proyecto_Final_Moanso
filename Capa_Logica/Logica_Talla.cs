using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class Logica_Talla
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly Logica_Talla _instancia = new Logica_Talla();
        //privado para evitar la instanciación directa
        public static Logica_Talla Instancia
        {
            get
            {
                return Logica_Talla._instancia;
            }
        }
        #endregion singleton

        #region metodo

        //listado
        public List<Entidad_Talla> ListarTalla()
        {
            return Datos_Talla.Instancia.ListarTalla();
        }

        //Registrar
        public void InsertarTalla(Entidad_Talla Tal)
        {
            Datos_Talla.Instancia.InsertarTalla(Tal);
        }

        //Deshabilitar
        public void DeshabilitarTalla(Entidad_Talla Tal)
        {
            Datos_Talla.Instancia.DeshabilitarTalla(Tal);
        }

        //Editar
        public void EditarTalla(Entidad_Talla Tal)
        {
            Datos_Talla.Instancia.EditarTalla(Tal);
        }

        //Habilitar
        public void HabilitarTalla(Entidad_Talla Tal)
        {
            Datos_Talla.Instancia.HabilitarTalla(Tal);
        }
        #endregion
    }
}
