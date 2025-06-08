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

        }

        private void Frm_Producto_Load(object sender, EventArgs e)
        {
            //dgvProductos.Columns["ID"].HeaderText = "Id:";
            //dgvProductos.Columns["NombreP"].HeaderText = "Nombre del Producto:";
            //dgvProductos.Columns["MarcaP"].HeaderText = "Marca:";
            //dgvProductos.Columns["ColorP"].HeaderText = "Color:";
            //dgvProductos.Columns["PrecioP"].HeaderText = "Precio ($):";
            //dgvProductos.Columns["StockP"].HeaderText = "Stock:";
        }
    }
}
