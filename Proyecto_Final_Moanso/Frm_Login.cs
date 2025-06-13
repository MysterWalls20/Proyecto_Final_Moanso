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
            Entidad_Empleado emp = new Entidad_Empleado()
            {
                usuario = txtUsuario.Text.Trim(),
                contrasena = txtContraseña.Text.Trim()
            };

            bool loginCorrecto = Logica_Empleado.Instancia.Login(emp);

            if (loginCorrecto)
            {
                MessageBox.Show("Acceso correcto", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Abrir siguiente ventana
                this.Hide();
                Form formMenu = new Frm_Menu();
                formMenu.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
