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
    public partial class FrmVeterinario : Form
    {
        private List<Veterinario> listaVeterinarios = new List<Veterinario>();
        private Veterinario veterinario;
        private VeterinarioBusiness veterinarioBusiness = new VeterinarioBusiness();

        public FrmVeterinario()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el veterinario seleccionado del ComboBox
                Veterinario seleccionado = (Veterinario)cmbEliminarVeterinario.SelectedItem;

                // Obtener el ID del veterinario seleccionado
                int idVeterinario = seleccionado.ID;

                // Llamar al método de la capa de negocio para eliminar el veterinario
                veterinarioBusiness.EliminarVeterinario(idVeterinario);

                // Actualizar los datos mostrados en la interfaz de usuario
                MostrarVeterinarios();
                ObtenerVeterinarios();

                // Mostrar mensaje de éxito
                MessageBox.Show("Veterinario eliminado con éxito");
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error en caso de excepción
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Guardar la lista de veterinarios
                veterinarioBusiness.GuardarVeterinarios(listaVeterinarios);

                // Limpiar la lista de veterinarios después de agregar
                listaVeterinarios = new List<Veterinario>();

                // Mostrar la lista actualizada de veterinarios
                MostrarVeterinarios();

                // Obtener la lista de veterinarios (probablemente de la base de datos)
                ObtenerVeterinarios();

                // Mostrar un mensaje de éxito
                MessageBox.Show("Veterinario agregado con éxito");
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error si ocurre alguna excepción
                MessageBox.Show(ex.Message);
            }
        }
        // Método para mostrar la lista de Veterinarios en un DataGridView
        public void MostrarVeterinarios()
        {
            try
            {
                // Obtener la lista de Veterinarios desde la capa de negocio
                List<Veterinario> listaVeterinarios = veterinarioBusiness.ObtenerVeterinario();

                // Limpiar cualquier fuente de datos anterior y asignar la nueva lista
                dgvVeterinarios.DataSource = null;
                dgvVeterinarios.DataSource = listaVeterinarios;
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error si ocurre una excepción
                MessageBox.Show(ex.Message);
            }
        }

        // Método para obtener la lista de Veterinarios y mostrarlos en un ComboBox (por ejemplo, para eliminar)
        public void ObtenerVeterinarios()
        {
            try
            {
                // Obtener la lista de Veterinarios desde la capa de negocio
                List<Veterinario> listaVeterinarios = veterinarioBusiness.ObtenerVeterinario();

                // Asignar la lista de Veterinarios al ComboBox
                cmbEliminarVeterinario.DataSource = listaVeterinarios;
                cmbEliminarVeterinario.DisplayMember = "Nombre";  // El nombre es lo que se muestra al usuario
                cmbEliminarVeterinario.ValueMember = "ID";       // El ID es el valor asociado, útil para eliminar
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error si ocurre una excepción
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores de los campos de texto
                int id = Convert.ToInt32(cmbModificarVeterinario.Text); // ID del Veterinario
                string nombre = txtModificarNombre.Text;         // Nombre del Veterinario
                string especialidad = txtespe.Text; // Especialidad del Veterinario
                string horarioTrabajo = txthora.Text;   // Horario de trabajo del Veterinario

                // Llamada al método de la capa de negocio para modificar el Veterinario
                veterinarioBusiness.ModificarVeterinario(id, nombre, especialidad, horarioTrabajo);

                // Actualizar los datos mostrados en la interfaz de usuario
                MostrarVeterinarios();
                ObtenerVeterinarios();

                // Mostrar mensaje de éxito
                MessageBox.Show("Veterinario modificado con éxito");

            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error en caso de excepción
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtApellido.Text = "";
            txtEspecialidad.Text = "";
            txtHorario.Text = "";
            

        }
    }
}
