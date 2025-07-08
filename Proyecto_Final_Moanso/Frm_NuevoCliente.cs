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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Proyecto_Final_Moanso
{
    public partial class Frm_NuevoCliente : Form
    {
        public Frm_NuevoCliente()
        {
            InitializeComponent();
            CargarRubro();
        }
        private void Frm_NuevoCliente_Load(object sender, EventArgs e)
        {
            cboTipoCliente.Items.Clear();
            cboTipoCliente.Items.Add("Natural");
            cboTipoCliente.Items.Add("Jurídico");
            cboTipoCliente.SelectedIndex = -1;

            cboDepartamento.DataSource = Logica_Ubigeo.Instancia.ObtenerDepartamentos();
            cboDepartamento.DisplayMember = "NombreDepartamento";
            cboDepartamento.ValueMember = "IdDepartamento";
            cboDepartamento.SelectedIndex = -1;

            cboTipoCliente.SelectedIndexChanged += cboTipoCliente_SelectedIndexChanged;
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
            cbmRubro.Enabled = !esNatural;

            txtDireccion.Enabled = true;
            txtNumero.Enabled = true;
            txtRUC.Enabled = true;
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

        private void CargarRubro()
        {
            cbmRubro.DataSource = Logica_Rubro.Instancia.ListarRubro();
            cbmRubro.DisplayMember = "rubro";
            cbmRubro.ValueMember = "id_rubro";
            cbmRubro.SelectedIndex = -1;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cboTipoCliente.Text == "")
            {
                MessageBox.Show("Por favor, seleccione un tipo de cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int idDepartamento = (int)cboDepartamento.SelectedValue;
                int idProvincia = (int)cboProvincia.SelectedValue;
                int idDistrito = (int)cboDistrito.SelectedValue;

                //int idUbigeo = Logica_Ubigeo.Instancia.ObtenerIdUbigeo(idDepartamento, idProvincia, idDistrito);

                string tipoCliente = cboTipoCliente.Text;

                if (tipoCliente == "Natural")
                {
                    if (cboDepartamento.Text == "" || txtDireccion.Text == "" || txtNumero.Text == ""
                        || txtRUC.Text == "" || txtNombre.Text == "" || txtApellido.Text == "" || txtDni.Text == "")
                    {
                        MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Entidad_Cliente cliente = new Entidad_Cliente
                        {
                            Direccion = txtDireccion.Text,
                            Numero = Convert.ToInt32(txtNumero.Text),
                            Ruc = Convert.ToInt64(txtRUC.Text),
                            Nombre = txtNombre.Text,
                            Apellido = txtApellido.Text,
                            Dni = txtDni.Text
                        };
                        Logica_Cliente.Instancia.RegistrarClienteNatural(
                         cliente,
                         idDepartamento,
                         idProvincia,
                         idDistrito,
                         1 // id_tipo_cliente → Natural
                        );
                    }
                }
                else if (tipoCliente == "Jurídico")
                {
                    if (cboDepartamento.Text == "" || txtDireccion.Text == "" || txtNumero.Text == ""
                        || txtRUC.Text == "" || txtRazonSocial.Text == "" || cbmRubro.Text == "")
                    {
                        MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Entidad_Cliente cliente = new Entidad_Cliente
                        {
                            Direccion = txtDireccion.Text,
                            Numero = Convert.ToInt32(txtNumero.Text),
                            Ruc = Convert.ToInt64(txtRUC.Text),
                            RazonSocial = txtRazonSocial.Text,
                            Rubro = cbmRubro.Text
                        };

                        Logica_Cliente.Instancia.RegistrarClienteJuridico(
                            cliente,
                            idDepartamento,
                            idProvincia,
                            idDistrito,
                            2 // id_tipo_cliente → Jurídico
                        );
                    }
                }
                MessageBox.Show("Cliente registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
