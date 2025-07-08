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
    public partial class Frm_ModificarCliente : Form
    {
        private Entidad_Cliente clienteSelect;

        public Frm_ModificarCliente(Entidad_Cliente Mcliente)
        {
            InitializeComponent();
            clienteSelect = Mcliente;
        }
        private void Frm_ModificarCliente_Load(object sender, EventArgs e)
        {
            cboTipoCliente.Items.Clear();
            cboTipoCliente.Items.Add("Natural");
            cboTipoCliente.Items.Add("Jurídico");
            cboTipoCliente.Text = clienteSelect.TipoCliente;
            cboTipoCliente.Enabled = false;

            cboDepartamento.DataSource = Logica_Ubigeo.Instancia.ObtenerDepartamentos();
            cboDepartamento.DisplayMember = "NombreDepartamento";
            cboDepartamento.ValueMember = "IdDepartamento";
            cboDepartamento.SelectedIndex = -1;
            CargarDatosCliente();
        }
        private void cboTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool esNatural = cboTipoCliente.Text == "Natural";

            // Natural
            txtNombre.Enabled = esNatural;
            txtApellido.Enabled = esNatural;
            txtDni.Enabled = esNatural;

            // Jurídico
            txtRazonSocial.Enabled = !esNatural;
            txtRubro.Enabled = !esNatural;

            txtDireccion.Enabled = true;
            txtNumero.Enabled = true;
            txtRUC.Enabled = true;
        }
        private void CargarDatosCliente()
        {
            if (cboTipoCliente.Text == "Natural")
            {
                txtNombre.Text = clienteSelect.Nombre;
                txtApellido.Text = clienteSelect.Apellido;
                txtDni.Text = clienteSelect.Dni.ToString();
                txtNumero.Text = clienteSelect.Numero.ToString();
                txtDireccion.Text = clienteSelect.Direccion;
                txtRUC.Text = clienteSelect.Ruc.ToString();
            }
            else if (cboTipoCliente.Text == "Jurídico")
            {
                txtNumero.Text = clienteSelect.Numero.ToString();
                txtDireccion.Text = clienteSelect.Direccion;
                txtRUC.Text = clienteSelect.Ruc.ToString();
                txtRazonSocial.Text = clienteSelect.RazonSocial;
                txtRubro.Text = clienteSelect.Rubro;
            }
        }
        private void btnModificarCli_Click(object sender, EventArgs e)
        {

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
