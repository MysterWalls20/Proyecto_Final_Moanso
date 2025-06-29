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
    public class DDCliente
    {

        public static void RegistrarClienteNatural(EClienteNatural cliente)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("RegistrarClienteNatural", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@apellido", cliente.Apellido);
                cmd.Parameters.AddWithValue("@dni", cliente.Dni);
                cmd.Parameters.AddWithValue("@direccion", cliente.Direccion);
                cmd.Parameters.AddWithValue("@idDistrito", cliente.IdDistrito);
                cmd.ExecuteNonQuery();
            }
        }

        public static void RegistrarClienteJuridico(EClienteJuridico cliente)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("RegistrarClienteJuridico", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@razon_social", cliente.RazonSocial);
                cmd.Parameters.AddWithValue("@ruc", cliente.Ruc);
                cmd.Parameters.AddWithValue("@direccion", cliente.Direccion);
                cmd.Parameters.AddWithValue("@idDistrito", cliente.IdDistrito);
                cmd.ExecuteNonQuery();
            }
        }


    }
}
