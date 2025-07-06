using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class Logica_Cliente
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly Logica_Cliente _instancia = new Logica_Cliente();
        //privado para evitar la instanciación directa
        public static Logica_Cliente Instancia
        {
            get
            {
                return Logica_Cliente._instancia;
            }
        }
        #endregion singleton

        #region metodos

        // Nuevo cliente natural
        public void RegistrarClienteNatural(Entidad_Cliente cliente,
                                            int idDepartamento,
                                            int idProvincia,
                                            int idDistrito,
                                            int id_tipo_cliente)
        {
            Datos_Cliente.Instancia.RegistrarClienteNatural(cliente,
                                                            idDepartamento,
                                                            idProvincia,
                                                            idDistrito,
                                                            id_tipo_cliente
            );
        }

        // Nuevo cliente juridico
        public void RegistrarClienteJuridico(Entidad_Cliente cliente,
                                     int idDepartamento,
                                     int idProvincia,
                                     int idDistrito,
                                     int id_tipo_cliente)
        {
            Datos_Cliente.Instancia.RegistrarClienteJuridico(cliente,
                                                             idDepartamento,
                                                             idProvincia,
                                                             idDistrito,
                                                             id_tipo_cliente
            );
        }

        // Listar clientes activos
        public DataTable ListarClientesActivos()
        {
            return Datos_Cliente.Instancia.ListarClientesActivos();
        }
        //Listar clientes inactivos
        public DataTable ListarClientesInactivos()
        {
            return Datos_Cliente.Instancia.ListarClientesInactivos();
        }
        // Deshabilitar cliente
        public void DeshabilitarCliente(int idCliente)
        {
            Datos_Cliente.Instancia.DeshabilitarCliente(idCliente);
        }
        // Habilitar cliente
        public void HabilitarCliente(int idCliente)
        {
            Datos_Cliente.Instancia.HabilitarCliente(idCliente);
        }
        #endregion metodos
    }
}

