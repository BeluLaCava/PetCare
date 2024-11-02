namespace UI
{
    partial class FrmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGuardar = new Button();
            groupBox1 = new GroupBox();
            btnBorrador = new Button();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtApellido = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvClientes = new DataGridView();
            groupBox4 = new GroupBox();
            btnModificar = new Button();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            txtModificarTelefono = new TextBox();
            txtModificarEmail = new TextBox();
            txtModificarDireccion = new TextBox();
            groupBox2 = new GroupBox();
            label9 = new Label();
            cmbCliente = new ComboBox();
            btnEliminar = new Button();
            cmbEliminar = new ComboBox();
            label10 = new Label();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 12F);
            btnGuardar.Location = new Point(258, 217);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(143, 42);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Confirmar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBorrador);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Location = new Point(89, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(419, 275);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alta Cliente";
            // 
            // btnBorrador
            // 
            btnBorrador.Font = new Font("Segoe UI", 12F);
            btnBorrador.Location = new Point(109, 217);
            btnBorrador.Name = "btnBorrador";
            btnBorrador.Size = new Size(143, 42);
            btnBorrador.TabIndex = 4;
            btnBorrador.Text = "Guardar borrador";
            btnBorrador.UseVisualStyleBackColor = true;
            btnBorrador.Click += btnBorrador_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(164, 159);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(237, 29);
            txtEmail.TabIndex = 3;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 12F);
            txtTelefono.Location = new Point(164, 69);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(237, 29);
            txtTelefono.TabIndex = 1;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 12F);
            txtDireccion.Location = new Point(164, 114);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(237, 29);
            txtDireccion.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 12F);
            txtApellido.Location = new Point(164, 26);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(237, 29);
            txtApellido.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(6, 167);
            label4.Name = "label4";
            label4.Size = new Size(48, 21);
            label4.TabIndex = 4;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(6, 77);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 3;
            label3.Text = "Telefono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(6, 122);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 2;
            label2.Text = "Direccion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(141, 21);
            label1.TabIndex = 1;
            label1.Text = "Apellido y Nombre";
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(6, 22);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(1203, 758);
            dgvClientes.TabIndex = 4;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvClientes);
            groupBox4.Location = new Point(548, 63);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1215, 786);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Clientes";
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 12F);
            btnModificar.Location = new Point(258, 251);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(143, 42);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(6, 148);
            label8.Name = "label8";
            label8.Size = new Size(68, 21);
            label8.TabIndex = 10;
            label8.Text = "Telefono";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(6, 202);
            label7.Name = "label7";
            label7.Size = new Size(48, 21);
            label7.TabIndex = 11;
            label7.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(6, 89);
            label5.Name = "label5";
            label5.Size = new Size(75, 21);
            label5.TabIndex = 13;
            label5.Text = "Direccion";
            // 
            // txtModificarTelefono
            // 
            txtModificarTelefono.Font = new Font("Segoe UI", 12F);
            txtModificarTelefono.Location = new Point(164, 140);
            txtModificarTelefono.Name = "txtModificarTelefono";
            txtModificarTelefono.Size = new Size(237, 29);
            txtModificarTelefono.TabIndex = 8;
            // 
            // txtModificarEmail
            // 
            txtModificarEmail.Font = new Font("Segoe UI", 12F);
            txtModificarEmail.Location = new Point(164, 194);
            txtModificarEmail.Name = "txtModificarEmail";
            txtModificarEmail.Size = new Size(237, 29);
            txtModificarEmail.TabIndex = 9;
            // 
            // txtModificarDireccion
            // 
            txtModificarDireccion.Font = new Font("Segoe UI", 12F);
            txtModificarDireccion.Location = new Point(164, 81);
            txtModificarDireccion.Name = "txtModificarDireccion";
            txtModificarDireccion.Size = new Size(237, 29);
            txtModificarDireccion.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(cmbCliente);
            groupBox2.Controls.Add(txtModificarDireccion);
            groupBox2.Controls.Add(txtModificarEmail);
            groupBox2.Controls.Add(txtModificarTelefono);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(btnModificar);
            groupBox2.Location = new Point(89, 355);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(422, 317);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Modificar Cliente";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(6, 40);
            label9.Name = "label9";
            label9.Size = new Size(58, 21);
            label9.TabIndex = 19;
            label9.Text = "Cliente";
            // 
            // cmbCliente
            // 
            cmbCliente.Font = new Font("Segoe UI", 12F);
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(164, 32);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(237, 29);
            cmbCliente.TabIndex = 6;
            cmbCliente.SelectedIndexChanged += cmbCliente_SelectedIndexChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 12F);
            btnEliminar.Location = new Point(258, 92);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(143, 42);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // cmbEliminar
            // 
            cmbEliminar.Font = new Font("Segoe UI", 12F);
            cmbEliminar.FormattingEnabled = true;
            cmbEliminar.Location = new Point(164, 29);
            cmbEliminar.Name = "cmbEliminar";
            cmbEliminar.Size = new Size(237, 29);
            cmbEliminar.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(6, 37);
            label10.Name = "label10";
            label10.Size = new Size(58, 21);
            label10.TabIndex = 22;
            label10.Text = "Cliente";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(cmbEliminar);
            groupBox3.Controls.Add(btnEliminar);
            groupBox3.Location = new Point(89, 689);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(422, 160);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Eliminar Cliente";
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1370, 749);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCliente";
            WindowState = FormWindowState.Maximized;
            Load += FrmCliente_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGuardar;
        private GroupBox groupBox1;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtApellido;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvClientes;
        private GroupBox groupBox4;
        private Button btnModificar;
        private Label label8;
        private Label label7;
        private Label label5;
        private TextBox txtModificarTelefono;
        private TextBox txtModificarEmail;
        private TextBox txtModificarDireccion;
        private GroupBox groupBox2;
        private Label label9;
        private ComboBox cmbCliente;
        private Button btnEliminar;
        private ComboBox cmbEliminar;
        private Label label10;
        private GroupBox groupBox3;
        private Button btnBorrador;
    }
}