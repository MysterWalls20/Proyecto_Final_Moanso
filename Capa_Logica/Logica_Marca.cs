using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class Logica_Marca
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly Logica_Marca _instancia = new Logica_Marca();
        //privado para evitar la instanciación directa
        public static Logica_Marca Instancia
        {
            get
            {
                return Logica_Marca._instancia;
            }
        }
        #endregion singleton

        #region metodo

        //listado
        public List<Entidad_Marca> ListarMarca()
        {
            return Datos_Marca.Instancia.ListarMarca();
        }

        //Registrar
        public void InsertarMarca(Entidad_Marca Mar)
        {
            Datos_Marca.Instancia.InsertarMarca(Mar);
        }

        //Deshabilitar
        public void DeshabilitarMarca(Entidad_Marca Mar)
        {
            Datos_Marca.Instancia.DeshabilitarMarca(Mar);
        }

        //Editar
        public void EditarMarca(Entidad_Marca Mar)
        {
            Datos_Marca.Instancia.EditarMarca(Mar);
        }

        //Habilitar
        public void HabilitarMarca(Entidad_Marca Mar)
        {
            Datos_Marca.Instancia.HabilitarMarca(Mar);
        }
        #endregion
    }
}
