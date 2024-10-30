namespace UI
{
    partial class FrmVeterinario
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
            groupBox4 = new GroupBox();
            dgvVeterinarios = new DataGridView();
            groupBox3 = new GroupBox();
            btnEliminar = new Button();
            label10 = new Label();
            cmbEliminarVeterinario = new ComboBox();
            groupBox2 = new GroupBox();
            label7 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cmbModificarVeterinario = new ComboBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox8 = new TextBox();
            btnModificar = new Button();
            groupBox1 = new GroupBox();
            txtEspecialidad = new TextBox();
            txtHorario = new TextBox();
            txtApellido = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnGuardar = new Button();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVeterinarios).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvVeterinarios);
            groupBox4.Location = new Point(362, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(598, 552);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Veterinarios";
            // 
            // dgvVeterinarios
            // 
            dgvVeterinarios.AllowUserToAddRows = false;
            dgvVeterinarios.AllowUserToDeleteRows = false;
            dgvVeterinarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVeterinarios.Location = new Point(6, 22);
            dgvVeterinarios.Name = "dgvVeterinarios";
            dgvVeterinarios.ReadOnly = true;
            dgvVeterinarios.Size = new Size(586, 524);
            dgvVeterinarios.TabIndex = 4;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnEliminar);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(cmbEliminarVeterinario);
            groupBox3.Location = new Point(12, 449);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(328, 109);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Eliminar Veterinario";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(173, 29);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(141, 45);
            btnEliminar.TabIndex = 23;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(19, 29);
            label10.Name = "label10";
            label10.Size = new Size(86, 21);
            label10.TabIndex = 22;
            label10.Text = "Veterinario";
            // 
            // cmbEliminarVeterinario
            // 
            cmbEliminarVeterinario.Font = new Font("Segoe UI", 12F);
            cmbEliminarVeterinario.FormattingEnabled = true;
            cmbEliminarVeterinario.Location = new Point(19, 53);
            cmbEliminarVeterinario.Name = "cmbEliminarVeterinario";
            cmbEliminarVeterinario.Size = new Size(143, 29);
            cmbEliminarVeterinario.TabIndex = 21;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(cmbModificarVeterinario);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox8);
            groupBox2.Controls.Add(btnModificar);
            groupBox2.Location = new Point(12, 203);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(328, 224);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Modificar Veterinario";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(8, 21);
            label7.Name = "label7";
            label7.Size = new Size(86, 21);
            label7.TabIndex = 22;
            label7.Text = "Veterinario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(10, 87);
            label4.Name = "label4";
            label4.Size = new Size(95, 21);
            label4.TabIndex = 21;
            label4.Text = "Especialidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(173, 87);
            label5.Name = "label5";
            label5.Size = new Size(63, 21);
            label5.TabIndex = 20;
            label5.Text = "Horario";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(173, 21);
            label6.Name = "label6";
            label6.Size = new Size(141, 21);
            label6.TabIndex = 19;
            label6.Text = "Apellido y Nombre";
            // 
            // cmbModificarVeterinario
            // 
            cmbModificarVeterinario.Font = new Font("Segoe UI", 12F);
            cmbModificarVeterinario.FormattingEnabled = true;
            cmbModificarVeterinario.Location = new Point(8, 45);
            cmbModificarVeterinario.Name = "cmbModificarVeterinario";
            cmbModificarVeterinario.Size = new Size(143, 29);
            cmbModificarVeterinario.TabIndex = 18;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 12F);
            textBox5.Location = new Point(171, 114);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(143, 29);
            textBox5.TabIndex = 17;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 12F);
            textBox6.Location = new Point(171, 45);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(143, 29);
            textBox6.TabIndex = 16;
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Segoe UI", 12F);
            textBox8.Location = new Point(8, 111);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(143, 29);
            textBox8.TabIndex = 14;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 12F);
            btnModificar.Location = new Point(171, 169);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(143, 42);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtEspecialidad);
            groupBox1.Controls.Add(txtHorario);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(328, 176);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alta Veterinario";
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Font = new Font("Segoe UI", 12F);
            txtEspecialidad.Location = new Point(171, 53);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(143, 29);
            txtEspecialidad.TabIndex = 7;
            // 
            // txtHorario
            // 
            txtHorario.Font = new Font("Segoe UI", 12F);
            txtHorario.Location = new Point(6, 117);
            txtHorario.Name = "txtHorario";
            txtHorario.Size = new Size(143, 29);
            txtHorario.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 12F);
            txtApellido.Location = new Point(6, 53);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(143, 29);
            txtApellido.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(171, 29);
            label3.Name = "label3";
            label3.Size = new Size(95, 21);
            label3.TabIndex = 3;
            label3.Text = "Especialidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(6, 93);
            label2.Name = "label2";
            label2.Size = new Size(63, 21);
            label2.TabIndex = 2;
            label2.Text = "Horario";
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
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 12F);
            btnGuardar.Location = new Point(171, 109);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(143, 42);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // FrmVeterinario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 582);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmVeterinario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmVeterinario";
            WindowState = FormWindowState.Maximized;
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVeterinarios).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox4;
        private DataGridView dgvVeterinarios;
        private GroupBox groupBox3;
        private Label label10;
        private ComboBox cmbEliminarVeterinario;
        private Button button3;
        private GroupBox groupBox2;
        private Label label9;
        private ComboBox cmbModificarVeterinario;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox8;
        private Label label8;
        private Button btnModificar;
        private GroupBox groupBox1;
        private TextBox txtEspecialidad;
        private TextBox txtHorario;
        private TextBox txtApellido;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnGuardar;
        private Label label7;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnEliminar;
    }
}