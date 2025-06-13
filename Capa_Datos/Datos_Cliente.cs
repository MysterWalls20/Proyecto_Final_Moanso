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
        //listado de Clientes
        public List<Entidad_Cliente> ListarCliente()
        {
            SqlCommand cmd = null;
            List<Entidad_Cliente> lista = new List<Entidad_Cliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Entidad_Cliente Cli = new Entidad_Cliente();
                    Cli.id = Convert.ToInt32(dr["id"]);
                    Cli.nombre = dr["nombre"].ToString();
                    Cli.apellido = dr["apellido"].ToString();
                    Cli.numero = Convert.ToInt32(dr["numero"]);
                    Cli.dni = dr["dni"].ToString();
                    Cli.fecha_registro = Convert.ToDateTime(dr["fecha_registro"]);
                    lista.Add(Cli);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        //InsertaCliente
        public Boolean InsertarCliente(Entidad_Cliente Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@cNombre", SqlDbType.VarChar).Value = Cli.nombre;
                cmd.Parameters.AddWithValue("@cApellido", SqlDbType.VarChar).Value = Cli.apellido;
                cmd.Parameters.AddWithValue("@cNumero", SqlDbType.Int).Value = Cli.numero;
                cmd.Parameters.AddWithValue("@cDNI", SqlDbType.VarChar).Value = Cli.dni;
                cmd.Parameters.AddWithValue("@cFechaRegistro", Cli.fecha_registro);
                cmd.Parameters.AddWithValue("@cEstado", Cli.estado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }


        //EditaCliente
        public Boolean EditarCliente(Entidad_Cliente Cli)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cId", SqlDbType.Int).Value = Cli.id;
                cmd.Parameters.AddWithValue("@cNombre", SqlDbType.VarChar).Value = Cli.nombre;
                cmd.Parameters.AddWithValue("@cApellido", SqlDbType.VarChar).Value = Cli.apellido;
                cmd.Parameters.AddWithValue("@cNumero", SqlDbType.Int).Value = Cli.numero;
                cmd.Parameters.AddWithValue("@cDNI", SqlDbType.VarChar).Value = Cli.dni;
                cmd.Parameters.AddWithValue("@cFechaRegistro", Cli.fecha_registro);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }

        //deshabilitaCliente
        public Boolean DeshabilitarCliente(Entidad_Cliente Cli)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cId", Cli.id);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return delete;
        }

        #endregion metodos

    }
}
