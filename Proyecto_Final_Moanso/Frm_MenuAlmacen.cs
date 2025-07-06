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
    public partial class Frm_MenuAlmacen : Form
    {
        public Frm_MenuAlmacen()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pbCerrarPrograma2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cerrar el programa?", "Cerrando Sesion", MessageBoxButtons.YesNo,
              MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                pbCerrarPrograma2.BackColor = Color.DarkOrange;
            }
        }
        private void pnTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
        private void btnMantProductos_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Frm_MantProductos());
            btnMantProductos.BackColor = Color.DarkOrange;
            btnReOrdenCompra.BackColor = Color.White;
            btnMantenedoresProd.BackColor = Color.White;
        }
        private void btnReOrdenCompra_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Frm_ReOrdenCompra());
            btnMantProductos.BackColor = Color.White;
            btnReOrdenCompra.BackColor = Color.DarkOrange;
            btnMantenedoresProd.BackColor = Color.White;
        }
        private void btnMantenedoresProd_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Frm_MantenedoresDePr());
            btnMantProductos.BackColor = Color.White;
            btnReOrdenCompra.BackColor = Color.White;
            btnMantenedoresProd.BackColor = Color.DarkOrange;
        }
        private void btnSalirDeMenu_Click(object sender, EventArgs e)
        {
            Frm_MenuPrincipal MenuPrincipal = new Frm_MenuPrincipal();
            MenuPrincipal.Show();
            this.Hide();
        }

        private void pbCerrarPrograma2_MouseDown(object sender, MouseEventArgs e)
        {
            pbCerrarPrograma2.BackColor = Color.Red;
        }
    }
}
