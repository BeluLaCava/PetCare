﻿namespace UI
{
    partial class FrmMascota
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
         dgvMascotas = new DataGridView();
         groupBox3 = new GroupBox();
         label10 = new Label();
         cmbEliminar = new ComboBox();
         btnEliminar = new Button();
         groupBox2 = new GroupBox();
         label13 = new Label();
         dtpModificarFecha = new DateTimePicker();
         label8 = new Label();
         label9 = new Label();
         label11 = new Label();
         label12 = new Label();
         cmbMascota = new ComboBox();
         txtModificarEspecie = new TextBox();
         txtModificarNombre = new TextBox();
         txtModificarRaza = new TextBox();
         btnModificar = new Button();
         groupBox1 = new GroupBox();
         dtpFecha = new DateTimePicker();
         txtRaza = new TextBox();
         txtEspecie = new TextBox();
         txtNombre = new TextBox();
         label4 = new Label();
         label7 = new Label();
         label3 = new Label();
         label6 = new Label();
         label2 = new Label();
         label5 = new Label();
         label1 = new Label();
         btnGuardar = new Button();
         groupBox4.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)dgvMascotas).BeginInit();
         groupBox3.SuspendLayout();
         groupBox2.SuspendLayout();
         groupBox1.SuspendLayout();
         SuspendLayout();
         // 
         // groupBox4
         // 
         groupBox4.Controls.Add(dgvMascotas);
         groupBox4.Location = new Point(414, 16);
         groupBox4.Margin = new Padding(3, 4, 3, 4);
         groupBox4.Name = "groupBox4";
         groupBox4.Padding = new Padding(3, 4, 3, 4);
         groupBox4.Size = new Size(683, 736);
         groupBox4.TabIndex = 9;
         groupBox4.TabStop = false;
         groupBox4.Text = "Mascotas";
         // 
         // dgvMascotas
         // 
         dgvMascotas.AllowUserToAddRows = false;
         dgvMascotas.AllowUserToDeleteRows = false;
         dgvMascotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         dgvMascotas.Location = new Point(7, 29);
         dgvMascotas.Margin = new Padding(3, 4, 3, 4);
         dgvMascotas.Name = "dgvMascotas";
         dgvMascotas.ReadOnly = true;
         dgvMascotas.RowHeadersWidth = 51;
         dgvMascotas.Size = new Size(670, 699);
         dgvMascotas.TabIndex = 4;
         // 
         // groupBox3
         // 
         groupBox3.Controls.Add(label10);
         groupBox3.Controls.Add(cmbEliminar);
         groupBox3.Controls.Add(btnEliminar);
         groupBox3.Location = new Point(13, 705);
         groupBox3.Margin = new Padding(3, 4, 3, 4);
         groupBox3.Name = "groupBox3";
         groupBox3.Padding = new Padding(3, 4, 3, 4);
         groupBox3.Size = new Size(375, 145);
         groupBox3.TabIndex = 8;
         groupBox3.TabStop = false;
         groupBox3.Text = "Eliminar Mascota";
         // 
         // label10
         // 
         label10.AutoSize = true;
         label10.Font = new Font("Segoe UI", 12F);
         label10.Location = new Point(22, 39);
         label10.Name = "label10";
         label10.Size = new Size(86, 28);
         label10.TabIndex = 22;
         label10.Text = "Mascota";
         // 
         // cmbEliminar
         // 
         cmbEliminar.Font = new Font("Segoe UI", 12F);
         cmbEliminar.FormattingEnabled = true;
         cmbEliminar.Location = new Point(22, 71);
         cmbEliminar.Margin = new Padding(3, 4, 3, 4);
         cmbEliminar.Name = "cmbEliminar";
         cmbEliminar.Size = new Size(163, 36);
         cmbEliminar.TabIndex = 21;
         // 
         // btnEliminar
         // 
         btnEliminar.Font = new Font("Segoe UI", 12F);
         btnEliminar.Location = new Point(195, 53);
         btnEliminar.Margin = new Padding(3, 4, 3, 4);
         btnEliminar.Name = "btnEliminar";
         btnEliminar.Size = new Size(163, 56);
         btnEliminar.TabIndex = 20;
         btnEliminar.Text = "Eliminar";
         btnEliminar.UseVisualStyleBackColor = true;
         btnEliminar.Click += btnEliminar_Click;
         // 
         // groupBox2
         // 
         groupBox2.Controls.Add(label13);
         groupBox2.Controls.Add(dtpModificarFecha);
         groupBox2.Controls.Add(label8);
         groupBox2.Controls.Add(label9);
         groupBox2.Controls.Add(label11);
         groupBox2.Controls.Add(label12);
         groupBox2.Controls.Add(cmbMascota);
         groupBox2.Controls.Add(txtModificarEspecie);
         groupBox2.Controls.Add(txtModificarNombre);
         groupBox2.Controls.Add(txtModificarRaza);
         groupBox2.Controls.Add(btnModificar);
         groupBox2.Location = new Point(14, 323);
         groupBox2.Margin = new Padding(3, 4, 3, 4);
         groupBox2.Name = "groupBox2";
         groupBox2.Padding = new Padding(3, 4, 3, 4);
         groupBox2.Size = new Size(375, 375);
         groupBox2.TabIndex = 7;
         groupBox2.TabStop = false;
         groupBox2.Text = "Modificar Mascota";
         // 
         // label13
         // 
         label13.AutoSize = true;
         label13.Font = new Font("Segoe UI", 12F);
         label13.Location = new Point(7, 28);
         label13.Name = "label13";
         label13.Size = new Size(86, 28);
         label13.TabIndex = 24;
         label13.Text = "Mascota";
         // 
         // dtpModificarFecha
         // 
         dtpModificarFecha.Font = new Font("Segoe UI", 12F);
         dtpModificarFecha.Location = new Point(11, 237);
         dtpModificarFecha.Margin = new Padding(3, 4, 3, 4);
         dtpModificarFecha.Name = "dtpModificarFecha";
         dtpModificarFecha.Size = new Size(245, 34);
         dtpModificarFecha.TabIndex = 23;
         // 
         // label8
         // 
         label8.AutoSize = true;
         label8.Font = new Font("Segoe UI", 12F);
         label8.Location = new Point(9, 205);
         label8.Name = "label8";
         label8.Size = new Size(168, 28);
         label8.TabIndex = 22;
         label8.Text = "Fecha Nacimiento";
         // 
         // label9
         // 
         label9.AutoSize = true;
         label9.Font = new Font("Segoe UI", 12F);
         label9.Location = new Point(9, 117);
         label9.Name = "label9";
         label9.Size = new Size(53, 28);
         label9.TabIndex = 21;
         label9.Text = "Raza";
         // 
         // label11
         // 
         label11.AutoSize = true;
         label11.Font = new Font("Segoe UI", 12F);
         label11.Location = new Point(195, 117);
         label11.Name = "label11";
         label11.Size = new Size(76, 28);
         label11.TabIndex = 20;
         label11.Text = "Especie";
         // 
         // label12
         // 
         label12.AutoSize = true;
         label12.Font = new Font("Segoe UI", 12F);
         label12.Location = new Point(195, 28);
         label12.Name = "label12";
         label12.Size = new Size(85, 28);
         label12.TabIndex = 19;
         label12.Text = "Nombre";
         // 
         // cmbMascota
         // 
         cmbMascota.Font = new Font("Segoe UI", 12F);
         cmbMascota.FormattingEnabled = true;
         cmbMascota.Location = new Point(9, 60);
         cmbMascota.Margin = new Padding(3, 4, 3, 4);
         cmbMascota.Name = "cmbMascota";
         cmbMascota.Size = new Size(163, 36);
         cmbMascota.TabIndex = 18;
         // 
         // txtModificarEspecie
         // 
         txtModificarEspecie.Font = new Font("Segoe UI", 12F);
         txtModificarEspecie.Location = new Point(195, 152);
         txtModificarEspecie.Margin = new Padding(3, 4, 3, 4);
         txtModificarEspecie.Name = "txtModificarEspecie";
         txtModificarEspecie.Size = new Size(163, 34);
         txtModificarEspecie.TabIndex = 17;
         // 
         // txtModificarNombre
         // 
         txtModificarNombre.Font = new Font("Segoe UI", 12F);
         txtModificarNombre.Location = new Point(195, 60);
         txtModificarNombre.Margin = new Padding(3, 4, 3, 4);
         txtModificarNombre.Name = "txtModificarNombre";
         txtModificarNombre.Size = new Size(163, 34);
         txtModificarNombre.TabIndex = 16;
         // 
         // txtModificarRaza
         // 
         txtModificarRaza.Font = new Font("Segoe UI", 12F);
         txtModificarRaza.Location = new Point(9, 148);
         txtModificarRaza.Margin = new Padding(3, 4, 3, 4);
         txtModificarRaza.Name = "txtModificarRaza";
         txtModificarRaza.Size = new Size(163, 34);
         txtModificarRaza.TabIndex = 14;
         // 
         // btnModificar
         // 
         btnModificar.Font = new Font("Segoe UI", 12F);
         btnModificar.Location = new Point(205, 311);
         btnModificar.Margin = new Padding(3, 4, 3, 4);
         btnModificar.Name = "btnModificar";
         btnModificar.Size = new Size(163, 56);
         btnModificar.TabIndex = 9;
         btnModificar.Text = "Modificar";
         btnModificar.UseVisualStyleBackColor = true;
         btnModificar.Click += btnModificar_Click;
         // 
         // groupBox1
         // 
         groupBox1.Controls.Add(dtpFecha);
         groupBox1.Controls.Add(txtRaza);
         groupBox1.Controls.Add(txtEspecie);
         groupBox1.Controls.Add(txtNombre);
         groupBox1.Controls.Add(label4);
         groupBox1.Controls.Add(label7);
         groupBox1.Controls.Add(label3);
         groupBox1.Controls.Add(label6);
         groupBox1.Controls.Add(label2);
         groupBox1.Controls.Add(label5);
         groupBox1.Controls.Add(label1);
         groupBox1.Controls.Add(btnGuardar);
         groupBox1.Location = new Point(14, 16);
         groupBox1.Margin = new Padding(3, 4, 3, 4);
         groupBox1.Name = "groupBox1";
         groupBox1.Padding = new Padding(3, 4, 3, 4);
         groupBox1.Size = new Size(375, 299);
         groupBox1.TabIndex = 6;
         groupBox1.TabStop = false;
         groupBox1.Text = "Alta Mascota";
         // 
         // dtpFecha
         // 
         dtpFecha.Font = new Font("Segoe UI", 12F);
         dtpFecha.Location = new Point(9, 235);
         dtpFecha.Margin = new Padding(3, 4, 3, 4);
         dtpFecha.Name = "dtpFecha";
         dtpFecha.Size = new Size(245, 34);
         dtpFecha.TabIndex = 8;
         // 
         // txtRaza
         // 
         txtRaza.Font = new Font("Segoe UI", 12F);
         txtRaza.Location = new Point(195, 71);
         txtRaza.Margin = new Padding(3, 4, 3, 4);
         txtRaza.Name = "txtRaza";
         txtRaza.Size = new Size(163, 34);
         txtRaza.TabIndex = 7;
         // 
         // txtEspecie
         // 
         txtEspecie.Font = new Font("Segoe UI", 12F);
         txtEspecie.Location = new Point(7, 156);
         txtEspecie.Margin = new Padding(3, 4, 3, 4);
         txtEspecie.Name = "txtEspecie";
         txtEspecie.Size = new Size(163, 34);
         txtEspecie.TabIndex = 6;
         // 
         // txtNombre
         // 
         txtNombre.Font = new Font("Segoe UI", 12F);
         txtNombre.Location = new Point(7, 71);
         txtNombre.Margin = new Padding(3, 4, 3, 4);
         txtNombre.Name = "txtNombre";
         txtNombre.Size = new Size(163, 34);
         txtNombre.TabIndex = 5;
         // 
         // label4
         // 
         label4.AutoSize = true;
         label4.Font = new Font("Segoe UI", 12F);
         label4.Location = new Point(7, 203);
         label4.Name = "label4";
         label4.Size = new Size(168, 28);
         label4.TabIndex = 4;
         label4.Text = "Fecha Nacimiento";
         // 
         // label7
         // 
         label7.AutoSize = true;
         label7.Font = new Font("Segoe UI", 12F);
         label7.Location = new Point(187, 39);
         label7.Name = "label7";
         label7.Size = new Size(53, 28);
         label7.TabIndex = 3;
         label7.Text = "Raza";
         // 
         // label3
         // 
         label3.AutoSize = true;
         label3.Font = new Font("Segoe UI", 12F);
         label3.Location = new Point(195, 39);
         label3.Name = "label3";
         label3.Size = new Size(53, 28);
         label3.TabIndex = 3;
         label3.Text = "Raza";
         // 
         // label6
         // 
         label6.AutoSize = true;
         label6.Font = new Font("Segoe UI", 12F);
         label6.Location = new Point(-1, 124);
         label6.Name = "label6";
         label6.Size = new Size(76, 28);
         label6.TabIndex = 2;
         label6.Text = "Especie";
         // 
         // label2
         // 
         label2.AutoSize = true;
         label2.Font = new Font("Segoe UI", 12F);
         label2.Location = new Point(7, 124);
         label2.Name = "label2";
         label2.Size = new Size(76, 28);
         label2.TabIndex = 2;
         label2.Text = "Especie";
         // 
         // label5
         // 
         label5.AutoSize = true;
         label5.Font = new Font("Segoe UI", 12F);
         label5.Location = new Point(-1, 39);
         label5.Name = "label5";
         label5.Size = new Size(85, 28);
         label5.TabIndex = 1;
         label5.Text = "Nombre";
         // 
         // label1
         // 
         label1.AutoSize = true;
         label1.Font = new Font("Segoe UI", 12F);
         label1.Location = new Point(7, 39);
         label1.Name = "label1";
         label1.Size = new Size(85, 28);
         label1.TabIndex = 1;
         label1.Text = "Nombre";
         // 
         // btnGuardar
         // 
         btnGuardar.Font = new Font("Segoe UI", 12F);
         btnGuardar.Location = new Point(195, 145);
         btnGuardar.Margin = new Padding(3, 4, 3, 4);
         btnGuardar.Name = "btnGuardar";
         btnGuardar.Size = new Size(163, 56);
         btnGuardar.TabIndex = 0;
         btnGuardar.Text = "Guardar";
         btnGuardar.UseVisualStyleBackColor = true;
         btnGuardar.Click += btnGuardar_Click;
         // 
         // FrmMascota
         // 
         AutoScaleDimensions = new SizeF(8F, 20F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(1247, 867);
         Controls.Add(groupBox4);
         Controls.Add(groupBox3);
         Controls.Add(groupBox2);
         Controls.Add(groupBox1);
         Margin = new Padding(3, 4, 3, 4);
         Name = "FrmMascota";
         StartPosition = FormStartPosition.CenterScreen;
         Text = "FrmMascota";
         WindowState = FormWindowState.Maximized;
         groupBox4.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)dgvMascotas).EndInit();
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
        private DataGridView dgvMascotas;
        private GroupBox groupBox3;
        private Label label10;
        private ComboBox cmbEliminar;
        private Button btnEliminar;
        private GroupBox groupBox2;
        private ComboBox cmbMascota;
        private TextBox txtModificarEspecie;
        private TextBox txtModificarNombre;
        private TextBox txtModificarRaza;
        private Button btnModificar;
        private GroupBox groupBox1;
        private TextBox txtRaza;
        private TextBox txtEspecie;
        private TextBox txtNombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnGuardar;
        private DateTimePicker dtpFecha;
        private DateTimePicker dtpModificarFecha;
        private Label label8;
        private Label label9;
        private Label label11;
        private Label label12;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label13;
    }
}