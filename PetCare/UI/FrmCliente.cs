using BLL;
using DAL;
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
    public partial class FrmCliente : Form
    {
        private List<Cliente> listaCliente = new List<Cliente>();
        private Cliente cliente;
        private ClienteBusiness clienteBusiness = new ClienteBusiness();

        public FrmCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                clienteBusiness.GuardarClientes(listaCliente);
                listaCliente = new List<Cliente>();
                MostrarClientes();

                MessageBox.Show("Cliente agregado con exito");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void MostrarClientes()
        {
            try
            {
                List<Cliente> listaClientes = clienteBusiness.ObtenerCliente();

                dgvClientes.DataSource = null;
                dgvClientes.DataSource = listaClientes;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtIdCliente.Text);
                string apellido = txtModificarApellido.Text;
                string direccion = txtModificarDireccion.Text;
                string email = txtModificarEmail.Text;
                string telefono = txtModificarTelefono.Text;
                clienteBusiness.ModificarCliente(id, apellido, direccion, email, telefono);
                MostrarClientes();
                MessageBox.Show("Cliente modificado");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtEliminarId.Text);
                clienteBusiness.EliminarCliente(id);
                MostrarClientes();
                MessageBox.Show("Cliente eliminado");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void LimpiarCampos()
        {
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";

        }

        private void btnBorrador_Click(object sender, EventArgs e)
        {
            try
            {
                cliente = new Cliente();

                cliente.Nombre = txtApellido.Text;
                cliente.Direccion = txtDireccion.Text;
                cliente.Email = txtEmail.Text.ToLower();
                cliente.Telefono = txtTelefono.Text;
                listaCliente.Add(cliente);

                LimpiarCampos();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.SelectedRows.Count > 0)
                {
                    Cliente clienteSeleccionado = (Cliente)dgvClientes.SelectedRows[0].DataBoundItem;
                    if (clienteSeleccionado != null)
                    {
                        txtIdCliente.Text = clienteSeleccionado.ID.ToString();
                        txtModificarApellido.Text = clienteSeleccionado.Nombre;
                        txtModificarDireccion.Text = clienteSeleccionado.Direccion;
                        txtModificarEmail.Text = clienteSeleccionado.Email;
                        txtModificarTelefono.Text = clienteSeleccionado.Telefono;
                        txtEliminarId.Text = clienteSeleccionado.ID.ToString();
                    }

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                cliente = new Cliente();

                cliente.Nombre = txtApellido.Text;
                cliente.Direccion = txtDireccion.Text;
                cliente.Email = txtEmail.Text.ToLower();
                cliente.Telefono = txtTelefono.Text;
                clienteBusiness.GuardarCliente(cliente);
                MostrarClientes();
                MessageBox.Show("Cliente agregado con exito");

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
    }
}
