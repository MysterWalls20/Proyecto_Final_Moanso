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
    public partial class Frm_MenuVentas : Form
    {
        public Frm_MenuVentas()
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
        private void pbCerrarPrograma1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cerrar el programa?", "Cerrando Sesion", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                pbCerrarPrograma1.BackColor = Color.DarkOrange;
            }
        }
        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }
        public void abrirFormHijo(Form formhijo)
        {
            if (this.pnPrincipal.Controls.Count > 0)
                this.pnPrincipal.Controls.RemoveAt(0);
            formhijo.TopLevel = false;
            formhijo.Dock = DockStyle.Fill;
            this.pnPrincipal.Controls.Add(formhijo);
            this.pnPrincipal.Tag = formhijo;
            this.pnPrincipal.Text = formhijo.Text;
            formhijo.Show();
        }
        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Frm_NuevaVenta());
            btnRealizarVenta.BackColor = Color.DarkOrange;
            btnMantClientes.BackColor = Color.White;
            btnReportesVenta.BackColor = Color.White;
        }
        private void btnMantClientes_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Frm_MantClientes());
            btnRealizarVenta.BackColor = Color.White;
            btnMantClientes.BackColor = Color.DarkOrange;
            btnReportesVenta.BackColor = Color.White;
        }
        private void btnReportesVenta_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Frm_ReportesVenta());
            btnRealizarVenta.BackColor = Color.White;
            btnMantClientes.BackColor = Color.White;
            btnReportesVenta.BackColor = Color.DarkOrange;
        }

        private void pbCerrarPrograma_MouseDown(object sender, MouseEventArgs e)
        {
            pbCerrarPrograma1.BackColor = Color.Red;
        }
        private void btnSalirDeMenu_Click(object sender, EventArgs e)
        {
            Frm_MenuPrincipal MenuPrincipal = new Frm_MenuPrincipal();
            MenuPrincipal.Show();
            this.Hide();
        }
    }
}
