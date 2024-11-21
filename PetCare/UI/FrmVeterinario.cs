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
        private CitaBusiness citaBusiness = new CitaBusiness();
        public FrmVeterinario()
        {
            InitializeComponent();
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


        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                veterinario = new Veterinario();
                veterinario.ID = Convert.ToInt32(txtModificarID.Text);
                veterinario.Nombre = txtModificarNombre.Text;
                veterinario.Especialidad = txtModificarEspecialidad.Text;
                veterinario.HorarioTrabajo = txtModificarHora.Text;

                // Llamada al método de la capa de negocio para modificar el Veterinario
                veterinarioBusiness.ModificarVeterinario(veterinario);

                // Actualizar los datos mostrados en la interfaz de usuario
                MostrarVeterinarios();

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

        private void btnBorrador_Click(object sender, EventArgs e)
        {
            try
            {
                veterinario = new Veterinario();
                veterinario.Nombre = txtApellido.Text;
                veterinario.Especialidad = txtEspecialidad.Text;
                veterinario.HorarioTrabajo = txtHorario.Text;
                listaVeterinarios.Add(veterinario);
                LimpiarCampos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FrmVeterinario_Load(object sender, EventArgs e)
        {
            MostrarVeterinarios();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Obtener el veterinario seleccionado del ComboBox
                int id = Convert.ToInt32(txtEliminarID.Text);

                // Llamar al método de la capa de negocio para eliminar el veterinario
                veterinarioBusiness.EliminarVeterinario(id);

                // Actualizar los datos mostrados en la interfaz de usuario
                MostrarVeterinarios();
                

                // Mostrar mensaje de éxito
                MessageBox.Show("Veterinario eliminado con éxito");
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error en caso de excepción
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                veterinario = new Veterinario();
                veterinario.Nombre = txtApellido.Text;
                veterinario.Especialidad = txtEspecialidad.Text;
                veterinario.HorarioTrabajo = txtHorario.Text;
                veterinarioBusiness.GuardarVeterinario(veterinario);
                LimpiarCampos();
                MostrarVeterinarios();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvVeterinarios_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvVeterinarios.SelectedRows.Count > 0)
                {
                    Veterinario veterinarioSeleccionado = (Veterinario)dgvVeterinarios.SelectedRows[0].DataBoundItem;
                    if (veterinarioSeleccionado != null)
                    {
                        txtModificarID.Text = veterinarioSeleccionado.ID.ToString();
                        txtModificarNombre.Text = veterinarioSeleccionado.Nombre;
                        txtModificarEspecialidad.Text = veterinarioSeleccionado.Especialidad;
                        txtModificarHora.Text = veterinarioSeleccionado.HorarioTrabajo;
                        txtEliminarID.Text = veterinarioSeleccionado.ID.ToString();
                        
                    }

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
