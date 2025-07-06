using Capa_Entidad;
using Capa_Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Moanso
{
    public partial class Frm_MantClientes : Form
    {    
        public Frm_MantClientes()
        {
            InitializeComponent();
        }
        private void Frm_Clientes_Load(object sender, EventArgs e)
        {
            CargarClientesActivos();
        }
        private void CargarClientesActivos()
        {
            dgvClientes.DataSource = Logica_Cliente.Instancia.ListarClientesActivos();
            int totalFilas = dgvClientes.AllowUserToAddRows
            ? dgvClientes.Rows.Count - 1
    :       dgvClientes.Rows.Count;
            lbNumRegCli.Text = "" + totalFilas.ToString();

        }
        private void btnMostrarDesh_Click(object sender, EventArgs e)
        {
            dgvClientes.DataSource = Logica_Cliente.Instancia.ListarClientesInactivos();
            int total = dgvClientes.AllowUserToAddRows
            ? dgvClientes.Rows.Count - 1
            : dgvClientes.Rows.Count;
            lbNumRegCli.Text = "" + total;
        }
        private void btnNuevoCli_Click(object sender, EventArgs e)
        {
            Frm_NuevoCliente nuevoCliente = new Frm_NuevoCliente();
            nuevoCliente.ShowDialog();
            CargarClientesActivos();
        }
        private void btnLeer_Click(object sender, EventArgs e)
        {
            CargarClientesActivos();
        }

        private void btnModificarCli_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                // Captura de fila actual seleccionada
                DataGridViewRow fila = dgvClientes.SelectedRows[0];
                // Llenar objeto con datos de la fila
                Entidad_Cliente Mcliente = new Entidad_Cliente()
                {
                    ID = Convert.ToInt32(fila.Cells["ID"].Value),
                    TipoCliente = fila.Cells["Tipo Cliente"].Value.ToString(),
                    Nombre = fila.Cells["Nombre"].Value.ToString(),
                    Apellido = fila.Cells["Apellido"].Value.ToString(),
                    Dni = fila.Cells["Dni"].Value.ToString(),
                    Ruc = long.Parse(fila.Cells["Ruc"].Value.ToString()),
                    RazonSocial = fila.Cells["Razon S."].Value.ToString(),
                    Rubro = fila.Cells["Rubro"].Value.ToString(),
                    Numero = Convert.ToInt32(fila.Cells["Numero"].Value),
                    Direccion = fila.Cells["Direccion"].Value.ToString()
                };

                // Pasar datos del producto al formulario de actualización
                Frm_ModificarCliente ModificarCliente = new Frm_ModificarCliente(Mcliente);
                ModificarCliente.ShowDialog();
                CargarClientesActivos();
            }
            //if (txtIDc.Text == "")
            //{
            //    MessageBox.Show("El ID del cliente es obligatorio para actualizar.", "Actualizar cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //try
            //{
            //    Entidad_Cliente eCl = new Entidad_Cliente();

            //    eCl.id = int.Parse(txtIDc.Text.Trim());
            //    eCl.nombre = txtNomC.Text.Trim();
            //    eCl.apellido = txtApeC.Text.Trim();
            //    eCl.numero = int.Parse(txtNumC.Text.Trim());
            //    eCl.dni = txtDniC.Text.Trim();
            //    Logica_Cliente.Instancia.EditaCliente(eCl);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error.." + ex);
            //}
            //LimpiarCampos();
            //listarCliente();
        }

        private void btnDeshabilitarCli_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                int idCliente = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["ID"].Value);
                string estado = dgvClientes.SelectedRows[0].Cells["Estado"].Value.ToString();

                if (estado != "Activo")
                {
                    MessageBox.Show("Este cliente ya está deshabilitado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirm = MessageBox.Show("¿Desea deshabilitar este cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    Logica_Cliente.Instancia.DeshabilitarCliente(idCliente);
                    MessageBox.Show("Cliente deshabilitado correctamente.");
                    CargarClientesActivos(); // Actualizar vista
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHabilitarCli_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                int idCliente = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["ID"].Value);
                string estado = dgvClientes.SelectedRows[0].Cells["Estado"].Value.ToString();

                if (estado != "Inactivo")
                {
                    MessageBox.Show("Este cliente ya está habilitado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirm = MessageBox.Show("¿Desea habilitar este cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    Logica_Cliente.Instancia.HabilitarCliente(idCliente);
                    MessageBox.Show("Cliente habilitado correctamente.");
                    CargarClientesActivos(); // Actualizar vista
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBusCliente_Click(object sender, EventArgs e)
        {
            string Cliente = txtBuscarCli.Text;

        }
    } 
}
