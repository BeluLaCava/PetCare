namespace UI
{
    partial class FrmProducto
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
            dgvProductos = new DataGridView();
            groupBox3 = new GroupBox();
            Productos = new Label();
            cmbEliminar = new ComboBox();
            btnEliminar = new Button();
            groupBox2 = new GroupBox();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            cmbProductos = new ComboBox();
            txtModificarPrecio = new TextBox();
            txtModificarNombre = new TextBox();
            txtModificarStock = new TextBox();
            txtModificarDescripcion = new TextBox();
            btnModificar = new Button();
            groupBox1 = new GroupBox();
            txtStock = new TextBox();
            txtDescripcion = new TextBox();
            txtPrecio = new TextBox();
            txtNombre = new TextBox();
            label4 = new Label();
            lebel3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnGuardar = new Button();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvProductos);
            groupBox4.Location = new Point(362, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(598, 552);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Productos";
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(6, 22);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.Size = new Size(586, 524);
            dgvProductos.TabIndex = 4;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(Productos);
            groupBox3.Controls.Add(cmbEliminar);
            groupBox3.Controls.Add(btnEliminar);
            groupBox3.Location = new Point(12, 455);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(328, 109);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Eliminar Producto";
            // 
            // Productos
            // 
            Productos.AutoSize = true;
            Productos.Font = new Font("Segoe UI", 12F);
            Productos.Location = new Point(19, 29);
            Productos.Name = "Productos";
            Productos.Size = new Size(61, 21);
            Productos.TabIndex = 22;
            Productos.Text = "label10";
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
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 12F);
            btnEliminar.Location = new Point(171, 45);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(143, 42);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(cmbProductos);
            groupBox2.Controls.Add(txtModificarPrecio);
            groupBox2.Controls.Add(txtModificarNombre);
            groupBox2.Controls.Add(txtModificarStock);
            groupBox2.Controls.Add(txtModificarDescripcion);
            groupBox2.Controls.Add(btnModificar);
            groupBox2.Location = new Point(12, 225);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(328, 224);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Modificar Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(8, 148);
            label3.Name = "label3";
            label3.Size = new Size(47, 21);
            label3.TabIndex = 23;
            label3.Text = "Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(6, 87);
            label5.Name = "label5";
            label5.Size = new Size(91, 21);
            label5.TabIndex = 22;
            label5.Text = "Descripcion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(171, 90);
            label6.Name = "label6";
            label6.Size = new Size(53, 21);
            label6.TabIndex = 21;
            label6.Text = "Precio";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(171, 19);
            label7.Name = "label7";
            label7.Size = new Size(68, 21);
            label7.TabIndex = 20;
            label7.Text = "Nombre";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(8, 21);
            label9.Name = "label9";
            label9.Size = new Size(80, 21);
            label9.TabIndex = 19;
            label9.Text = "Productos";
            // 
            // cmbProductos
            // 
            cmbProductos.Font = new Font("Segoe UI", 12F);
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(8, 45);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(143, 29);
            cmbProductos.TabIndex = 18;
            // 
            // txtModificarPrecio
            // 
            txtModificarPrecio.Font = new Font("Segoe UI", 12F);
            txtModificarPrecio.Location = new Point(171, 114);
            txtModificarPrecio.Name = "txtModificarPrecio";
            txtModificarPrecio.Size = new Size(143, 29);
            txtModificarPrecio.TabIndex = 17;
            // 
            // txtModificarNombre
            // 
            txtModificarNombre.Font = new Font("Segoe UI", 12F);
            txtModificarNombre.Location = new Point(171, 45);
            txtModificarNombre.Name = "txtModificarNombre";
            txtModificarNombre.Size = new Size(143, 29);
            txtModificarNombre.TabIndex = 16;
            // 
            // txtModificarStock
            // 
            txtModificarStock.Font = new Font("Segoe UI", 12F);
            txtModificarStock.Location = new Point(8, 172);
            txtModificarStock.Name = "txtModificarStock";
            txtModificarStock.Size = new Size(143, 29);
            txtModificarStock.TabIndex = 15;
            // 
            // txtModificarDescripcion
            // 
            txtModificarDescripcion.Font = new Font("Segoe UI", 12F);
            txtModificarDescripcion.Location = new Point(8, 111);
            txtModificarDescripcion.Name = "txtModificarDescripcion";
            txtModificarDescripcion.Size = new Size(143, 29);
            txtModificarDescripcion.TabIndex = 14;
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
            btnModificar.Click += btnModificar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lebel3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(328, 207);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alta Producto";
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Segoe UI", 12F);
            txtStock.Location = new Point(171, 117);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(143, 29);
            txtStock.TabIndex = 8;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 12F);
            txtDescripcion.Location = new Point(171, 53);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(143, 29);
            txtDescripcion.TabIndex = 7;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI", 12F);
            txtPrecio.Location = new Point(6, 117);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(143, 29);
            txtPrecio.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.Location = new Point(6, 53);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(143, 29);
            txtNombre.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(171, 93);
            label4.Name = "label4";
            label4.Size = new Size(47, 21);
            label4.TabIndex = 4;
            label4.Text = "Stock";
            // 
            // lebel3
            // 
            lebel3.AutoSize = true;
            lebel3.Font = new Font("Segoe UI", 12F);
            lebel3.Location = new Point(171, 29);
            lebel3.Name = "lebel3";
            lebel3.Size = new Size(91, 21);
            lebel3.TabIndex = 3;
            lebel3.Text = "Descripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(6, 93);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 2;
            label2.Text = "Precio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
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
            // 
            // FrmProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 579);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmProducto";
            WindowState = FormWindowState.Maximized;
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
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
        private DataGridView dgvProductos;
        private GroupBox groupBox3;
        private Label Productos;
        private ComboBox cmbEliminar;
        private Button btnEliminar;
        private GroupBox groupBox2;
        private Label label9;
        private ComboBox cmbProductos;
        private TextBox txtModificarPrecio;
        private TextBox txtModificarNombre;
        private TextBox txtModificarStock;
        private TextBox txtModificarDescripcion;
        private Button btnModificar;
        private GroupBox groupBox1;
        private TextBox txtStock;
        private TextBox txtDescripcion;
        private TextBox txtPrecio;
        private TextBox txtNombre;
        private Label label4;
        private Label lebel3;
        private Label label2;
        private Label label1;
        private Button btnGuardar;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}