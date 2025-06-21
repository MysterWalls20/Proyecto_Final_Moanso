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

namespace Proyecto_Final_Moanso
{
    public partial class ActualizarProducto : Form
    {
        public bool ProductoActualizado { get; set; } = false;
        private Entidad_Productos productoSeleccionado;

        public ActualizarProducto(Entidad_Productos producto)
        {
            InitializeComponent();
            productoSeleccionado = producto;
            CargarDatos();
        }

        private void CargarDatos()
        {
            CargarComboboxs();
            txtIDa.Text = productoSeleccionado.id.ToString();
            txtNomA.Text = productoSeleccionado.nombre;
            MarcaA.Text = productoSeleccionado.marca;
            cbColorA.Text = productoSeleccionado.color;
            txtStockA.Text = productoSeleccionado.stock.ToString();
            cbCategoriaA.Text = productoSeleccionado.categoria;
            txtPrecioA.Text = productoSeleccionado.precio_unidad.ToString("F2");
        }
        private void ActualizarProducto_Load(object sender, EventArgs e)
        {
            txtNomA.KeyPress += textBoxSoloLetras_KeyPress;
            txtPrecioA.KeyPress += textBoxSoloNumeros_KeyPress;
            txtStockA.KeyPress += textBoxSoloNumeros_KeyPress;
        }
        private void btnActualizarP_Click(object sender, EventArgs e)
        {
            if (txtIDa.Text == string.Empty || MarcaA.Text == string.Empty ||
            txtNomA.Text == string.Empty || txtPrecioA.Text == string.Empty ||
            txtStockA.Text == string.Empty)
            {
                MessageBox.Show("Faltan datos obligatorios para actualizar el producto", "Érror en actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Entidad_Productos APr = new Entidad_Productos();
                APr.id = int.Parse(txtIDa.Text);
                APr.nombre = txtNomA.Text.Trim();
                APr.marca = MarcaA.Text.Trim();
                APr.color = cbColorA.Text.Trim();
                APr.stock = int.Parse(txtStockA.Text.Trim());
                APr.categoria = cbCategoriaA.Text.Trim();
                APr.precio_unidad = double.Parse(txtPrecioA.Text.Trim());
                Logica_Productos.Instancia.EditaProducto(APr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            MessageBox.Show("Producto actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ProductoActualizado = true;
            this.Close();
        }
        private void CargarComboboxs()
        {
            // Combobox Categorias
            try
            {
                cbCategoriaA.Items.Clear();
                var categorias = Logica_Productos.Instancia.ObtenerCategorias();
                foreach (string cat in categorias)
                {
                    cbCategoriaA.Items.Add(cat);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message);
            }
            // Combobox colores
            cbColorA.Items.Clear();
            var colores = Logica_Productos.Instancia.ObtenerColores();
            foreach (var color in colores)
            {
                cbColorA.Items.Add(color);
            }
        }
        private void textBoxSoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir letras, tecla de borrar (Backspace) y espacio
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBoxSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y tecla de borrar (Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void pbCerrarAP_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pbCerrarAP_MouseDown(object sender, MouseEventArgs e)
        {
            pbCerrarAP.BackColor = Color.Red;
        }
    }
}
