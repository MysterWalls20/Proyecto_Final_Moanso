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
            //listarCliente();
        }
        private void Frm_Clientes_Load(object sender, EventArgs e)
        {
            //CargarDepartamentos();
            //cmbDepartamento.SelectedIndexChanged += cmbDepartamento_SelectedIndexChanged;
        }
        public void listarCliente()
        {
            dgvClientes.DataSource = Logica_Cliente.Instancia.ListarCliente();
        }
        private void btnNuevoCli_Click(object sender, EventArgs e)
        {
            Frm_NuevoCliente nuevoCliente = new Frm_NuevoCliente();
            nuevoCliente.ShowDialog();
            //if (txtNomC.Text == "" || txtApeC.Text == "" || txtNumC.Text == "" || txtDniC.Text == "")
            //{
            //    MessageBox.Show("Ingresa todos los datos del cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //try
            //{
            //    Entidad_Cliente eCl = new Entidad_Cliente();
            //    eCl.nombre = txtNomC.Text.Trim();
            //    eCl.apellido = txtApeC.Text.Trim();
            //    eCl.numero = int.Parse(txtNumC.Text.Trim());
            //    eCl.dni = txtDniC.Text.Trim();
            //    eCl.estado = true;
            //    Logica_Cliente.Instancia.InsertaCliente(eCl);

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error.." + ex);
            //}

            //MessageBox.Show("Cliente guardado exitosamente", "Nuevo cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //listarCliente();
            //LimpiarCampos();

        }

        private void btnEliminarCli_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Entidad_Cliente c = new Entidad_Cliente();
            //    int id;
            //    if (int.TryParse(txtIDc.Text.Trim(), out id))
            //    {
            //        c.id = id;
            //        Logica_Cliente.Instancia.DeshabilitarCliente(c);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Ingrese un ID válido antes de eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return; // Detiene la ejecución si el ID no es válido
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}
            //LimpiarCampos();
            //listarCliente();
        }

        private void btnActualizarCli_Click(object sender, EventArgs e)
        {
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
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            listarCliente();
        }
        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Si hay una fila válida seleccionada (no cabecera ni clic fuera del rango)
            //if (e.RowIndex >= 0 && dgvClientes.Rows[e.RowIndex].Selected)
            //{
            //    DataGridViewRow row = dgvClientes.Rows[e.RowIndex];

            //    txtIDc.Text = row.Cells["id"].Value.ToString();
            //    txtNomC.Text = row.Cells["nombre"].Value.ToString();
            //    txtApeC.Text = row.Cells["apellido"].Value.ToString();
            //    txtNumC.Text = row.Cells["numero"].Value.ToString();
            //    txtDniC.Text = row.Cells["dni"].Value.ToString();
            //}
            //else
            //{
            //    // Si no hay una fila válida o fue deseleccionada, limpiar campos
            //    LimpiarCampos();
            //}
        }
    } 
}
