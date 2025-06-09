using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class Datos_Cliente
    {
        public DataTable Listadocl(string cTexto)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand command = new SqlCommand("USP_Listado_Cliente", sqlcon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@cTexto", SqlDbType.VarChar).Value = cTexto;
                sqlcon.Open();
                resultado = command.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
        }

        public string Guardar_cl(int nOpcion, Entidad_Cliente eCl)
        {
            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand command = new SqlCommand("USP_Guardado_Cliente", sqlcon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion;
                command.Parameters.Add("@nId", SqlDbType.Int).Value = eCl.id;
                command.Parameters.Add("@nNombre", SqlDbType.VarChar).Value = eCl.nombre;
                command.Parameters.Add("@nApellido", SqlDbType.VarChar).Value = eCl.apellido;
                command.Parameters.Add("@nNumero", SqlDbType.Int).Value = eCl.numero;
                command.Parameters.Add("@nDNI", SqlDbType.VarChar).Value = eCl.dni;

                command.Parameters.AddWithValue("@nFechaRegistro", eCl.fecha_registro); // ✅ sin .ToString()

                //command.Parameters.Add("@nFechaRegistro", SqlDbType.VarChar).Value = eCl.fecha_registro;
                sqlcon.Open();
                rpta = command.ExecuteNonQuery() == 1 ? "Vale" : "No se pudo registrar los datos";
            }
            catch (Exception ex)
            {

                rpta = ex.Message;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
            return rpta;
        }

        public string Eliminar_cl(int codigo_ca)
        {
            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand command = new SqlCommand("USP_Eliminar_Cliente", sqlcon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@nId", SqlDbType.Int).Value = codigo_ca;
                sqlcon.Open();
                rpta = command.ExecuteNonQuery() == 1 ? "Vale" : "No se pudo eliminar los datos";
            }
            catch (Exception ex)
            {

                rpta = ex.Message;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
            return rpta;
        }
    }
}
