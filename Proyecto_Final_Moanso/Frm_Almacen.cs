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
    public partial class Frm_Almacen : Form
    {
        public Frm_Almacen()
        {
            InitializeComponent();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoProducto nuevoProducto = new NuevoProducto();
            nuevoProducto.ShowDialog();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarProducto actualPodruct = new ActualizarProducto();
            actualPodruct.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductosAlm.SelectedRows.Count > 0)
            {
                // Confirmación opcional
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar esta fila?", "Confirmar eliminación", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Elimina la fila seleccionada
                    dgvProductosAlm.Rows.RemoveAt(dgvProductosAlm.SelectedRows[0].Index);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.");
            }
        }

        private void Frm_Producto_Load(object sender, EventArgs e)
        {
            
        }
    }
}
