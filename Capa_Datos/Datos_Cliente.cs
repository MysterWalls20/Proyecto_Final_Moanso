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

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly Datos_Cliente _instancia = new Datos_Cliente();
        //privado para evitar la instanciación directa
        public static Datos_Cliente Instancia
        {
            get
            {
                return Datos_Cliente._instancia;
            }
        }
        #endregion singleton

        #region metodos

        // Listar Clientes Activos
        public DataTable ListarClientesActivos()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("sp_ListarClientesActivos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
            }
            return tabla;
        }

        // Listar Clientes Inactivos
        public DataTable ListarClientesInactivos()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("sp_ListarClientesInactivos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
            }
            return tabla;
        }

        // Metodo para Registrar Cliente Natural
        public void RegistrarClienteNatural(Entidad_Cliente cliente,
                                            int idDepartamento,
                                            int idProvincia,
                                            int idDistrito,
                                            int id_tipo_cliente)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarClienteNatural", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@direccion", cliente.Direccion);
                cmd.Parameters.AddWithValue("@numero", cliente.Numero);
                cmd.Parameters.AddWithValue("@ruc", cliente.Ruc);
                cmd.Parameters.AddWithValue("@id_tipo_cliente", id_tipo_cliente);
                cmd.Parameters.AddWithValue("@idDepartamento", idDepartamento);
                cmd.Parameters.AddWithValue("@idProvincia", idProvincia);
                cmd.Parameters.AddWithValue("@idDistrito", idDistrito);
                cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@apellido", cliente.Apellido);
                cmd.Parameters.AddWithValue("@dni", cliente.Dni);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Metodo para Registrar Cliente Juridico
        public void RegistrarClienteJuridico(Entidad_Cliente cliente,
                                             int idDepartamento,
                                             int idProvincia,
                                             int idDistrito,
                                             int id_tipo_cliente)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarClienteJuridico", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@direccion", cliente.Direccion);
                cmd.Parameters.AddWithValue("@numero", cliente.Numero);
                cmd.Parameters.AddWithValue("@ruc", cliente.Ruc);
                cmd.Parameters.AddWithValue("@id_tipo_cliente", id_tipo_cliente);
                cmd.Parameters.AddWithValue("@idDepartamento", idDepartamento);
                cmd.Parameters.AddWithValue("@idProvincia", idProvincia);
                cmd.Parameters.AddWithValue("@idDistrito", idDistrito);
                cmd.Parameters.AddWithValue("@razon_social", cliente.RazonSocial);
                cmd.Parameters.AddWithValue("@rubro", cliente.Rubro);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Deshabilitar Cliente
        public void DeshabilitarCliente(int idCliente)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("sp_DeshabilitarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Habilitar Cliente
        public void HabilitarCliente(int idCliente)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("sp_HabilitarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //EditaCliente
        //public Boolean EditarCliente(Entidad_Cliente Cli)
        //{
        //    SqlCommand cmd = null;
        //    Boolean edita = false;
        //    try
        //    {
        //        SqlConnection cn = Conexion.Instancia.Conectar();
        //        cmd = new SqlCommand("spEditaCliente", cn);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@cId", SqlDbType.Int).Value = Cli.id;
        //        cmd.Parameters.AddWithValue("@cNombre", SqlDbType.VarChar).Value = Cli.nombre;
        //        cmd.Parameters.AddWithValue("@cApellido", SqlDbType.VarChar).Value = Cli.apellido;
        //        cmd.Parameters.AddWithValue("@cNumero", SqlDbType.Int).Value = Cli.numero;
        //        cmd.Parameters.AddWithValue("@cDNI", SqlDbType.VarChar).Value = Cli.dni;
        //        cmd.Parameters.AddWithValue("@cFechaRegistro", Cli.fecha_registro);
        //        cn.Open();
        //        int i = cmd.ExecuteNonQuery();
        //        if (i > 0)
        //        {
        //            edita = true;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //    finally { cmd.Connection.Close(); }
        //    return edita;
        //}

        public DataTable BuscarClientePorNombre(string nombre)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                if (cn.State != ConnectionState.Open)
                    cn.Open();

                SqlCommand cmd = new SqlCommand("sp_BuscarClientePorNombre", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", nombre);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
            }

            return tabla;
        }
        #endregion metodos

    }
}
