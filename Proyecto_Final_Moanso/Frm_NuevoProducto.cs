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
            if (string.IsNullOrWhiteSpace(txtNombreNP.Text) ||
            string.IsNullOrWhiteSpace(txtPrecioN.Text) ||
            string.IsNullOrWhiteSpace(txtStockNP.Text))
            {
                MessageBox.Show("Falta ingresar los datos requeridos", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Entidad_Productos NPr = new Entidad_Productos
                {
                    nombre = txtNombreNP.Text,
                    id_marca = ((KeyValuePair<int, string>)cmbMarca.SelectedItem).Key,
                    id_color = ((KeyValuePair<int, string>)cmbColor.SelectedItem).Key,
                    id_talla = ((KeyValuePair<int, string>)cmbtalla.SelectedItem).Key,
                    id_categoria = ((KeyValuePair<int, string>)cbCategoria.SelectedItem).Key,
                    stock = int.Parse(txtStockNP.Text),
                    precio_unidad = double.Parse(txtPrecioN.Text),
                    precio_Compra = double.Parse(txtPrecioN.Text),
                    estado = true
                };

                Logica_Productos.Instancia.InsertaProducto(NPr);

                MessageBox.Show("Los datos del producto se han guardado correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ProductoAgregado = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar producto: " + ex.Message);
            }
        }
        private void CargarComboboxs()
        {
            // Categorías
            cbCategoria.DataSource = Logica_Productos.Instancia.ObtenerCategorias();
            cbCategoria.DisplayMember = "Value";
            cbCategoria.ValueMember = "Key";
            cbCategoria.SelectedIndex = -1;

            // Marcas
            cmbMarca.DataSource = Logica_Productos.Instancia.ObtenerMarca();
            cmbMarca.DisplayMember = "Value";
            cmbMarca.ValueMember = "Key";
            cmbMarca.SelectedIndex = -1;

            // Colores
            cmbColor.DataSource = Logica_Productos.Instancia.ObtenerColores();
            cmbColor.DisplayMember = "Value";
            cmbColor.ValueMember = "Key";
            cmbColor.SelectedIndex = -1;

            // Tallas
            cmbtalla.DataSource = Logica_Productos.Instancia.ObtenerTalla();
            cmbtalla.DisplayMember = "Value";
            cmbtalla.ValueMember = "Key";
            cmbtalla.SelectedIndex = -1;
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
