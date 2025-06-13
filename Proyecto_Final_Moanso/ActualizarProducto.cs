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
            MarcaA.KeyPress += textBoxSoloLetras_KeyPress;
            txtPrecioA.KeyPress += textBoxSoloNumeros_KeyPress;
            txtStockA.KeyPress += textBoxSoloNumeros_KeyPress;
        }
        private void pbCerrarAP_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void pbCerrarAP_MouseDown(object sender, MouseEventArgs e)
        {
            pbCerrarAP.BackColor = Color.Red;
        }

        private void btnActualizarP_Click(object sender, EventArgs e)
        {
            if (txtIDa.Text == string.Empty)
            {
                MessageBox.Show("Faltan datos obligatorios", "Érror", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Entidad_Productos ePr = new Entidad_Productos();
                ePr.id = int.Parse(txtIDa.Text);
                ePr.nombre = txtNomA.Text.Trim();
                ePr.marca = MarcaA.Text.Trim();
                ePr.color = cbColorA.Text.Trim();
                ePr.stock = int.Parse(txtStockA.Text.Trim());
                ePr.categoria = cbCategoriaA.Text.Trim();
                ePr.precio_unidad = double.Parse(txtPrecioA.Text.Trim());
                Logica_Productos.Instancia.EditaProducto(ePr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

            MessageBox.Show("Producto actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ProductoActualizado = true;
            this.Close();


            
        }
    }
}
