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
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }
        private void Empleados_Load(object sender, EventArgs e)
        {
            try
            {
                cbCarUsuario.Items.Clear();

                var roles = Logica_Empleado.Instancia.ObtenerRoles();

                foreach (string rol in roles)
                {
                    cbCarUsuario.Items.Add(rol);
                }

                if (cbCarUsuario.Items.Count > 0)
                    cbCarUsuario.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar roles de empleados: " + ex.Message);
            }

            txtNomEmp.KeyPress += textBoxSoloLetras_KeyPress;
            txtNumEmp.KeyPress += textBoxSoloNumeros_KeyPress;
            txtSalario.KeyPress += textBoxSoloNumeros_KeyPress;
        }
        private void textBoxSoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir letras, tecla de borrar (Backspace) y espacio
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBoxSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y tecla de borrar (Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnNuevoEmp_Click(object sender, EventArgs e)
        {

        }
    }
}
