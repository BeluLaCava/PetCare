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
      private MascotaBusiness mascotaBusiness;
      public FrmMascota()
      {
         InitializeComponent();
         mascotaBusiness = new MascotaBusiness();
         CargarMascotas();
      }
      private void CargarMascotas()
      {
         List<Mascota> mascotas = mascotaBusiness.ObtenerMascotas();
         cmbMascota.DataSource = mascotas;
         cmbMascota.DisplayMember = "Nombre";
         cmbMascota.ValueMember = "ID";
      }

      private void btnGuardar_Click(object sender, EventArgs e)
      {
         try
         {
            Mascota mascota = new Mascota
            {
               Nombre = txtNombre.Text,
               Especie = txtEspecie.Text,
               Raza = txtRaza.Text,
               FechaNacimiento = dtpFecha.Value,

               ClienteID = 1
            };

            MascotaBusiness business = new MascotaBusiness();
            business.GuardarMascota(mascota);

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
            Mascota mascota = new Mascota
            {
               ID = Convert.ToInt32(cmbMascota.SelectedValue), 
               Nombre = txtModificarNombre.Text, 
               Especie = txtModificarEspecie.Text, 
               Raza = txtModificarRaza.Text, 
               FechaNacimiento = dtpModificarFecha.Value 
            };


            MascotaBusiness business = new MascotaBusiness();
            business.ModificarMascota(mascota);           
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
            int id = Convert.ToInt32(cmbEliminar.SelectedValue);
            MascotaBusiness business = new MascotaBusiness();
            business.EliminarMascota(id);
            MessageBox.Show("Mascota eliminada correctamente");
         }
         catch (Exception ex)
         {
            MessageBox.Show("Error al eliminar mascota: " + ex.Message);
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
