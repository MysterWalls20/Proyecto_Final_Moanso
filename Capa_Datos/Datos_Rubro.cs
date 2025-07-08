using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class Datos_Rubro
    {
        #region Singleton
        private static readonly Datos_Rubro _instancia = new Datos_Rubro();
        public static Datos_Rubro Instancia
        {
            get { return _instancia; }
        }
        #endregion

        #region Métodos

        //Listar
        public List<Entidad_rubro> ListarRubro()
        {
            SqlCommand cmd = null;
            List<Entidad_rubro> lista = new List<Entidad_rubro>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaRubroActivo", cn);
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Entidad_rubro r = new Entidad_rubro
                    {
                        id_rubro = Convert.ToInt32(dr["id_rubro"]),
                        rubro = dr["Rubro"].ToString(),
                        estado = Convert.ToBoolean(dr["estado"])
                    };
                    lista.Add(r);
                }

                dr.Close();
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

        //Insertar
        public Boolean InsertarRubro(Entidad_rubro Rub) 
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaRubro", cn);  
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@rubro", Rub.rubro);   
                cmd.Parameters.AddWithValue("@Estado", Rub.estado);  

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
        public Boolean DeshabilitarRubro(Entidad_rubro rub) 
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInhabilitarRubro", cn); 
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idRubro", rub.id_rubro); 
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
        public Boolean EditarRubro(Entidad_rubro rub) 
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaRubro", cn);  
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idRubro", rub.id_rubro); 
                cmd.Parameters.AddWithValue("@rubro", rub.rubro);   
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

        //Habilitar
        public Boolean HabilitarRubro(Entidad_rubro rub)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInhabilitarRubro", cn); 
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idRubro", rub.id_rubro);
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

        //Buscar por id
        public Entidad_rubro BuscarRubroPorID(int idRubro)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            Entidad_rubro Rub = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarRubro", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idRubro", idRubro);
                cn.Open();

                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Rub = new Entidad_rubro();
                    Rub.id_rubro = Convert.ToInt32(dr["id_rubro"]);
                    Rub.rubro = dr["rubro"].ToString();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null) cmd.Connection.Close();
            }

            return Rub;
        }

        //Mostrar inhabilitado
        public List<Entidad_rubro> ListarInactivosRubro()
        {
            SqlCommand cmd = null;
            List<Entidad_rubro> lista = new List<Entidad_rubro>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaRubroInactivo", cn);
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Entidad_rubro r = new Entidad_rubro
                    {
                        id_rubro = Convert.ToInt32(dr["id_rubro"]),
                        rubro = dr["Rubro"].ToString(),
                        estado = Convert.ToBoolean(dr["estado"])
                    };
                    lista.Add(r);
                }

                dr.Close();
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
        #endregion
    }
}
