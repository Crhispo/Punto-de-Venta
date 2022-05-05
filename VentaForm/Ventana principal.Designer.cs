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
            this.mSAbrirFactura = new System.Windows.Forms.ToolStripMenuItem();
            this.MiUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mS.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(478, 228);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // mS
            // 
            this.mS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MiArchivos,
            this.MiUsuarios});
            this.mS.Location = new System.Drawing.Point(0, 0);
            this.mS.Name = "mS";
            this.mS.Size = new System.Drawing.Size(583, 24);
            this.mS.TabIndex = 1;
            this.mS.Text = "Menu";
            this.mS.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mS_ItemClicked);
            // 
            // MiArchivos
            // 
            this.MiArchivos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mSAbrirFactura});
            this.MiArchivos.Name = "MiArchivos";
            this.MiArchivos.Size = new System.Drawing.Size(65, 20);
            this.MiArchivos.Text = "Archivos";
            // 
            // mSAbrirFactura
            // 
            this.mSAbrirFactura.Name = "mSAbrirFactura";
            this.mSAbrirFactura.Size = new System.Drawing.Size(180, 22);
            this.mSAbrirFactura.Text = "Abrir factura";
            this.mSAbrirFactura.Click += new System.EventHandler(this.mSAbrirFactura_Click);
            // 
            // MiUsuarios
            // 
            this.MiUsuarios.Name = "MiUsuarios";
            this.MiUsuarios.Size = new System.Drawing.Size(64, 20);
            this.MiUsuarios.Text = "Usuarios";
            this.MiUsuarios.Click += new System.EventHandler(this.MiUsuarios_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 271);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.mS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mS;
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaPrincipal";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.mS.ResumeLayout(false);
            this.mS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnCerrar;
        private MenuStrip mS;
        private ToolStripMenuItem MiArchivos;
        private ToolStripMenuItem mSAbrirFactura;
        private ToolStripMenuItem MiUsuarios;
    }
}