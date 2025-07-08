using Capa_Entidad;
using Capa_Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Final_Moanso
{
    public partial class Frm_MantProductos : Form
    {
        public Frm_MantProductos()
        {
            InitializeComponent();
            MostrarProductos();
        }

        private void MostrarProductos()
        {
            cbCategoriaLP.SelectedIndex = -1;
            cbCategoriaLP.Text = "";

            dgvProductosAlm.DataSource = Logica_Productos.Instancia.ListarProductos();
            // Asegúrarse de que estos nombres coincidan con los campos del DataTable
            dgvProductosAlm.Columns["id"].HeaderText = "ID";
            dgvProductosAlm.Columns["nombre"].HeaderText = "Nombre del Producto:";
            dgvProductosAlm.Columns["marca"].HeaderText = "Marca";
            dgvProductosAlm.Columns["color"].HeaderText = "Color";
            dgvProductosAlm.Columns["stock"].HeaderText = "Stock";
            dgvProductosAlm.Columns["categoria"].HeaderText = "Categoría";
            dgvProductosAlm.Columns["precio_unidad"].HeaderText = "Precio Venta";
            dgvProductosAlm.Columns["precio_unidad"].DefaultCellStyle.Format = "N2";
            dgvProductosAlm.Columns["precio_compra"].HeaderText = "Precio compra";
            dgvProductosAlm.Columns["precio_compra"].DefaultCellStyle.Format = "N2";

            dgvProductosAlm.Columns["estado"].Visible = false;
            dgvProductosAlm.Columns["id_marca"].Visible = false;
            dgvProductosAlm.Columns["id_color"].Visible = false;
            dgvProductosAlm.Columns["id_talla"].Visible = false;
            dgvProductosAlm.Columns["id_categoria"].Visible = false;
        }
        private void MostrarProductosNoActivado()
        {
            cbCategoriaLP.SelectedIndex = -1;
            cbCategoriaLP.Text = "";

            dgvProductosAlm.DataSource = Logica_Productos.Instancia.ListarProductosNoListado();
            // Asegúrarse de que estos nombres coincidan con los campos del DataTable
            dgvProductosAlm.Columns["id"].HeaderText = "ID";
            dgvProductosAlm.Columns["nombre"].HeaderText = "Nombre del Producto:";
            dgvProductosAlm.Columns["marca"].HeaderText = "Marca";
            dgvProductosAlm.Columns["color"].HeaderText = "Color";
            dgvProductosAlm.Columns["stock"].HeaderText = "Stock";
            dgvProductosAlm.Columns["categoria"].HeaderText = "Categoría";
            dgvProductosAlm.Columns["precio_unidad"].HeaderText = "Precio Venta";
            dgvProductosAlm.Columns["precio_unidad"].DefaultCellStyle.Format = "N2";
            dgvProductosAlm.Columns["precio_compra"].HeaderText = "Precio compra";
            dgvProductosAlm.Columns["precio_compra"].DefaultCellStyle.Format = "N2";

            dgvProductosAlm.Columns["estado"].Visible = false;
            dgvProductosAlm.Columns["id_marca"].Visible = false;
            dgvProductosAlm.Columns["id_color"].Visible = false;
            dgvProductosAlm.Columns["id_talla"].Visible = false;
            dgvProductosAlm.Columns["id_categoria"].Visible = false;

        }
        private void Frm_Producto_Load(object sender, EventArgs e)
        {
            List<KeyValuePair<int, string>> categorias = Logica_Productos.Instancia.ObtenerCategorias();
            cbCategoriaLP.DataSource = categorias;
            cbCategoriaLP.DisplayMember = "Value";  // Muestra el nombre de la categoría
            cbCategoriaLP.ValueMember = "Key";      // Internamente guarda el ID
            cbCategoriaLP.SelectedIndex = -1;       // Nada seleccionado al inicio

            MostrarProductos(); // llamado al método
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Frm_NuevoProducto nuevoProducto = new Frm_NuevoProducto();
            nuevoProducto.ShowDialog();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvProductosAlm.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvProductosAlm.SelectedRows[0];

                Entidad_Productos producto = new Entidad_Productos()
                {
                    id = Convert.ToInt32(fila.Cells["id"].Value),
                    nombre = fila.Cells["nombre"].Value.ToString(),
                    id_marca = Convert.ToInt32(fila.Cells["id_marca"].Value),
                    id_categoria = Convert.ToInt32(fila.Cells["id_categoria"].Value),
                    id_color = Convert.ToInt32(fila.Cells["id_color"].Value),
                    id_talla = Convert.ToInt32(fila.Cells["id_talla"].Value),
                    stock = Convert.ToInt32(fila.Cells["stock"].Value),
                    precio_unidad = Convert.ToDouble(fila.Cells["precio_unidad"].Value),
                    precio_Compra = Convert.ToDouble(fila.Cells["precio_compra"].Value)
                };

                ActualizarProducto frm = new ActualizarProducto(producto);
                frm.ShowDialog();

                if (frm.ProductoActualizado)
                {
                    MostrarProductos();
                }
            }
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarProductos(); // llamado al método
        }

        private void btnDeshabilitar_Click_1(object sender, EventArgs e)
        {
            if (dgvProductosAlm.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas deshabilitar este producto?", "Confirmar deshabilitacion de producto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Obtener el ID del producto seleccionado
                    int idProducto = Convert.ToInt32(dgvProductosAlm.SelectedRows[0].Cells["id"].Value);
                    // Crear entidad con solo el ID
                    Entidad_Productos producto = new Entidad_Productos();
                    producto.id = idProducto;
                    // Llamar a la lógica para deshabilitar
                    Logica_Productos.Instancia.DeshabilitarProducto(producto);
                    // Refrescar la tabla
                    MostrarProductos(); // Asegúrate de tener esta función en tu formulario
                    // Limpiar selección y deshabilitar botones
                    dgvProductosAlm.ClearSelection();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            MostrarProductos();
        }
        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            if (dgvProductosAlm.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas habilitar este producto?", "Confirmar deshabilitacion de producto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Obtener el ID del producto seleccionado
                    int idProducto = Convert.ToInt32(dgvProductosAlm.SelectedRows[0].Cells["id"].Value);
                    // Crear entidad con solo el ID
                    Entidad_Productos producto = new Entidad_Productos();
                    producto.id = idProducto;
                    // Llamar a la lógica para deshabilitar
                    Logica_Productos.Instancia.HabilitarProducto(producto);
                    // Refrescar la tabla
                    MostrarProductos(); // Asegúrate de tener esta función en tu formulario
                    // Limpiar selección y deshabilitar botones
                    dgvProductosAlm.ClearSelection();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            MostrarProductosNoActivado();
        }
        private void dgvProductosAlm_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Captura de fila actual
                DataGridViewRow fila = dgvProductosAlm.Rows[e.RowIndex];
                // Llenar objeto con datos de la fila
                Entidad_Productos producto = new Entidad_Productos()
                {
                    id = Convert.ToInt32(fila.Cells["id"].Value),
                    nombre = fila.Cells["nombre"].Value.ToString(),
                    id_marca = Convert.ToInt32(fila.Cells["id_marca"].Value),
                    id_categoria = Convert.ToInt32(fila.Cells["id_categoria"].Value),
                    id_color = Convert.ToInt32(fila.Cells["id_color"].Value),
                    id_talla = Convert.ToInt32(fila.Cells["id_talla"].Value),
                    stock = Convert.ToInt32(fila.Cells["stock"].Value),
                    precio_unidad = Convert.ToDouble(fila.Cells["precio_unidad"].Value),
                    precio_Compra = Convert.ToDouble(fila.Cells["precio_compra"].Value)
                };

                // Pasar datos del producto al formulario de actualización
                ActualizarProducto frm = new ActualizarProducto(producto);
                frm.ShowDialog();
                MostrarProductos();
                if (frm.ProductoActualizado)
                {
                    MostrarProductos();
                }
            }
        }
        private void dgvProductosAlm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idProducto = Convert.ToInt32(dgvProductosAlm.SelectedRows[0].Cells["id"].Value);
                //txtIdCopiar.Text = idProducto.ToString();
            }
        }
        private void btnBuscarNom_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscarProduct.Text.Trim();
            if (!string.IsNullOrEmpty(nombre))
            {
                dgvProductosAlm.DataSource = Logica_Productos.Instancia.BuscarProductoPorNombre(nombre);
            }
            else
            {
                MessageBox.Show("Ingresa un nombre de producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscarCat_Click(object sender, EventArgs e)
        {
            if (cbCategoriaLP.SelectedIndex != -1)
            {
                int idCategoria = Convert.ToInt32(cbCategoriaLP.SelectedValue);
                dgvProductosAlm.DataSource = Logica_Productos.Instancia.BuscarProductoPorCategoria(idCategoria);
            }
            else
            {
                MessageBox.Show("Selecciona una categoría.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMostrarDesh_Click(object sender, EventArgs e)
        {
            MostrarProductosNoActivado();
        }

        private void cbCategoriaLP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
