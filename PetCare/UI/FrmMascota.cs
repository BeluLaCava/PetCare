using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmMascota : Form
    {
        private MascotaBusiness mascotaBusiness = new MascotaBusiness();
        private ClienteBusiness clienteBusiness = new ClienteBusiness();
        private List<Mascota> listaMascota = new List<Mascota>();
        public FrmMascota()
        {
            InitializeComponent();

        }

        private void CargarClientes()
        {
            List<Cliente> cliente = clienteBusiness.ObtenerCliente();
            cmbCliente.DataSource = cliente;
            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.ValueMember = "ID";

            cmbModificarCliente.DataSource = cliente;
            cmbModificarCliente.DisplayMember = "Nombre";
            cmbModificarCliente.ValueMember = "ID";
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Mascota mascota = new Mascota();
                mascota.Nombre = txtNombre.Text;
                mascota.Especie = txtEspecie.Text;
                mascota.Raza = txtRaza.Text;
                mascota.FechaNacimiento = dtpFecha.Value.Date;
                Cliente cliente = new Cliente();
                cliente.ID = Convert.ToInt32(cmbCliente.SelectedValue);
                mascota.ClienteId = cliente;
                mascotaBusiness.GuardarMascota(mascota);
                MostrarMascotas();
                MessageBox.Show("Mascota guardada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar mascota: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Mascota mascota = new Mascota();
                mascota.ID = Convert.ToInt32(txtModificarID.Text);
                mascota.Nombre = txtModificarNombre.Text;
                mascota.Especie = txtModificarEspecie.Text;
                mascota.Raza = txtModificarRaza.Text;
                mascota.FechaNacimiento = dtpModificarFecha.Value.Date;
                Cliente cliente = new Cliente();
                cliente.ID = Convert.ToInt32(cmbModificarCliente.SelectedValue);
                mascota.ClienteId = cliente;
                mascotaBusiness.ModificarMascota(mascota);
                MostrarMascotas();
                MessageBox.Show("Mascota modificada correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar mascota: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtEliminarId.Text);

                mascotaBusiness.EliminarMascota(id);
                MostrarMascotas();
                MessageBox.Show("Mascota eliminada correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar mascota: " + ex.Message);
            }
        }
        private void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
            txtRaza.Text = string.Empty;
            txtEspecie.Text = string.Empty;
            dtpFecha.Value = DateTime.Now;
        }
        private void MostrarMascotas()
        {
            List<Mascota> listamascota = mascotaBusiness.ObtenerMascotas();

            dgvMascotas.DataSource = null;
            dgvMascotas.DataSource = listamascota;
            dgvMascotas.Columns["ClienteId"].Visible = false;
        }
        private void LimpiarCamposModificar()
        {
            txtModificarNombre.Text = string.Empty;
            txtModificarRaza.Text = string.Empty;
            txtModificarEspecie.Text = string.Empty;
            dtpModificarFecha.Value = DateTime.Now;
        }

        private void FrmMascota_Load(object sender, EventArgs e)
        {
            CargarClientes();
            MostrarMascotas();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMascotas_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvMascotas.SelectedRows.Count > 0)
                {
                    Mascota mascotaSeleccionado = (Mascota)dgvMascotas.SelectedRows[0].DataBoundItem;
                    if (mascotaSeleccionado != null)
                    {
                        txtModificarID.Text = mascotaSeleccionado.ID.ToString();
                        txtModificarNombre.Text = mascotaSeleccionado.Nombre;
                        txtModificarEspecie.Text = mascotaSeleccionado.Especie;
                        txtModificarRaza.Text = mascotaSeleccionado.Raza;
                        txtEliminarId.Text = mascotaSeleccionado.ID.ToString();
                    }

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnBorrador_Click(object sender, EventArgs e)
        {
            try
            {
                Mascota mascota = new Mascota();
                mascota.Nombre = txtNombre.Text;
                mascota.Especie = txtEspecie.Text;
                mascota.Raza = txtRaza.Text;
                mascota.FechaNacimiento = dtpFecha.Value.Date;
                Cliente cliente = new Cliente();
                cliente.ID = Convert.ToInt32(cmbCliente.SelectedValue);
                mascota.ClienteId = cliente;
                listaMascota.Add(mascota);
                LimpiarCampos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                mascotaBusiness.GuardarMascotasMultiples(listaMascota);
                listaMascota = new List<Mascota>();
                MostrarMascotas();
                LimpiarCampos();
                MessageBox.Show("Mascota agregada con exito");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
