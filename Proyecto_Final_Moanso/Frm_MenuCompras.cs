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
    public partial class Frm_MenuCompras : Form
    {
        public Frm_MenuCompras()
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
        private void btnRealizaCompra_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Frm_ReCompra());
            btnRealizaCompra.BackColor = Color.DarkOrange;
            btnMantenedorRubro.BackColor = Color.White;
            btnMantProveedor.BackColor = Color.White;
            btnReportesCompra.BackColor = Color.White;
            
        }
        private void btnMantenedorRubro_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Frm_MantRubro());
            btnRealizaCompra.BackColor = Color.White;
            btnMantenedorRubro.BackColor = Color.DarkOrange;
            btnMantProveedor.BackColor = Color.White;
            btnReportesCompra.BackColor = Color.White;
        }
        private void btnMantProveedor_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Frm_Proveedor());
            btnRealizaCompra.BackColor = Color.White;
            btnMantenedorRubro.BackColor = Color.White;
            btnMantProveedor.BackColor = Color.DarkOrange;
            btnReportesCompra.BackColor = Color.White;
        }

        private void btnReportesCompra_Click(object sender, EventArgs e)
        {
            btnRealizaCompra.BackColor = Color.White;
            btnMantenedorRubro.BackColor = Color.White;
            btnMantProveedor.BackColor = Color.White;
            btnReportesCompra.BackColor = Color.DarkOrange;
        }
    }
}
