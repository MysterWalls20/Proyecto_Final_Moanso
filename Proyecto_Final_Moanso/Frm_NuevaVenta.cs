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
    public partial class Frm_NuevaVenta : Form
    {
        public Frm_NuevaVenta()
        {
            InitializeComponent();
            txtFechaV.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private void Frm_NuevaVenta_Load(object sender, EventArgs e)
        {
            try
            {
                cbmMetodoPag.Items.Clear();
                var metodos = Logica_Ventas.Instancia.ObtenerMetodosPago();
                foreach (string metodo in metodos)
                {
                    cbmMetodoPag.Items.Add(metodo);
                }

                if (cbmMetodoPag.Items.Count > 0)
                    cbmMetodoPag.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar métodos de pago: " + ex.Message);
            }
            txtIdV.KeyPress += textBoxSoloNumeros_KeyPress;
            txtCantidadV.KeyPress += textBoxSoloNumeros_KeyPress;
        }
        private void textBoxSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y tecla de borrar (Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnVender_Click(object sender, EventArgs e)
        {

        }
        private void LimpiarFormularioVenta()
        {
            lblClienteId.Text = "";
            lbPagoT.Text = "0.00";
            dgvProductosV.Rows.Clear();
            txtDniV.Text = "";
            txtClienV.Text = "";

        }
        private void RegistrarVentaDirecta()
        {
            if (txtDniV.Text == "" || txtDireccionV.Text == "" || lblClienteId.Text == "" || dgvProductosV.Rows.Count == 0 || txtClienV.Text == "")
            {
                MessageBox.Show("Faltan datos para la venta.");
                return;
            }

            int idVentaGenerada = 0;
            decimal totalVenta = 0;

            List<Entidad_DetalleVenta> detalles = new List<Entidad_DetalleVenta>();

            foreach (DataGridViewRow row in dgvProductosV.Rows)
            {
                int idProducto = Convert.ToInt32(row.Cells["IDv"].Value);
                int cantidad = Convert.ToInt32(row.Cells["cantPV"].Value);
                decimal precioUnidad = Convert.ToDecimal(row.Cells["PrecioUpv"].Value);
                decimal subtotal = Convert.ToDecimal(row.Cells["PrecioTPV"].Value);

                totalVenta += subtotal;

                detalles.Add(new Entidad_DetalleVenta
                {
                    IdProducto = idProducto,
                    Cantidad = cantidad,
                    PrecioUnidad = precioUnidad,
                    Subtotal = subtotal
                });
            }

            bool ventaRegistrada = Logica_Ventas.Instancia.RegistrarVenta(
                Convert.ToInt32(lblClienteId.Text),
                DateTime.Now,
                totalVenta,
                detalles,
                out idVentaGenerada
            );

            if (ventaRegistrada)
            {
                MessageBox.Show("Pedido registrado correctamente.");
                // Opcional: limpiar formulario
            }
            else
            {
                MessageBox.Show("Error al registrar pedido.");
            }
        }
        private void txtIdV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // evita el beep del Enter
                int id;
                if (int.TryParse(txtIdV.Text.Trim(), out id))
                {
                    var producto = Logica_Productos.Instancia.BuscarProductoPorID(id);

                    if (producto != null)
                    {
                        txtProductV.Text = producto.nombre;
                        txtMarcaV.Text = producto.marca;
                        txtColorV.Text = producto.color;
                        txtStockV.Text = producto.stock.ToString();
                        txtCategoriaV.Text = producto.categoria;
                        txtPrecioV.Text = producto.precio_unidad.ToString("0.00");
                        txtCantidadV.Focus(); // Mover el foco a la cantidad automáticamente
                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado o deshabilitado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtIdV.SelectAll();
                        txtIdV.Focus();
                    }
                }
            }
        }

        private void txtCantidadV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // para evitar beep

                // Validaciones básicas
                if (txtIdV.Text == "" || txtCantidadV.Text == "" || txtProductV.Text == "")
                {
                    MessageBox.Show("Por favor complete todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int stock = int.Parse(txtStockV.Text);
                int cantidad = int.Parse(txtCantidadV.Text);
                if (cantidad > stock)
                {
                    MessageBox.Show("Cantidad mayor al stock disponible.", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCantidadV.Focus();
                    return;
                }
                decimal precioUnitario = decimal.Parse(txtPrecioV.Text);
                decimal subtotal = precioUnitario * cantidad;
                // Agregar al DataGridView
                dgvProductosV.Rows.Add(
                    txtIdV.Text,
                    txtProductV.Text,
                    txtColorV.Text,
                    txtCantidadV.Text,
                    txtPrecioV.Text,
                    subtotal.ToString(),
                    cbmMetodoPag.Text
                );
                CalcularTotal();
                // Limpiar campos
                txtIdV.Clear();
                txtProductV.Clear();
                txtMarcaV.Clear();
                txtColorV.Clear();
                txtCategoriaV.Clear();
                txtStockV.Clear();
                txtPrecioV.Clear();
                txtCantidadV.Clear();
                txtIdV.Focus();
            }
        }
        //lbPagoT.Text
        private decimal CalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow fila in dgvProductosV.Rows)
            {
                total += Convert.ToDecimal(fila.Cells["PrecioTPV"].Value);
            }

            lbPagoT.Text = total.ToString("0.00");
            return total;
        }
        private void txtDniV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                string dni = txtDniV.Text.Trim();

                if (dni.Length != 8 || !dni.All(char.IsDigit))
                {
                    MessageBox.Show("Ingrese un DNI válido de 8 dígitos.");
                    return;
                }

                var cliente = Logica_Cliente.Instancia.ObtenerClientePorDni(dni);

                if (cliente != null)
                {
                    txtClienV.Text = cliente.nombre + " " + cliente.apellido;
                    lblClienteId.Text = Convert.ToString(cliente.id);
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado o está deshabilitado.");
                    txtClienV.Clear();
                }
            }
        }
    }
}
