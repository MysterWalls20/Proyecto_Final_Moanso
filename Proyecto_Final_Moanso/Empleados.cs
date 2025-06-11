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
    }
}
