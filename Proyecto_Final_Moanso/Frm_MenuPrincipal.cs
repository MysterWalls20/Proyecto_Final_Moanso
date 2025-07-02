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
    public partial class Frm_MenuPrincipal : Form
    {
        public Frm_MenuPrincipal()
        {
            InitializeComponent();
        }
        private void Frm_MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
        private void pbCerrarMenuP_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pbCerrarMenuP_MouseDown(object sender, MouseEventArgs e)
        {
            pbCerrarMenuP.BackColor = Color.Red;
        }
        private void btnMVentas_Click(object sender, EventArgs e)
        {
            Frm_MenuVentas menu = new Frm_MenuVentas();
            menu.Show();
            this.Hide();
        }
        private void btnMAlmacen_Click(object sender, EventArgs e)
        {
            Frm_MenuAlmacen menu = new Frm_MenuAlmacen();
            menu.Show();
            this.Hide();
        }
        private void btnMCompras_Click(object sender, EventArgs e)
        {
            Frm_MenuCompras menu = new Frm_MenuCompras();
            menu.Show();
            this.Hide();
        }
    }
}
