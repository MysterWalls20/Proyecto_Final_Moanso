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
        }
        private void chkNatural_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNatural.Checked)
            {
                LimpiarCamposJ();
                chkJuridico.Checked = false;
                txtNomC.Enabled = true;
                txtApeC.Enabled = true;
                txtDniC.Enabled = true;
                txtNumC.Enabled = true;
                txtDIreccionC.Enabled = true;
            }
            else
            {
                LimpiarCamposN();
                txtNomC.Enabled = false;
                txtApeC.Enabled = false;
                txtDniC.Enabled = false;
                txtNumC.Enabled = false;
                txtDIreccionC.Enabled = false;
            }
        }
        private void chkJuridico_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJuridico.Checked)
            {
                LimpiarCamposN();
                chkNatural.Checked = false;
                txtRuc.Enabled = true;
                txtRazonS.Enabled = true;
                txtNumC.Enabled = true;
                txtDIreccionC.Enabled = true;
            }
            else
            {
                LimpiarCamposJ();
                txtRuc.Enabled = false;
                txtRazonS.Enabled = false;
                txtNumC.Enabled = false;
                txtDIreccionC.Enabled = false;
            }
        }
        private void LimpiarCamposN()
        {
            txtNomC.Clear();
            txtApeC.Clear();
            txtDniC.Clear();
            txtNumC.Clear();
            txtDIreccionC.Clear();
        }
        private void LimpiarCamposJ()
        {
            txtRuc.Clear();
            txtRazonS.Clear();
            txtNumC.Clear();
            txtDIreccionC.Clear();
        }
        private void btnGuardarCli_Click(object sender, EventArgs e)
        {

        }
        private void btnCancelarCli_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
