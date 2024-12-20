﻿using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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
            dataGridView1.Columns["Producto"].Visible = false;
            dataGridView1.Columns["Cliente"].Visible = false;
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

                Producto prod = productoBusiness.obtenerProducto(fac.Producto.ID);
                decimal valor = 0;
                if (prod != null)
                {
                    valor = prod.Precio * fac.Cantidad;
                }
                label6.Text = valor.ToString();
                fac.Total = valor;

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

                Producto prod = productoBusiness.obtenerProducto(fac.Producto.ID);
                decimal valor = 0;
                if (prod != null)
                {
                    valor = prod.Precio * fac.Cantidad;
                }
                label6.Text = valor.ToString();

                fac.Total = valor;

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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Factura facturaSeleccionado = (Factura)dataGridView1.SelectedRows[0].DataBoundItem;
                    if (facturaSeleccionado != null)
                    {
                        txtIdMod.Text = facturaSeleccionado.ID.ToString();
                        txtModCant.Text = facturaSeleccionado.Cantidad.ToString(); 
                        txtIdEliminar.Text = facturaSeleccionado.ID.ToString();
                        cmbModClie.SelectedValue = facturaSeleccionado.Cliente.ID;
                        cmbModProd.SelectedValue = facturaSeleccionado.Producto.ID;
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
