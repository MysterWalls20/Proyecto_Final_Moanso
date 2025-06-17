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
        private void pbCerrarPrograma_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cerrar la aplicación?", "Cerrando Programa", MessageBoxButtons.YesNo,
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
        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Frm_NuevaVenta());
            btnNuevaVenta.BackColor = Color.DarkOrange;
            btnAlmacen.BackColor = Color.White;
            btnClientes.BackColor = Color.White;
            btnPedidos.BackColor = Color.White;
            btnEmpleados.BackColor = Color.White;
        }
        private void btnAlmacen_Click_1(object sender, EventArgs e)
        {
            abrirFormHijo(new Frm_Almacen());
            btnNuevaVenta.BackColor = Color.White;
            btnAlmacen.BackColor = Color.DarkOrange;
            btnClientes.BackColor = Color.White;
            btnPedidos.BackColor = Color.White;
            btnEmpleados.BackColor = Color.White;
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Frm_Clientes());
            btnNuevaVenta.BackColor = Color.White;
            btnAlmacen.BackColor = Color.White;
            btnClientes.BackColor = Color.DarkOrange;
            btnPedidos.BackColor = Color.White;
            btnEmpleados.BackColor = Color.White;
        }
        private void btnPedidos_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Frm_Pedidos());
            btnNuevaVenta.BackColor = Color.White;
            btnAlmacen.BackColor = Color.White;
            btnClientes.BackColor = Color.White;
            btnPedidos.BackColor = Color.DarkOrange;
            btnEmpleados.BackColor = Color.White;
        }
        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Empleados());
            btnNuevaVenta.BackColor = Color.White;
            btnAlmacen.BackColor = Color.White;
            btnClientes.BackColor = Color.White;
            btnPedidos.BackColor = Color.White;
            btnEmpleados.BackColor = Color.DarkOrange;
        }
        private void pbCerrarPrograma_MouseDown(object sender, MouseEventArgs e)
        {
            pbCerrarPrograma.BackColor = Color.Red;
        }
    }
}
