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
    public partial class FrmFactura : Form
    {

        ClienteBusiness clienteBusiness = new ClienteBusiness();
        FacturaBusiness facturaBusiness = new FacturaBusiness();
        ProductoBusiness productoBusiness = new ProductoBusiness();
        public FrmFactura()
        {
            InitializeComponent();
            actualizarCampos();
        }

        private void actualizarCampos()
        {
            actualizarCombo();
            updateDataGridView();
        }
        private void actualizarCombo()
        {
            cmbCliente.DataSource = clienteBusiness.ObtenerCliente();
            cmbCliente.ValueMember = "ID";
            cmbCliente.DisplayMember = "Nombre";

            cmbProducto.DataSource = productoBusiness.ObtenerProductos();
            cmbProducto.ValueMember = "ID";
            cmbProducto.DisplayMember = "Nombre";

            cmbModClie.DataSource = clienteBusiness.ObtenerCliente();
            cmbModClie.ValueMember = "ID";
            cmbModClie.DisplayMember = "Nombre";

            cmbModProd.DataSource = productoBusiness.ObtenerProductos();
            cmbModProd.ValueMember = "ID";
            cmbModProd.DisplayMember = "Nombre";

        }

        private void updateDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = facturaBusiness.obtenerFacturas();
        }


        private void FrmFactura_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Factura fac = new Factura();
                fac.Cantidad = Convert.ToInt32(txtCantidad.Text);
                fac.Producto = new Producto();
                fac.Producto.ID = Convert.ToInt32(cmbProducto.SelectedValue);
                fac.Cliente = new Cliente();
                fac.Cliente.ID = Convert.ToInt32(cmbCliente.SelectedValue);
                fac.Fecha = DateTime.Parse(dateFechaValidez.Text);
                facturaBusiness.agregarFactura(fac);
                updateDataGridView();
                MessageBox.Show("Factura agregada");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Factura fac = new Factura();
                fac.ID = Convert.ToInt32(txtIdMod.Text);
                fac.Producto = new Producto();
                fac.Producto.ID = Convert.ToInt32(cmbModProd.SelectedValue);
                fac.Cliente = new Cliente();
                fac.Cliente.ID = Convert.ToInt32(cmbModClie.SelectedValue);
                fac.Cantidad = Convert.ToInt32(txtModCant.Text);
                facturaBusiness.modificarFactura(fac);
                updateDataGridView();
                MessageBox.Show("Factura modificada");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtIdEliminar.Text);
                facturaBusiness.eliminarFactura(id);
                updateDataGridView();
                MessageBox.Show("Factura Eliminada");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
