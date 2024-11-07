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
      public FrmMascota()
      {
         InitializeComponent();
         CargarMascotas();
      }

      private void CargarMascotas()
      {
         try
         {
            List<Mascota> mascotas = mascotaBusiness.ObtenerMascotas();

            cmbMascota.DataSource = mascotas;
            cmbMascota.DisplayMember = "Nombre";
            cmbMascota.ValueMember = "ID";

            cmbEliminar.DataSource = new List<Mascota>(mascotas);
            cmbEliminar.DisplayMember = "Nombre";
            cmbEliminar.ValueMember = "ID";
         }
         catch (Exception ex)
         {
            MessageBox.Show("Error al cargar la lista de mascotas: " + ex.Message);
         }
      }

      private void btnGuardar_Click(object sender, EventArgs e)
      {
         try
         {

            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtRaza.Text) || string.IsNullOrEmpty(txtEspecie.Text))
            {
               MessageBox.Show("Por favor, complete todos los campos.");
               return;
            }

            Mascota nuevaMascota = new Mascota
            {
               Nombre = txtNombre.Text,
               Raza = txtRaza.Text,
               Especie = txtEspecie.Text,
               FechaNacimiento = dtpFecha.Value
            };

            mascotaBusiness.AgregarMascota(nuevaMascota);

            MessageBox.Show("Mascota guardada exitosamente.");
            CargarMascotas();
            LimpiarCampos();
         }
         catch (Exception ex)
         {
            MessageBox.Show("Error al guardar la mascota: " + ex.Message);
         }

      }

      private void btnModificar_Click(object sender, EventArgs e)
      {
         try
         {
            if (cmbMascota.SelectedIndex == -1)
            {
               MessageBox.Show("Por favor, seleccione una mascota para modificar.");
               return;
            }

            int idMascota = Convert.ToInt32(cmbMascota.SelectedValue);

            Mascota mascotaModificada = new Mascota
            {
               ID = idMascota,
               Nombre = txtModificarNombre.Text,
               Raza = txtModificarRaza.Text,
               Especie = txtModificarEspecie.Text,
               FechaNacimiento = dtpModificarFecha.Value
            };

            mascotaBusiness.ActualizarMascota(mascotaModificada.ID, mascotaModificada.Nombre, mascotaModificada.Especie, mascotaModificada.Raza, mascotaModificada.FechaNacimiento, mascotaModificada.ClienteID);

            MessageBox.Show("Mascota modificada exitosamente.");
            CargarMascotas();

            LimpiarCamposModificar();
         }
         catch (Exception ex)
         {
            MessageBox.Show("Error al modificar la mascota: " + ex.Message);
         }

      }

      private void btnEliminar_Click(object sender, EventArgs e)
      {
         try
         {

            if (cmbEliminar.SelectedIndex == -1)
            {
               MessageBox.Show("Por favor, seleccione una mascota para eliminar.");
               return;
            }

            int idMascota = Convert.ToInt32(cmbEliminar.SelectedValue);

            mascotaBusiness.EliminarMascota(idMascota);

            MessageBox.Show("Mascota eliminada exitosamente.");
            CargarMascotas();
         }
         catch (Exception ex)
         {
            MessageBox.Show("Error al eliminar la mascota: " + ex.Message);
         }
      }
      private void LimpiarCampos()
      {
         txtNombre.Clear();
         txtRaza.Clear();
         txtEspecie.Clear();
         dtpFecha.Value = DateTime.Now;
      }
      private void LimpiarCamposModificar()
      {
         txtModificarNombre.Clear();
         txtModificarRaza.Clear();
         txtModificarEspecie.Clear();
         dtpModificarFecha.Value = DateTime.Now;
      }

   }
}
