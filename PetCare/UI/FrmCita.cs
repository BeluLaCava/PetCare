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
    public partial class FrmCita : Form
    {
        private MascotaBusiness mascotaBusiness = new MascotaBusiness();
        //private VeterinarioBusiness veterinarioBusiness = new VeterinarioBusiness();
        private CitaBusiness citaBusiness = new CitaBusiness();
        private Cita cita;
        private List<Cita> listaCita = new List<Cita>();
        public FrmCita()
        {
            InitializeComponent();
        }
        private void ObtenerMascotas()
        {
            List<Mascota> listaMascota = mascotaBusiness.ObtenerMascotas();

            cmbMascota.DataSource = listaMascota;
            cmbMascota.DisplayMember = "Nombre";
            cmbMascota.ValueMember = "ID";

            cmbModificarMascota.DataSource = listaMascota;
            cmbModificarMascota.DisplayMember = "Nombre";
            cmbModificarMascota.ValueMember = "ID";
        }

        //private void ObtenerVeterinario()
        //{
        //    List<Veterinario> listaVeterinario = veterinarioBusiness.ObtenerVeterinario();

        //    cmbMascota.DataSource = listaVeterinario;
        //    cmbMascota.DisplayMember = "Nombre";
        //    cmbMascota.ValueMember = "ID";
        //}
        private void MostrarCitas()
        {
            List<Cita> listaCita = citaBusiness.ObtenerCitas();
            dgvCitas.DataSource = null;
            dgvCitas.DataSource = listaCita;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                cita = new Cita();
                cita.Fecha = dtpFecha.Value.Date;
                cita.Hora = dtpHora.Value.TimeOfDay;
                Mascota mascota = new Mascota();
                mascota.ID = Convert.ToInt32(cmbMascota.SelectedValue);
                cita.MascotaID = mascota;
                Veterinario veterinario = new Veterinario();
                veterinario.ID = Convert.ToInt32(cmbVeterinario.SelectedValue);
                cita.VeterinarioID = veterinario;
                citaBusiness.GuardarCita(cita);
                MostrarCitas();
                MessageBox.Show("Cita agendada con exito");
                LimpiarCampos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCita_Load(object sender, EventArgs e)
        {
            ObtenerMascotas();
            //ObtenerVeterinario();
            MostrarCitas();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                cita = new Cita();
                cita.ID = Convert.ToInt32(txtCita.Text);
                cita.Fecha = dtpModificarFecha.Value.Date;
                cita.Hora = dtpModificarHora.Value.TimeOfDay;
                Mascota mascota = new Mascota();
                mascota.ID = Convert.ToInt32(cmbModificarMascota.SelectedValue);
                cita.MascotaID = mascota;
                Veterinario veterinario = new Veterinario();
                veterinario.ID = Convert.ToInt32(cmbModificarVeterinario.SelectedValue);
                cita.VeterinarioID = veterinario;
                citaBusiness.ModificarCita(cita);
                MostrarCitas();
                MessageBox.Show("Cita modificada");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void LimpiarCampos()
        {
            dtpFecha.Value = DateTime.Now;
            txtHora.Text = string.Empty;
        }

        private void btnEliminarCita_Click(object sender, EventArgs e)
        {
            try
            {
                int idEliminar = Convert.ToInt32(txtEliminarCita.Text);
                citaBusiness.EliminarCita(idEliminar);
                MostrarCitas();
                MessageBox.Show("Cita eliminada");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
