using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class Logica_Color
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly Logica_Color _instancia = new Logica_Color();
        //privado para evitar la instanciación directa
        public static Logica_Color Instancia
        {
            get
            {
                return Logica_Color._instancia;
            }
        }
        #endregion singleton

        #region metodo

        //listado
        public List<Entidad_Color> ListarColor()
        {
            return Datos_Color.Instancia.ListarColor();
        }

        //Registrar
        public void InsertarColor(Entidad_Color Col)
        {
            Datos_Color.Instancia.InsertarColor(Col);
        }

        //Deshabilitar
        public void DeshabilitarColor(Entidad_Color Col)
        {
            Datos_Color.Instancia.DeshabilitarColor(Col);
        }

        //Editar
        public void EditarColor(Entidad_Color Col)
        {
            Datos_Color.Instancia.EditarColor(Col);
        }

        //Habilita
        public void HabilitarColor(Entidad_Color Col)
        {
            Datos_Color.Instancia.HabilitarColor(Col);
        }

        #endregion
    }
}
