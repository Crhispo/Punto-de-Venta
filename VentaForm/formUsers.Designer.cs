namespace Presentacion
{
    partial class FormUsers
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
            this.DGUsers = new System.Windows.Forms.DataGridView();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.BtnNuevoUser = new System.Windows.Forms.Button();
            this.BtnActualizarUser = new System.Windows.Forms.Button();
            this.BtnElminarUser = new System.Windows.Forms.Button();
            this.LbNombre = new System.Windows.Forms.Label();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.LbApellidos = new System.Windows.Forms.Label();
            this.TBApellidos = new System.Windows.Forms.TextBox();
            this.TBDNI = new System.Windows.Forms.TextBox();
            this.LbDNI = new System.Windows.Forms.Label();
            this.TBTelefono = new System.Windows.Forms.TextBox();
            this.LbTelefono = new System.Windows.Forms.Label();
            this.TBClave = new System.Windows.Forms.TextBox();
            this.LbClave = new System.Windows.Forms.Label();
            this.TBUsuario = new System.Windows.Forms.TextBox();
            this.LbUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // DGUsers
            // 
            this.DGUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DGUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DGUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGUsers.Location = new System.Drawing.Point(228, 12);
            this.DGUsers.Name = "DGUsers";
            this.DGUsers.RowTemplate.Height = 25;
            this.DGUsers.Size = new System.Drawing.Size(514, 255);
            this.DGUsers.TabIndex = 0;
            this.DGUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGUsers_CellContentClick);
            // 
            // BtnVolver
            // 
            this.BtnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnVolver.Location = new System.Drawing.Point(647, 326);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(94, 43);
            this.BtnVolver.TabIndex = 1;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // BtnNuevoUser
            // 
            this.BtnNuevoUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNuevoUser.Location = new System.Drawing.Point(315, 326);
            this.BtnNuevoUser.Name = "BtnNuevoUser";
            this.BtnNuevoUser.Size = new System.Drawing.Size(94, 43);
            this.BtnNuevoUser.TabIndex = 2;
            this.BtnNuevoUser.Text = "Nuevo Usuario";
            this.BtnNuevoUser.UseVisualStyleBackColor = true;
            this.BtnNuevoUser.Click += new System.EventHandler(this.BtnNuevoUser_Click);
            // 
            // BtnActualizarUser
            // 
            this.BtnActualizarUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnActualizarUser.Location = new System.Drawing.Point(415, 326);
            this.BtnActualizarUser.Name = "BtnActualizarUser";
            this.BtnActualizarUser.Size = new System.Drawing.Size(110, 43);
            this.BtnActualizarUser.TabIndex = 3;
            this.BtnActualizarUser.Text = "Actualizar Usuario";
            this.BtnActualizarUser.UseVisualStyleBackColor = true;
            this.BtnActualizarUser.Click += new System.EventHandler(this.BtnActualizarUser_Click);
            // 
            // BtnElminarUser
            // 
            this.BtnElminarUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnElminarUser.Location = new System.Drawing.Point(531, 326);
            this.BtnElminarUser.Name = "BtnElminarUser";
            this.BtnElminarUser.Size = new System.Drawing.Size(110, 43);
            this.BtnElminarUser.TabIndex = 4;
            this.BtnElminarUser.Text = "Eliminar Usuario";
            this.BtnElminarUser.UseVisualStyleBackColor = true;
            this.BtnElminarUser.Click += new System.EventHandler(this.BtnEliminarUser_Click);
            // 
            // LbNombre
            // 
            this.LbNombre.AutoSize = true;
            this.LbNombre.Location = new System.Drawing.Point(12, 12);
            this.LbNombre.Name = "LbNombre";
            this.LbNombre.Size = new System.Drawing.Size(51, 15);
            this.LbNombre.TabIndex = 6;
            this.LbNombre.Text = "Nombre";
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(12, 30);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TBNombre.Size = new System.Drawing.Size(200, 23);
            this.TBNombre.TabIndex = 7;
            this.TBNombre.TextChanged += new System.EventHandler(this.TBNombre_TextChanged);
            // 
            // LbApellidos
            // 
            this.LbApellidos.AutoSize = true;
            this.LbApellidos.Location = new System.Drawing.Point(12, 56);
            this.LbApellidos.Name = "LbApellidos";
            this.LbApellidos.Size = new System.Drawing.Size(56, 15);
            this.LbApellidos.TabIndex = 8;
            this.LbApellidos.Text = "Apellidos";
            // 
            // TBApellidos
            // 
            this.TBApellidos.Location = new System.Drawing.Point(12, 74);
            this.TBApellidos.Name = "TBApellidos";
            this.TBApellidos.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TBApellidos.Size = new System.Drawing.Size(200, 23);
            this.TBApellidos.TabIndex = 9;
            this.TBApellidos.TextChanged += new System.EventHandler(this.TBApellidos_TextChanged);
            // 
            // TBDNI
            // 
            this.TBDNI.Location = new System.Drawing.Point(12, 118);
            this.TBDNI.Name = "TBDNI";
            this.TBDNI.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TBDNI.Size = new System.Drawing.Size(200, 23);
            this.TBDNI.TabIndex = 11;
            // 
            // LbDNI
            // 
            this.LbDNI.AutoSize = true;
            this.LbDNI.Location = new System.Drawing.Point(12, 100);
            this.LbDNI.Name = "LbDNI";
            this.LbDNI.Size = new System.Drawing.Size(27, 15);
            this.LbDNI.TabIndex = 10;
            this.LbDNI.Text = "DNI";
            // 
            // TBTelefono
            // 
            this.TBTelefono.Location = new System.Drawing.Point(12, 162);
            this.TBTelefono.Name = "TBTelefono";
            this.TBTelefono.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TBTelefono.Size = new System.Drawing.Size(200, 23);
            this.TBTelefono.TabIndex = 13;
            // 
            // LbTelefono
            // 
            this.LbTelefono.AutoSize = true;
            this.LbTelefono.Location = new System.Drawing.Point(12, 144);
            this.LbTelefono.Name = "LbTelefono";
            this.LbTelefono.Size = new System.Drawing.Size(52, 15);
            this.LbTelefono.TabIndex = 12;
            this.LbTelefono.Text = "Telefono";
            // 
            // TBClave
            // 
            this.TBClave.Location = new System.Drawing.Point(12, 288);
            this.TBClave.Name = "TBClave";
            this.TBClave.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TBClave.Size = new System.Drawing.Size(200, 23);
            this.TBClave.TabIndex = 15;
            // 
            // LbClave
            // 
            this.LbClave.AutoSize = true;
            this.LbClave.Location = new System.Drawing.Point(12, 270);
            this.LbClave.Name = "LbClave";
            this.LbClave.Size = new System.Drawing.Size(36, 15);
            this.LbClave.TabIndex = 14;
            this.LbClave.Text = "Clave";
            // 
            // TBUsuario
            // 
            this.TBUsuario.Location = new System.Drawing.Point(12, 244);
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TBUsuario.Size = new System.Drawing.Size(200, 23);
            this.TBUsuario.TabIndex = 17;
            this.TBUsuario.TextChanged += new System.EventHandler(this.TBUsuario_TextChanged);
            // 
            // LbUsuario
            // 
            this.LbUsuario.AutoSize = true;
            this.LbUsuario.Location = new System.Drawing.Point(12, 226);
            this.LbUsuario.Name = "LbUsuario";
            this.LbUsuario.Size = new System.Drawing.Size(47, 15);
            this.LbUsuario.TabIndex = 16;
            this.LbUsuario.Text = "Usuario";
            this.LbUsuario.Click += new System.EventHandler(this.LbUsuario_Click);
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 381);
            this.Controls.Add(this.TBUsuario);
            this.Controls.Add(this.LbUsuario);
            this.Controls.Add(this.TBClave);
            this.Controls.Add(this.LbClave);
            this.Controls.Add(this.TBTelefono);
            this.Controls.Add(this.LbTelefono);
            this.Controls.Add(this.TBDNI);
            this.Controls.Add(this.LbDNI);
            this.Controls.Add(this.TBApellidos);
            this.Controls.Add(this.LbApellidos);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.LbNombre);
            this.Controls.Add(this.BtnElminarUser);
            this.Controls.Add(this.BtnActualizarUser);
            this.Controls.Add(this.BtnNuevoUser);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.DGUsers);
            this.Name = "FormUsers";
            this.Text = "FormUsers";
            this.Load += new System.EventHandler(this.FormUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView DGUsers;
        private Button BtnVolver;
        private Button BtnNuevoUser;
        private Button BtnActualizarUser;
        private Button BtnElminarUser;
        private Label LbNombre;
        private TextBox TBNombre;
        private Label LbApellidos;
        private TextBox TBApellidos;
        private TextBox TBDNI;
        private Label LbDNI;
        private TextBox TBTelefono;
        private Label LbTelefono;
        private TextBox TBClave;
        private Label LbClave;
        private TextBox TBUsuario;
        private Label LbUsuario;
    }
}