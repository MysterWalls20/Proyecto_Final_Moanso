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
    public partial class Frm_ReOrdenCompra : Form
    {

        public Frm_ReOrdenCompra()
        {
            InitializeComponent();
            CargarCombos();
            ActualizarTabla();
            CargarOrdenesFinales();
        }
        private void ActualizarTabla()
        {
            // Refrescar DataGridView
            dgvReqProductos.DataSource = null;
            dgvReqProductos.DataSource = listaDetalleTemporal;

            // Cambiar encabezados
            dgvReqProductos.Columns["IdProducto"].HeaderText = "ID";
            dgvReqProductos.Columns["NombreProducto"].HeaderText = "Producto";
            dgvReqProductos.Columns["Cantidad"].HeaderText = "Cantidad";
            dgvReqProductos.Columns["PrecioUnitario"].HeaderText = "Precio Unitario";
            dgvReqProductos.Columns["SubtotalFinal"].HeaderText = "Subtotal";

            // Formato numérico
            dgvReqProductos.Columns["PrecioUnitario"].DefaultCellStyle.Format = "N2";
            dgvReqProductos.Columns["SubtotalFinal"].DefaultCellStyle.Format = "N2";

            // Ocultar columnas no necesarias
            /*dgvOrdenFinal.Columns["IdProveedor"].Visible = false;
            dgvOrdenFinal.Columns["IdTipoPago"].Visible = false;
            dgvOrdenFinal.Columns["IdFormaPago"].Visible = false;*/
        }

        private void CargarOrdenesFinales()
        {
            dgvOrdenFinal.DataSource = null;
            dgvOrdenFinal.DataSource = Logica_OrdenCompra.Instancia.ListarOrdenesCompra();

            dgvOrdenFinal.Columns["IdOrdenCompra"].HeaderText = "ID";
            dgvOrdenFinal.Columns["FechaOrden"].HeaderText = "Fecha";
            dgvOrdenFinal.Columns["Proveedor"].HeaderText = "Proveedor";
            dgvOrdenFinal.Columns["TipoPago"].HeaderText = "Tipo Pago";
            dgvOrdenFinal.Columns["FormaPago"].HeaderText = "Forma Pago";
            dgvOrdenFinal.Columns["Total"].HeaderText = "Total";
            dgvOrdenFinal.Columns["Estado"].HeaderText = "Estado";

            dgvOrdenFinal.Columns["Total"].DefaultCellStyle.Format = "N2";
        }
        private void LimpiarFormulario()
        {
            cmbProveedor.SelectedIndex = -1;
            cmbProducto.SelectedIndex = -1;
            cmbTipoPago.SelectedIndex = -1;
            cmbFormaPago.SelectedIndex = -1;
            txtCantidad.Clear();
            //lblTotal.Text = "Total: S/ 0.00";
        }

        private void CargarCombos()
        {
            // Producto
            cmbProducto.DataSource = Logica_DetalleOrdenCompra.Instancia.ListarProductos();
            cmbProducto.DisplayMember = "Value";
            cmbProducto.ValueMember = "Key";
            cmbProducto.SelectedIndex = -1;

            // Proveedor
            cmbProveedor.DataSource = Logica_DetalleOrdenCompra.Instancia.ListarProveedores();
            cmbProveedor.DisplayMember = "Value";
            cmbProveedor.ValueMember = "Key";
            cmbProveedor.SelectedIndex = -1;

            // Tipo de Pago
            cmbTipoPago.DataSource = Logica_DetalleOrdenCompra.Instancia.ListarTipoPago();
            cmbTipoPago.DisplayMember = "Value";
            cmbTipoPago.ValueMember = "Key";
            cmbTipoPago.SelectedIndex = -1;

            // Forma de Pago
            cmbFormaPago.DataSource = Logica_DetalleOrdenCompra.Instancia.ListarFormaPago();
            cmbFormaPago.DisplayMember = "Value";
            cmbFormaPago.ValueMember = "Key";
            cmbFormaPago.SelectedIndex = -1;
        }
        private List<Entidad_DetalleOrdenCompra> listaDetalleTemporal = new List<Entidad_DetalleOrdenCompra>();

        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Seleccione un producto y escriba la cantidad.");
                return;
            }

            int idProducto = ((KeyValuePair<int, string>)cmbProducto.SelectedItem).Key;
            string nombreProducto = ((KeyValuePair<int, string>)cmbProducto.SelectedItem).Value;
            int cantidad = Convert.ToInt32(txtCantidad.Text);

            // Verificar duplicado
            if (listaDetalleTemporal.Any(d => d.IdProducto == idProducto))
            {
                MessageBox.Show("Este producto ya fue agregado.");
                return;
            }

            decimal precioUnitario = Logica_OrdenCompra.Instancia.ObtenerPrecioCompra(idProducto);
            decimal subtotal = cantidad * precioUnitario;

            listaDetalleTemporal.Add(new Entidad_DetalleOrdenCompra
            {
                IdProducto = idProducto,
                NombreProducto = nombreProducto,
                Cantidad = cantidad,
                PrecioUnitario = precioUnitario,
                SubtotalFinal = subtotal
            });
            ActualizarTabla();
        }

        private void btnEliminarProd_Click(object sender, EventArgs e)
        {
            if (dgvReqProductos.CurrentRow != null)
            {
                int idProducto = Convert.ToInt32(dgvReqProductos.CurrentRow.Cells["IdProducto"].Value);

                listaDetalleTemporal.RemoveAll(p => p.IdProducto == idProducto);

                ActualizarTabla();
            }
        }

        private void btnGrabarOrdenCompra_Click(object sender, EventArgs e)
        {
            if (listaDetalleTemporal.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un producto antes de grabar.");
                return;
            }

            if (cmbProveedor.SelectedIndex == -1 || cmbTipoPago.SelectedIndex == -1 || cmbFormaPago.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Proveedor, Tipo de Pago y Forma de Pago.");
                return;
            }

            // Obtener datos del formulario
            int idProveedor = ((KeyValuePair<int, string>)cmbProveedor.SelectedItem).Key;
            int idTipoPago = ((KeyValuePair<int, string>)cmbTipoPago.SelectedItem).Key;
            int idFormaPago = ((KeyValuePair<int, string>)cmbFormaPago.SelectedItem).Key;
            DateTime fechaOrden = DateTime.Now;
            decimal total = listaDetalleTemporal.Sum(d => d.SubtotalFinal);

            // Crear entidad orden
            Entidad_OrdenCompra orden = new Entidad_OrdenCompra
            {
                FechaOrden = fechaOrden,
                IdProveedor = idProveedor,
                IdTipoPago = idTipoPago,
                IdFormaPago = idFormaPago,
                Estado = "Pendiente",
                Total = total
            };

            // Registrar orden y obtener el ID generado
            int idOrdenGenerado = Logica_OrdenCompra.Instancia.RegistrarOrdenCompra(orden);

            // Registrar los detalles con ese ID
            foreach (var detalle in listaDetalleTemporal)
            {
                detalle.IdOrdenCompra = idOrdenGenerado;
                Logica_DetalleOrdenCompra.Instancia.RegistrarDetalleOrdenCompra(detalle);
            }

            MessageBox.Show("Orden de compra registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar para siguiente registro
            listaDetalleTemporal.Clear();
            ActualizarTabla();
            LimpiarFormulario();
        }


    }
}
