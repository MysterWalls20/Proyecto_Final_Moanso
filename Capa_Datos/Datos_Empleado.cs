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
        public bool VerificarLogin(Capa_Entidad.Entidad_Empleado login)
        {
            bool existe = false;

            try
            {
                // Aquí se crea la conexión usando tu clase Conexion
                using (SqlConnection cn = Conexion.getInstancia().CrearConexion())
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_VerificarLogin", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@usuario", login.usuario);
                        cmd.Parameters.AddWithValue("@contraseña", login.contrasena);

                        object result = cmd.ExecuteScalar();
                        int count = Convert.ToInt32(result);

                        existe = count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar el login: " + ex.Message);
            }

            return existe;
        }
    }
}
