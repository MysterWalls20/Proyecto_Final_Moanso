using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Capa_Datos
{
    public class Datos_Empleado
    {
        // Singleton
        private static readonly Datos_Empleado _instancia = new Datos_Empleado();
        public static Datos_Empleado Instancia => _instancia;

        public bool Login(Entidad_Empleado empleado)
        {
            SqlConnection cn = null;
            bool existe = false;

            try
            {
                cn = Conexion.Instancia.Conectar();
                SqlCommand cmd = new SqlCommand("sp_Login_Empleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@usuario", empleado.usuario);
                cmd.Parameters.AddWithValue("@contrasena", empleado.contrasena);

                cn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                existe = count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar sp_Login_Empleado: " + ex.Message);
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                    cn.Close();
            }

            return existe;
        }
    }
}
