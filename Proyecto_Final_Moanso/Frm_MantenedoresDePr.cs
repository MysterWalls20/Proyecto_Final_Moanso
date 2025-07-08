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
    public partial class Frm_MantenedoresDePr : Form
    {
        public Frm_MantenedoresDePr()
        {
            InitializeComponent();
            listarCategoria();
            listarColor();
            listarTalla();
            listarMarca();
        }
        public void listarCategoria()

        {
            dgvCategoria.DataSource = Logica_Categoria.Instancia.ListarCategoria();
        }
        public void listarColor()

        {
            dgvColor.DataSource = Logica_Color.Instancia.ListarColor();

        }
        public void listarTalla()

        {
            dgvTalla.DataSource = Logica_Talla.Instancia.ListarTalla();
        }
        public void listarMarca()

        {
            dgvMarca.DataSource = Logica_Marca.Instancia.ListarMarca();
        }
        private void LimpiarColor()
        {
            txtCol.Clear();
            cbkEstCol.Checked = false;
            txtIdColor.Clear();
        }
        private void LimpiarCategoria()
        {
            txtCategoria.Clear();
            cbkEstCat.Checked = false;
            txtIdCat.Clear();
        }
        private void LimpiarTalla()
        {
            txtTalla.Clear();
            cbkEstTal.Checked = false;
            txtIdTalla.Clear();
        }
        private void LimpiarMarca()
        {
            txtMarca.Clear();
            cbkEstMarc.Checked = false;
            txtIdMarca.Clear();
        }

        //  -  -  -  -  - CRUD de CATEGORIA: -  -  -  -  -  -  -
        private void btnRegCat_Click(object sender, EventArgs e)
        {
            try
            {
                Entidad_Categoria cat = new Entidad_Categoria();
                cat.categoria = txtCategoria.Text.Trim();
                cat.Estado = cbkEstCat.Checked;
                Logica_Categoria.Instancia.InsertarCategoria(cat);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarCategoria();
            listarCategoria();
        }

        private void btnEditCat_Click(object sender, EventArgs e)
        {
            try
            {
                Entidad_Categoria cat = new Entidad_Categoria();
                cat.IdCategoria = int.Parse(txtIdCat.Text.Trim());
                cat.categoria = txtCategoria.Text.Trim();
                cat.Estado = cbkEstCat.Checked;
                Logica_Categoria.Instancia.EditarCategoria(cat);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarCategoria();
            listarCategoria();
        }

        private void btnDeshCat_Click(object sender, EventArgs e)
        {
            try
            {
                Entidad_Categoria cat = new Entidad_Categoria();

                cat.IdCategoria = int.Parse(txtIdCat.Text.Trim());
                Logica_Categoria.Instancia.DeshabilitarCategoria(cat);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarCategoria();
            listarCategoria();
        }

        private void btnHabCat_Click(object sender, EventArgs e)
        {
            try
            {
                Entidad_Categoria cat = new Entidad_Categoria();

                cat.IdCategoria = int.Parse(txtIdCat.Text.Trim());
                Logica_Categoria.Instancia.HabilitarCategoria(cat);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarCategoria();
            listarCategoria();
        }
        private void btnBusCat_Click(object sender, EventArgs e)
        {

        }
        //  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -

        //  -  -  -  -  - CRUD de COLOR: -  -  -  -  -  -  -
        private void btnRegCol_Click(object sender, EventArgs e)
        {
            try
            {
                Entidad_Color col = new Entidad_Color();
                col.color = txtCol.Text.Trim();
                col.Estado = cbkEstCol.Checked;
                Logica_Color.Instancia.InsertarColor(col);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarColor();
            listarColor();
        }

        private void btnEditCol_Click(object sender, EventArgs e)
        {
            try
            {
                Entidad_Color col = new Entidad_Color();
                col.IdColor = int.Parse(txtIdColor.Text.Trim());
                col.color = txtCol.Text.Trim();
                col.Estado = cbkEstCat.Checked;
                Logica_Color.Instancia.EditarColor(col);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarColor();
            listarColor();
        }

        private void DeshCol_Click(object sender, EventArgs e)
        {
            try
            {
                Entidad_Color col = new Entidad_Color();

                col.IdColor = int.Parse(txtIdColor.Text.Trim());
                Logica_Color.Instancia.DeshabilitarColor(col);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarColor();
            listarColor();
        }

        private void btnHabCol_Click(object sender, EventArgs e)
        {
            try
            {
                Entidad_Color col = new Entidad_Color();

                col.IdColor = int.Parse(txtIdColor.Text.Trim());
                Logica_Color.Instancia.HabilitarColor(col);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarColor();
            listarColor();
        }

        private void btnBusCol_Click(object sender, EventArgs e)
        {

        }
        //  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -

        //  -  -  -  -  - CRUD de TALLA: -  -  -  -  -  -  -
        private void btnRegTal_Click(object sender, EventArgs e)
        {
            try
            {
                Entidad_Talla Tal = new Entidad_Talla();
                Tal.talla = txtTalla.Text.Trim();
                Tal.Estado = cbkEstTal.Checked;
                Logica_Talla.Instancia.InsertarTalla(Tal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarTalla();
            listarTalla();
        }

        private void btnEditTal_Click(object sender, EventArgs e)
        {
            try
            {
                Entidad_Talla tal = new Entidad_Talla();
                tal.IdTalla = int.Parse(txtIdTalla.Text.Trim());
                tal.talla = txtTalla.Text.Trim();
                tal.Estado = cbkEstTal.Checked;
                Logica_Talla.Instancia.EditarTalla(tal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarTalla();
            listarTalla();
        }

        private void btnDeshTal_Click(object sender, EventArgs e)
        {
            try
            {
                Entidad_Talla tal = new Entidad_Talla();

                tal.IdTalla = int.Parse(txtIdTalla.Text.Trim());
                Logica_Talla.Instancia.DeshabilitarTalla(tal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarTalla();
            listarTalla();
        }

        private void btnHabTal_Click(object sender, EventArgs e)
        {
            try
            {
                Entidad_Talla tal = new Entidad_Talla();

                tal.IdTalla = int.Parse(txtIdTalla.Text.Trim());
                Logica_Talla.Instancia.HabilitarTalla(tal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarTalla();
            listarTalla();
        }

        private void txtBusTal_Click(object sender, EventArgs e)
        {

        }
        //  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -

        //  -  -  -  -  - CRUD de MARCA: -  -  -  -  -  -  -
        private void btnRegMarc_Click(object sender, EventArgs e)
        {
            try
            {
                Entidad_Marca Mar = new Entidad_Marca();
                Mar.Marca = txtMarca.Text.Trim();
                Mar.Estado = cbkEstMarc.Checked;
                Logica_Marca.Instancia.InsertarMarca(Mar);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarMarca();
            listarMarca();
        }

        private void btnEditMarc_Click(object sender, EventArgs e)
        {
            try
            {
                Entidad_Marca mar = new Entidad_Marca();
                mar.IdMarca = int.Parse(txtIdMarca.Text.Trim());
                mar.Marca = txtMarca.Text.Trim();
                mar.Estado = cbkEstMarc.Checked;
                Logica_Marca.Instancia.EditarMarca(mar);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarMarca();
            listarMarca();
        }

        private void btnDeshMarc_Click(object sender, EventArgs e)
        {
            try
            {
                Entidad_Marca mar = new Entidad_Marca();

                mar.IdMarca = int.Parse(txtIdMarca.Text.Trim());
                Logica_Marca.Instancia.DeshabilitarMarca(mar);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarMarca();
            listarMarca();
        }

        private void btnHabMarc_Click(object sender, EventArgs e)
        {
            try
            {
                Entidad_Marca mar = new Entidad_Marca();

                mar.IdMarca = int.Parse(txtIdMarca.Text.Trim());
                Logica_Marca.Instancia.HabilitarMarca(mar);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarMarca();
            listarMarca();
        }

        private void btnBusMarc_Click(object sender, EventArgs e)
        {

        }
    }
}
