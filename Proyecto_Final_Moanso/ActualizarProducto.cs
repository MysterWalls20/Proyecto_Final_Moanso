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
        }

        private void CargarDatos()
        {
            // Primero cargamos los combobox
            CargarComboboxs();

            // Luego asignamos los valores
            txtIDa.Text = productoSeleccionado.id.ToString();
            txtNomA.Text = productoSeleccionado.nombre;
            txtStockA.Text = productoSeleccionado.stock.ToString();
            txtPrecioA.Text = productoSeleccionado.precio_unidad.ToString("F2");
            txtPrecioC.Text = productoSeleccionado.precio_Compra.ToString("F2");


            // Ahora seleccionamos los valores en los ComboBox
            cmbMarca.SelectedValue = productoSeleccionado.id_marca;
            cbColorA.SelectedValue = productoSeleccionado.id_color;
            cbCategoriaA.SelectedValue = productoSeleccionado.id_categoria;
            cmbtalla.SelectedValue = productoSeleccionado.id_talla;
        }
        private void ActualizarProducto_Load(object sender, EventArgs e)
        {
            CargarDatos();
            txtNomA.KeyPress += textBoxSoloLetras_KeyPress;
            txtPrecioA.KeyPress += textBoxSoloNumeros_KeyPress;
            txtStockA.KeyPress += textBoxSoloNumeros_KeyPress;
        }
        private void btnActualizarP_Click(object sender, EventArgs e)
        {
            if (txtIDa.Text == string.Empty)
            {
                MessageBox.Show("Faltan datos obligatorios para actualizar el producto", "Érror en actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (!double.TryParse(txtPrecioA.Text.Trim(), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double precioVenta))
                {
                    MessageBox.Show("El precio de venta ingresado no es válido", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(txtPrecioC.Text.Trim(), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double precioCompra))
                {
                    MessageBox.Show("El precio de compra ingresado no es válido", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Entidad_Productos APr = new Entidad_Productos();
                APr.id = int.Parse(txtIDa.Text);
                APr.nombre = txtNomA.Text.Trim();
                APr.id_marca = Convert.ToInt32(cmbMarca.SelectedValue);
                APr.id_color = Convert.ToInt32(cbColorA.SelectedValue);
                APr.id_categoria = Convert.ToInt32(cbCategoriaA.SelectedValue);
                APr.id_talla = Convert.ToInt32(cmbtalla.SelectedValue);
                APr.stock = int.Parse(txtStockA.Text.Trim());
                APr.precio_unidad = precioVenta;
                APr.precio_Compra = precioCompra;
                APr.estado = true;

                //bool actualizado = Logica_Productos.Instancia.EditaProducto(APr);
                Logica_Productos.Instancia.EditaProducto(APr);
                MessageBox.Show("Producto actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            MessageBox.Show("Producto actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ProductoActualizado = true;
            this.Close();
        }
        private void CargarComboboxs()
        {
            try
            {
                cmbMarca.DataSource = Logica_Productos.Instancia.ObtenerMarca();
                cmbMarca.DisplayMember = "Value";
                cmbMarca.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar marcas: " + ex.Message);
            }

            try
            {
                cbCategoriaA.DataSource = Logica_Productos.Instancia.ObtenerCategorias();
                cbCategoriaA.DisplayMember = "Value";
                cbCategoriaA.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message);
            }

            try
            {
                cbColorA.DataSource = Logica_Productos.Instancia.ObtenerColores();
                cbColorA.DisplayMember = "Value";
                cbColorA.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar colores: " + ex.Message);
            }

            try
            {
                cmbtalla.DataSource = Logica_Productos.Instancia.ObtenerTalla();
                cmbtalla.DisplayMember = "Value";
                cmbtalla.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tallas: " + ex.Message);
            }

            // Aquí va el bloque para seleccionar por texto
            cmbMarca.SelectedIndex = cmbMarca.FindStringExact(productoSeleccionado.marca);
            cbColorA.SelectedIndex = cbColorA.FindStringExact(productoSeleccionado.color);
            cbCategoriaA.SelectedIndex = cbCategoriaA.FindStringExact(productoSeleccionado.categoria);
            cmbtalla.SelectedIndex = cmbtalla.FindStringExact(productoSeleccionado.tallas);
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
