namespace Vista
{
    partial class Frm_Compra
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_agregarCarnes = new System.Windows.Forms.Label();
            this.dgv_listaCarnes = new System.Windows.Forms.DataGridView();
            this.corteCarne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_kg = new System.Windows.Forms.TextBox();
            this.rtb_cuenta = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clb_carnes = new System.Windows.Forms.CheckedListBox();
            this.lb_total = new System.Windows.Forms.Label();
            this.btn_anotarPedido = new System.Windows.Forms.Button();
            this.btn_anularCompra = new System.Windows.Forms.Button();
            this.cb_listaClientes = new System.Windows.Forms.ComboBox();
            this.lb_venderA = new System.Windows.Forms.Label();
            this.btn_realizarPago = new System.Windows.Forms.Button();
            this.btn_actualizarLista = new System.Windows.Forms.Button();
            this.cb_tipoPago = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_montoMax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_historial = new System.Windows.Forms.Button();
            this.btn_limpiarRtb = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_serializar = new System.Windows.Forms.Button();
            this.btn_deserializar = new System.Windows.Forms.Button();
            this.lb_reloj = new System.Windows.Forms.Label();
            this.btn_serialJson = new System.Windows.Forms.Button();
            this.btn_deserialJson = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mensajeLabel = new System.Windows.Forms.Label();
            this.lb_cartel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaCarnes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(222, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "FACTURACION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_agregarCarnes
            // 
            this.lb_agregarCarnes.AutoSize = true;
            this.lb_agregarCarnes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lb_agregarCarnes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lb_agregarCarnes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_agregarCarnes.Location = new System.Drawing.Point(87, 57);
            this.lb_agregarCarnes.Name = "lb_agregarCarnes";
            this.lb_agregarCarnes.Size = new System.Drawing.Size(84, 15);
            this.lb_agregarCarnes.TabIndex = 14;
            this.lb_agregarCarnes.Text = "ELEGIR CARNE";
            // 
            // dgv_listaCarnes
            // 
            this.dgv_listaCarnes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgv_listaCarnes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listaCarnes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.corteCarne,
            this.cantidad,
            this.precio});
            this.dgv_listaCarnes.Location = new System.Drawing.Point(12, 288);
            this.dgv_listaCarnes.Name = "dgv_listaCarnes";
            this.dgv_listaCarnes.ReadOnly = true;
            this.dgv_listaCarnes.RowTemplate.Height = 25;
            this.dgv_listaCarnes.Size = new System.Drawing.Size(369, 150);
            this.dgv_listaCarnes.TabIndex = 13;
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
            // tb_kg
            // 
            this.tb_kg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tb_kg.Location = new System.Drawing.Point(75, 202);
            this.tb_kg.Name = "tb_kg";
            this.tb_kg.Size = new System.Drawing.Size(131, 23);
            this.tb_kg.TabIndex = 15;
            this.tb_kg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_kg_KeyPress);
            // 
            // rtb_cuenta
            // 
            this.rtb_cuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.rtb_cuenta.Location = new System.Drawing.Point(496, 64);
            this.rtb_cuenta.Name = "rtb_cuenta";
            this.rtb_cuenta.ReadOnly = true;
            this.rtb_cuenta.Size = new System.Drawing.Size(202, 300);
            this.rtb_cuenta.TabIndex = 16;
            this.rtb_cuenta.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(75, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cantidad (kg/gr) :";
            // 
            // clb_carnes
            // 
            this.clb_carnes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.clb_carnes.FormattingEnabled = true;
            this.clb_carnes.Location = new System.Drawing.Point(87, 75);
            this.clb_carnes.Name = "clb_carnes";
            this.clb_carnes.Size = new System.Drawing.Size(120, 94);
            this.clb_carnes.TabIndex = 18;
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lb_total.Location = new System.Drawing.Point(496, 46);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(41, 15);
            this.lb_total.TabIndex = 19;
            this.lb_total.Text = "Total : ";
            // 
            // btn_anotarPedido
            // 
            this.btn_anotarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_anotarPedido.Location = new System.Drawing.Point(513, 370);
            this.btn_anotarPedido.Name = "btn_anotarPedido";
            this.btn_anotarPedido.Size = new System.Drawing.Size(120, 23);
            this.btn_anotarPedido.TabIndex = 20;
            this.btn_anotarPedido.Text = "AGREGAR PEDIDO";
            this.btn_anotarPedido.UseVisualStyleBackColor = false;
            this.btn_anotarPedido.Click += new System.EventHandler(this.btn_anotarPedido_Click);
            // 
            // btn_anularCompra
            // 
            this.btn_anularCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_anularCompra.Location = new System.Drawing.Point(387, 370);
            this.btn_anularCompra.Name = "btn_anularCompra";
            this.btn_anularCompra.Size = new System.Drawing.Size(120, 23);
            this.btn_anularCompra.TabIndex = 21;
            this.btn_anularCompra.Text = "ANULAR COMPRA";
            this.btn_anularCompra.UseVisualStyleBackColor = false;
            this.btn_anularCompra.Click += new System.EventHandler(this.btn_anularCompra_Click);
            // 
            // cb_listaClientes
            // 
            this.cb_listaClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cb_listaClientes.FormattingEnabled = true;
            this.cb_listaClientes.Location = new System.Drawing.Point(260, 75);
            this.cb_listaClientes.Name = "cb_listaClientes";
            this.cb_listaClientes.Size = new System.Drawing.Size(121, 23);
            this.cb_listaClientes.TabIndex = 22;
            // 
            // lb_venderA
            // 
            this.lb_venderA.AutoSize = true;
            this.lb_venderA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lb_venderA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lb_venderA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_venderA.Location = new System.Drawing.Point(260, 57);
            this.lb_venderA.Name = "lb_venderA";
            this.lb_venderA.Size = new System.Drawing.Size(58, 15);
            this.lb_venderA.TabIndex = 23;
            this.lb_venderA.Text = "Vender a :";
            // 
            // btn_realizarPago
            // 
            this.btn_realizarPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_realizarPago.Location = new System.Drawing.Point(639, 370);
            this.btn_realizarPago.Name = "btn_realizarPago";
            this.btn_realizarPago.Size = new System.Drawing.Size(120, 23);
            this.btn_realizarPago.TabIndex = 24;
            this.btn_realizarPago.Text = "REALIZAR PAGO";
            this.btn_realizarPago.UseVisualStyleBackColor = false;
            this.btn_realizarPago.Click += new System.EventHandler(this.btn_realizarPago_Click);
            // 
            // btn_actualizarLista
            // 
            this.btn_actualizarLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_actualizarLista.Location = new System.Drawing.Point(12, 259);
            this.btn_actualizarLista.Name = "btn_actualizarLista";
            this.btn_actualizarLista.Size = new System.Drawing.Size(129, 23);
            this.btn_actualizarLista.TabIndex = 25;
            this.btn_actualizarLista.Text = "ACTUALIZAR STOCK";
            this.btn_actualizarLista.UseVisualStyleBackColor = false;
            this.btn_actualizarLista.Click += new System.EventHandler(this.btn_actualizarLista_Click);
            // 
            // cb_tipoPago
            // 
            this.cb_tipoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cb_tipoPago.FormattingEnabled = true;
            this.cb_tipoPago.Location = new System.Drawing.Point(260, 146);
            this.cb_tipoPago.Name = "cb_tipoPago";
            this.cb_tipoPago.Size = new System.Drawing.Size(121, 23);
            this.cb_tipoPago.TabIndex = 26;
            this.cb_tipoPago.SelectedIndexChanged += new System.EventHandler(this.cb_tipoPago_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(260, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Metodo de pago :";
            // 
            // tb_montoMax
            // 
            this.tb_montoMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tb_montoMax.Location = new System.Drawing.Point(260, 202);
            this.tb_montoMax.Name = "tb_montoMax";
            this.tb_montoMax.Size = new System.Drawing.Size(121, 23);
            this.tb_montoMax.TabIndex = 28;
            this.tb_montoMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_montoMax_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(260, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Monto maximo :";
            // 
            // btn_historial
            // 
            this.btn_historial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_historial.Location = new System.Drawing.Point(461, 415);
            this.btn_historial.Name = "btn_historial";
            this.btn_historial.Size = new System.Drawing.Size(197, 23);
            this.btn_historial.TabIndex = 30;
            this.btn_historial.Text = "VER HISTORIAL DE FACTURAS";
            this.btn_historial.UseVisualStyleBackColor = false;
            this.btn_historial.Click += new System.EventHandler(this.btn_historial_Click);
            // 
            // btn_limpiarRtb
            // 
            this.btn_limpiarRtb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_limpiarRtb.Location = new System.Drawing.Point(598, 24);
            this.btn_limpiarRtb.Name = "btn_limpiarRtb";
            this.btn_limpiarRtb.Size = new System.Drawing.Size(100, 23);
            this.btn_limpiarRtb.TabIndex = 31;
            this.btn_limpiarRtb.Text = "Limpiar Panel";
            this.btn_limpiarRtb.UseVisualStyleBackColor = false;
            this.btn_limpiarRtb.Click += new System.EventHandler(this.btn_limpiarRtb_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_salir.Location = new System.Drawing.Point(12, 9);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(63, 23);
            this.btn_salir.TabIndex = 32;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_serializar
            // 
            this.btn_serializar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_serializar.Location = new System.Drawing.Point(796, 128);
            this.btn_serializar.Name = "btn_serializar";
            this.btn_serializar.Size = new System.Drawing.Size(97, 37);
            this.btn_serializar.TabIndex = 33;
            this.btn_serializar.Text = "SERIALIZAR";
            this.btn_serializar.UseVisualStyleBackColor = false;
            this.btn_serializar.Click += new System.EventHandler(this.btn_serializar_Click);
            // 
            // btn_deserializar
            // 
            this.btn_deserializar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_deserializar.Location = new System.Drawing.Point(949, 128);
            this.btn_deserializar.Name = "btn_deserializar";
            this.btn_deserializar.Size = new System.Drawing.Size(97, 37);
            this.btn_deserializar.TabIndex = 34;
            this.btn_deserializar.Text = "DESERIALIZAR";
            this.btn_deserializar.UseVisualStyleBackColor = false;
            this.btn_deserializar.Click += new System.EventHandler(this.btn_deserializar_Click);
            // 
            // lb_reloj
            // 
            this.lb_reloj.AutoSize = true;
            this.lb_reloj.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lb_reloj.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_reloj.ForeColor = System.Drawing.Color.Black;
            this.lb_reloj.Location = new System.Drawing.Point(731, 10);
            this.lb_reloj.Name = "lb_reloj";
            this.lb_reloj.Size = new System.Drawing.Size(0, 37);
            this.lb_reloj.TabIndex = 35;
            // 
            // btn_serialJson
            // 
            this.btn_serialJson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_serialJson.Location = new System.Drawing.Point(796, 225);
            this.btn_serialJson.Name = "btn_serialJson";
            this.btn_serialJson.Size = new System.Drawing.Size(97, 37);
            this.btn_serialJson.TabIndex = 36;
            this.btn_serialJson.Text = "SERIALIZAR";
            this.btn_serialJson.UseVisualStyleBackColor = false;
            this.btn_serialJson.Click += new System.EventHandler(this.btn_serialJson_Click);
            // 
            // btn_deserialJson
            // 
            this.btn_deserialJson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_deserialJson.Location = new System.Drawing.Point(949, 225);
            this.btn_deserialJson.Name = "btn_deserialJson";
            this.btn_deserialJson.Size = new System.Drawing.Size(97, 37);
            this.btn_deserialJson.TabIndex = 37;
            this.btn_deserialJson.Text = "DESERIALIZAR";
            this.btn_deserialJson.UseVisualStyleBackColor = false;
            this.btn_deserialJson.Click += new System.EventHandler(this.btn_deserialJson_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(840, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 15);
            this.label3.TabIndex = 38;
            this.label3.Text = "SERIALIZAR PRODUCTOS EN XML";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(840, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 15);
            this.label6.TabIndex = 39;
            this.label6.Text = "SERIALIZAR PRODUCTOS EN JSON";
            // 
            // mensajeLabel
            // 
            this.mensajeLabel.AutoSize = true;
            this.mensajeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mensajeLabel.ForeColor = System.Drawing.Color.Red;
            this.mensajeLabel.Location = new System.Drawing.Point(52, 453);
            this.mensajeLabel.Name = "mensajeLabel";
            this.mensajeLabel.Size = new System.Drawing.Size(0, 21);
            this.mensajeLabel.TabIndex = 40;
            // 
            // lb_cartel
            // 
            this.lb_cartel.AutoSize = true;
            this.lb_cartel.BackColor = System.Drawing.Color.DarkOrange;
            this.lb_cartel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_cartel.ForeColor = System.Drawing.Color.Black;
            this.lb_cartel.Location = new System.Drawing.Point(929, 21);
            this.lb_cartel.Name = "lb_cartel";
            this.lb_cartel.Size = new System.Drawing.Size(52, 21);
            this.lb_cartel.TabIndex = 41;
            this.lb_cartel.Text = "label7";
            this.lb_cartel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Frm_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 607);
            this.ControlBox = false;
            this.Controls.Add(this.lb_cartel);
            this.Controls.Add(this.mensajeLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_deserialJson);
            this.Controls.Add(this.btn_serialJson);
            this.Controls.Add(this.lb_reloj);
            this.Controls.Add(this.btn_deserializar);
            this.Controls.Add(this.btn_serializar);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_limpiarRtb);
            this.Controls.Add(this.btn_historial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_montoMax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_tipoPago);
            this.Controls.Add(this.btn_actualizarLista);
            this.Controls.Add(this.btn_realizarPago);
            this.Controls.Add(this.lb_venderA);
            this.Controls.Add(this.cb_listaClientes);
            this.Controls.Add(this.btn_anularCompra);
            this.Controls.Add(this.btn_anotarPedido);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.clb_carnes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtb_cuenta);
            this.Controls.Add(this.tb_kg);
            this.Controls.Add(this.lb_agregarCarnes);
            this.Controls.Add(this.dgv_listaCarnes);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Compra";
            this.Text = "VENTAS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Compra_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Compra_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Compra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaCarnes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label lb_agregarCarnes;
        public DataGridView dgv_listaCarnes;
        private DataGridViewTextBoxColumn corteCarne;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn precio;
        private TextBox tb_kg;
        private RichTextBox rtb_cuenta;
        private Label label2;
        private CheckedListBox clb_carnes;
        private Button btn_anotarPedido;
        private Button btn_anularCompra;
        private Label lb_total;
        public ComboBox cb_listaClientes;
        public Label lb_venderA;
        private Button btn_realizarPago;
        private Button btn_actualizarLista;
        private ComboBox cb_tipoPago;
        private Label label4;
        private TextBox tb_montoMax;
        private Label label5;
        public Button btn_historial;
        private Button btn_limpiarRtb;
        private Button btn_salir;
        private Button btn_serializar;
        private Button btn_deserializar;
        private Label lb_reloj;
        private Button btn_serialJson;
        private Button btn_deserialJson;
        private Label label3;
        private Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lb_pocoStock;
        private Label mensajeLabel;
        private Label lb_cartel;
    }
}