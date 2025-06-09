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
    public partial class Frm_Pedidos : Form
    {
        public Frm_Pedidos()
        {
            InitializeComponent();
            dtpHoraEnvio.MinDate = DateTime.Now;
            dtpHoraEnvio.CustomFormat = "hh:mm  tt";
            dtpHoraEntrega.MinDate = DateTime.Now;
            dtpHoraEntrega.CustomFormat = "hh:mm  tt";
            dtpFechaEntrega.MinDate = DateTime.Now;
            dtpFechaEntrega.CustomFormat = "dd/MM/yyyy";
        }
        private void chConfirmaDiaEnv_CheckedChanged(object sender, EventArgs e)
        {
            if (chConfirmaDiaEnv.Checked)
            {
                dtpHoraEntrega.Enabled = true;
                dtpFechaEntrega.Enabled = false;
            }
            else
            {
                dtpHoraEntrega.Enabled = false;
                dtpFechaEntrega.Enabled = true;
            }
        }
        private void btnAsignar_Click(object sender, EventArgs e)
        {

        }
        private void btnVerEstadosPed_Click(object sender, EventArgs e)
        {
            EstadoPedidos estadoPedidos = new EstadoPedidos();
            estadoPedidos.ShowDialog();
        }
    }
}
