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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Proyecto_Final_Moanso
{
    public partial class Frm_Proveedor : Form
    {
        public Frm_Proveedor()
        {
            InitializeComponent();
            CargarRubro();
            MostrarProveedores();
        }

        private void LimpiarCampos()
        {
            txtBuscar.Clear();
            txtRazSoc.Clear();
            txtRuc.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            cbmRubro.SelectedIndex = -1;
            cboDepartamento.SelectedIndex = -1;
            cboDistrito.SelectedIndex = -1;
            cboProvincia.SelectedIndex = -1;
            dgvProveedor.ClearSelection();
        }

        private void CargarRubro()
        {
            cbmRubro.DataSource = Logica_Rubro.Instancia.ListarRubro();
            cbmRubro.DisplayMember = "rubro";
            cbmRubro.ValueMember = "id_rubro";
            cbmRubro.SelectedIndex = -1;
        }

        private void MostrarProveedores()
        {
            dgvProveedor.DataSource = Logica_Proveedor.Instancia.ListarProveedoresActivos();

            int totalFilas = dgvProveedor.AllowUserToAddRows
                ? dgvProveedor.Rows.Count - 1
                : dgvProveedor.Rows.Count;
        }

        private void MostrarProveedoresInactivo()
        {
            dgvProveedor.DataSource = Logica_Proveedor.Instancia.ListarProveedoresInactivos();

            int totalFilas = dgvProveedor.AllowUserToAddRows
                ? dgvProveedor.Rows.Count - 1
                : dgvProveedor.Rows.Count;
        }
        private void Frm_Proveedor_Load(object sender, EventArgs e)
        {
            cboDepartamento.DataSource = Logica_Ubigeo.Instancia.ObtenerDepartamentos();
            cboDepartamento.DisplayMember = "NombreDepartamento";
            cboDepartamento.ValueMember = "IdDepartamento";
            cboDepartamento.SelectedIndex = -1;
        }
        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartamento.SelectedValue is int idDepartamento)
            {
                cboProvincia.DataSource = Logica_Ubigeo.Instancia.ObtenerProvincias(idDepartamento);
                cboProvincia.DisplayMember = "NombreProvincia";
                cboProvincia.ValueMember = "IdProvincia";
                cboProvincia.SelectedIndex = -1;
            }
        }
        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProvincia.SelectedValue is int idProvincia)
            {
                cboDistrito.DataSource = Logica_Ubigeo.Instancia.ObtenerDistritos(idProvincia);
                cboDistrito.DisplayMember = "NombreDistrito";
                cboDistrito.ValueMember = "IdDistrito";
                cboDistrito.SelectedIndex = -1;
            }
        }
        private void dgvProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvProveedor.Rows[e.RowIndex].IsNewRow)
                return;

            if (ultimaFilaSeleccionada == e.RowIndex)
            {
                // Deselecciona si ya estaba seleccionada
                dgvProveedor.ClearSelection();
                ultimaFilaSeleccionada = -1;
                LimpiarCampos();
                idProveedorSeleccionado = 0;
                return;
            }

            ultimaFilaSeleccionada = e.RowIndex;

            DataGridViewRow fila = dgvProveedor.Rows[e.RowIndex];
            idProveedorSeleccionado = Convert.ToInt32(fila.Cells[0].Value); // Usa el índice o nombre correcto

            // Buscar proveedor desde BD
            Entidad_Proveedor proveedor = Logica_Proveedor.Instancia.BuscarProveedorPorID(idProveedorSeleccionado);

            if (proveedor != null)
            {
                txtRazSoc.Text = proveedor.razon_social;
                txtRuc.Text = proveedor.ruc.ToString();
                txtDireccion.Text = proveedor.direccion;
                txtTelefono.Text = proveedor.telefono.ToString();
                cbmRubro.SelectedValue = proveedor.Rubro.id_rubro;
                // puedes cargar también ubigeo si quieres

                // Obtener Ubigeo
                var (idDep, idProv, idDist) = Logica_Ubigeo.Instancia.ObtenerUbigeoCompleto(proveedor.id_ubigeo);

                // Asignar Departamento
                cboDepartamento.SelectedValue = idDep;

                // Cargar provincias
                cboProvincia.DataSource = Logica_Ubigeo.Instancia.ObtenerProvincias(idDep);
                cboProvincia.DisplayMember = "NombreProvincia";
                cboProvincia.ValueMember = "IdProvincia";
                cboProvincia.SelectedValue = idProv;

                // Cargar distritos
                cboDistrito.DataSource = Logica_Ubigeo.Instancia.ObtenerDistritos(idProv);
                cboDistrito.DisplayMember = "NombreDistrito";
                cboDistrito.ValueMember = "IdDistrito";
                cboDistrito.SelectedValue = idDist;
            }
        }
        private void btnNuevoProv_Click(object sender, EventArgs e)
        {
            if (txtRazSoc.Text == "" || txtRuc.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == ""
            || cbmRubro.SelectedIndex == -1 || cboDepartamento.SelectedIndex == -1
            || cboProvincia.SelectedIndex == -1 || cboDistrito.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Entidad_Proveedor eProv = new Entidad_Proveedor
                {
                    razon_social = txtRazSoc.Text.Trim(),
                    ruc = Convert.ToInt32(txtRuc.Text),
                    direccion = txtDireccion.Text.Trim(),
                    telefono = Convert.ToInt32(txtTelefono.Text),
                    estado = true,
                    Rubro = new Entidad_rubro
                    {
                        id_rubro = Convert.ToInt32(cbmRubro.SelectedValue)
                    }
                };

                int idDepartamento = Convert.ToInt32(cboDepartamento.SelectedValue);
                int idProvincia = Convert.ToInt32(cboProvincia.SelectedValue);
                int idDistrito = Convert.ToInt32(cboDistrito.SelectedValue);

                Logica_Proveedor.Instancia.RegistrarProveedor(eProv, idDepartamento, idProvincia, idDistrito);

                MessageBox.Show("Proveedor registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarProveedores();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarProveedores();
            LimpiarCampos();
        }

        private void btnActualizarProv_Click(object sender, EventArgs e)
        {
            if (idProveedorSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un proveedor para actualizar.");
                return;
            }
            try
            {
                Entidad_Proveedor prov = new Entidad_Proveedor
                {
                    id = idProveedorSeleccionado,
                    razon_social = string.IsNullOrWhiteSpace(txtRazSoc.Text) ? null : txtRazSoc.Text.Trim(),
                    direccion = string.IsNullOrWhiteSpace(txtDireccion.Text) ? null : txtDireccion.Text.Trim(),
                    ruc = string.IsNullOrWhiteSpace(txtRuc.Text) ? 0 : Convert.ToInt32(txtRuc.Text),
                    telefono = string.IsNullOrWhiteSpace(txtTelefono.Text) ? 0 : Convert.ToInt32(txtTelefono.Text),
                    Rubro = cbmRubro.SelectedValue != null
                                ? new Entidad_rubro { id_rubro = Convert.ToInt32(cbmRubro.SelectedValue) }
                                : null
                };

                Logica_Proveedor.Instancia.EditaProveedor(prov);
                MessageBox.Show("Proveedor actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarProveedores();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarProv_Click(object sender, EventArgs e)
        {
            if (idProveedorSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un proveedor de la tabla.");
                return;
            }

            Entidad_Proveedor prov = new Entidad_Proveedor
            {
                id = idProveedorSeleccionado
            };

            Logica_Proveedor.Instancia.DeshabilitarProveedor(prov);
            MessageBox.Show("Proveedor inhabilitado correctamente.");
            MostrarProveedores();
            LimpiarCampos();
            idProveedorSeleccionado = 0;
        }

        private int idProveedorSeleccionado = 0;
        private int ultimaFilaSeleccionada = -1;
        private void btnHabilitadProv_Click(object sender, EventArgs e)
        {
            if (idProveedorSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un proveedor de la tabla.");
                return;
            }

            Entidad_Proveedor prov = new Entidad_Proveedor
            {
                id = idProveedorSeleccionado
            };
            Logica_Proveedor.Instancia.habilitarProveedor(prov);
            MessageBox.Show("Proveedor habilitado correctamente.");
            MostrarProveedores();
            LimpiarCampos();
            idProveedorSeleccionado = 0;
        }

        private void btnMostrarDesh_Click(object sender, EventArgs e)
        {
            MostrarProveedoresInactivo();
            LimpiarCampos();
        }

        private void btnBusProveedor_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Ingrese un nombre para buscar.");
                return;
            }

            DataTable resultado = Logica_Proveedor.Instancia.BuscarProveedorPorNombre(nombre);

            if (resultado.Rows.Count > 0)
            {
                dgvProveedor.DataSource = resultado;

                // Simular clic en primera fila para llenar los datos
                DataGridViewRow fila = dgvProveedor.Rows[0];
                idProveedorSeleccionado = Convert.ToInt32(fila.Cells["id_proveedor"].Value);

                Entidad_Proveedor proveedor = Logica_Proveedor.Instancia.BuscarProveedorPorID(idProveedorSeleccionado);

                if (proveedor != null)
                {
                    txtRazSoc.Text = proveedor.razon_social;
                    txtRuc.Text = proveedor.ruc.ToString();
                    txtDireccion.Text = proveedor.direccion;
                    txtTelefono.Text = proveedor.telefono.ToString();
                    cbmRubro.SelectedValue = proveedor.Rubro.id_rubro;

                    var (idDep, idProv, idDist) = Logica_Ubigeo.Instancia.ObtenerUbigeoCompleto(proveedor.id_ubigeo);

                    cboDepartamento.SelectedValue = idDep;

                    cboProvincia.DataSource = Logica_Ubigeo.Instancia.ObtenerProvincias(idDep);
                    cboProvincia.DisplayMember = "NombreProvincia";
                    cboProvincia.ValueMember = "IdProvincia";
                    cboProvincia.SelectedValue = idProv;

                    cboDistrito.DataSource = Logica_Ubigeo.Instancia.ObtenerDistritos(idProv);
                    cboDistrito.DisplayMember = "NombreDistrito";
                    cboDistrito.ValueMember = "IdDistrito";
                    cboDistrito.SelectedValue = idDist;
                }
            }
            else
            {
                MessageBox.Show("No se encontró proveedor con ese nombre.");
                dgvProveedor.DataSource = null;
                LimpiarCampos();
            }
        }
    }
}
