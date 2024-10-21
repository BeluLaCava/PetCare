namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarVeterinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVeterinario formVeterinario = Application.OpenForms["FrmVeterinario"] as FrmVeterinario;

            if (formVeterinario == null)
            {
                formVeterinario = new FrmVeterinario
                {
                    MdiParent = this,
                    // WindowState = FormWindowState.Maximized
                };
                formVeterinario.Show();
            }
            else
            {
                formVeterinario.BringToFront(); // Traer al frente si ya está abierto
            }
        }



        private void agregarClienteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmCliente formCliente = Application.OpenForms["FrmCliente"] as FrmCliente;

            if (formCliente == null)
            {
                formCliente = new FrmCliente
                {
                    MdiParent = this,

                };
                formCliente.Show();
            }
            else
            {
                formCliente.BringToFront(); // Traer al frente si ya está abierto
            }
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
                formProducto.Show();
            }
            else
            {
                formProducto.BringToFront(); // Traer al frente si ya está abierto
            }
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
                formMascota.Show();
            }
            else
            {
                formMascota.BringToFront(); // Traer al frente si ya está abierto
            }
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
                formCita.Show();
            }
            else
            {
                formCita.BringToFront(); // Traer al frente si ya está abierto
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
