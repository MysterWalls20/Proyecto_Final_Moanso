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
    public partial class Frm_MantRubro : Form
    {
        public Frm_MantRubro()
        {
            InitializeComponent();
            listarRubro();
        }
        private void limpiarRubro()
        {
            txtBuscar.Clear();
            txtRubro.Clear();
        }
        public void listarRubro()
        {
            dgvRubro.DataSource = Logica_Rubro.Instancia.ListarRubro();
            dgvRubro.Columns["estado"].Visible = false;
        }

        private int idRubroSeleccionado = 0;
        private int ultimaFilaSeleccionada = -1;

        public void listarInactivaRubro()
        {
            dgvRubro.DataSource = Logica_Rubro.Instancia.ListarInactivosRubro();
        }

        private void btnNuevoProv_Click(object sender, EventArgs e)
        {
            try
            {
                Entidad_rubro rub = new Entidad_rubro();
                rub.rubro = txtRubro.Text.Trim();
                Logica_Rubro.Instancia.InsertarRubro(rub);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            listarRubro();
            limpiarRubro();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            listarRubro();
            limpiarRubro();
        }

        private void btnModificarProv_Click(object sender, EventArgs e)
        {
            Entidad_rubro rub = new Entidad_rubro
            {
                id_rubro = int.Parse(txtBuscar.Text),
                rubro = txtRubro.Text,
            };

            Logica_Rubro.Instancia.EditarRubro(rub);
            MessageBox.Show("Rubro actualizado");

            limpiarRubro();
            listarRubro();
        }

        private void btnDeshabilitarProv_Click(object sender, EventArgs e)
        {
            if (idRubroSeleccionado == 0)
            {
                MessageBox.Show("Seleccione la fila de un rubro para deshabilitar");
                return;
            }

            Entidad_rubro rub = new Entidad_rubro
            {
                id_rubro = idRubroSeleccionado
            };

            Logica_Rubro.Instancia.DeshabilitarRubro(rub);
            MessageBox.Show("Rubro inhabilitado");

            limpiarRubro();
            listarRubro();
        }

        private void btnHabilitadProv_Click(object sender, EventArgs e)
        {
            if (idRubroSeleccionado == 0)
            {
                MessageBox.Show("Seleccione la fila de un rubro para deshabilitar");
                return;
            }

            Entidad_rubro rub = new Entidad_rubro
            {
                id_rubro = idRubroSeleccionado
            };

            Logica_Rubro.Instancia.HabilitarRubro(rub);
            MessageBox.Show("Rubro inhabilitado");

            limpiarRubro();
            listarRubro();
        }

        private void btnMostrarDesh_Click(object sender, EventArgs e)
        {
            listarInactivaRubro();
        }

        private void btnBusRubro_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtBuscar.Text.Trim());
                Entidad_rubro rub = Logica_Rubro.Instancia.BuscarRubroPorID(id);

                if (rub != null)
                {
                    // Mostrar en los controles del formulario
                    txtRubro.Text = rub.rubro;

                    // Mostrar solo ese resultado en el DataGridView
                    List<Entidad_rubro> resultado = new List<Entidad_rubro>();
                    resultado.Add(rub);
                    dgvRubro.DataSource = resultado;
                }
                else
                {
                    MessageBox.Show("No se encontró una Rubro con ese ID.");

                    // Opcional: limpiar el DataGridView y controles
                    dgvRubro.DataSource = null;
                    limpiarRubro();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar la rubro: " + ex.Message);
            }
        }
    }
}
