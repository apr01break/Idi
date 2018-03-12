namespace InstitutoDeIdiomas
{
    partial class frmActualizarUsuario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvwUsuarios = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TXTPATERNOUSER = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TXTMATERNOUSER = new System.Windows.Forms.TextBox();
            this.TXTTELEFONOUSER = new System.Windows.Forms.TextBox();
            this.TXTNOMBRESUSER = new System.Windows.Forms.TextBox();
            this.TXTCELULARUSER = new System.Windows.Forms.TextBox();
            this.NACIMIENTO_USER_DATE = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.TXTEDADUSER = new System.Windows.Forms.TextBox();
            this.CBINSTRUCCION = new System.Windows.Forms.ComboBox();
            this.TXTCORREOUSER = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.FOTOUSER = new System.Windows.Forms.PictureBox();
            this.BTNFOTOUSUARIO = new System.Windows.Forms.Button();
            this.TXTDNI = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblIdPersona = new System.Windows.Forms.Label();
            this.CBSEXO = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FOTOUSER)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CBSEXO);
            this.panel1.Controls.Add(this.lblIdPersona);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dgvwUsuarios);
            this.panel1.Controls.Add(this.TXTPATERNOUSER);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TXTDNI);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.TXTMATERNOUSER);
            this.panel1.Controls.Add(this.TXTTELEFONOUSER);
            this.panel1.Controls.Add(this.TXTNOMBRESUSER);
            this.panel1.Controls.Add(this.TXTCELULARUSER);
            this.panel1.Controls.Add(this.BTNFOTOUSUARIO);
            this.panel1.Controls.Add(this.NACIMIENTO_USER_DATE);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.FOTOUSER);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.TXTEDADUSER);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.CBINSTRUCCION);
            this.panel1.Controls.Add(this.TXTCORREOUSER);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1193, 403);
            this.panel1.TabIndex = 0;
            // 
            // dgvwUsuarios
            // 
            this.dgvwUsuarios.AllowUserToAddRows = false;
            this.dgvwUsuarios.AllowUserToDeleteRows = false;
            this.dgvwUsuarios.AllowUserToResizeRows = false;
            this.dgvwUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwUsuarios.Location = new System.Drawing.Point(11, 55);
            this.dgvwUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.dgvwUsuarios.Name = "dgvwUsuarios";
            this.dgvwUsuarios.ReadOnly = true;
            this.dgvwUsuarios.RowHeadersVisible = false;
            this.dgvwUsuarios.RowTemplate.Height = 24;
            this.dgvwUsuarios.Size = new System.Drawing.Size(397, 331);
            this.dgvwUsuarios.TabIndex = 76;
            this.dgvwUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwUsuarios_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Ingresa el nombre del usuario";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(12, 31);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(293, 20);
            this.txtBuscar.TabIndex = 74;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(523, 185);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 71;
            this.label8.Text = "SEXO";
            // 
            // TXTPATERNOUSER
            // 
            this.TXTPATERNOUSER.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTPATERNOUSER.Location = new System.Drawing.Point(563, 70);
            this.TXTPATERNOUSER.Margin = new System.Windows.Forms.Padding(2);
            this.TXTPATERNOUSER.Name = "TXTPATERNOUSER";
            this.TXTPATERNOUSER.Size = new System.Drawing.Size(153, 20);
            this.TXTPATERNOUSER.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "APELLIDO PATERNO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 221);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "FECHA DE NACIMIENTO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 258);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "CORREO ELECTRONICO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(498, 109);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "NOMBRES";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(742, 73);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "APELLIDO MATERNO";
            // 
            // TXTMATERNOUSER
            // 
            this.TXTMATERNOUSER.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTMATERNOUSER.Location = new System.Drawing.Point(862, 70);
            this.TXTMATERNOUSER.Margin = new System.Windows.Forms.Padding(2);
            this.TXTMATERNOUSER.Name = "TXTMATERNOUSER";
            this.TXTMATERNOUSER.Size = new System.Drawing.Size(155, 20);
            this.TXTMATERNOUSER.TabIndex = 54;
            // 
            // TXTTELEFONOUSER
            // 
            this.TXTTELEFONOUSER.Location = new System.Drawing.Point(862, 297);
            this.TXTTELEFONOUSER.Margin = new System.Windows.Forms.Padding(2);
            this.TXTTELEFONOUSER.Name = "TXTTELEFONOUSER";
            this.TXTTELEFONOUSER.Size = new System.Drawing.Size(112, 20);
            this.TXTTELEFONOUSER.TabIndex = 74;
            // 
            // TXTNOMBRESUSER
            // 
            this.TXTNOMBRESUSER.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTNOMBRESUSER.Location = new System.Drawing.Point(563, 106);
            this.TXTNOMBRESUSER.Margin = new System.Windows.Forms.Padding(2);
            this.TXTNOMBRESUSER.Name = "TXTNOMBRESUSER";
            this.TXTNOMBRESUSER.Size = new System.Drawing.Size(454, 20);
            this.TXTNOMBRESUSER.TabIndex = 56;
            // 
            // TXTCELULARUSER
            // 
            this.TXTCELULARUSER.Location = new System.Drawing.Point(1060, 297);
            this.TXTCELULARUSER.Margin = new System.Windows.Forms.Padding(2);
            this.TXTCELULARUSER.Name = "TXTCELULARUSER";
            this.TXTCELULARUSER.Size = new System.Drawing.Size(112, 20);
            this.TXTCELULARUSER.TabIndex = 75;
            // 
            // NACIMIENTO_USER_DATE
            // 
            this.NACIMIENTO_USER_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NACIMIENTO_USER_DATE.Location = new System.Drawing.Point(563, 218);
            this.NACIMIENTO_USER_DATE.Margin = new System.Windows.Forms.Padding(2);
            this.NACIMIENTO_USER_DATE.MaxDate = new System.DateTime(2017, 7, 4, 0, 0, 0, 0);
            this.NACIMIENTO_USER_DATE.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.NACIMIENTO_USER_DATE.Name = "NACIMIENTO_USER_DATE";
            this.NACIMIENTO_USER_DATE.Size = new System.Drawing.Size(219, 20);
            this.NACIMIENTO_USER_DATE.TabIndex = 60;
            this.NACIMIENTO_USER_DATE.Value = new System.DateTime(2017, 6, 5, 0, 0, 0, 0);
            this.NACIMIENTO_USER_DATE.ValueChanged += new System.EventHandler(this.NACIMIENTO_USER_DATE_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1000, 300);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 84;
            this.label17.Text = "CELULAR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(821, 221);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 67;
            this.label5.Text = "EDAD";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(791, 300);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 13);
            this.label16.TabIndex = 83;
            this.label16.Text = "TELEFONO";
            // 
            // TXTEDADUSER
            // 
            this.TXTEDADUSER.Enabled = false;
            this.TXTEDADUSER.Location = new System.Drawing.Point(862, 218);
            this.TXTEDADUSER.Margin = new System.Windows.Forms.Padding(2);
            this.TXTEDADUSER.Name = "TXTEDADUSER";
            this.TXTEDADUSER.Size = new System.Drawing.Size(155, 20);
            this.TXTEDADUSER.TabIndex = 63;
            // 
            // CBINSTRUCCION
            // 
            this.CBINSTRUCCION.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBINSTRUCCION.FormattingEnabled = true;
            this.CBINSTRUCCION.Items.AddRange(new object[] {
            "PRIMARIA",
            "SECUNDARIA",
            "UNIVERSIDAD",
            "TECNICO",
            "ESTUDIANTE UNIVERSITARIO",
            "ESTUDIANTE TECNICO",
            "DOCTORADO",
            "LICENCIADO",
            "MAGISTER"});
            this.CBINSTRUCCION.Location = new System.Drawing.Point(563, 292);
            this.CBINSTRUCCION.Margin = new System.Windows.Forms.Padding(2);
            this.CBINSTRUCCION.Name = "CBINSTRUCCION";
            this.CBINSTRUCCION.Size = new System.Drawing.Size(207, 21);
            this.CBINSTRUCCION.TabIndex = 72;
            // 
            // TXTCORREOUSER
            // 
            this.TXTCORREOUSER.Location = new System.Drawing.Point(563, 255);
            this.TXTCORREOUSER.Margin = new System.Windows.Forms.Padding(2);
            this.TXTCORREOUSER.Name = "TXTCORREOUSER";
            this.TXTCORREOUSER.Size = new System.Drawing.Size(454, 20);
            this.TXTCORREOUSER.TabIndex = 64;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(418, 295);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(141, 13);
            this.label15.TabIndex = 81;
            this.label15.Text = "GRADO DE INSTRUCCION";
            // 
            // FOTOUSER
            // 
            this.FOTOUSER.Location = new System.Drawing.Point(1043, 70);
            this.FOTOUSER.Margin = new System.Windows.Forms.Padding(2);
            this.FOTOUSER.Name = "FOTOUSER";
            this.FOTOUSER.Size = new System.Drawing.Size(128, 133);
            this.FOTOUSER.TabIndex = 73;
            this.FOTOUSER.TabStop = false;
            // 
            // BTNFOTOUSUARIO
            // 
            this.BTNFOTOUSUARIO.Location = new System.Drawing.Point(1043, 220);
            this.BTNFOTOUSUARIO.Margin = new System.Windows.Forms.Padding(2);
            this.BTNFOTOUSUARIO.Name = "BTNFOTOUSUARIO";
            this.BTNFOTOUSUARIO.Size = new System.Drawing.Size(128, 26);
            this.BTNFOTOUSUARIO.TabIndex = 82;
            this.BTNFOTOUSUARIO.Text = "CARGAR FOTO";
            this.BTNFOTOUSUARIO.UseVisualStyleBackColor = true;
            // 
            // TXTDNI
            // 
            this.TXTDNI.Location = new System.Drawing.Point(563, 143);
            this.TXTDNI.Margin = new System.Windows.Forms.Padding(2);
            this.TXTDNI.Name = "TXTDNI";
            this.TXTDNI.Size = new System.Drawing.Size(153, 20);
            this.TXTDNI.TabIndex = 58;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(533, 146);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 78;
            this.label12.Text = "DNI";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(1060, 343);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = true;
            this.btnGuardar.Size = new System.Drawing.Size(112, 31);
            this.btnGuardar.TabIndex = 87;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblIdPersona
            // 
            this.lblIdPersona.AutoSize = true;
            this.lblIdPersona.Location = new System.Drawing.Point(501, 31);
            this.lblIdPersona.Name = "lblIdPersona";
            this.lblIdPersona.Size = new System.Drawing.Size(70, 13);
            this.lblIdPersona.TabIndex = 88;
            this.lblIdPersona.Text = "IDPERSONA";
            this.lblIdPersona.Visible = false;
            // 
            // CBSEXO
            // 
            this.CBSEXO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBSEXO.Enabled = false;
            this.CBSEXO.FormattingEnabled = true;
            this.CBSEXO.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.CBSEXO.Location = new System.Drawing.Point(563, 181);
            this.CBSEXO.Margin = new System.Windows.Forms.Padding(2);
            this.CBSEXO.Name = "CBSEXO";
            this.CBSEXO.Size = new System.Drawing.Size(248, 21);
            this.CBSEXO.TabIndex = 89;
            // 
            // frmActualizarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 466);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmActualizarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACTUALIZAR DATOS DE USUARIO";
            this.Load += new System.EventHandler(this.frmActualizarUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FOTOUSER)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvwUsuarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
        private MaterialSkin.Controls.MaterialRaisedButton btnGuardar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TXTPATERNOUSER;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXTDNI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXTMATERNOUSER;
        private System.Windows.Forms.TextBox TXTTELEFONOUSER;
        private System.Windows.Forms.TextBox TXTNOMBRESUSER;
        private System.Windows.Forms.TextBox TXTCELULARUSER;
        private System.Windows.Forms.Button BTNFOTOUSUARIO;
        private System.Windows.Forms.DateTimePicker NACIMIENTO_USER_DATE;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox FOTOUSER;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TXTEDADUSER;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox CBINSTRUCCION;
        private System.Windows.Forms.TextBox TXTCORREOUSER;
        private System.Windows.Forms.Label lblIdPersona;
        private System.Windows.Forms.ComboBox CBSEXO;
    }
}