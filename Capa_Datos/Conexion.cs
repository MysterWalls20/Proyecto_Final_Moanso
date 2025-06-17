using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool Seguridad;

        private Conexion()
        {

            this.Base = "BD_Compania_Rubio";
            this.Servidor = "USER"; //Poner el nombre de tu servidor sql
            this.Usuario = "sa";
            this.Clave = "clavedelSA";
            this.Seguridad = false;
        }

        //patron de Diseño Singleton
        private static readonly Conexion _instancia = new Conexion();
        public static Conexion Instancia
        {
            get { return Conexion._instancia; }
        }

        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection();

            if (this.Seguridad)
            {
                // Autenticación de Windows
                cn.ConnectionString = $"Data Source={this.Servidor}; Initial Catalog={this.Base}; Integrated Security=True";
            }
            else
            {
                // Autenticación de SQL Server
                cn.ConnectionString = $"Data Source={this.Servidor}; Initial Catalog={this.Base}; User ID={this.Usuario}; Password={this.Clave}";
            }

            return cn;
        }

    } 
}
