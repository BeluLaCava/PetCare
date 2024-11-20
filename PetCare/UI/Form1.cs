using BLL;
using Entity;

namespace UI
{
    public partial class Form1 : Form
    {
        private Empleado empleado;
       
        public Form1(Empleado empleadoAutenticado)
        {
            InitializeComponent();
            empleado = empleadoAutenticado;


        }
        private void MostrarCitasHoy()
        {
           
        }
        private void OcultarControles()
        {
            lblEmpleadoNombre.Visible = false;
            lblTitulo.Visible = false;
            dgvCitasHoy.Visible = false;
            lblVeterinaria.Visible = false;
            imgCruz.Visible = false;
        }

        private void MostrarControles()
        {
            lblEmpleadoNombre.Visible = true;
            lblTitulo.Visible = true;
            dgvCitasHoy.Visible = true;
            lblVeterinaria.Visible = true;
            imgCruz.Visible = true;
        }
        private void agregarVeterinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVeterinario formVeterinario = Application.OpenForms["FrmVeterinario"] as FrmVeterinario;

            if (formVeterinario == null)
            {
                formVeterinario = new FrmVeterinario
                {
                    MdiParent = this,

                };
                OcultarControles();

                // Muestra el formulario y agrega el evento FormClosed
                formVeterinario.FormClosed += FrmVeterinario_FormClosed;
                formVeterinario.Show();
            }
            else
            {
                formVeterinario.BringToFront();
            }
        }

        private void FrmVeterinario_FormClosed(object sender, FormClosedEventArgs e)
        {
            MostrarControles();
        }

        private void agregarClienteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmCliente formCliente = Application.OpenForms["FrmCliente"] as FrmCliente;

            if (formCliente == null)
            {
                formCliente = new FrmCliente
                {
                    MdiParent = this
                };

                OcultarControles();

                // Muestra el formulario y agrega el evento FormClosed
                formCliente.FormClosed += FormCliente_FormClosed;
                formCliente.Show();

            }
            else
            {
                formCliente.BringToFront();
            }
        }
        private void FormCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            MostrarControles();
        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProducto formProducto = Application.OpenForms["FrmProducto"] as FrmProducto;

            if (formProducto == null)
            {
                formProducto = new FrmProducto
                {
                    MdiParent = this,

                };
                OcultarControles();

                // Muestra el formulario y agrega el evento FormClosed
                formProducto.FormClosed += FrmProducto_FormClosed;
                formProducto.Show();
            }
            else
            {
                formProducto.BringToFront();
            }
        }
        private void FrmProducto_FormClosed(object sender, FormClosedEventArgs e)
        {
            MostrarControles();
        }

        private void agregarMascotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMascota formMascota = Application.OpenForms["FrmMascota"] as FrmMascota;

            if (formMascota == null)
            {
                formMascota = new FrmMascota
                {
                    MdiParent = this,

                };
                OcultarControles();

                // Muestra el formulario y agrega el evento FormClosed
                formMascota.FormClosed += FrmMascota_FormClosed;
                formMascota.Show();
            }
            else
            {
                formMascota.BringToFront();
            }
        }
        private void FrmMascota_FormClosed(object sender, FormClosedEventArgs e)
        {
            MostrarControles();
        }
        private void agendarCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCita formCita = Application.OpenForms["FrmCita"] as FrmCita;

            if (formCita == null)
            {
                formCita = new FrmCita
                {
                    MdiParent = this,

                };
                OcultarControles();

                // Muestra el formulario y agrega el evento FormClosed
                formCita.FormClosed += FrmCita_FormClosed;
                formCita.Show();
            }
            else
            {
                formCita.BringToFront();
            }
        }
        private void FrmCita_FormClosed(object sender, FormClosedEventArgs e)
        {
            MostrarControles();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblEmpleadoNombre.Text = $"Bienvenido/a, {empleado.Apellido} {empleado.Nombre}";
            MostrarCitasHoy();
        }

        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFactura formFactura = Application.OpenForms["FrmFactura"] as FrmFactura;

            if (formFactura == null)
            {
                formFactura = new FrmFactura
                {
                    MdiParent = this,

                };
                OcultarControles();

                // Muestra el formulario y agrega el evento FormClosed
                formFactura.FormClosed += FrmCita_FormClosed;
                formFactura.Show();
            }
            else
            {
                formFactura.BringToFront();
            }
        }
        private void FrmFactura_FormClosed(object sender, FormClosedEventArgs e)
        {
            MostrarControles();
        }
    }
}
