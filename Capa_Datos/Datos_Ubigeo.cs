using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Capa_Entidad.Entidad_Ubigeo;

namespace Capa_Datos
{
    public class Datos_Ubigeo
    {
        #region singleton
        private static readonly Datos_Ubigeo _instancia = new Datos_Ubigeo();
        public static Datos_Ubigeo Instancia => _instancia;
        #endregion singleton

        #region metodos

        // Listar Departamentos
        public List<Entidad_Ubigeo.Entidad_Departamento> ListarDepartamentos()
        {
            var lista = new List<Entidad_Ubigeo.Entidad_Departamento>();
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("sp_ListarDepartamentos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Entidad_Ubigeo.Entidad_Departamento
                    {
                        IdDepartamento = Convert.ToInt32(dr["idDepartamento"]),
                        NombreDepartamento = dr["departamento"].ToString()
                    });
                }
            }
            return lista;
        }

        // Listar Provincias
        public List<Entidad_Ubigeo.Entidad_Provincia> ListarProvinciasPorDepartamento(int idDepartamento)
        {
            var lista = new List<Entidad_Ubigeo.Entidad_Provincia>();
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("sp_ListarProvinciasPorDepartamento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idDepartamento", idDepartamento);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Entidad_Ubigeo.Entidad_Provincia
                    {
                        IdProvincia = Convert.ToInt32(dr["idProvincia"]),
                        NombreProvincia = dr["provincia"].ToString(),
                        IdDepartamento = idDepartamento
                    });
                }
            }
            return lista;
        }

        // Listar Distritos
        public List<Entidad_Ubigeo.Entidad_Distrito> ListarDistritosPorProvincia(int idProvincia)
        {
            var lista = new List<Entidad_Ubigeo.Entidad_Distrito>();
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("sp_ListarDistritosPorProvincia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProvincia", idProvincia);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Entidad_Ubigeo.Entidad_Distrito
                    {
                        IdDistrito = Convert.ToInt32(dr["idDistrito"]),
                        NombreDistrito = dr["distrito"].ToString(),
                        IdProvincia = idProvincia
                    });
                }
            }
            return lista;
        }

        // Obtener ID de Ubigeo
        public int ObtenerIdUbigeo(int idDepartamento, int idProvincia, int idDistrito)
        {
            int idUbigeo = 0;
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerIdUbigeo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idDepartamento", idDepartamento);
                cmd.Parameters.AddWithValue("@idProvincia", idProvincia);
                cmd.Parameters.AddWithValue("@idDistrito", idDistrito);
                cn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                    idUbigeo = Convert.ToInt32(result);
            }
            return idUbigeo;
        }

        #endregion metodos
    }
}
