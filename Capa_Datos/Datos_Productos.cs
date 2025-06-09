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
    public class Datos_Productos
    {
        public DataTable ListadoPR (string cTexto)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand command = new SqlCommand("USP_Listado_Productos", sqlcon);
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

        public string Guardar_pr(int nOpcion, Entidad_Productos ePr)
        {
            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand command = new SqlCommand("usp_GuardarProducto", sqlcon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion;
                command.Parameters.Add("@nId", SqlDbType.Int).Value = ePr.id;
                command.Parameters.Add("cNombre", SqlDbType.VarChar).Value = ePr.nombre;
                command.Parameters.Add("cMarca", SqlDbType.VarChar).Value = ePr.marca;
                command.Parameters.Add("cColor", SqlDbType.VarChar).Value = ePr.color;
                command.Parameters.Add("nStock", SqlDbType.Int).Value = ePr.stock;
                command.Parameters.Add("cCategoria", SqlDbType.VarChar).Value = ePr.categoria;
                command.Parameters.Add("nPrecio", SqlDbType.Decimal).Value = ePr.precio_unidad;
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

        public string Eliminar_pr(int codigo_ca)
        {
            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand command = new SqlCommand("usp_EliminarProducto", sqlcon);
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

