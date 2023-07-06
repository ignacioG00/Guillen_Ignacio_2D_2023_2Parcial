namespace Vista
{
    partial class Frm_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_autoVendedor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_usuario = new System.Windows.Forms.TextBox();
            this.tb_contra = new System.Windows.Forms.TextBox();
            this.btn_autoCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_login.Location = new System.Drawing.Point(457, 224);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(77, 49);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_autoVendedor
            // 
            this.btn_autoVendedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_autoVendedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_autoVendedor.Location = new System.Drawing.Point(12, 267);
            this.btn_autoVendedor.Name = "btn_autoVendedor";
            this.btn_autoVendedor.Size = new System.Drawing.Size(122, 40);
            this.btn_autoVendedor.TabIndex = 1;
            this.btn_autoVendedor.Text = "AUTO. VENDEDOR";
            this.btn_autoVendedor.UseVisualStyleBackColor = false;
            this.btn_autoVendedor.Click += new System.EventHandler(this.btn_autoVendedor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(62, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(271, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // tb_usuario
            // 
            this.tb_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tb_usuario.Location = new System.Drawing.Point(62, 238);
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.Size = new System.Drawing.Size(180, 23);
            this.tb_usuario.TabIndex = 4;
            // 
            // tb_contra
            // 
            this.tb_contra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tb_contra.Location = new System.Drawing.Point(271, 238);
            this.tb_contra.Name = "tb_contra";
            this.tb_contra.PasswordChar = '*';
            this.tb_contra.Size = new System.Drawing.Size(180, 23);
            this.tb_contra.TabIndex = 5;
            // 
            // btn_autoCliente
            // 
            this.btn_autoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_autoCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_autoCliente.Location = new System.Drawing.Point(140, 267);
            this.btn_autoCliente.Name = "btn_autoCliente";
            this.btn_autoCliente.Size = new System.Drawing.Size(122, 40);
            this.btn_autoCliente.TabIndex = 6;
            this.btn_autoCliente.Text = "AUTO. CLIENTE";
            this.btn_autoCliente.UseVisualStyleBackColor = false;
            this.btn_autoCliente.Click += new System.EventHandler(this.btn_autoCliente_Click);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(583, 330);
            this.Controls.Add(this.btn_autoCliente);
            this.Controls.Add(this.tb_contra);
            this.Controls.Add(this.tb_usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_autoVendedor);
            this.Controls.Add(this.btn_login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CARNICERIA";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_login;
        private Button btn_autoVendedor;
        private Label label1;
        private Label label2;
        private TextBox tb_usuario;
        private TextBox tb_contra;
        private Button btn_autoCliente;
    }
}