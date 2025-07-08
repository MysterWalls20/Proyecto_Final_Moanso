using Capa_Entidad;
using Capa_Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            CargarFormasPago();
            txtIdV.KeyPress += textBoxSoloNumeros_KeyPress;
            txtCantidadV.KeyPress += textBoxSoloNumeros_KeyPress;
        }
        private void CargarFormasPago()
        {
            Logica_Ventas logica = new Logica_Ventas();
            DataTable dt = logica.ObtenerFormasPago();
            cbmFormaPag.DataSource = dt;
            cbmFormaPag.DisplayMember = "Descripcion";
            cbmFormaPag.ValueMember = "id_FormaPago";
            cbmFormaPag.SelectedIndex = -1; // Ninguna seleccionada por defecto
        }
        private void textBoxSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y tecla de borrar (Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIdV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(txtIdV.Text.Trim(), out int idProducto))
                {
                    Entidad_Productos prod = new Logica_Productos().BuscarProductoPorID(idProducto);

                    if (prod != null)
                    {
                        txtProductV.Text = prod.nombre;
                        txtMarcaV.Text = prod.marca;
                        txtColorV.Text = prod.color;
                        txtTallaV.Text = prod.tallas;
                        txtPrecioV.Text = prod.precio_unidad.ToString("0.00");
                        txtStockV.Text = prod.stock.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                e.SuppressKeyPress = true; // evita el beep del Enter
            }
        }
        private void LimpiarCampos()
        {
            txtProductV.Clear();
            txtMarcaV.Clear();
            txtColorV.Clear();
            txtTallaV.Clear();
            txtPrecioV.Clear();
            txtStockV.Clear();
        }

        private void btnAgregarProTabla_Click(object sender, EventArgs e)
        {
            // Validar que los campos estén llenos
            if (string.IsNullOrWhiteSpace(txtProductV.Text) ||
                string.IsNullOrWhiteSpace(txtCantidadV.Text))
            {
                MessageBox.Show("Debe buscar un producto y especificar la cantidad.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar cantidad
            if (!int.TryParse(txtCantidadV.Text.Trim(), out int cantidadSolicitada))
            {
                MessageBox.Show("Cantidad no válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int stock = int.Parse(txtStockV.Text);
            if (cantidadSolicitada > stock)
            {
                MessageBox.Show("No puede ingresar más de lo que hay en stock.", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double precioUnitario = double.Parse(txtPrecioV.Text);
            double precioTotal = cantidadSolicitada * precioUnitario;

            // Agregar al DataGridView
            dgvProductosV.Rows.Add(
                txtIdV.Text,
                txtProductV.Text,
                txtMarcaV.Text,
                txtColorV.Text,
                txtTallaV.Text,
                cantidadSolicitada.ToString(),
                precioUnitario.ToString("0.00"),
                precioTotal.ToString("0.00")
            );

            CalcularTotalVenta();
            LimpiarCamposProducto();
        }
        private void CalcularTotalVenta()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvProductosV.Rows)
            {
                if (row.Cells[7].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells[7].Value);
                }
            }

            lbPagoTotal.Text = total.ToString("0.00");
        }
        private void LimpiarCamposProducto()
        {
            txtIdV.Clear();
            txtProductV.Clear();
            txtMarcaV.Clear();
            txtColorV.Clear();
            txtTallaV.Clear();
            txtPrecioV.Clear();
            txtStockV.Clear();
            txtCantidadV.Clear();
        }

        private void btnEliminarProTabla_Click(object sender, EventArgs e)
        {
            if (dgvProductosV.CurrentRow != null && dgvProductosV.CurrentRow.Index >= 0)
            {
                dgvProductosV.Rows.RemoveAt(dgvProductosV.CurrentRow.Index);
                CalcularTotalVenta();
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtClienV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarCliente();
            }
        }
        private void BuscarCliente()
        {
            string nombreBuscado = txtClienV.Text.Trim();

            DataTable dt = new Logica_Cliente().BuscarClientePorNombre(nombreBuscado);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                lblClienteId.Text = row["id_cliente"].ToString();
                txtTipoCli.Text = row["tipoCliente"].ToString();
                txtDireccionV.Text = row["direccion"].ToString();

                // Opcional:
                //txtRUC.Text = row["ruc"].ToString();
                //txtNumero.Text = row["numero"].ToString();
            }
            else
            {
                MessageBox.Show("Cliente no encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCamposCliente();
            }
        }

        private void LimpiarCamposCliente()
        {
            lblClienteId.Text = "";
            txtTipoCli.Clear();
            txtDireccionV.Clear();
        }

        private void txtPago_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPago.Text))
            {
                lbVuelto.Text = "0.00";
                return;
            }

            if (decimal.TryParse(txtPago.Text, out decimal pago) &&
                decimal.TryParse(lbPagoTotal.Text, out decimal total))
            {
                decimal vuelto = pago - total;
                lbVuelto.Text = vuelto >= 0 ? vuelto.ToString("0.00") : "0.00";
            }
            else
            {
                lbVuelto.Text = "0.00";
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            // Validar que haya productos
            if (dgvProductosV.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar cliente
            if (string.IsNullOrWhiteSpace(lblClienteId.Text))
            {
                MessageBox.Show("Seleccione un cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar forma de pago
            if (cbmFormaPag.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una forma de pago.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar monto pagado
            if (!decimal.TryParse(txtPago.Text, out decimal montoPago))
            {
                MessageBox.Show("Ingrese un monto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal totalVenta = decimal.Parse(lbPagoTotal.Text);

            if (montoPago < totalVenta)
            {
                MessageBox.Show("El pago no cubre el total de la venta.", "Pago insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal vuelto = montoPago - totalVenta;
            lbVuelto.Text = vuelto.ToString("0.00");

            // Registrar Venta
            int idCliente = int.Parse(lblClienteId.Text);
            int idFormaPago = Convert.ToInt32(cbmFormaPag.SelectedValue);

            Logica_Ventas logica = new Logica_Ventas();

            int idVenta = logica.RegistrarVenta(idCliente, idFormaPago, totalVenta);
            GenerarFacturaTXT(
            idVenta,
            dgvProductosV,
            txtClienV.Text,
            txtTipoCli.Text,
            txtDireccionV.Text,
            totalVenta,
            montoPago,
            vuelto,
            cbmFormaPag.Text
            );  

            // Registrar detalles
            foreach (DataGridViewRow row in dgvProductosV.Rows)
            {
                int idProducto = Convert.ToInt32(row.Cells[0].Value);
                int cantidad = Convert.ToInt32(row.Cells[5].Value);
                decimal precioUnitario = Convert.ToDecimal(row.Cells[6].Value);
                decimal subtotal = Convert.ToDecimal(row.Cells[7].Value);

                logica.RegistrarDetalleVenta(idVenta, idProducto, cantidad, precioUnitario, subtotal);

                // ACTUALIZAR STOCK
                logica.ActualizarStock(idProducto, cantidad);
            }

            MessageBox.Show("Venta registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarFormulario();


            
        }

        private void LimpiarFormulario()
        {
            dgvProductosV.Rows.Clear();
            lblClienteId.Text = "";
            txtClienV.Clear();
            txtTipoCli.Clear();
            txtDireccionV.Clear();
            txtPago.Clear();
            lbPagoTotal.Text = "0.00";
            lbVuelto.Text = "0.00";
            cbmFormaPag.SelectedIndex = -1;
        }

        private void GenerarFacturaTXT(int idVenta, DataGridView dgvProductosV, string nombreCliente, string tipoCliente, string direccion, decimal total, decimal pago, decimal vuelto, string formaPago)
        {
            string ruta = @"C:\Users\ACER\OneDrive\Escritorio\Facturas Venta Rubio" + idVenta + ".txt";

            using (StreamWriter sw = new StreamWriter(ruta))
            {
                sw.WriteLine("===== FACTURA =====");
                sw.WriteLine($"ID Venta: {idVenta}");
                sw.WriteLine($"Cliente: {nombreCliente}");
                sw.WriteLine($"Tipo Cliente: {tipoCliente}");
                sw.WriteLine($"Dirección: {direccion}");
                sw.WriteLine($"Forma de Pago: {formaPago}");
                sw.WriteLine("-----------------------------");
                sw.WriteLine("DETALLE:");

                foreach (DataGridViewRow row in dgvProductosV.Rows)
                {
                    sw.WriteLine(
                        $"ID: {row.Cells[0].Value} | " +
                        $"Producto: {row.Cells[1].Value} | " +
                        $"Marca: {row.Cells[2].Value} | " +
                        $"Color: {row.Cells[3].Value} | " +
                        $"Talla: {row.Cells[4].Value} | " +
                        $"Cant.: {row.Cells[5].Value} | " +
                        $"P.Unit.: {row.Cells[6].Value} | " +
                        $"Subtotal: {row.Cells[7].Value}"
                    );
                }

                sw.WriteLine("-----------------------------");
                sw.WriteLine($"Total: S/ {total}");
                sw.WriteLine($"Pago: S/ {pago}");
                sw.WriteLine($"Vuelto: S/ {vuelto}");
                sw.WriteLine("=============================");
                sw.WriteLine("¡Gracias por su compra!");
            }
            MessageBox.Show("Factura generada correctamente en TXT.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
