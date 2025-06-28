using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Moanso
{
    public partial class Frm_MenuCompra : Form
    {
        public Frm_MenuCompra()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pbCerrarPrograma_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cerrar el programa?", "Cerrando Sesion", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                pbCerrarPrograma.BackColor = Color.DarkOrange;
            }
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }
        private void btnSalirDeMenu_Click(object sender, EventArgs e)
        {
            Frm_MenuPrincipal MenuPrincipal = new Frm_MenuPrincipal();
            MenuPrincipal.Show();
            this.Hide();
        }
        private void pbCerrarPrograma_MouseDown(object sender, MouseEventArgs e)
        {
            pbCerrarPrograma.BackColor = Color.Red;
        }
    }
}
