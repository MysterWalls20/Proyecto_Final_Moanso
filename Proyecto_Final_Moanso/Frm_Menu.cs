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
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
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
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnCerrarPrograma_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cerrar la aplicación?", "Cerrando Programa", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }
        private void btnProducto_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Frm_Producto());
            btnProducto.BackColor = Color.DarkOrange;
            btnAlmacen.BackColor = Color.White;
        }
        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Frm_Almacen());
            btnProducto.BackColor = Color.White;
            btnAlmacen.BackColor = Color.DarkOrange;
        }
    }
}
