namespace Vista
{
    partial class Frm_Historial
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
            this.dgv_histFacturas = new System.Windows.Forms.DataGridView();
            this.venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.btn_GuardarFacturas = new System.Windows.Forms.Button();
            this.btn_verFacturas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_histFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_histFacturas
            // 
            this.dgv_histFacturas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgv_histFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_histFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.venta,
            this.cliente,
            this.productos,
            this.monto});
            this.dgv_histFacturas.Location = new System.Drawing.Point(136, 74);
            this.dgv_histFacturas.Name = "dgv_histFacturas";
            this.dgv_histFacturas.RowTemplate.Height = 25;
            this.dgv_histFacturas.Size = new System.Drawing.Size(617, 322);
            this.dgv_histFacturas.TabIndex = 0;
            // 
            // venta
            // 
            this.venta.HeaderText = "Venta";
            this.venta.Name = "venta";
            this.venta.ReadOnly = true;
            // 
            // cliente
            // 
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            // 
            // productos
            // 
            this.productos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productos.HeaderText = "productos";
            this.productos.Name = "productos";
            // 
            // monto
            // 
            this.monto.HeaderText = "Monto";
            this.monto.Name = "monto";
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lb_titulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_titulo.Location = new System.Drawing.Point(315, 9);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(251, 30);
            this.lb_titulo.TabIndex = 1;
            this.lb_titulo.Text = "HISTORIAL DE FACTURAS";
            // 
            // btn_GuardarFacturas
            // 
            this.btn_GuardarFacturas.Location = new System.Drawing.Point(389, 417);
            this.btn_GuardarFacturas.Name = "btn_GuardarFacturas";
            this.btn_GuardarFacturas.Size = new System.Drawing.Size(136, 43);
            this.btn_GuardarFacturas.TabIndex = 2;
            this.btn_GuardarFacturas.Text = "GUARDAR FACTURAS";
            this.btn_GuardarFacturas.UseVisualStyleBackColor = true;
            this.btn_GuardarFacturas.Click += new System.EventHandler(this.btn_GuardarFacturas_Click);
            // 
            // btn_verFacturas
            // 
            this.btn_verFacturas.Location = new System.Drawing.Point(164, 417);
            this.btn_verFacturas.Name = "btn_verFacturas";
            this.btn_verFacturas.Size = new System.Drawing.Size(195, 43);
            this.btn_verFacturas.TabIndex = 3;
            this.btn_verFacturas.Text = "VER FACTURAS ANTERIORES";
            this.btn_verFacturas.UseVisualStyleBackColor = true;
            this.btn_verFacturas.Click += new System.EventHandler(this.btn_verFacturas_Click);
            // 
            // Frm_Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(868, 498);
            this.Controls.Add(this.btn_verFacturas);
            this.Controls.Add(this.btn_GuardarFacturas);
            this.Controls.Add(this.lb_titulo);
            this.Controls.Add(this.dgv_histFacturas);
            this.Name = "Frm_Historial";
            this.Text = "HISTORIAL";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Historial_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_histFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_histFacturas;
        private Label lb_titulo;
        private DataGridViewTextBoxColumn venta;
        private DataGridViewTextBoxColumn cliente;
        private DataGridViewTextBoxColumn productos;
        private DataGridViewTextBoxColumn monto;
        private Button btn_GuardarFacturas;
        private Button btn_verFacturas;
        private Label label1;
        private TextBox tb_idfactura;
    }
}