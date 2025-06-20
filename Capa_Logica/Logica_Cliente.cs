﻿using Capa_Datos;
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

        //listado
        public List<Entidad_Cliente> ListarCliente()
        {
            return Datos_Cliente.Instancia.ListarCliente();
        }
        //Busca por dni
        public Entidad_Cliente ObtenerClientePorDni(string dni)
        {
            return Datos_Cliente.Instancia.BuscarClientePorDni(dni);
        }
        ///inserta
        public void InsertaCliente(Entidad_Cliente Cli)
        {
            Datos_Cliente.Instancia.InsertarCliente(Cli);
        }
        ///Edita
        public void EditaCliente(Entidad_Cliente Cli)
        {
            Datos_Cliente.Instancia.EditarCliente(Cli);
        }
        //Deshabilita
        public void DeshabilitarCliente(Entidad_Cliente Cli)
        {
            Datos_Cliente.Instancia.DeshabilitarCliente(Cli);
        }
        #endregion metodos
    }
}

