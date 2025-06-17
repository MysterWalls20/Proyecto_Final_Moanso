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

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly Datos_Productos _instancia = new Datos_Productos();
        //privado para evitar la instanciación directa
        public static Datos_Productos Instancia
        {
            get
            {
                return Datos_Productos._instancia;
            }
        }
        #endregion singleton

        #region metodos
        //listado de todos los Productos
        public List<Entidad_Productos> ListarProductos()
        {
            SqlCommand cmd = null;
            List<Entidad_Productos> lista = new List<Entidad_Productos>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Entidad_Productos Pro = new Entidad_Productos();

                    Pro.id = Convert.ToInt32(dr["id"]);
                    Pro.nombre = dr["nombre"].ToString();
                    Pro.marca = dr["marca"].ToString();
                    Pro.color = dr["color"].ToString();
                    Pro.stock = Convert.ToInt32(dr["stock"]);
                    Pro.categoria = dr["categoria"].ToString();
                    Pro.precio_unidad = Convert.ToDouble(dr["precio_unidad"]);
                    lista.Add(Pro);
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

        //listado de los Productos por categoria
        public List<Entidad_Productos> ListarProductosPorCategoria(string categoria)
        {
            SqlCommand cmd = null;
            List<Entidad_Productos> lista = new List<Entidad_Productos>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_ListarProductosPorCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Categoria", categoria);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Entidad_Productos pro = new Entidad_Productos
                    {
                        id = Convert.ToInt32(dr["id"]),
                        nombre = dr["nombre"].ToString(),
                        marca = dr["marca"].ToString(),
                        color = dr["color"].ToString(),
                        stock = Convert.ToInt32(dr["stock"]),
                        categoria = dr["categoria"].ToString(),
                        precio_unidad = Convert.ToDouble(dr["precio_unidad"])
                    };
                    lista.Add(pro);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        //Buscar producto por ID
        public Entidad_Productos BuscarProductoPorID(int id)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            Entidad_Productos pr = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_BuscarProductoPorID", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);

                cn.Open();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    pr = new Entidad_Productos()
                    {
                        id = Convert.ToInt32(dr["id"]),
                        nombre = dr["nombre"].ToString(),
                        marca = dr["marca"].ToString(),
                        color = dr["color"].ToString(),
                        stock = Convert.ToInt32(dr["stock"]),
                        categoria = dr["categoria"].ToString(),
                        precio_unidad = Convert.ToDouble(dr["precio_unidad"])
                    };
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dr != null) dr.Close();
                if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();
            }

            return pr;
        }
        // Llenar Combobox de categorias
        public List<string> ObtenerCategorias()
        {
            List<string> lista = new List<string>();

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    SqlCommand cmd = new SqlCommand("sp_ObtenerCategorias", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        lista.Add(dr["categoriaPr"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener categorías: " + ex.Message);
            }

            return lista;
        }
        // Llenar Combobox de colores
        public List<string> ObtenerColores()
        {
            List<string> lista = new List<string>();

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("SELECT colorPr FROM ColoresPr ORDER BY id", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(dr["colorPr"].ToString());
                }
            }

            return lista;
        }
        //Insertar producto
        public Boolean InsertarProductos(Entidad_Productos Pro)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaProductos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pNombre", SqlDbType.VarChar).Value = Pro.nombre;
                cmd.Parameters.AddWithValue("@pMarca", SqlDbType.VarChar).Value = Pro.marca;
                cmd.Parameters.AddWithValue("@pColor", SqlDbType.VarChar).Value = Pro.color;
                cmd.Parameters.AddWithValue("@pStock", SqlDbType.Int).Value = Pro.stock;
                cmd.Parameters.AddWithValue("@pCategoria", SqlDbType.VarChar).Value = Pro.categoria;
                cmd.Parameters.AddWithValue("@pPrecio", SqlDbType.Decimal).Value = Pro.precio_unidad;
                cmd.Parameters.AddWithValue("@pEstado", Pro.estado);
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

        //Edita Producto
        public Boolean EditarProductos(Entidad_Productos Pro)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaProductos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pId", SqlDbType.Int).Value = Pro.id;
                cmd.Parameters.AddWithValue("@pNombre", SqlDbType.VarChar).Value = Pro.nombre;
                cmd.Parameters.AddWithValue("@pMarca", SqlDbType.VarChar).Value = Pro.marca;
                cmd.Parameters.AddWithValue("@pColor", SqlDbType.VarChar).Value = Pro.color;
                cmd.Parameters.AddWithValue("@pStock", SqlDbType.Int).Value = Pro.stock;
                cmd.Parameters.AddWithValue("@pCategoria", SqlDbType.VarChar).Value = Pro.categoria;
                cmd.Parameters.AddWithValue("@pPrecio", SqlDbType.Decimal).Value = Pro.precio_unidad;
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

        //deshabilita Productos

        public Boolean DeshabilitarProductos(Entidad_Productos Pro)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaProductos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pId", Pro.id);
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

