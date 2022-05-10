namespace VentaForm
{
    partial class Login
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
            this.TbUser = new System.Windows.Forms.TextBox();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.Label();
            this.Clave = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbUser
            // 
            this.TbUser.Location = new System.Drawing.Point(76, 55);
            this.TbUser.Name = "TbUser";
            this.TbUser.Size = new System.Drawing.Size(178, 23);
            this.TbUser.TabIndex = 0;
            // 
            // TbPassword
            // 
            this.TbPassword.Location = new System.Drawing.Point(76, 112);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(178, 23);
            this.TbPassword.TabIndex = 1;
            this.TbPassword.UseSystemPasswordChar = true;
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(135, 37);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(47, 15);
            this.Usuario.TabIndex = 2;
            this.Usuario.Text = "Usuario";
            // 
            // Clave
            // 
            this.Clave.AutoSize = true;
            this.Clave.Location = new System.Drawing.Point(135, 94);
            this.Clave.Name = "Clave";
            this.Clave.Size = new System.Drawing.Size(36, 15);
            this.Clave.TabIndex = 3;
            this.Clave.Text = "Clave";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(76, 183);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 23);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "Iniciar";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(179, 183);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 5;
            this.BtnClose.Text = "Cerrar";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 237);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.Clave);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.TbUser);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TbUser;
        private TextBox TbPassword;
        private Label Usuario;
        private Label Clave;
        private Button BtnLogin;
        private Button BtnClose;
    }
}