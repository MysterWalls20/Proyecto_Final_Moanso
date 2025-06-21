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
        private static readonly Datos_Ubigeo _instancia = new Datos_Ubigeo();
        public static Datos_Ubigeo Instancia => _instancia;
        // Obtener Departamentos
        public List<Entidad_Departamento> ObtenerDepartamentos()
        {
            List<Entidad_Departamento> lista = new List<Entidad_Departamento>();
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("SELECT idDepartamento, departamento FROM Departamentos", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Entidad_Departamento
                    {
                        IdDepartamento = Convert.ToInt32(dr["idDepartamento"]),
                        NombreDepartamento = dr["departamento"].ToString()
                    });
                }
            }
            return lista;
        }
        // Obtener Provincias por departamento
        public List<Entidad_Provincia> ObtenerProvinciasPorDepartamento(int idDepartamento)
        {
            List<Entidad_Provincia> lista = new List<Entidad_Provincia>();
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("SELECT idProvincia, provincia FROM Provincia WHERE idDepart = @id", cn);
                cmd.Parameters.AddWithValue("@id", idDepartamento);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Entidad_Provincia
                    {
                        IdProvincia = Convert.ToInt32(dr["idProvincia"]),
                        NombreProvincia = dr["provincia"].ToString(),
                        IdDepart = idDepartamento
                    });
                }
            }
            return lista;
        }
        public List<Entidad_Distrito> ObtenerDistritosPorProvincia(int idProvincia)
        {
            List<Entidad_Distrito> lista = new List<Entidad_Distrito>();
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("SELECT idDistrito, distrito FROM Distrito WHERE idProvin = @id", cn);
                cmd.Parameters.AddWithValue("@id", idProvincia);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Entidad_Distrito
                    {
                        IdDistrito = Convert.ToInt32(dr["idDistrito"]),
                        NombreDistrito = dr["distrito"].ToString(),
                        IdProvincia = idProvincia
                    });
                }
            }
            return lista;
        }
    }
}
