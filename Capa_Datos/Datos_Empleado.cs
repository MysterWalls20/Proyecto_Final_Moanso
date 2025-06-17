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

        public bool VerificarLogin(string usuario, string contraseña)
        {
            bool loginCorrecto = false;

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_VerificarLogin", cn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@contraseña", contraseña);

                        cn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        loginCorrecto = dr.HasRows; // True si encontró algún resultado
                        dr.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar el login: " + ex.Message);
            }

            return loginCorrecto;
        }

        public DataTable ObtenerEmpleadosPorRol(string rol)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerEmpleadosPorRol", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Rol", rol);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                da.Fill(tabla);
                return tabla;
            }
        }
        public bool CambiarDisponibilidad(int idEmpleado, bool disponible)
        {
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    SqlCommand cmd = new SqlCommand("sp_CambiarDisponibilidadEmp", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
                    cmd.Parameters.AddWithValue("@Disponible", disponible ? 1 : 0);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cambiar disponibilidad del empleado: " + ex.Message);
            }
        }

        public List<string> ObtenerRoles()
        {
            List<string> roles = new List<string>();

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("SELECT RolEmp FROM Roles ORDER BY id", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    roles.Add(dr["RolEmp"].ToString());
                }
            }

            return roles;
        }

    }
}
