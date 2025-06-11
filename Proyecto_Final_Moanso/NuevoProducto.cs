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
    public partial class NuevoProducto : Form
    {
        public bool ProductoAgregado { get; set; } = false;
        public NuevoProducto()
        {
            InitializeComponent();
        }
        private void NuevoProducto_Load(object sender, EventArgs e)
        {
            txtNombreNP.KeyPress += textBoxSoloLetras_KeyPress;
            txtMarcaNP.KeyPress += textBoxSoloLetras_KeyPress;
            txtPrecioN.KeyPress += textBoxSoloNumeros_KeyPress;
            txtStockNP.KeyPress += textBoxSoloNumeros_KeyPress;
        }
        private void pbCerrarNP_Click(object sender, EventArgs e)
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
        private void pbCerrarNP_MouseDown(object sender, MouseEventArgs e)
        {
            pbCerrarNP.BackColor = Color.Red;
        }
        private void btnNuevoP_Click(object sender, EventArgs e)
        {

            if (txtIDnp.Text == string.Empty || txtMarcaNP.Text == string.Empty ||
            txtNombreNP.Text == string.Empty || txtPrecioN.Text == string.Empty ||
            txtStockNP.Text == string.Empty)
            {
                MessageBox.Show("Falta ingresar los datos requeridos", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Entidad_Productos ePr = new Entidad_Productos();
                string rpta = " ";
                ePr.id = int.Parse(txtIDnp.Text);
                ePr.nombre = txtNombreNP.Text;
                ePr.marca = txtMarcaNP.Text;
                ePr.color = cbColorN.Text;
                ePr.stock = int.Parse(txtStockNP.Text);
                ePr.categoria = cbCategoria.Text;
                ePr.precio_unidad = double.Parse(txtPrecioN.Text);

                rpta = Logica_Productos.Guardado_PR(1, ePr); // 1 = Nuevo producto

                if (rpta == "Vale")
                {
                    MessageBox.Show("Los datos del producto se han guardado correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ProductoAgregado = true; // ✅ Indica que se guardó
                    this.Close();            // ✅ Cierra el formulario
                }
                else
                {
                    MessageBox.Show(rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
