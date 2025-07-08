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

        //Listar
        public List<Entidad_rubro> ListarRubro()
        {
            return Datos_Rubro.Instancia.ListarRubro();
        }

        //Registrar
        public void InsertarRubro(Entidad_rubro rub)
        {
            Datos_Rubro.Instancia.InsertarRubro(rub);
        }

        //Deshabilitar
        public void DeshabilitarRubro(Entidad_rubro rub)
        {
            Datos_Rubro.Instancia.DeshabilitarRubro(rub);
        }

        //Editar
        public void EditarRubro(Entidad_rubro rub)
        {
            Datos_Rubro.Instancia.EditarRubro(rub);
        }

        //Habilitar
        public void HabilitarRubro(Entidad_rubro rub)
        {
            Datos_Rubro.Instancia.HabilitarRubro(rub);
        }

        //Mostrar lista inactivo
        public List<Entidad_rubro> ListarInactivosRubro()
        {
            return Datos_Rubro.Instancia.ListarInactivosRubro();
        }

        //Buscar Rubro
        public Entidad_rubro BuscarRubroPorID(int idRubro)
        {
            return Datos_Rubro.Instancia.BuscarRubroPorID(idRubro);
        }
        #endregion
    }
}
