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
                SqlConnection cn = Conexion.Instancia.Conectar(); // patrón singleton
                cmd = new SqlCommand("spListarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Entidad_Productos pro = new Entidad_Productos();

                    pro.id = Convert.ToInt32(dr["id_Producto"]);
                    pro.nombre = dr["nombre"].ToString();
                    pro.marca = dr["marca"].ToString();
                    pro.color = dr["color"].ToString();
                    pro.stock = Convert.ToInt32(dr["stock"]);
                    pro.categoria = dr["categoria"].ToString();
                    pro.tallas = dr["talla"].ToString();
                    pro.precio_unidad = Convert.ToDouble(dr["precio_Venta"]);
                    pro.precio_Compra = Convert.ToDouble(dr["precio_Compra"]);
                    pro.fecha_registro = Convert.ToDateTime(dr["fechaRegisto"]);

                    lista.Add(pro);
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

        //Buscar por categoria
        public List<Entidad_Productos> BuscarProductoPorCategoria(int idCategoria)
        {
            SqlCommand cmd = null;
            List<Entidad_Productos> lista = new List<Entidad_Productos>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_BuscarProductoPorCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCategoria", idCategoria);
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Entidad_Productos pro = new Entidad_Productos
                    {
                        id = Convert.ToInt32(dr["id_Producto"]),
                        nombre = dr["nombre"].ToString(),
                        marca = dr["marca"].ToString(),
                        color = dr["color"].ToString(),
                        tallas = dr["talla"].ToString(),
                        categoria = dr["categoria"].ToString(),
                        stock = Convert.ToInt32(dr["stock"]),
                        precio_unidad = Convert.ToDouble(dr["precio_Venta"]),
                        precio_Compra = Convert.ToDouble(dr["precio_Compra"]),
                        fecha_registro = Convert.ToDateTime(dr["fechaRegisto"]),
                        estado = Convert.ToBoolean(dr["estado"])
                    };
                    lista.Add(pro);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }

            return lista;
        }

        //Buscar producto por ID.
        public Entidad_Productos ObtenerProductoPorId(int idProducto)
        {
            SqlCommand cmd = null;
            Entidad_Productos producto = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_ObtenerProductoPorId", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", idProducto);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    producto = new Entidad_Productos
                    {
                        id = Convert.ToInt32(dr["id_Producto"]),
                        nombre = dr["nombre"].ToString(),
                        id_marca = Convert.ToInt32(dr["id_marca"]),
                        id_color = Convert.ToInt32(dr["id_color"]),
                        id_talla = Convert.ToInt32(dr["id_talla"]),
                        id_categoria = Convert.ToInt32(dr["id_categoria"]),
                        stock = Convert.ToInt32(dr["stock"]),
                        precio_unidad = Convert.ToDouble(dr["precio_Venta"]),
                        precio_Compra = Convert.ToDouble(dr["precio_Compra"]),
                        estado = Convert.ToBoolean(dr["estado"])
                    };
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
            return producto;
        }

        //Buscar por nombre
        public List<Entidad_Productos> BuscarProductoPorNombre(string nombre)
        {
            SqlCommand cmd = null;
            List<Entidad_Productos> lista = new List<Entidad_Productos>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_BuscarProductoPorNombre", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Entidad_Productos pro = new Entidad_Productos
                    {
                        id = Convert.ToInt32(dr["id_Producto"]),
                        nombre = dr["nombre"].ToString(),
                        marca = dr["marca"].ToString(),
                        color = dr["color"].ToString(),
                        tallas = dr["talla"].ToString(),
                        categoria = dr["categoria"].ToString(),
                        stock = Convert.ToInt32(dr["stock"]),
                        precio_unidad = Convert.ToDouble(dr["precio_Venta"]),
                        precio_Compra = Convert.ToDouble(dr["precio_Compra"]),
                        fecha_registro = Convert.ToDateTime(dr["fechaRegisto"]),
                        estado = Convert.ToBoolean(dr["estado"])
                    };
                    lista.Add(pro);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }

            return lista;
        }

        // Llenar Combobox de categorias
        public List<KeyValuePair<int, string>> ObtenerCategorias()
        {
            List<KeyValuePair<int, string>> lista = new List<KeyValuePair<int, string>>();

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerCategorias", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr["id_Categoria"]);
                    string nombre = dr["categoria"].ToString();
                    lista.Add(new KeyValuePair<int, string>(id, nombre));
                }
            }
            return lista;
        }

        // Llenar Combobox de colores
        public List<KeyValuePair<int, string>> ObtenerColores()
        {
            List<KeyValuePair<int, string>> lista = new List<KeyValuePair<int, string>>();

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("spObtenerColores", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr["id_Color"]);
                    string nombre = dr["color"].ToString();
                    lista.Add(new KeyValuePair<int, string>(id, nombre));
                }
            }

            return lista;
        }

        // Llenar Combobox de marca
        public List<KeyValuePair<int, string>> ObtenerMarca()
        {
            List<KeyValuePair<int, string>> lista = new List<KeyValuePair<int, string>>();

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerMarca", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr["id_marca"]);
                    string nombre = dr["marca"].ToString();
                    lista.Add(new KeyValuePair<int, string>(id, nombre));
                }
            }
            return lista;
        }

        // Llenar combobox de tallas
        public List<KeyValuePair<int, string>> ObtenerTalla()
        {
            List<KeyValuePair<int, string>> lista = new List<KeyValuePair<int, string>>();

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerTalla", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr["id_talla"]);
                    string nombre = dr["talla"].ToString();
                    lista.Add(new KeyValuePair<int, string>(id, nombre));
                }
            }

            return lista;
        }

        //Insertar producto
        public Boolean InsertarProductos(Entidad_Productos pro)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre", SqlDbType.VarChar).Value = pro.nombre;
                cmd.Parameters.AddWithValue("@id_marca", SqlDbType.Int).Value = pro.id_marca;        // Debes incluir estos ID en la clase o recibirlos desde UI
                cmd.Parameters.AddWithValue("@id_color", SqlDbType.Int).Value = pro.id_color;
                cmd.Parameters.AddWithValue("@id_talla", SqlDbType.Int).Value = pro.id_talla;
                cmd.Parameters.AddWithValue("@id_categoria", SqlDbType.Int).Value = pro.id_categoria;
                cmd.Parameters.AddWithValue("@stock", SqlDbType.Int).Value = pro.stock;
                cmd.Parameters.AddWithValue("@precio_Venta", SqlDbType.Decimal).Value = pro.precio_unidad;
                cmd.Parameters.AddWithValue("@precio_Compra", SqlDbType.Decimal).Value = pro.precio_Compra;




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
        public Boolean EditarProductos(Entidad_Productos pro)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id", SqlDbType.Int).Value = pro.id;
                cmd.Parameters.Add("@pNombre", SqlDbType.VarChar, 100).Value = pro.nombre;
                cmd.Parameters.Add("@pMarca", SqlDbType.Int).Value = pro.id_marca;
                cmd.Parameters.Add("@pColor", SqlDbType.Int).Value = pro.id_color;
                cmd.Parameters.Add("@pTalla", SqlDbType.Int).Value = pro.id_talla;
                cmd.Parameters.Add("@pCategoria", SqlDbType.Int).Value = pro.id_categoria;
                cmd.Parameters.Add("@pStock", SqlDbType.Int).Value = pro.stock;
                cmd.Parameters.Add("@pPrecio", SqlDbType.Decimal).Value = pro.precio_unidad;
                cmd.Parameters.Add("@pCompra", SqlDbType.Decimal).Value = pro.precio_Compra;
                cmd.Parameters.Add("@pEstado", SqlDbType.Bit).Value = pro.estado;

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

        //Habilitar
        public Boolean HabilitarProductos(Entidad_Productos Pro)
        {
            SqlCommand cmd = null;
            Boolean agregar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spHabilitaProductos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pId", Pro.id);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    agregar = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return agregar;
        }
        //Listar No Ianctivos
        public List<Entidad_Productos> ListarProductosNoListado()
        {
            SqlCommand cmd = null;
            List<Entidad_Productos> lista = new List<Entidad_Productos>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); // patrón singleton
                cmd = new SqlCommand("spListarProductoNoListado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Entidad_Productos pro = new Entidad_Productos();

                    pro.id = Convert.ToInt32(dr["id_Producto"]);
                    pro.nombre = dr["nombre"].ToString();
                    pro.marca = dr["marca"].ToString();
                    pro.color = dr["color"].ToString();
                    pro.stock = Convert.ToInt32(dr["stock"]);
                    pro.categoria = dr["categoria"].ToString();
                    pro.tallas = dr["talla"].ToString();
                    pro.precio_unidad = Convert.ToDouble(dr["precio_Venta"]);
                    pro.precio_Compra = Convert.ToDouble(dr["precio_Compra"]);
                    pro.fecha_registro = Convert.ToDateTime(dr["fechaRegisto"]);

                    lista.Add(pro);
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

        public Entidad_Productos BuscarProductoPorID(int idProducto)
        {
            Entidad_Productos producto = null;

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                if (cn.State != ConnectionState.Open)
                    cn.Open();

                SqlCommand cmd = new SqlCommand("sp_BuscarProductoPorID", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProducto", idProducto);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    producto = new Entidad_Productos
                    {
                        id = Convert.ToInt32(dr["id_Producto"]),
                        nombre = dr["nombre"].ToString(),
                        marca = dr["marca"].ToString(),
                        color = dr["color"].ToString(),
                        tallas = dr["talla"].ToString(),
                        precio_unidad = Convert.ToDouble(dr["precio_Venta"]),
                        stock = Convert.ToInt32(dr["stock"])
                    };
                }
            }
            return producto;
        }
        #endregion metodos
    }
}

