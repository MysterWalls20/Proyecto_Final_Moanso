using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;

namespace Capa_Datos
{
    public class Datos_PedidosTemp
    {
        public List<Entidad_PedidoSeguimiento> ListarPedidosParaSeguimiento()
        {
            var lista = new List<Entidad_PedidoSeguimiento>();

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("sp_ListarPedidosTemp_Seguimiento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Entidad_PedidoSeguimiento
                    {
                        IdPedido = Convert.ToInt32(dr["PedidoID"]),
                        Cliente = dr["Cliente"].ToString(),
                        Direccion = dr["direccionEntrega"].ToString(),
                        Almacen = dr["Almacen1"] + "\n" + dr["Almacen2"], // Salto de línea
                        Repartidor = dr["Repartidor"].ToString(),
                        Estado = dr["estadoEnvio"].ToString()
                    });
                }
            }

            return lista;
        }

    }
}
