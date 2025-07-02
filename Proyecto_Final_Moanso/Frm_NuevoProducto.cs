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
    public partial class Frm_NuevoProducto : Form
    {
        public bool ProductoAgregado { get; set; } = false;
        public Frm_NuevoProducto()
        {
            InitializeComponent();
        }
        private void NuevoProducto_Load(object sender, EventArgs e)
        {
            CargarComboboxs();
            txtNombreNP.KeyPress += textBoxSoloLetras_KeyPress;
            txtPrecioN.KeyPress += textBoxSoloNumeros_KeyPress;
            txtStockNP.KeyPress += textBoxSoloNumeros_KeyPress;
        }
        private void btnNuevoP_Click(object sender, EventArgs e)
        {
            if (txtMarcaNP.Text == string.Empty ||
            txtNombreNP.Text == string.Empty || txtPrecioN.Text == string.Empty ||
            txtStockNP.Text == string.Empty)
            {
                MessageBox.Show("Falta ingresar los datos requeridos", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Entidad_Productos NPr = new Entidad_Productos();
                    NPr.nombre = txtNombreNP.Text;
                    NPr.marca = txtMarcaNP.Text;
                    NPr.color = cbColorN.Text;
                    NPr.stock = int.Parse(txtStockNP.Text);
                    NPr.categoria = cbCategoria.Text;
                    NPr.precio_unidad = double.Parse(txtPrecioN.Text);
                    Logica_Productos.Instancia.InsertaProducto(NPr);
                    MessageBox.Show("Los datos del producto se han guardado correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ProductoAgregado = true; // ✅ Indica que se guardó
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error.." + ex);
                }
            }
        }
        private void CargarComboboxs()
        {
            // Combobox Categorias
            try
            {
                cbCategoria.Items.Clear();
                var categorias = Logica_Productos.Instancia.ObtenerCategorias();
                foreach (string cat in categorias)
                {
                    cbCategoria.Items.Add(cat);
                }
                if (cbCategoria.Items.Count > 0)
                    cbCategoria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message);
            }
            // Combobox colores
            cbColorN.Items.Clear();
            var colores = Logica_Productos.Instancia.ObtenerColores();
            foreach (var color in colores)
            {
                cbColorN.Items.Add(color);
            }
            if (cbColorN.Items.Count > 0)
                cbColorN.SelectedIndex = -1;
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
        private void pbCerrarNP_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pbCerrarNP_MouseDown(object sender, MouseEventArgs e)
        {
            pbCerrarNP.BackColor = Color.Red;
        }
    }
}
