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

        private void pbCerrarAP_Click(object sender, EventArgs e)
        {
            this.Close();
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
                MessageBox.Show("Faltan datos obligatorios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
