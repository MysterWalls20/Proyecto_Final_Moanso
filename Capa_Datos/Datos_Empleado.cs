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
