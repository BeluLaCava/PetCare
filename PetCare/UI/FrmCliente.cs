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
                ObtenerClientes();
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

                cmbCliente.DataSource = listaClientes;
                cmbCliente.DisplayMember = "Nombre";
                cmbCliente.ValueMember = "ID";

            }
            catch (Exception)
            {

                throw;
            }
        }
        public void ObtenerClientes()
        {
            List<Cliente> listaClientes = clienteBusiness.ObtenerCliente();

            cmbEliminar.DataSource = listaClientes;
            cmbEliminar.DisplayMember = "Nombre";
            cmbEliminar.ValueMember = "ID";

        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente seleccionado = (Cliente)cmbCliente.SelectedItem;
                int idcliente = seleccionado.ID;

                string direccion = txtModificarDireccion.Text;
                string email = txtModificarEmail.Text;
                string telefono = txtModificarTelefono.Text;
                clienteBusiness.ModificarCliente(idcliente, direccion, email, telefono);
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
            ObtenerClientes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente seleccionado = (Cliente)cmbEliminar.SelectedItem;
                int idcliente = seleccionado.ID;
                clienteBusiness.EliminarCliente(idcliente);
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

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Cliente seleccionado = (Cliente)cmbCliente.SelectedItem;

                txtModificarDireccion.Text = seleccionado.Direccion;
                txtModificarEmail.Text = seleccionado.Email;
                txtModificarTelefono.Text = seleccionado.Telefono;
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
                cliente = new Cliente();

                cliente.Nombre = txtApellido.Text;
                cliente.Direccion = txtDireccion.Text;
                cliente.Email = txtEmail.Text.ToLower();
                cliente.Telefono = txtTelefono.Text;
                listaCliente.Add(cliente);
                
                LimpiarCampos();
                MessageBox.Show("Cliente agregado con exito");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
