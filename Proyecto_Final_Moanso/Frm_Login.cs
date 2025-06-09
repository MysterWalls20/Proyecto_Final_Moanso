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

            Capa_Entidad.Entidad_Empleado login = new Capa_Entidad.Entidad_Empleado()
            {
                usuario = txtUsuario.Text,
                contrasena = txtContraseña.Text
            };

            Capa_Logica.Logica_Empleado loginBL = new Capa_Logica.Logica_Empleado();

            if (loginBL.ValidarLogin(login))
            {
                MessageBox.Show("¡Login exitoso!");
                // Abrir el formulario principal, por ejemplo:
                // new FormPrincipal().Show();
                // this.Hide();
                this.Hide();
                Form formMenu = new Frm_Menu();
                formMenu.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
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
