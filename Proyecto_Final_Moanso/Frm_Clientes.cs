using Capa_Entidad;
using Capa_Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
            //listarCliente();
        }
        
        private void Frm_Clientes_Load(object sender, EventArgs e)
        {
         
        }
       
        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idDep = Convert.ToInt32(cmbDepartamento.SelectedValue);
            cmbDistrito.DataSource = NUbigeo.ListarProvincias(idDep);
            cmbDistrito.DisplayMember = "provincia";
            cmbDistrito.ValueMember = "idProvincia";
        }
        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idProv = Convert.ToInt32(cmbDistrito.SelectedValue);
            cmbDistrito.DataSource = NUbigeo.ListarDistritos(idProv);
            cmbDistrito.DisplayMember = "distrito";
            cmbDistrito.ValueMember = "idDistrito";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            grpClienteNatural.Enabled = grpClienteNatural.Checked;
            grpClienteJuridico.Enabled = grpClienteJuridico.Checked;
        }
    } 
}
