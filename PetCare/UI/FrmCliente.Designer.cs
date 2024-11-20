﻿namespace UI
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
            btnAgregar = new Button();
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
            label6 = new Label();
            txtIdCliente = new TextBox();
            txtModificarApellido = new TextBox();
            label9 = new Label();
            btnEliminar = new Button();
            label10 = new Label();
            groupBox3 = new GroupBox();
            txtEliminarId = new TextBox();
            btnSalir = new Button();
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
            btnGuardar.Location = new Point(223, 256);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(143, 42);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Confirmar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAgregar);
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
            groupBox1.Location = new Point(89, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(419, 304);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alta Cliente";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 12F);
            btnAgregar.Location = new Point(141, 208);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(143, 42);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Guardar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBorrador
            // 
            btnBorrador.Font = new Font("Segoe UI", 12F);
            btnBorrador.Location = new Point(65, 256);
            btnBorrador.Name = "btnBorrador";
            btnBorrador.Size = new Size(143, 42);
            btnBorrador.TabIndex = 4;
            btnBorrador.Text = "Agregar Borrador";
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
            dgvClientes.Size = new Size(1203, 691);
            dgvClientes.TabIndex = 4;
            dgvClientes.SelectionChanged += dgvClientes_SelectionChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvClientes);
            groupBox4.Location = new Point(548, 34);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1215, 718);
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
            label8.Location = new Point(6, 173);
            label8.Name = "label8";
            label8.Size = new Size(68, 21);
            label8.TabIndex = 10;
            label8.Text = "Telefono";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(6, 212);
            label7.Name = "label7";
            label7.Size = new Size(48, 21);
            label7.TabIndex = 11;
            label7.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(6, 129);
            label5.Name = "label5";
            label5.Size = new Size(75, 21);
            label5.TabIndex = 13;
            label5.Text = "Direccion";
            // 
            // txtModificarTelefono
            // 
            txtModificarTelefono.Font = new Font("Segoe UI", 12F);
            txtModificarTelefono.Location = new Point(164, 165);
            txtModificarTelefono.Name = "txtModificarTelefono";
            txtModificarTelefono.Size = new Size(237, 29);
            txtModificarTelefono.TabIndex = 8;
            // 
            // txtModificarEmail
            // 
            txtModificarEmail.Font = new Font("Segoe UI", 12F);
            txtModificarEmail.Location = new Point(164, 204);
            txtModificarEmail.Name = "txtModificarEmail";
            txtModificarEmail.Size = new Size(237, 29);
            txtModificarEmail.TabIndex = 9;
            // 
            // txtModificarDireccion
            // 
            txtModificarDireccion.Font = new Font("Segoe UI", 12F);
            txtModificarDireccion.Location = new Point(164, 121);
            txtModificarDireccion.Name = "txtModificarDireccion";
            txtModificarDireccion.Size = new Size(237, 29);
            txtModificarDireccion.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtIdCliente);
            groupBox2.Controls.Add(txtModificarApellido);
            groupBox2.Controls.Add(label9);
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(6, 39);
            label6.Name = "label6";
            label6.Size = new Size(25, 21);
            label6.TabIndex = 22;
            label6.Text = "ID";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Font = new Font("Segoe UI", 12F);
            txtIdCliente.Location = new Point(164, 31);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(237, 29);
            txtIdCliente.TabIndex = 21;
            // 
            // txtModificarApellido
            // 
            txtModificarApellido.Font = new Font("Segoe UI", 12F);
            txtModificarApellido.Location = new Point(164, 76);
            txtModificarApellido.Name = "txtModificarApellido";
            txtModificarApellido.Size = new Size(237, 29);
            txtModificarApellido.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(6, 84);
            label9.Name = "label9";
            label9.Size = new Size(141, 21);
            label9.TabIndex = 19;
            label9.Text = "Apellido y Nombre";
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
            groupBox3.Controls.Add(txtEliminarId);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(btnEliminar);
            groupBox3.Location = new Point(89, 689);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(422, 160);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Eliminar Cliente";
            // 
            // txtEliminarId
            // 
            txtEliminarId.Font = new Font("Segoe UI", 12F);
            txtEliminarId.Location = new Point(164, 34);
            txtEliminarId.Name = "txtEliminarId";
            txtEliminarId.Size = new Size(237, 29);
            txtEliminarId.TabIndex = 23;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 12F);
            btnSalir.Location = new Point(548, 781);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(143, 42);
            btnSalir.TabIndex = 24;
            btnSalir.Text = "Cerrar";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1416, 797);
            Controls.Add(btnSalir);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cliente";
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
        private Button btnEliminar;
        private Label label10;
        private GroupBox groupBox3;
        private Button btnBorrador;
        private Label label6;
        private TextBox txtIdCliente;
        private TextBox txtModificarApellido;
        private Button btnAgregar;
        private TextBox txtEliminarId;
        private Button btnSalir;
    }
}