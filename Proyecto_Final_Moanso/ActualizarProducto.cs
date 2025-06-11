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

        public ActualizarProducto()
        {
            InitializeComponent();
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
            if (txtIDa.Text == string.Empty || txtNomA.Text == string.Empty ||
           txtStockA.Text == string.Empty || txtPrecioA.Text == string.Empty)
            {
                MessageBox.Show("Faltan datos obligatorios", "Érror", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Entidad_Productos ePr = new Entidad_Productos();
            ePr.id = int.Parse(txtIDa.Text);
            ePr.nombre = txtNomA.Text;
            ePr.marca = MarcaA.Text;
            ePr.color = cbColorA.Text;
            ePr.stock = int.Parse(txtStockA.Text);
            ePr.categoria = cbCategoriaA.Text;
            ePr.precio_unidad = double.Parse(txtPrecioA.Text);

            string rpta = Logica_Productos.Guardado_PR(2, ePr); // 2 = Actualizar

            if (rpta == "Vale")
            {
                MessageBox.Show("Producto actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ProductoActualizado = true; // ✅ Marca que se actualizó
                this.Close();               // ✅ Cierra el formulario
            }
            else
            {
                MessageBox.Show(rpta, "Error al actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
