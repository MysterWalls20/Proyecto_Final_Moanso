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
    public partial class Frm_Pedidos : Form
    {
        public Frm_Pedidos()
        {
            InitializeComponent();
            CargarPedidosPendientes();
            CargarEmpleadosDisponibles();
        }
        private void CargarPedidosPendientes()
        {
            dgvPedidos.Rows.Clear();

            int contador = 1;
            foreach (var pedido in Logica_PedidosTemporales.Instancia.PedidosPendientes)
            {
                pedido.Id = contador++; // ID temporal para mostrar

                // Calcular total si aún no está calculado
                decimal total = pedido.Detalles.Sum(d => d.Subtotal);

                dgvPedidos.Rows.Add(
                    pedido.Id,
                    pedido.DireccionEntrega,
                    total.ToString("0.00"),
                    pedido.FechaPedido.ToString("dd/MM/yyyy")
                );
            }
        }
        private void btnVerEstadosPed_Click(object sender, EventArgs e)
        {
            EstadoPedidos estadoPedidos = new EstadoPedidos();
            estadoPedidos.ShowDialog();
        }
        private void CargarEmpleadosDisponibles()
        {
            dgvPerAlmacen.DataSource = null;
            dgvPerAlmacen.DataSource = Logica_Empleado.Instancia.ListarEmpleadosPorRol("Per. Almacen");

            dgvPerReparto.DataSource = null;
            dgvPerReparto.DataSource = Logica_Empleado.Instancia.ListarEmpleadosPorRol("Per. Repartidor");
        }
        private void btnAsigAlm1_Click(object sender, EventArgs e)
        {
            if (dgvPerAlmacen.SelectedRows.Count > 0)
            {
                var fila = dgvPerAlmacen.SelectedRows[0];
                string disponibilidad = fila.Cells["DisEmpA"].Value.ToString();
                string nombre = fila.Cells["NomE"].Value.ToString();

                if (disponibilidad == "Disponible")
                {
                    if (txtAlmacenAsig2.Text == nombre)
                    {
                        MessageBox.Show("Este empleado ya está asignado como Almacén 2.");
                        return;
                    }
                    txtAlmacenAsig1.Tag = fila.Cells["IdE"].Value; // Guarda el ID
                    txtAlmacenAsig1.Text = nombre;
                }
                else
                {
                    MessageBox.Show("Empleado no disponible.");
                }
            }
            else
            {
                MessageBox.Show("Selecciona un empleado de almacén.");
            }
        }
        private void btnAsigAlm2_Click(object sender, EventArgs e)
        {
            if (dgvPerAlmacen.SelectedRows.Count > 0)
            {
                var fila = dgvPerAlmacen.SelectedRows[0];
                string disponibilidad = fila.Cells["DisEmpA"].Value.ToString();
                string nombre = fila.Cells["NomE"].Value.ToString();

                if (disponibilidad == "Disponible")
                {
                    if (txtAlmacenAsig1.Text == nombre)
                    {
                        MessageBox.Show("Este empleado ya está asignado como Almacén 1.");
                        return;
                    }
                    txtAlmacenAsig2.Tag = fila.Cells["IdE"].Value; // Guarda el ID
                    txtAlmacenAsig2.Text = nombre;
                }
                else
                {
                    MessageBox.Show("Empleado no disponible.");
                }
            }
            else
            {
                MessageBox.Show("Selecciona un empleado de almacén.");
            }
        }
        private void btnAsigRepart_Click(object sender, EventArgs e)
        {
            if (dgvPerReparto.SelectedRows.Count > 0)
            {
                var fila = dgvPerReparto.SelectedRows[0];
                string disponibilidad = fila.Cells["DisEmpR"].Value.ToString();
                string nombre = fila.Cells["NomER"].Value.ToString();

                if (disponibilidad == "Disponible")
                {
                    txtRepartidorAsig.Text = nombre;
                }
                else
                {
                    MessageBox.Show("Repartidor no disponible.");
                }
            }
            else
            {
                MessageBox.Show("Selecciona un repartidor.");
            }
        }
        private int ObtenerIdEmpleadoPorNombre(DataGridView dgv, string nombre)
        {
            foreach (DataGridViewRow fila in dgv.Rows)
            {
                if (fila.Cells["NomER"].Value.ToString() == nombre)
                {
                    return Convert.ToInt32(fila.Cells["IdEmpleado"].Value);
                }
            }
            return -1; // No encontrado
        }
        private void btnAsignarEnvio_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un pedido para asignar personal.");
                return;
            }

            if (txtAlmacenAsig1.Text == "" || txtAlmacenAsig2.Text == "" || txtRepartidorAsig.Text == "")
            {
                MessageBox.Show("Debes asignar 2 empleados de almacén y 1 repartidor.");
                return;
            }
            // Obtener ID del pedido seleccionado
            int pedidoIndex = dgvPedidos.SelectedRows[0].Index;
            var pedido = Logica_PedidosTemporales.Instancia.PedidosPendientes[pedidoIndex];
            // Asignar IDs desde Tag
            pedido.Almacen1_Id = Convert.ToInt32(txtAlmacenAsig1.Tag);
            pedido.Almacen2_Id = Convert.ToInt32(txtAlmacenAsig2.Tag);
            pedido.Repartidor_Id = Convert.ToInt32(txtRepartidorAsig.Tag);

            pedido.estadoEnvio = "Asignado";

            MessageBox.Show("Personal asignado al pedido correctamente.");
            // Refrescar tabla
            CargarPedidosPendientes(); // volver a llamar al método que llena el dgvPedidosTemp
            EstadoPedidos seguimiento = new EstadoPedidos();
            seguimiento.ShowDialog();
        }
    }
}
