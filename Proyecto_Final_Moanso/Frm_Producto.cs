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
    public partial class Frm_Producto : Form
    {
        public Frm_Producto()
        {
            InitializeComponent();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            btnActualizar.Enabled = false;
            Form actualPodruct = new ActualizarProducto();
            actualPodruct.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Producto_Load(object sender, EventArgs e)
        {

        }
    }
}
