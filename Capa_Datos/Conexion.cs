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
        // Singleton
        private static readonly Conexion _instancia = new Conexion();
        public static Conexion Instancia
        {
            get { return _instancia; }
        }

        // Cadena de conexión unificada
        private string cadenaConexion = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BD_Compania_Rubio;Data Source=USER";

        // Método para obtener la conexión (cerrada)
        public SqlConnection Conectar()
        {
            return new SqlConnection(cadenaConexion);
        }
    } 
}
