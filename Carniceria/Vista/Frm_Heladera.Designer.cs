namespace Vista
{
    partial class Frm_Heladera
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
            this.lb_Titulo = new System.Windows.Forms.Label();
            this.dgv_listaCarnes = new System.Windows.Forms.DataGridView();
            this.corteCarne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_actualizarLista = new System.Windows.Forms.Button();
            this.btn_fijarPrecioxKilo = new System.Windows.Forms.Button();
            this.tb_fijarPrecio = new System.Windows.Forms.TextBox();
            this.cb_listaCarnes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_nuevoProducto = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.tb_precioxkilo = new System.Windows.Forms.TextBox();
            this.tb_nombreCorte = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_reponer = new System.Windows.Forms.Label();
            this.btn_reponerCarnes = new System.Windows.Forms.Button();
            this.tb_cantAReponer = new System.Windows.Forms.TextBox();
            this.lb_cantAReponer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaCarnes)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Titulo
            // 
            this.lb_Titulo.AutoSize = true;
            this.lb_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lb_Titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_Titulo.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Titulo.ForeColor = System.Drawing.Color.Black;
            this.lb_Titulo.Location = new System.Drawing.Point(216, 9);
            this.lb_Titulo.Name = "lb_Titulo";
            this.lb_Titulo.Size = new System.Drawing.Size(210, 48);
            this.lb_Titulo.TabIndex = 0;
            this.lb_Titulo.Text = "HELADERA";
            // 
            // dgv_listaCarnes
            // 
            this.dgv_listaCarnes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgv_listaCarnes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listaCarnes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.corteCarne,
            this.cantidad,
            this.precio});
            this.dgv_listaCarnes.Location = new System.Drawing.Point(28, 355);
            this.dgv_listaCarnes.Name = "dgv_listaCarnes";
            this.dgv_listaCarnes.RowTemplate.Height = 25;
            this.dgv_listaCarnes.Size = new System.Drawing.Size(369, 150);
            this.dgv_listaCarnes.TabIndex = 6;
            // 
            // corteCarne
            // 
            this.corteCarne.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.corteCarne.HeaderText = "Corte de Carne";
            this.corteCarne.Name = "corteCarne";
            this.corteCarne.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 80;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // btn_actualizarLista
            // 
            this.btn_actualizarLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_actualizarLista.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_actualizarLista.Location = new System.Drawing.Point(455, 450);
            this.btn_actualizarLista.Name = "btn_actualizarLista";
            this.btn_actualizarLista.Size = new System.Drawing.Size(129, 23);
            this.btn_actualizarLista.TabIndex = 22;
            this.btn_actualizarLista.Text = "ACTUALIZAR STOCK";
            this.btn_actualizarLista.UseVisualStyleBackColor = false;
            this.btn_actualizarLista.Click += new System.EventHandler(this.btn_actualizarLista_Click);
            // 
            // btn_fijarPrecioxKilo
            // 
            this.btn_fijarPrecioxKilo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_fijarPrecioxKilo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_fijarPrecioxKilo.Location = new System.Drawing.Point(216, 290);
            this.btn_fijarPrecioxKilo.Name = "btn_fijarPrecioxKilo";
            this.btn_fijarPrecioxKilo.Size = new System.Drawing.Size(163, 30);
            this.btn_fijarPrecioxKilo.TabIndex = 23;
            this.btn_fijarPrecioxKilo.Text = "FIJAR PRECIO POR KILO";
            this.btn_fijarPrecioxKilo.UseVisualStyleBackColor = false;
            this.btn_fijarPrecioxKilo.Click += new System.EventHandler(this.btn_fijarPrecioxKilo_Click);
            // 
            // tb_fijarPrecio
            // 
            this.tb_fijarPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tb_fijarPrecio.Location = new System.Drawing.Point(216, 257);
            this.tb_fijarPrecio.Name = "tb_fijarPrecio";
            this.tb_fijarPrecio.Size = new System.Drawing.Size(160, 23);
            this.tb_fijarPrecio.TabIndex = 24;
            this.tb_fijarPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_fijarPrecio_KeyPress);
            // 
            // cb_listaCarnes
            // 
            this.cb_listaCarnes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cb_listaCarnes.FormattingEnabled = true;
            this.cb_listaCarnes.Location = new System.Drawing.Point(150, 148);
            this.cb_listaCarnes.Name = "cb_listaCarnes";
            this.cb_listaCarnes.Size = new System.Drawing.Size(123, 23);
            this.cb_listaCarnes.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(216, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "FIJAR PRECIO X KILO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(150, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "LISTA DE CARNES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.RosyBrown;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(238, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 21);
            this.label4.TabIndex = 28;
            this.label4.Text = "Precio por kg:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(471, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 23);
            this.label5.TabIndex = 29;
            this.label5.Text = "AÑADIR CARNE";
            // 
            // btn_nuevoProducto
            // 
            this.btn_nuevoProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_nuevoProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_nuevoProducto.Location = new System.Drawing.Point(455, 364);
            this.btn_nuevoProducto.Name = "btn_nuevoProducto";
            this.btn_nuevoProducto.Size = new System.Drawing.Size(188, 30);
            this.btn_nuevoProducto.TabIndex = 31;
            this.btn_nuevoProducto.Text = "AÑADIR NUEVO PRODUCTO";
            this.btn_nuevoProducto.UseVisualStyleBackColor = false;
            this.btn_nuevoProducto.Click += new System.EventHandler(this.btn_nuevoProducto_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_salir.Location = new System.Drawing.Point(12, 12);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(89, 30);
            this.btn_salir.TabIndex = 33;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // tb_precioxkilo
            // 
            this.tb_precioxkilo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tb_precioxkilo.Location = new System.Drawing.Point(471, 335);
            this.tb_precioxkilo.Name = "tb_precioxkilo";
            this.tb_precioxkilo.Size = new System.Drawing.Size(160, 23);
            this.tb_precioxkilo.TabIndex = 34;
            this.tb_precioxkilo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_precioxkilo_KeyPress);
            // 
            // tb_nombreCorte
            // 
            this.tb_nombreCorte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tb_nombreCorte.Location = new System.Drawing.Point(471, 263);
            this.tb_nombreCorte.Name = "tb_nombreCorte";
            this.tb_nombreCorte.Size = new System.Drawing.Size(160, 23);
            this.tb_nombreCorte.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.RosyBrown;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(471, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 21);
            this.label6.TabIndex = 37;
            this.label6.Text = "Nombre de corte :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.RosyBrown;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(471, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 21);
            this.label8.TabIndex = 39;
            this.label8.Text = "Precio por kilo :";
            // 
            // lb_reponer
            // 
            this.lb_reponer.AutoSize = true;
            this.lb_reponer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lb_reponer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_reponer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_reponer.ForeColor = System.Drawing.Color.Black;
            this.lb_reponer.Location = new System.Drawing.Point(42, 191);
            this.lb_reponer.Name = "lb_reponer";
            this.lb_reponer.Size = new System.Drawing.Size(145, 23);
            this.lb_reponer.TabIndex = 7;
            this.lb_reponer.Text = "REPONER CARNES";
            // 
            // btn_reponerCarnes
            // 
            this.btn_reponerCarnes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_reponerCarnes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_reponerCarnes.Location = new System.Drawing.Point(42, 292);
            this.btn_reponerCarnes.Name = "btn_reponerCarnes";
            this.btn_reponerCarnes.Size = new System.Drawing.Size(145, 30);
            this.btn_reponerCarnes.TabIndex = 40;
            this.btn_reponerCarnes.Text = "REPONER CARNE";
            this.btn_reponerCarnes.UseVisualStyleBackColor = false;
            this.btn_reponerCarnes.Click += new System.EventHandler(this.btn_reponerCarnes_Click);
            // 
            // tb_cantAReponer
            // 
            this.tb_cantAReponer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tb_cantAReponer.Location = new System.Drawing.Point(57, 257);
            this.tb_cantAReponer.Name = "tb_cantAReponer";
            this.tb_cantAReponer.Size = new System.Drawing.Size(122, 23);
            this.tb_cantAReponer.TabIndex = 41;
            this.tb_cantAReponer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cantAReponer_KeyPress);
            // 
            // lb_cantAReponer
            // 
            this.lb_cantAReponer.AutoSize = true;
            this.lb_cantAReponer.BackColor = System.Drawing.Color.RosyBrown;
            this.lb_cantAReponer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_cantAReponer.ForeColor = System.Drawing.Color.Black;
            this.lb_cantAReponer.Location = new System.Drawing.Point(57, 233);
            this.lb_cantAReponer.Name = "lb_cantAReponer";
            this.lb_cantAReponer.Size = new System.Drawing.Size(130, 21);
            this.lb_cantAReponer.TabIndex = 42;
            this.lb_cantAReponer.Text = "Cant. a reponer :";
            // 
            // Frm_Heladera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.carniceria;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(722, 517);
            this.ControlBox = false;
            this.Controls.Add(this.tb_cantAReponer);
            this.Controls.Add(this.lb_cantAReponer);
            this.Controls.Add(this.btn_reponerCarnes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_fijarPrecioxKilo);
            this.Controls.Add(this.tb_fijarPrecio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_listaCarnes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_nombreCorte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_precioxkilo);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_nuevoProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_actualizarLista);
            this.Controls.Add(this.lb_reponer);
            this.Controls.Add(this.dgv_listaCarnes);
            this.Controls.Add(this.lb_Titulo);
            this.MaximizeBox = false;
            this.Name = "Frm_Heladera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HELADERA";
            this.Load += new System.EventHandler(this.Frm_Heladera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaCarnes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btn_asado;
        private Button btn_choripan;
        private DataGridView dgv_listaCarnes;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn corteCarne;
        private DataGridViewTextBoxColumn precio;
        private Label lb_Titulo;
        private Button btn_actualizarLista;
        private Button btn_fijarPrecioxKilo;
        private TextBox tb_fijarPrecio;
        private ComboBox cb_listaCarnes;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_nuevoProducto;
        private Button btn_salir;
        private TextBox tb_precioxkilo;
        private TextBox tb_nombreCorte;
        private Label label6;
        private Label label8;
        private Label lb_reponer;
        private Button btn_reponerCarnes;
        private TextBox tb_cantAReponer;
        private Label lb_cantAReponer;
    }
}