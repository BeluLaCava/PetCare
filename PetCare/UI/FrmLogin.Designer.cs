namespace UI
{
    partial class FrmLogin
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
            btnLogin = new Button();
            txtEmail = new TextBox();
            txtPass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            btnSalir = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F);
            btnLogin.Location = new Point(50, 225);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(180, 43);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(50, 99);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(181, 29);
            txtEmail.TabIndex = 1;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 12F);
            txtPass.Location = new Point(50, 169);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(181, 29);
            txtPass.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(50, 75);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 3;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(50, 145);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(63, 31);
            label3.Name = "label3";
            label3.Size = new Size(156, 21);
            label3.TabIndex = 5;
            label3.Text = "Bienvenido a PetCare";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtPass);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(283, 323);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 12F);
            btnSalir.Location = new Point(50, 274);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(180, 43);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 353);
            Controls.Add(groupBox1);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += FrmLogin_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogin;
        private TextBox txtEmail;
        private TextBox txtPass;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private Button btnSalir;
    }
}