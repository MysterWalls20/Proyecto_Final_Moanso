using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class Logica_Rubro
    {
        #region Singleton
        private static readonly Logica_Rubro _instancia = new Logica_Rubro();
        public static Logica_Rubro Instancia
        {
            get { return _instancia; }
        }
        #endregion

        #region Métodos

        public List<Entidad_rubro> ListarRubro()
        {
            return Datos_Rubro.Instancia.ListarRubro();
        }

        #endregion
    }
}
