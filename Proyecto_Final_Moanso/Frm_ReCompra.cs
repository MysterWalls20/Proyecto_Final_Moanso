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
    public partial class Frm_ReCompra : Form
    {
        public Frm_ReCompra()
        {
            InitializeComponent();
        }

        private void btnVerLista_Click(object sender, EventArgs e)
        {
            Frm_ListaReq listaReq = new Frm_ListaReq();
            listaReq.ShowDialog();
        }
    }
}
