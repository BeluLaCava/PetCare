namespace UI
{
    partial class FrmCita
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
            Clientes = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox3 = new GroupBox();
            btnEliminarCita = new Button();
            cmbEliminarCita = new ComboBox();
            label10 = new Label();
            groupBox2 = new GroupBox();
            dtpModificarFecha = new DateTimePicker();
            label8 = new Label();
            cmbModificarVeterinario = new ComboBox();
            label6 = new Label();
            cmbModificarMascota = new ComboBox();
            label9 = new Label();
            cmbCita = new ComboBox();
            txtModificarHora = new TextBox();
            label5 = new Label();
            label7 = new Label();
            btnModificar = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            dtpFecha = new DateTimePicker();
            label3 = new Label();
            label1 = new Label();
            cmbVeterinario = new ComboBox();
            cmbMascota = new ComboBox();
            txtHora = new TextBox();
            label4 = new Label();
            btnGuardar = new Button();
            Clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Clientes
            // 
            Clientes.Controls.Add(dataGridView1);
            Clientes.Location = new Point(362, 12);
            Clientes.Name = "Clientes";
            Clientes.Size = new Size(598, 552);
            Clientes.TabIndex = 9;
            Clientes.TabStop = false;
            Clientes.Text = "Citas";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(586, 524);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnEliminarCita);
            groupBox3.Controls.Add(cmbEliminarCita);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(12, 521);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(328, 109);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Eliminar Cita";
            // 
            // btnEliminarCita
            // 
            btnEliminarCita.Font = new Font("Segoe UI", 12F);
            btnEliminarCita.Location = new Point(171, 47);
            btnEliminarCita.Name = "btnEliminarCita";
            btnEliminarCita.Size = new Size(139, 44);
            btnEliminarCita.TabIndex = 24;
            btnEliminarCita.Text = "Eliminar";
            btnEliminarCita.UseVisualStyleBackColor = true;
            // 
            // cmbEliminarCita
            // 
            cmbEliminarCita.Font = new Font("Segoe UI", 12F);
            cmbEliminarCita.FormattingEnabled = true;
            cmbEliminarCita.Location = new Point(19, 59);
            cmbEliminarCita.Name = "cmbEliminarCita";
            cmbEliminarCita.Size = new Size(146, 29);
            cmbEliminarCita.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(19, 29);
            label10.Name = "label10";
            label10.Size = new Size(37, 21);
            label10.TabIndex = 22;
            label10.Text = "Cita";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtpModificarFecha);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(cmbModificarVeterinario);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(cmbModificarMascota);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(cmbCita);
            groupBox2.Controls.Add(txtModificarHora);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(btnModificar);
            groupBox2.Location = new Point(12, 254);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(328, 261);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Modificar Cita";
            // 
            // dtpModificarFecha
            // 
            dtpModificarFecha.Font = new Font("Segoe UI", 12F);
            dtpModificarFecha.Location = new Point(8, 172);
            dtpModificarFecha.Name = "dtpModificarFecha";
            dtpModificarFecha.Size = new Size(200, 29);
            dtpModificarFecha.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(6, 87);
            label8.Name = "label8";
            label8.Size = new Size(86, 21);
            label8.TabIndex = 23;
            label8.Text = "Veterinario";
            // 
            // cmbModificarVeterinario
            // 
            cmbModificarVeterinario.Font = new Font("Segoe UI", 12F);
            cmbModificarVeterinario.FormattingEnabled = true;
            cmbModificarVeterinario.Location = new Point(6, 113);
            cmbModificarVeterinario.Name = "cmbModificarVeterinario";
            cmbModificarVeterinario.Size = new Size(141, 29);
            cmbModificarVeterinario.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(169, 21);
            label6.Name = "label6";
            label6.Size = new Size(68, 21);
            label6.TabIndex = 21;
            label6.Text = "Mascota";
            // 
            // cmbModificarMascota
            // 
            cmbModificarMascota.Font = new Font("Segoe UI", 12F);
            cmbModificarMascota.FormattingEnabled = true;
            cmbModificarMascota.Location = new Point(169, 47);
            cmbModificarMascota.Name = "cmbModificarMascota";
            cmbModificarMascota.Size = new Size(141, 29);
            cmbModificarMascota.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(8, 21);
            label9.Name = "label9";
            label9.Size = new Size(37, 21);
            label9.TabIndex = 19;
            label9.Text = "Cita";
            // 
            // cmbCita
            // 
            cmbCita.Font = new Font("Segoe UI", 12F);
            cmbCita.FormattingEnabled = true;
            cmbCita.Location = new Point(8, 45);
            cmbCita.Name = "cmbCita";
            cmbCita.Size = new Size(143, 29);
            cmbCita.TabIndex = 18;
            // 
            // txtModificarHora
            // 
            txtModificarHora.Font = new Font("Segoe UI", 12F);
            txtModificarHora.Location = new Point(171, 111);
            txtModificarHora.Name = "txtModificarHora";
            txtModificarHora.Size = new Size(143, 29);
            txtModificarHora.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(171, 87);
            label5.Name = "label5";
            label5.Size = new Size(44, 21);
            label5.TabIndex = 13;
            label5.Text = "Hora";
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
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 12F);
            btnModificar.Location = new Point(171, 213);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(143, 42);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dtpFecha);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbVeterinario);
            groupBox1.Controls.Add(cmbMascota);
            groupBox1.Controls.Add(txtHora);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(328, 236);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alta Cita";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(8, 153);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 14;
            label2.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Segoe UI", 12F);
            dtpFecha.Location = new Point(8, 177);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 29);
            dtpFecha.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(171, 31);
            label3.Name = "label3";
            label3.Size = new Size(86, 21);
            label3.TabIndex = 12;
            label3.Text = "Veterinario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(8, 31);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 11;
            label1.Text = "Mascota";
            // 
            // cmbVeterinario
            // 
            cmbVeterinario.Font = new Font("Segoe UI", 12F);
            cmbVeterinario.FormattingEnabled = true;
            cmbVeterinario.Location = new Point(171, 57);
            cmbVeterinario.Name = "cmbVeterinario";
            cmbVeterinario.Size = new Size(141, 29);
            cmbVeterinario.TabIndex = 10;
            // 
            // cmbMascota
            // 
            cmbMascota.Font = new Font("Segoe UI", 12F);
            cmbMascota.FormattingEnabled = true;
            cmbMascota.Location = new Point(8, 57);
            cmbMascota.Name = "cmbMascota";
            cmbMascota.Size = new Size(141, 29);
            cmbMascota.TabIndex = 9;
            // 
            // txtHora
            // 
            txtHora.Font = new Font("Segoe UI", 12F);
            txtHora.Location = new Point(8, 113);
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(143, 29);
            txtHora.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(8, 89);
            label4.Name = "label4";
            label4.Size = new Size(44, 21);
            label4.TabIndex = 4;
            label4.Text = "Hora";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 12F);
            btnGuardar.Location = new Point(169, 105);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(143, 42);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // FrmCita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 639);
            Controls.Add(Clientes);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmCita";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCita";
            WindowState = FormWindowState.Maximized;
            Clientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Clientes;
        private DataGridView dgvClientes;
        private GroupBox groupBox3;
        private Label label10;
        private ComboBox cmbEliminar;
        private Button button3;
        private GroupBox groupBox2;
        private Label label9;
        private ComboBox cmbCita;
        private TextBox txtModificarHora;
        private TextBox txtModificarEmail;
        private Label label5;
        private Label label7;
        private Button btnModificar;
        private GroupBox groupBox1;
        private Label label2;
        private DateTimePicker dtpFecha;
        private Label label3;
        private Label label1;
        private ComboBox cmbVeterinario;
        private ComboBox cmbMascota;
        private TextBox txtHora;
        private Label label4;
        private Button btnGuardar;
        private Label label8;
        private ComboBox cmbModificarVeterinario;
        private Label label6;
        private ComboBox cmbModificarMascota;
        private DateTimePicker dtpModificarFecha;
        private Button btnEliminarCita;
        private ComboBox cmbEliminarCita;
        private DataGridView dataGridView1;
    }
}