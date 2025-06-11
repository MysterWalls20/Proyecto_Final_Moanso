using Capa_Entidad;
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
    public partial class Frm_NuevaVenta : Form
    {
        Control panelPrincipal;
        public Frm_NuevaVenta(Control panelPrincipal)
        {
            InitializeComponent();
            txtFechaV.Text = DateTime.Now.ToString("dd/MM/yyyy");
            this.panelPrincipal = panelPrincipal;
        }
        private void Frm_NuevaVenta_Load(object sender, EventArgs e)
        {
            txtIdV.KeyPress += textBoxSoloNumeros_KeyPress;
            txtCantidadV.KeyPress += textBoxSoloNumeros_KeyPress;
            txtDniV.KeyPress += textBoxSoloNumeros_KeyPress;
        }
        private void textBoxSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y tecla de borrar (Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void abrirFormHijo(Form formhijo)
        {
            if (this.panelPrincipal.Controls.Count > 0)
                this.panelPrincipal.Controls.RemoveAt(0);
            formhijo.TopLevel = false;
            formhijo.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(formhijo);
            this.panelPrincipal.Tag = formhijo;
            this.panelPrincipal.Text = formhijo.Text;
            formhijo.Show();
        }
        private void btnVender_Click(object sender, EventArgs e)
        {
            //Aqui se evalua si hay direccion por parte del usuario para reservar el envio y los productos pedidos
            if(txtDireccionPed.Text != "" && txtDniV.Text != "" && txtClienV.Text != "" && dgvProductosV.Rows.Count > 0)
            {
                //nos enviara al Frm_pedidos para terminar de asignar el envio, la venta y su estado.
                abrirFormHijo(new Frm_Pedidos());
            }
            else if(dgvProductosV.Rows.Count > 0 && txtClienV.Text != "")
            {
                //registrar venta
            }
            else
            {
                MessageBox.Show("Ingrese los datos de los productos a vender", "Érror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void chEnviar_CheckedChanged(object sender, EventArgs e)
        {
            if(chEnviar.Checked)
            {
                txtDireccionPed.Enabled = true;
            }else
            {
                txtDireccionPed.Enabled = false;
            }
        }

        private void txtIdV_Enter(object sender, EventArgs e)
        {
            //Busca el id del producto y carga los datos en los Texbox de arriba de la tabla de venta
            if (txtIdV.Text == "")
            {

            }
            else{
                Entidad_Productos ePr = new Entidad_Productos();
            }
        }

        private void txtDniV_Enter(object sender, EventArgs e)
        {
            //Busca al cliente y carga su nombre al texbox
        }
    }
}
