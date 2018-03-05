namespace InstitutoDeIdiomas
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.ERROREMPTYTXTLOGIN = new System.Windows.Forms.ErrorProvider(this.components);
            this.BTNLOGIN = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TXTPASSWORD = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TXTUSUARIO = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ERROREMPTYTXTLOGIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ERROREMPTYTXTLOGIN
            // 
            this.ERROREMPTYTXTLOGIN.ContainerControl = this;
            // 
            // BTNLOGIN
            // 
            this.BTNLOGIN.BackColor = System.Drawing.Color.Maroon;
            this.BTNLOGIN.Depth = 0;
            this.BTNLOGIN.ForeColor = System.Drawing.Color.LightCoral;
            this.BTNLOGIN.Location = new System.Drawing.Point(86, 335);
            this.BTNLOGIN.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTNLOGIN.Name = "BTNLOGIN";
            this.BTNLOGIN.Primary = true;
            this.BTNLOGIN.Size = new System.Drawing.Size(127, 31);
            this.BTNLOGIN.TabIndex = 13;
            this.BTNLOGIN.Text = "ACEPTAR";
            this.BTNLOGIN.UseVisualStyleBackColor = false;
            this.BTNLOGIN.Click += new System.EventHandler(this.BTNLOGIN_Click_1);
            // 
            // TXTPASSWORD
            // 
            this.TXTPASSWORD.Depth = 0;
            this.TXTPASSWORD.Hint = "Contraseña";
            this.TXTPASSWORD.Location = new System.Drawing.Point(26, 290);
            this.TXTPASSWORD.MouseState = MaterialSkin.MouseState.HOVER;
            this.TXTPASSWORD.Name = "TXTPASSWORD";
            this.TXTPASSWORD.PasswordChar = '\0';
            this.TXTPASSWORD.SelectedText = "";
            this.TXTPASSWORD.SelectionLength = 0;
            this.TXTPASSWORD.SelectionStart = 0;
            this.TXTPASSWORD.Size = new System.Drawing.Size(247, 23);
            this.TXTPASSWORD.TabIndex = 12;
            this.TXTPASSWORD.UseSystemPasswordChar = true;
            this.TXTPASSWORD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTPASSWORD_KeyDown);
            // 
            // TXTUSUARIO
            // 
            this.TXTUSUARIO.Depth = 0;
            this.TXTUSUARIO.Hint = "Usuario";
            this.TXTUSUARIO.Location = new System.Drawing.Point(26, 247);
            this.TXTUSUARIO.MouseState = MaterialSkin.MouseState.HOVER;
            this.TXTUSUARIO.Name = "TXTUSUARIO";
            this.TXTUSUARIO.PasswordChar = '\0';
            this.TXTUSUARIO.SelectedText = "";
            this.TXTUSUARIO.SelectionLength = 0;
            this.TXTUSUARIO.SelectionStart = 0;
            this.TXTUSUARIO.Size = new System.Drawing.Size(247, 23);
            this.TXTUSUARIO.TabIndex = 11;
            this.TXTUSUARIO.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InstitutoDeIdiomas.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(75, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 388);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTNLOGIN);
            this.Controls.Add(this.TXTPASSWORD);
            this.Controls.Add(this.TXTUSUARIO);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INICIAR SESIÓN";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLogin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ERROREMPTYTXTLOGIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider ERROREMPTYTXTLOGIN;
        private MaterialSkin.Controls.MaterialRaisedButton BTNLOGIN;
        private MaterialSkin.Controls.MaterialSingleLineTextField TXTPASSWORD;
        private MaterialSkin.Controls.MaterialSingleLineTextField TXTUSUARIO;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

