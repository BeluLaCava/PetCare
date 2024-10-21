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
            button2 = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtModificarTelefono = new TextBox();
            txtModificarEmail = new TextBox();
            txtModificarApellido = new TextBox();
            txtModificarDireccion = new TextBox();
            groupBox2 = new GroupBox();
            label9 = new Label();
            cmbCliente = new ComboBox();
            button3 = new Button();
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
            btnGuardar.Location = new Point(171, 152);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(143, 42);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(328, 207);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alta Cliente";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(171, 117);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(143, 29);
            txtEmail.TabIndex = 8;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 12F);
            txtTelefono.Location = new Point(171, 53);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(143, 29);
            txtTelefono.TabIndex = 7;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 12F);
            txtDireccion.Location = new Point(6, 117);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(143, 29);
            txtDireccion.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 12F);
            txtApellido.Location = new Point(6, 53);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(143, 29);
            txtApellido.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(171, 93);
            label4.Name = "label4";
            label4.Size = new Size(48, 21);
            label4.TabIndex = 4;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(171, 29);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 3;
            label3.Text = "Telefono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(6, 93);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 2;
            label2.Text = "Direccion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(141, 21);
            label1.TabIndex = 1;
            label1.Text = "Apellido y Nombre";
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(6, 22);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.Size = new Size(586, 524);
            dgvClientes.TabIndex = 4;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvClientes);
            groupBox4.Location = new Point(362, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(598, 552);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Clientes";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(171, 169);
            button2.Name = "button2";
            button2.Size = new Size(143, 42);
            button2.TabIndex = 9;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(8, 87);
            label8.Name = "label8";
            label8.Size = new Size(68, 21);
            label8.TabIndex = 10;
            label8.Text = "Telefono";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(8, 148);
            label7.Name = "label7";
            label7.Size = new Size(48, 21);
            label7.TabIndex = 11;
            label7.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(171, 21);
            label6.Name = "label6";
            label6.Size = new Size(141, 21);
            label6.TabIndex = 12;
            label6.Text = "Apellido y Nombre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(171, 87);
            label5.Name = "label5";
            label5.Size = new Size(75, 21);
            label5.TabIndex = 13;
            label5.Text = "Direccion";
            // 
            // txtModificarTelefono
            // 
            txtModificarTelefono.Font = new Font("Segoe UI", 12F);
            txtModificarTelefono.Location = new Point(8, 111);
            txtModificarTelefono.Name = "txtModificarTelefono";
            txtModificarTelefono.Size = new Size(143, 29);
            txtModificarTelefono.TabIndex = 14;
            // 
            // txtModificarEmail
            // 
            txtModificarEmail.Font = new Font("Segoe UI", 12F);
            txtModificarEmail.Location = new Point(8, 172);
            txtModificarEmail.Name = "txtModificarEmail";
            txtModificarEmail.Size = new Size(143, 29);
            txtModificarEmail.TabIndex = 15;
            // 
            // txtModificarApellido
            // 
            txtModificarApellido.Font = new Font("Segoe UI", 12F);
            txtModificarApellido.Location = new Point(171, 45);
            txtModificarApellido.Name = "txtModificarApellido";
            txtModificarApellido.Size = new Size(143, 29);
            txtModificarApellido.TabIndex = 16;
            // 
            // txtModificarDireccion
            // 
            txtModificarDireccion.Font = new Font("Segoe UI", 12F);
            txtModificarDireccion.Location = new Point(171, 111);
            txtModificarDireccion.Name = "txtModificarDireccion";
            txtModificarDireccion.Size = new Size(143, 29);
            txtModificarDireccion.TabIndex = 17;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(cmbCliente);
            groupBox2.Controls.Add(txtModificarDireccion);
            groupBox2.Controls.Add(txtModificarApellido);
            groupBox2.Controls.Add(txtModificarEmail);
            groupBox2.Controls.Add(txtModificarTelefono);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(12, 225);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(328, 224);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Modificar Cliente";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(8, 21);
            label9.Name = "label9";
            label9.Size = new Size(58, 21);
            label9.TabIndex = 19;
            label9.Text = "Cliente";
            // 
            // cmbCliente
            // 
            cmbCliente.Font = new Font("Segoe UI", 12F);
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(8, 45);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(143, 29);
            cmbCliente.TabIndex = 18;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(171, 40);
            button3.Name = "button3";
            button3.Size = new Size(143, 42);
            button3.TabIndex = 20;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // cmbEliminar
            // 
            cmbEliminar.Font = new Font("Segoe UI", 12F);
            cmbEliminar.FormattingEnabled = true;
            cmbEliminar.Location = new Point(19, 53);
            cmbEliminar.Name = "cmbEliminar";
            cmbEliminar.Size = new Size(143, 29);
            cmbEliminar.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(19, 29);
            label10.Name = "label10";
            label10.Size = new Size(61, 21);
            label10.TabIndex = 22;
            label10.Text = "label10";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(cmbEliminar);
            groupBox3.Controls.Add(button3);
            groupBox3.Location = new Point(12, 455);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(328, 109);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Eliminar Cliente";
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 573);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCliente";
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
        private Button button2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtModificarTelefono;
        private TextBox txtModificarEmail;
        private TextBox txtModificarApellido;
        private TextBox txtModificarDireccion;
        private GroupBox groupBox2;
        private Label label9;
        private ComboBox cmbCliente;
        private Button button3;
        private ComboBox cmbEliminar;
        private Label label10;
        private GroupBox groupBox3;
    }
}