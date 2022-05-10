namespace Presentacion
{
    partial class FormInventory
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
            this.PBLogo = new System.Windows.Forms.PictureBox();
            this.DGInventory = new System.Windows.Forms.DataGridView();
            this.TBProducto = new System.Windows.Forms.TextBox();
            this.TBCategoria = new System.Windows.Forms.TextBox();
            this.TBPrecio = new System.Windows.Forms.TextBox();
            this.TBCantidad = new System.Windows.Forms.TextBox();
            this.LbProducto = new System.Windows.Forms.Label();
            this.LBCategoria = new System.Windows.Forms.Label();
            this.LBPrecio = new System.Windows.Forms.Label();
            this.Cantidad = new System.Windows.Forms.Label();
            this.LbId = new System.Windows.Forms.Label();
            this.TBId = new System.Windows.Forms.TextBox();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.BtnElminarProduct = new System.Windows.Forms.Button();
            this.BtnActualizarProduct = new System.Windows.Forms.Button();
            this.BtnNuevoProduct = new System.Windows.Forms.Button();
            this.BtnBuscarId = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // PBLogo
            // 
            this.PBLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PBLogo.Image = global::Presentacion.Properties.Resources.pngegg;
            this.PBLogo.Location = new System.Drawing.Point(12, 12);
            this.PBLogo.Name = "PBLogo";
            this.PBLogo.Size = new System.Drawing.Size(95, 111);
            this.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBLogo.TabIndex = 3;
            this.PBLogo.TabStop = false;
            // 
            // DGInventory
            // 
            this.DGInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DGInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGInventory.Location = new System.Drawing.Point(255, 12);
            this.DGInventory.Name = "DGInventory";
            this.DGInventory.RowTemplate.Height = 25;
            this.DGInventory.Size = new System.Drawing.Size(470, 222);
            this.DGInventory.TabIndex = 4;
            // 
            // TBProducto
            // 
            this.TBProducto.Location = new System.Drawing.Point(113, 30);
            this.TBProducto.Name = "TBProducto";
            this.TBProducto.Size = new System.Drawing.Size(136, 23);
            this.TBProducto.TabIndex = 5;
            // 
            // TBCategoria
            // 
            this.TBCategoria.Location = new System.Drawing.Point(113, 74);
            this.TBCategoria.Name = "TBCategoria";
            this.TBCategoria.Size = new System.Drawing.Size(136, 23);
            this.TBCategoria.TabIndex = 6;
            // 
            // TBPrecio
            // 
            this.TBPrecio.Location = new System.Drawing.Point(113, 118);
            this.TBPrecio.Name = "TBPrecio";
            this.TBPrecio.Size = new System.Drawing.Size(136, 23);
            this.TBPrecio.TabIndex = 7;
            // 
            // TBCantidad
            // 
            this.TBCantidad.Location = new System.Drawing.Point(113, 162);
            this.TBCantidad.Name = "TBCantidad";
            this.TBCantidad.Size = new System.Drawing.Size(136, 23);
            this.TBCantidad.TabIndex = 8;
            // 
            // LbProducto
            // 
            this.LbProducto.AutoSize = true;
            this.LbProducto.Location = new System.Drawing.Point(113, 12);
            this.LbProducto.Name = "LbProducto";
            this.LbProducto.Size = new System.Drawing.Size(56, 15);
            this.LbProducto.TabIndex = 9;
            this.LbProducto.Text = "Producto";
            // 
            // LBCategoria
            // 
            this.LBCategoria.AutoSize = true;
            this.LBCategoria.Location = new System.Drawing.Point(113, 56);
            this.LBCategoria.Name = "LBCategoria";
            this.LBCategoria.Size = new System.Drawing.Size(58, 15);
            this.LBCategoria.TabIndex = 10;
            this.LBCategoria.Text = "Categoria";
            // 
            // LBPrecio
            // 
            this.LBPrecio.AutoSize = true;
            this.LBPrecio.Location = new System.Drawing.Point(113, 100);
            this.LBPrecio.Name = "LBPrecio";
            this.LBPrecio.Size = new System.Drawing.Size(40, 15);
            this.LBPrecio.TabIndex = 11;
            this.LBPrecio.Text = "Precio";
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSize = true;
            this.Cantidad.Location = new System.Drawing.Point(113, 144);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(55, 15);
            this.Cantidad.TabIndex = 12;
            this.Cantidad.Text = "Cantidad";
            // 
            // LbId
            // 
            this.LbId.AutoSize = true;
            this.LbId.Location = new System.Drawing.Point(12, 304);
            this.LbId.Name = "LbId";
            this.LbId.Size = new System.Drawing.Size(18, 15);
            this.LbId.TabIndex = 13;
            this.LbId.Text = "ID";
            // 
            // TBId
            // 
            this.TBId.Location = new System.Drawing.Point(12, 322);
            this.TBId.Name = "TBId";
            this.TBId.Size = new System.Drawing.Size(136, 23);
            this.TBId.TabIndex = 14;
            // 
            // BtnVolver
            // 
            this.BtnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnVolver.Location = new System.Drawing.Point(631, 311);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(94, 43);
            this.BtnVolver.TabIndex = 15;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // BtnElminarProduct
            // 
            this.BtnElminarProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnElminarProduct.Location = new System.Drawing.Point(515, 311);
            this.BtnElminarProduct.Name = "BtnElminarProduct";
            this.BtnElminarProduct.Size = new System.Drawing.Size(110, 43);
            this.BtnElminarProduct.TabIndex = 16;
            this.BtnElminarProduct.Text = "Eliminar Producto";
            this.BtnElminarProduct.UseVisualStyleBackColor = true;
            this.BtnElminarProduct.Click += new System.EventHandler(this.BtnElminarProduct_Click);
            // 
            // BtnActualizarProduct
            // 
            this.BtnActualizarProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnActualizarProduct.Location = new System.Drawing.Point(399, 311);
            this.BtnActualizarProduct.Name = "BtnActualizarProduct";
            this.BtnActualizarProduct.Size = new System.Drawing.Size(110, 43);
            this.BtnActualizarProduct.TabIndex = 17;
            this.BtnActualizarProduct.Text = "Actualizar Producto";
            this.BtnActualizarProduct.UseVisualStyleBackColor = true;
            this.BtnActualizarProduct.Click += new System.EventHandler(this.BtnActualizarProduct_Click);
            // 
            // BtnNuevoProduct
            // 
            this.BtnNuevoProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNuevoProduct.Location = new System.Drawing.Point(299, 311);
            this.BtnNuevoProduct.Name = "BtnNuevoProduct";
            this.BtnNuevoProduct.Size = new System.Drawing.Size(94, 43);
            this.BtnNuevoProduct.TabIndex = 18;
            this.BtnNuevoProduct.Text = "Nuevo Producto";
            this.BtnNuevoProduct.UseVisualStyleBackColor = true;
            this.BtnNuevoProduct.Click += new System.EventHandler(this.BtnNuevoProduct_Click);
            // 
            // BtnBuscarId
            // 
            this.BtnBuscarId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnBuscarId.Location = new System.Drawing.Point(154, 314);
            this.BtnBuscarId.Name = "BtnBuscarId";
            this.BtnBuscarId.Size = new System.Drawing.Size(95, 37);
            this.BtnBuscarId.TabIndex = 19;
            this.BtnBuscarId.Text = "Buscar por ID";
            this.BtnBuscarId.UseVisualStyleBackColor = true;
            this.BtnBuscarId.Click += new System.EventHandler(this.BtnBuscarId_Click);
            // 
            // FormInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 366);
            this.Controls.Add(this.BtnBuscarId);
            this.Controls.Add(this.BtnNuevoProduct);
            this.Controls.Add(this.BtnActualizarProduct);
            this.Controls.Add(this.BtnElminarProduct);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.TBId);
            this.Controls.Add(this.LbId);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.LBPrecio);
            this.Controls.Add(this.LBCategoria);
            this.Controls.Add(this.LbProducto);
            this.Controls.Add(this.TBCantidad);
            this.Controls.Add(this.TBPrecio);
            this.Controls.Add(this.TBCategoria);
            this.Controls.Add(this.TBProducto);
            this.Controls.Add(this.DGInventory);
            this.Controls.Add(this.PBLogo);
            this.Name = "FormInventory";
            this.Text = "Formulario de inventario";
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox PBLogo;
        private DataGridView DGInventory;
        private TextBox TBProducto;
        private TextBox TBCategoria;
        private TextBox TBPrecio;
        private TextBox TBCantidad;
        private Label LbProducto;
        private Label LBCategoria;
        private Label LBPrecio;
        private Label Cantidad;
        private Label LbId;
        private TextBox TBId;
        private Button BtnVolver;
        private Button BtnElminarProduct;
        private Button BtnActualizarProduct;
        private Button BtnNuevoProduct;
        private Button BtnBuscarId;
    }
}