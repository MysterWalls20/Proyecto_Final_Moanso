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

        private void pbCerrarNP_Click(object sender, EventArgs e)
        {
            this.Close();
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
                MessageBox.Show("Falta ingresar datos requeridos (*)", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
