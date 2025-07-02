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
            CargarCiudad();
            CargarRubro();
            MostrarProveedores();
        }

        private void LimpiarCampos()
        {
            txtBuscar.Clear();
            txtRazSoc.Clear();
            txtRuc.Clear();
            txtDireccion.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            cbmCiudad.SelectedIndex = -1;
            cbmRubro.SelectedIndex = -1;
            dgvProveedor.ClearSelection();
        }

        private void CargarCiudad()
        {
            cbmCiudad.DataSource = Logica_Ciudad.Instancia.ListarCiudad();
            cbmCiudad.DisplayMember = "nombre";
            cbmCiudad.ValueMember = "id_ciudad";
            cbmCiudad.SelectedIndex = -1;
        }

        private void CargarRubro()
        {
            cbmRubro.DataSource = Logica_Rubro.Instancia.ListarRubro();
            cbmRubro.DisplayMember = "descripcion";
            cbmRubro.ValueMember = "id_rubro";
            cbmRubro.SelectedIndex = -1;
        }

        private void MostrarProveedores()
        {
            var lista = Logica_Proveedor.Instancia.ListarProveedor();

            var listaFormateada = lista.Select(p => new
            {
                ID = p.id,
                RazonSocial = p.razon_social,
                RUC = p.ruc,
                Direccion = p.direccion,
                Telefono = p.telefono,
                Email = p.email,
                Ciudad = p.Ciudad.nombre,           
                Rubro = p.Rubro.descripcion         
            }).ToList();

            dgvProveedor.DataSource = listaFormateada;
        }

        private void btnNuevoProv_Click(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "" || txtRazSoc.Text == "" || txtRuc.Text == "" )
            {
                MessageBox.Show("Ingresa todos los datos del Proveedor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Entidad_Proveedor eProv = new Entidad_Proveedor();
                eProv.razon_social = txtRazSoc.Text.Trim().ToLower();
                eProv.ruc = int.Parse(txtRuc.Text.Trim());
                eProv.direccion = txtDireccion.Text.Trim() ;
                eProv.telefono = int.Parse(txtTelefono.Text.Trim());
                eProv.email = txtEmail.Text.Trim();
                eProv.estado = true;
                eProv.Ciudad = new Entidad_ciudad { id_ciudad = Convert.ToInt32(cbmCiudad.SelectedValue) };
                eProv.Rubro = new Entidad_rubro { id_rubro = Convert.ToInt32(cbmRubro.SelectedValue) };
                Logica_Proveedor.Instancia.InsertaProveedor(eProv);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            MostrarProveedores();
            LimpiarCampos();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarProveedores();
        }

        private void btnActualizarProv_Click(object sender, EventArgs e)
        {
            Entidad_Proveedor prov = new Entidad_Proveedor
            {
                id = idProveedorSeleccionado,
                razon_social = txtRazSoc.Text,
                ruc = int.Parse(txtRuc.Text),
                direccion = txtDireccion.Text,
                telefono = int.Parse(txtTelefono.Text),
                email = txtEmail.Text,
                estado = true,
                Ciudad = (Entidad_ciudad)cbmCiudad.SelectedItem,
                Rubro = (Entidad_rubro)cbmRubro.SelectedItem
            };

            Logica_Proveedor.Instancia.EditaCliente(prov);
            MessageBox.Show("Proveedor actualizado");
            MostrarProveedores();
            LimpiarCampos();
        }

        private void btnEliminarProv_Click(object sender, EventArgs e)
        {
            if (idProveedorSeleccionado == 0)
            {
                MessageBox.Show("Seleccione la fila de un proveedor para deshabilitar");
                return;
            }

            Entidad_Proveedor prov = new Entidad_Proveedor
            {
                id = idProveedorSeleccionado
            };

            Logica_Proveedor.Instancia.DeshabilitarProveedor(prov);
            MessageBox.Show("Proveedor inhabilitado");
            MostrarProveedores();
            LimpiarCampos();
        }

        private int idProveedorSeleccionado = 0;
        private int ultimaFilaSeleccionada = -1;

        private void dgvProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.RowIndex == ultimaFilaSeleccionada)
                {
                    // Si haces clic otra vez en la misma fila, limpia los campos
                    LimpiarCampos();
                    idProveedorSeleccionado = 0;
                    ultimaFilaSeleccionada = -1;
                }
                else
                {
                    // Cargar datos en los campos
                    DataGridViewRow fila = dgvProveedor.Rows[e.RowIndex];

                    idProveedorSeleccionado = Convert.ToInt32(fila.Cells["ID"].Value);
                    txtRazSoc.Text = fila.Cells["RazonSocial"].Value.ToString();
                    txtRuc.Text = fila.Cells["RUC"].Value.ToString();
                    txtDireccion.Text = fila.Cells["Direccion"].Value.ToString();
                    txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
                    txtEmail.Text = fila.Cells["Email"].Value.ToString();

                    cbmCiudad.SelectedItem = cbmCiudad.Items.Cast<Entidad_ciudad>()
                        .FirstOrDefault(c => c.nombre == fila.Cells["Ciudad"].Value.ToString());

                    cbmRubro.SelectedItem = cbmRubro.Items.Cast<Entidad_rubro>()
                        .FirstOrDefault(r => r.descripcion == fila.Cells["Rubro"].Value.ToString());
                    ultimaFilaSeleccionada = e.RowIndex;
                }
            }
        }
    }
}
