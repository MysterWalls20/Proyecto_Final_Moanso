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
    public partial class Frm_Clientes : Form
    {
        public Frm_Clientes()
        {
            InitializeComponent();
            dtpFechRegC.MinDate = DateTime.Now;
            dtpFechRegC.CustomFormat = "dd/MM/yyyy";
        }

        private void btnNuevoCli_Click(object sender, EventArgs e)
        {

        }
    }
}
