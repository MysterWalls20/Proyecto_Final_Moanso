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
        public Frm_NuevaVenta()
        {
            InitializeComponent();
        }
        private void btnVender_Click(object sender, EventArgs e)
        {

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
    }
}
