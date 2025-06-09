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
            //Aqui se evalua si hay direccion por parte del usuario para reservar el envio y los productos pedidos
            //nos enviara al Frm_pedidos para terminar de asignar el envio y su estado.
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
