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
    public partial class Frm_Clientes : Form
    {
        private int idClienteActual = 0;
        public Frm_Clientes()
        {
            InitializeComponent();
            dtpFechRegC.MinDate = DateTime.Now;
            dtpFechRegC.CustomFormat = "dd/MM/yyyy";
            MostrarClientes();

        }

        private void LimpiarCampos()
        {
            txtIDc.Clear();
            txtNomC.Clear();
            txtApeC.Clear();
            txtNumC.Clear();
            txtDniC.Clear();
            dtpFechRegC.Value = DateTime.Now;
        }

        private void MostrarClientes()
        {
            dgvClientes.DataSource = Logica_Cliente.Listadocl("");
        }

        private void btnNuevoCli_Click(object sender, EventArgs e)
        {
            if (txtNomC.Text == "" || txtApeC.Text == "" || txtNumC.Text == "" || txtDniC.Text == "")
            {
                MessageBox.Show("Ingresa todos los datos del cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Entidad_Cliente cliente = new Entidad_Cliente
            {
                id = int.Parse(txtIDc.Text),
                nombre = txtNomC.Text,
                apellido = txtApeC.Text,
                numero = int.Parse(txtNumC.Text),
                dni = txtDniC.Text, // ⚠️ o usa ToString si cambias a string
                fecha_registro = dtpFechRegC.Value
            };

            string rpta = Logica_Cliente.Guardado_cl(1, cliente);

            if (rpta == "Vale")
            {
                MessageBox.Show("Cliente guardado exitosamente", "Nuevo cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarClientes();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show(rpta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarCli_Click(object sender, EventArgs e)
        {
            if (txtIDc.Text == "")
            {
                MessageBox.Show("El ID es obligatorio para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("¿Estás seguro de eliminar este cliente?", "Eliminar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                string rpta = Logica_Cliente.Eliminar_cl(int.Parse(txtIDc.Text));
                if (rpta == "Vale")
                {
                    MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarClientes();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(rpta, "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnActualizarCli_Click(object sender, EventArgs e)
        {
            if (txtIDc.Text == "")
            {
                MessageBox.Show("El ID del cliente es obligatorio para actualizar.", "Actualizar cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Entidad_Cliente cliente = new Entidad_Cliente
            {
                id = int.Parse(txtIDc.Text),
                nombre = txtNomC.Text.Trim(),
                apellido = txtApeC.Text.Trim(),
                numero = int.Parse(txtNumC.Text),
                dni = txtDniC.Text.Trim(), // ⚠️ Cambiar a string si deseas todo el DNI
                fecha_registro = dtpFechRegC.Value
            };

            string rpta = Logica_Cliente.Guardado_cl(2, cliente);
            if (rpta == "Vale")
            {
                MessageBox.Show("Cliente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarClientes();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show(rpta, "Error al actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
                  MostrarClientes();
        }


        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // Si hay una fila válida seleccionada (no cabecera ni clic fuera del rango)
            if (e.RowIndex >= 0 && dgvClientes.Rows[e.RowIndex].Selected)
            {
                DataGridViewRow row = dgvClientes.Rows[e.RowIndex];

                txtIDc.Text = row.Cells["id"].Value.ToString();
                txtNomC.Text = row.Cells["nombre"].Value.ToString();
                txtApeC.Text = row.Cells["apellido"].Value.ToString();
                txtNumC.Text = row.Cells["numero"].Value.ToString();
                txtDniC.Text = row.Cells["dni"].Value.ToString();

                // Evitar error si la celda es null
                if (row.Cells["fecha_registro"].Value != DBNull.Value)
                {
                    //dtpFechRegC.Value = Convert.ToDateTime(row.Cells["fecha_registro"].Value);
                    DateTime fecha = Convert.ToDateTime(dgvClientes.Rows[e.RowIndex].Cells["fecha_registro"].Value);
                    if (fecha < dtpFechRegC.MinDate)
                        dtpFechRegC.Value = dtpFechRegC.MinDate;
                    else
                        dtpFechRegC.Value = fecha;
                }
            }
            else
            {
                // Si no hay una fila válida o fue deseleccionada, limpiar campos
                LimpiarCampos();
            }
        }
    }
      
    
}
