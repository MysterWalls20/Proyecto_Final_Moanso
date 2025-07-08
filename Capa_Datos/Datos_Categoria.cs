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
    public class Datos_Categoria
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly Datos_Categoria _instancia = new Datos_Categoria();
        //privado para evitar la instanciación directa
        public static Datos_Categoria Instancia
        {
            get
            {
                return Datos_Categoria._instancia;
            }
        }
        #endregion singleton


        #region metodo

        //Listar
        public List<Entidad_Categoria> ListarCategoria()
        {
            SqlCommand cmd = null;
            List<Entidad_Categoria> lista = new List<Entidad_Categoria>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Entidad_Categoria Cat = new Entidad_Categoria();
                    Cat.IdCategoria = Convert.ToInt32(dr["id_Categoria"]);
                    Cat.categoria = dr["categoria"].ToString();
                    Cat.Estado = Convert.ToBoolean(dr["estado"]);
                    lista.Add(Cat);
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
        public Boolean InsertarCategoria(Entidad_Categoria Cat)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Categoria", Cat.categoria);
                cmd.Parameters.AddWithValue("@Estado", Cat.Estado);

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
        public Boolean DeshabilitarCategoria(Entidad_Categoria Cat)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInhabilitarCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCategoria", Cat.IdCategoria);
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

        // Editar
        public Boolean EditarCategoria(Entidad_Categoria Cat)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_categoria", Cat.IdCategoria);
                cmd.Parameters.AddWithValue("@categoria", Cat.categoria);
                cmd.Parameters.AddWithValue("@estado", Cat.Estado);
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
        public Boolean HabilitarCategoria(Entidad_Categoria Cat)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spHabilitarCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCategoria", Cat.IdCategoria);
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

        // Buscar por Id
        public Entidad_Categoria BuscarCategoriaPorID(int id)
        {
            SqlCommand cmd = null;
            Entidad_Categoria cat = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_Categoria", id);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    cat = new Entidad_Categoria();
                    cat.IdCategoria = Convert.ToInt32(dr["id_Categoria"]);
                    cat.categoria = dr["categoria"].ToString();
                    cat.Estado = Convert.ToBoolean(dr["estado"]);

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
            return cat;
        }
        #endregion
    }
}
