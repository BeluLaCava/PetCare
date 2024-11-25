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
    public partial class FrmProducto : Form
    {
        private ProductoBusiness productoBusiness = new ProductoBusiness();
        private Producto producto;
        private List<Producto> listaProducto = new List<Producto>();
        public FrmProducto()
        {
            InitializeComponent();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                producto = new Producto();
                producto.ID = Convert.ToInt32(txtID.Text);
                producto.Nombre = txtModificarNombre.Text;
                producto.Descripcion = txtModificarDescripcion.Text;
                producto.Precio = Convert.ToDecimal(txtModificarPrecio.Text);
                producto.Stock = Convert.ToInt32(txtModificarStock.Text);
                productoBusiness.ModificarProducto(producto);
                MostrarProductos();
                MessageBox.Show("Producto modificado");
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
                int id = Convert.ToInt32(txtEliminarID.Text);
                productoBusiness.EliminarProducto(id);
                MostrarProductos();
                MessageBox.Show("Producto eliminado");
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void MostrarProductos()
        {
            List<Producto> listaProducto = productoBusiness.ObtenerProductos();

            dgvProductos.DataSource = null;
            dgvProductos.DataSource = listaProducto;
        }

        private void LimpiarCampos()
        {
            // Limpiar campos de texto
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
           
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                producto = new Producto();
                producto.Nombre = txtNombre.Text;
                producto.Descripcion = txtDescripcion.Text;
                producto.Precio = Convert.ToDecimal(txtPrecio.Text);
                producto.Stock = Convert.ToInt32(txtStock.Text);
                productoBusiness.GuardarProductos(producto);
                MostrarProductos();
                MessageBox.Show("Producto agregado");
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
                productoBusiness.GuardarProducto(listaProducto);
                MostrarProductos();
                MessageBox.Show("Producto agregado");
                LimpiarCampos();
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
                producto = new Producto();
                producto.Nombre = txtNombre.Text;
                producto.Descripcion = txtDescripcion.Text;
                producto.Precio = Convert.ToDecimal(txtPrecio.Text);
                producto.Stock = Convert.ToInt32(txtStock.Text);
                listaProducto.Add(producto);
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.SelectedRows.Count > 0)
                {
                    Producto seleccionado = (Producto)dgvProductos.SelectedRows[0].DataBoundItem;
                    if (seleccionado != null)
                    {
                        txtID.Text = seleccionado.ID.ToString();
                        txtModificarNombre.Text = seleccionado.Nombre.ToString();
                        txtModificarDescripcion.Text = seleccionado.Descripcion.ToString();
                        txtModificarPrecio.Text = seleccionado.Precio.ToString();
                        txtModificarStock.Text = seleccionado.Stock.ToString();
                        txtEliminarID.Text = seleccionado.ID.ToString();
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
