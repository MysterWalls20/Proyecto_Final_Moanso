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
    public class Datos_Color
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly Datos_Color _instancia = new Datos_Color();
        //privado para evitar la instanciación directa
        public static Datos_Color Instancia
        {
            get
            {
                return Datos_Color._instancia;
            }
        }
        #endregion singleton


        #region metodo

        //Listar
        public List<Entidad_Color> ListarColor()
        {
            SqlCommand cmd = null;
            List<Entidad_Color> lista = new List<Entidad_Color>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaColor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Entidad_Color Col = new Entidad_Color();
                    Col.IdColor = Convert.ToInt32(dr["id_Color"]);
                    Col.color = dr["color"].ToString();
                    Col.Estado = Convert.ToBoolean(dr["estado"]);
                    lista.Add(Col);
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

        //Registrar
        public Boolean InsertarColor(Entidad_Color Col)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaColor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Color", Col.color);
                cmd.Parameters.AddWithValue("@Estado", Col.Estado);

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

        //Deshabilitar
        public Boolean DeshabilitarColor(Entidad_Color Col)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInhabilitarColor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idColor", Col.IdColor);
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

        //Editar
        public Boolean EditarColor(Entidad_Color Col)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaColor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_Color", Col.IdColor);
                cmd.Parameters.AddWithValue("@Color", Col.color);
                cmd.Parameters.AddWithValue("@estado", Col.Estado);
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

        // Habilitar
        public Boolean HabilitarColor(Entidad_Color Col)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spHabilitarColor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idColor", Col.IdColor);
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
    }
    #endregion
}
