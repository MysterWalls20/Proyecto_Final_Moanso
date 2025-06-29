using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class Logica_Ciudad
    {
        #region Singleton
        private static readonly Logica_Ciudad _instancia = new Logica_Ciudad();
        public static Logica_Ciudad Instancia
        {
            get { return _instancia; }
        }
        #endregion

        #region Métodos

        public List<Entidad_ciudad> ListarCiudad()
        {
            return Datos_Ciudad.Instancia.ListarCiudad();
        }

        #endregion
    }
}
