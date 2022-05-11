namespace VentaForm
{
    partial class VentanaPrincipal
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
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.mS = new System.Windows.Forms.MenuStrip();
            this.MiArchivos = new System.Windows.Forms.ToolStripMenuItem();
            this.mSAImpDescuento = new System.Windows.Forms.ToolStripMenuItem();
            this.MiImpVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.TBImpVenta = new System.Windows.Forms.ToolStripTextBox();
            this.MiDescuento = new System.Windows.Forms.ToolStripMenuItem();
            this.TBDescuento = new System.Windows.Forms.ToolStripTextBox();
            this.MiUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.MiInventario = new System.Windows.Forms.ToolStripMenuItem();
            this.MiClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MiReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.PBLogo = new System.Windows.Forms.PictureBox();
            this.DtgFacturacion = new System.Windows.Forms.DataGridView();
            this.BtnAgregarProducto = new System.Windows.Forms.Button();
            this.TBCodigoProducto = new System.Windows.Forms.TextBox();
            this.LbCodigoProducto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBDescuentoRead = new System.Windows.Forms.TextBox();
            this.BtnFacturar = new System.Windows.Forms.Button();
            this.TBCantidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TBImpVentaRead = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TBNumFact = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.mS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgFacturacion)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(683, 373);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(90, 29);
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // mS
            // 
            this.mS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MiArchivos,
            this.MiUsuarios,
            this.MiInventario,
            this.MiClientes,
            this.MiReportes});
            this.mS.Location = new System.Drawing.Point(0, 0);
            this.mS.Name = "mS";
            this.mS.Size = new System.Drawing.Size(785, 24);
            this.mS.TabIndex = 1;
            this.mS.Text = "Menu";
            // 
            // MiArchivos
            // 
            this.MiArchivos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mSAImpDescuento});
            this.MiArchivos.Name = "MiArchivos";
            this.MiArchivos.Size = new System.Drawing.Size(65, 20);
            this.MiArchivos.Text = "Archivos";
            // 
            // mSAImpDescuento
            // 
            this.mSAImpDescuento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MiImpVenta,
            this.MiDescuento});
            this.mSAImpDescuento.Name = "mSAImpDescuento";
            this.mSAImpDescuento.Size = new System.Drawing.Size(195, 22);
            this.mSAImpDescuento.Text = "Imp venta y Descuento";
            // 
            // MiImpVenta
            // 
            this.MiImpVenta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TBImpVenta});
            this.MiImpVenta.Name = "MiImpVenta";
            this.MiImpVenta.Size = new System.Drawing.Size(130, 22);
            this.MiImpVenta.Text = "imp Venta";
            // 
            // TBImpVenta
            // 
            this.TBImpVenta.Name = "TBImpVenta";
            this.TBImpVenta.Size = new System.Drawing.Size(110, 23);
            this.TBImpVenta.Text = "0";
            this.TBImpVenta.TextChanged += new System.EventHandler(this.TBImpVenta_TextChanged);
            // 
            // MiDescuento
            // 
            this.MiDescuento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TBDescuento});
            this.MiDescuento.Name = "MiDescuento";
            this.MiDescuento.Size = new System.Drawing.Size(130, 22);
            this.MiDescuento.Text = "Descuento";
            // 
            // TBDescuento
            // 
            this.TBDescuento.Name = "TBDescuento";
            this.TBDescuento.Size = new System.Drawing.Size(100, 23);
            this.TBDescuento.Text = "0";
            this.TBDescuento.TextChanged += new System.EventHandler(this.TBDescuento_TextChanged);
            // 
            // MiUsuarios
            // 
            this.MiUsuarios.Name = "MiUsuarios";
            this.MiUsuarios.Size = new System.Drawing.Size(64, 20);
            this.MiUsuarios.Text = "Usuarios";
            this.MiUsuarios.Click += new System.EventHandler(this.MiUsuarios_Click);
            // 
            // MiInventario
            // 
            this.MiInventario.Name = "MiInventario";
            this.MiInventario.Size = new System.Drawing.Size(72, 20);
            this.MiInventario.Text = "Inventario";
            this.MiInventario.Click += new System.EventHandler(this.MiInventario_Click);
            // 
            // MiClientes
            // 
            this.MiClientes.Name = "MiClientes";
            this.MiClientes.Size = new System.Drawing.Size(61, 20);
            this.MiClientes.Text = "Clientes";
            // 
            // MiReportes
            // 
            this.MiReportes.Name = "MiReportes";
            this.MiReportes.Size = new System.Drawing.Size(65, 20);
            this.MiReportes.Text = "Reportes";
            // 
            // PBLogo
            // 
            this.PBLogo.Image = global::Presentacion.Properties.Resources.pngegg;
            this.PBLogo.Location = new System.Drawing.Point(12, 27);
            this.PBLogo.Name = "PBLogo";
            this.PBLogo.Size = new System.Drawing.Size(114, 112);
            this.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBLogo.TabIndex = 0;
            this.PBLogo.TabStop = false;
            // 
            // DtgFacturacion
            // 
            this.DtgFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgFacturacion.Location = new System.Drawing.Point(132, 56);
            this.DtgFacturacion.Name = "DtgFacturacion";
            this.DtgFacturacion.RowTemplate.Height = 25;
            this.DtgFacturacion.Size = new System.Drawing.Size(641, 182);
            this.DtgFacturacion.TabIndex = 2;
            // 
            // BtnAgregarProducto
            // 
            this.BtnAgregarProducto.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAgregarProducto.Location = new System.Drawing.Point(400, 288);
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(235, 45);
            this.BtnAgregarProducto.TabIndex = 3;
            this.BtnAgregarProducto.Text = "Agregar Producto";
            this.BtnAgregarProducto.UseVisualStyleBackColor = true;
            this.BtnAgregarProducto.Click += new System.EventHandler(this.BtnAgregarProducto_Click);
            // 
            // TBCodigoProducto
            // 
            this.TBCodigoProducto.Location = new System.Drawing.Point(400, 259);
            this.TBCodigoProducto.Name = "TBCodigoProducto";
            this.TBCodigoProducto.Size = new System.Drawing.Size(114, 23);
            this.TBCodigoProducto.TabIndex = 4;
            // 
            // LbCodigoProducto
            // 
            this.LbCodigoProducto.AutoSize = true;
            this.LbCodigoProducto.Location = new System.Drawing.Point(400, 241);
            this.LbCodigoProducto.Name = "LbCodigoProducto";
            this.LbCodigoProducto.Size = new System.Drawing.Size(114, 15);
            this.LbCodigoProducto.TabIndex = 5;
            this.LbCodigoProducto.Text = "Codigo de Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(132, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sub Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(132, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(253, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(253, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 54);
            this.label4.TabIndex = 9;
            this.label4.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Descuento";
            // 
            // TBDescuentoRead
            // 
            this.TBDescuentoRead.Location = new System.Drawing.Point(319, 288);
            this.TBDescuentoRead.Name = "TBDescuentoRead";
            this.TBDescuentoRead.ReadOnly = true;
            this.TBDescuentoRead.Size = new System.Drawing.Size(59, 23);
            this.TBDescuentoRead.TabIndex = 11;
            // 
            // BtnFacturar
            // 
            this.BtnFacturar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnFacturar.Location = new System.Drawing.Point(658, 259);
            this.BtnFacturar.Name = "BtnFacturar";
            this.BtnFacturar.Size = new System.Drawing.Size(115, 74);
            this.BtnFacturar.TabIndex = 12;
            this.BtnFacturar.Text = "Facturar";
            this.BtnFacturar.UseVisualStyleBackColor = true;
            // 
            // TBCantidad
            // 
            this.TBCantidad.Location = new System.Drawing.Point(520, 259);
            this.TBCantidad.Name = "TBCantidad";
            this.TBCantidad.Size = new System.Drawing.Size(115, 23);
            this.TBCantidad.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(520, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cantidad";
            // 
            // TBImpVentaRead
            // 
            this.TBImpVentaRead.Location = new System.Drawing.Point(319, 259);
            this.TBImpVentaRead.Name = "TBImpVentaRead";
            this.TBImpVentaRead.ReadOnly = true;
            this.TBImpVentaRead.Size = new System.Drawing.Size(59, 23);
            this.TBImpVentaRead.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Imp Venta";
            // 
            // TBNumFact
            // 
            this.TBNumFact.Location = new System.Drawing.Point(201, 27);
            this.TBNumFact.Name = "TBNumFact";
            this.TBNumFact.ReadOnly = true;
            this.TBNumFact.Size = new System.Drawing.Size(115, 23);
            this.TBNumFact.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(132, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "N* Factura";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 164);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(114, 23);
            this.textBox5.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Codigo Cliente";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(417, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Cliente";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(467, 27);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(306, 23);
            this.textBox6.TabIndex = 23;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 414);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TBNumFact);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TBImpVentaRead);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TBCantidad);
            this.Controls.Add(this.BtnFacturar);
            this.Controls.Add(this.TBDescuentoRead);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbCodigoProducto);
            this.Controls.Add(this.TBCodigoProducto);
            this.Controls.Add(this.BtnAgregarProducto);
            this.Controls.Add(this.DtgFacturacion);
            this.Controls.Add(this.PBLogo);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.mS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mS;
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaPrincipal";
            this.mS.ResumeLayout(false);
            this.mS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgFacturacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private Button BtnCerrar;
        private MenuStrip mS;
        private ToolStripMenuItem MiArchivos;
        private ToolStripMenuItem mSAImpDescuento;
        private ToolStripMenuItem MiUsuarios;
        private PictureBox PBLogo;
        private ToolStripMenuItem MiInventario;
        private ToolStripMenuItem MiClientes;
        private ToolStripMenuItem MiReportes;
        private DataGridView DtgFacturacion;
        private Button BtnAgregarProducto;
        private TextBox TBCodigoProducto;
        private Label LbCodigoProducto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TBDescuentoRead;
        private Button BtnFacturar;
        private TextBox TBCantidad;
        private Label label6;
        private TextBox TBImpVentaRead;
        private Label label7;
        private TextBox TBNumFact;
        private Label label8;
        private Button button1;
        private TextBox textBox5;
        private Label label9;
        private Label label10;
        private TextBox textBox6;
        private ToolStripMenuItem MiImpVenta;
        private ToolStripMenuItem MiDescuento;
        private ToolStripTextBox TBImpVenta;
        private ToolStripTextBox TBDescuento;
    }
}