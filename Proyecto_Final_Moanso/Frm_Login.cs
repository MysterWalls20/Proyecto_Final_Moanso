using Capa_Entidad;
using Capa_Logica;
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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btnCerrarLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text.Trim();
            string pass = txtContraseña.Text.Trim();

            if (user == "" || pass == "")
            {
                MessageBox.Show("Ingrese un usuario y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Text = "";
                txtContraseña.Text = "";
                return;
            }

            bool accesoValido = Logica_Empleado.Instancia.ValidarAcceso(user, pass);

            if (accesoValido)
            {
                MessageBox.Show("¡Acceso permitido!, usuario y contraseña correctas","Login correcto",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Frm_MenuVenta menu = new Frm_MenuVenta();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas o cuenta deshabilitada.", "Error de Login",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbMostrar_Click(object sender, EventArgs e)
        {
            pbOcultar.BringToFront();
            txtContraseña.PasswordChar = '\0';
        }

        private void pbOcultar_Click(object sender, EventArgs e)
        {
            pbMostrar.BringToFront();
            txtContraseña.PasswordChar = '*';
        }
    }
}
