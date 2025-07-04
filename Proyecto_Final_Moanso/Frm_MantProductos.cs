﻿using Capa_Entidad;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Final_Moanso
{
    public partial class Frm_MantProductos : Form
    {
        public Frm_MantProductos()
        {
            InitializeComponent();
            //MostrarProductos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Frm_NuevoProducto nuevoProducto = new Frm_NuevoProducto();
            nuevoProducto.ShowDialog();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvProductosAlm.SelectedRows.Count > 0)
            {
                // Captura de fila actual
                DataGridViewRow fila = dgvProductosAlm.SelectedRows[0];
                // Llenar objeto con datos de la fila
                Entidad_Productos producto = new Entidad_Productos()
                {
                    id = Convert.ToInt32(fila.Cells["id"].Value),
                    nombre = fila.Cells["nombre"].Value.ToString(),
                    marca = fila.Cells["marca"].Value.ToString(),
                    color = fila.Cells["color"].Value.ToString(),
                    stock = Convert.ToInt32(fila.Cells["stock"].Value),
                    categoria = fila.Cells["categoria"].Value.ToString(),
                    precio_unidad = Convert.ToDouble(fila.Cells["precio_unidad"].Value)
                };

                // Pasar datos del producto al formulario de actualización
                ActualizarProducto frm = new ActualizarProducto(producto);
                frm.ShowDialog();
                MostrarProductos();
                if (frm.ProductoActualizado)
                {
                    MostrarProductos();
                }
            }
        }

        private void MostrarProductos()
        {
            cbCategoriaLP.SelectedIndex = -1;
            cbCategoriaLP.Text = "";

            dgvProductosAlm.DataSource = Logica_Productos.Instancia.ListarProductos();
            // Asegúrarse de que estos nombres coincidan con los campos del DataTable
            dgvProductosAlm.Columns["id"].HeaderText = "ID";
            dgvProductosAlm.Columns["nombre"].HeaderText = "Nombre del Producto:";
            dgvProductosAlm.Columns["marca"].HeaderText = "Marca";
            dgvProductosAlm.Columns["color"].HeaderText = "Color";
            dgvProductosAlm.Columns["stock"].HeaderText = "Stock";
            dgvProductosAlm.Columns["categoria"].HeaderText = "Categoría";
            dgvProductosAlm.Columns["precio_unidad"].HeaderText = "Precio s/";
            dgvProductosAlm.Columns["precio_unidad"].DefaultCellStyle.Format = "N2";
        }

        private void Frm_Producto_Load(object sender, EventArgs e)
        {
            try
            {
                cbCategoriaLP.Items.Clear();
                var categorias = Logica_Productos.Instancia.ObtenerCategorias();

                foreach (string cat in categorias)
                {
                    cbCategoriaLP.Items.Add(cat);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message);
            }
            MostrarProductos(); // llamado al método
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarProductos(); // llamado al método
        }

        private void btnDeshabilitar_Click_1(object sender, EventArgs e)
        {
            if (dgvProductosAlm.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas deshabilitar este producto?", "Confirmar deshabilitacion de producto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Obtener el ID del producto seleccionado
                    int idProducto = Convert.ToInt32(dgvProductosAlm.SelectedRows[0].Cells["id"].Value);
                    // Crear entidad con solo el ID
                    Entidad_Productos producto = new Entidad_Productos();
                    producto.id = idProducto;
                    // Llamar a la lógica para deshabilitar
                    Logica_Productos.Instancia.DeshabilitarProducto(producto);
                    // Refrescar la tabla
                    MostrarProductos(); // Asegúrate de tener esta función en tu formulario
                    // Limpiar selección y deshabilitar botones
                    dgvProductosAlm.ClearSelection();
                    btnActualizar.Enabled = false;
                    btnDeshabilitar.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            MostrarProductos();
        }
        private void btnHabilitar_Click(object sender, EventArgs e)
        {

        }
        private void dgvProductosAlm_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Captura de fila actual
                DataGridViewRow fila = dgvProductosAlm.Rows[e.RowIndex];
                // Llenar objeto con datos de la fila
                Entidad_Productos producto = new Entidad_Productos()
                {
                    id = Convert.ToInt32(fila.Cells["id"].Value),
                    nombre = fila.Cells["nombre"].Value.ToString(),
                    marca = fila.Cells["marca"].Value.ToString(),
                    color = fila.Cells["color"].Value.ToString(),
                    stock = Convert.ToInt32(fila.Cells["stock"].Value),
                    categoria = fila.Cells["categoria"].Value.ToString(),
                    precio_unidad = Convert.ToDouble(fila.Cells["precio_unidad"].Value)
                };

                // Pasar datos del producto al formulario de actualización
                ActualizarProducto frm = new ActualizarProducto(producto);
                frm.ShowDialog();
                MostrarProductos();
                if (frm.ProductoActualizado)
                {
                    MostrarProductos();
                }
            }
        }
        private void dgvProductosAlm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idProducto = Convert.ToInt32(dgvProductosAlm.SelectedRows[0].Cells["id"].Value);
                //txtIdCopiar.Text = idProducto.ToString();
            }
        }
        private void btnBuscarNom_Click(object sender, EventArgs e)
        {
            string busProduct = txtBuscarProduct.Text;
            //....
        }

        private void btnBuscarCat_Click(object sender, EventArgs e)
        {
            string categoria = cbCategoriaLP.Text;
            if(categoria == "")
            {
                MessageBox.Show("Por favor, selecciona una categoria.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dgvProductosAlm.DataSource = Logica_Productos.Instancia.ObtenerProductosPorCategoria(categoria);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscarProduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbCategoriaLP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
