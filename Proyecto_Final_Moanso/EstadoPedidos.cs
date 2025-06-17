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
    public partial class EstadoPedidos : Form
    {
        Timer timerEnvio = new Timer();
        DateTime horaInicio, horaFin;
        Entidad_PedidoTemp pedidoActual;
        public EstadoPedidos()
        {
            InitializeComponent();
            dtpHoraEnvio.MinDate = DateTime.Now;
            dtpHoraEnvio.CustomFormat = "hh:mm  tt";
            dtpHoraEntrega.MinDate = DateTime.Now;
            dtpHoraEntrega.CustomFormat = "hh:mm  tt";
            dgvPedidosEstado.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvPedidosEstado.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        private void EstadoPedidos_Load(object sender, EventArgs e)
        {
            dgvPedidosEstado.Rows.Clear();

            foreach (var pedido in Logica_PedidosTemporales.Instancia.PedidosPendientes)
            {
                if (!string.IsNullOrEmpty(pedido.estadoEnvio)) // Solo si ya se asignó
                {
                    string personalAlmacen = $"{pedido.Almacen1_Id}\n{pedido.Almacen2_Id}";
                    string repartidor = pedido.Repartidor_Id.ToString(); // Puedes reemplazar por nombre

                    dgvPedidosEstado.Rows.Add(
                        pedido.Id,
                        pedido.ClienteId, // o nombre si lo tienes mapeado
                        pedido.DireccionEntrega,
                        personalAlmacen,
                        repartidor,
                        pedido.estadoEnvio
                    );
                }
            }
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (dgvPedidosEstado.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un pedido.");
                return;
            }

            DateTime horaSalida = dtpHoraEnvio.Value;
            DateTime horaEntrega = dtpHoraEntrega.Value;

            if (horaEntrega <= horaSalida)
            {
                MessageBox.Show("La hora de entrega debe ser mayor a la de salida.");
                return;
            }

            // Obtener el ID
            int idPedido = Convert.ToInt32(dgvPedidosEstado.SelectedRows[0].Cells["ID"].Value);
            var pedido = Logica_PedidosTemporales.Instancia.PedidosPendientes.FirstOrDefault(p => p.Id == idPedido);

            if (pedido != null)
            {
                pedido.HoraSalida = horaSalida;
                pedido.HoraEntrega = horaEntrega;
                pedido.estadoEnvio = "Inicio";

                // Marcar empleados como disponibles nuevamente
                Logica_Empleado.Instancia.MarcarDisponible(pedido.Almacen1_Id);
                Logica_Empleado.Instancia.MarcarDisponible(pedido.Almacen2_Id);
                Logica_Empleado.Instancia.MarcarDisponible(pedido.Repartidor_Id);
                //CargarEmpleadosDisponibles();
                IniciarTimerEnvio(pedido); // Inicia la barra de progreso
            }
        }
        //private void CargarEmpleadosDisponibles()
        //{
        //    dgvPerAlmacen.DataSource = null;
        //    dgvPerAlmacen.DataSource = Logica_Empleado.Instancia.ListarEmpleadosPorRol("Per. Almacen");

        //    dgvPerReparto.DataSource = null;
        //    dgvPerReparto.DataSource = Logica_Empleado.Instancia.ListarEmpleadosPorRol("Per. Repartidor");
        //}
        private void IniciarTimerEnvio(Entidad_PedidoTemp pedido)
        {
            pedidoActual = pedido;
            horaInicio = pedido.HoraSalida;
            horaFin = pedido.HoraEntrega;

            timerEnvio.Interval = 1000; // cada segundo
            timerEnvio.Tick += timer1_Tick;
            timerEnvio.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan total = horaFin - horaInicio;
            TimeSpan transcurrido = DateTime.Now - horaInicio;

            double porcentaje = (transcurrido.TotalSeconds / total.TotalSeconds) * 100;
            if (porcentaje >= 100) porcentaje = 100;

            progressBarEnvio.Value = (int)porcentaje;
            lbPorcentajeEnv.Text = $"{(int)porcentaje}%";

            if (porcentaje < 50)
                pedidoActual.estadoEnvio = "Inicio";
            else if (porcentaje < 100)
                pedidoActual.estadoEnvio = "Mitad";
            else
            {
                pedidoActual.estadoEnvio = "Entregado";
                if (!pedidoActual.RegistradoComoVenta)
                {
                    Logica_PedidosTemporales.Instancia.FinalizarPedidoYRegistrarVenta(pedidoActual);
                    pedidoActual.RegistradoComoVenta = true;
                }
                timerEnvio.Stop();
                // Aquí puedes convertirlo a una venta real en SQL y quitarlo de la lista temporal:
                RegistrarVentaDePedido(pedidoActual);
                Logica_PedidosTemporales.Instancia.PedidosPendientes.Remove(pedidoActual);
                MessageBox.Show("Pedido entregado y registrado como venta.");
                this.Close();
            }
            // Actualiza en el DGV también si deseas
            ActualizarEstadoEnGrid(pedidoActual);
        }
        private void ActualizarEstadoEnGrid(Entidad_PedidoTemp pedido)
        {
            foreach (DataGridViewRow row in dgvPedidosEstado.Rows)
            {
                if (Convert.ToInt32(row.Cells["IDped"].Value) == pedido.Id)
                {
                    row.Cells["EstPed"].Value = pedido.estadoEnvio;
                    break;
                }
            }
        }
        private void RegistrarVentaDePedido(Entidad_PedidoTemp pedido)
        {
            try
            {
                bool ventaRegistrada = Logica_Ventas.Instancia.RegistrarVentaDesdePedido(pedido);
                if (ventaRegistrada)
                {
                    // Opcional: quitar el pedido de la lista temporal
                    Logica_PedidosTemporales.Instancia.PedidosPendientes.Remove(pedido);
                    MessageBox.Show("Pedido entregado y venta registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo registrar la venta del pedido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPedidosEstado.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un pedido entregado para quitar.");
                return;
            }
            string estado = dgvPedidosEstado.CurrentRow.Cells["EstadoEnvio"].Value.ToString();
            if (estado != "Entregado")
            {
                MessageBox.Show("Solo se pueden quitar pedidos con estado 'Entregado'.");
                return;
            }
            // Quitar visualmente del DataGridView
            dgvPedidosEstado.Rows.Remove(dgvPedidosEstado.CurrentRow);
        }
        private void pbCerrarEstado_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbCerrarEstado_MouseDown(object sender, MouseEventArgs e)
        {
            pbCerrarEstado.BackColor = Color.Red;
        }
    }
}
