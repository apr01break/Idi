namespace InstitutoDeIdiomas
{
    partial class frmRegistrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrar));
            this.TXTPATERNOUSER = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TXTMATERNOUSER = new System.Windows.Forms.TextBox();
            this.TXTNOMBRESUSER = new System.Windows.Forms.TextBox();
            this.NACIMIENTO_USER_DATE = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTEDADUSER = new System.Windows.Forms.TextBox();
            this.TXTCORREOUSER = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RBMASCULINO = new System.Windows.Forms.RadioButton();
            this.RBFEMENINO = new System.Windows.Forms.RadioButton();
            this.BTNFOTOUSUARIO = new System.Windows.Forms.Button();
            this.CBDEPARTAMENTOS = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CBPROVINCIA = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TXTDNI = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CBDISTRITO = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TXTDIRECCIONUSER = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.CBINSTRUCCION = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.TXTCELULARUSER = new System.Windows.Forms.TextBox();
            this.TXTTELEFONOUSER = new System.Windows.Forms.TextBox();
            this.RBADMINISTRADOR = new System.Windows.Forms.RadioButton();
            this.RBSECRETARIO = new System.Windows.Forms.RadioButton();
            this.RBPROFESOR = new System.Windows.Forms.RadioButton();
            this.ERRORTXTVACIO = new System.Windows.Forms.ErrorProvider(this.components);
            this.GBROLTRABAJADOR = new System.Windows.Forms.GroupBox();
            this.RBSECPRINCIPAL = new System.Windows.Forms.RadioButton();
            this.RBACADEMICA = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.TXTPROCEDENCIA = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TXTUSUARIOUSER = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.TXTPASSWORDUSER = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTNREGISTRARUSER = new MaterialSkin.Controls.MaterialRaisedButton();
            this.FOTOUSER = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ERRORTXTVACIO)).BeginInit();
            this.GBROLTRABAJADOR.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FOTOUSER)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTPATERNOUSER
            // 
            this.TXTPATERNOUSER.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTPATERNOUSER.Location = new System.Drawing.Point(155, 25);
            this.TXTPATERNOUSER.Margin = new System.Windows.Forms.Padding(2);
            this.TXTPATERNOUSER.Name = "TXTPATERNOUSER";
            this.TXTPATERNOUSER.Size = new System.Drawing.Size(153, 20);
            this.TXTPATERNOUSER.TabIndex = 0;
            this.TXTPATERNOUSER.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloLetras);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "APELLIDO PATERNO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "FECHA DE NACIMIENTO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "CORREO ELECTRONICO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "NOMBRES";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(331, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "APELLIDO MATERNO";
            // 
            // TXTMATERNOUSER
            // 
            this.TXTMATERNOUSER.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTMATERNOUSER.Location = new System.Drawing.Point(454, 25);
            this.TXTMATERNOUSER.Margin = new System.Windows.Forms.Padding(2);
            this.TXTMATERNOUSER.Name = "TXTMATERNOUSER";
            this.TXTMATERNOUSER.Size = new System.Drawing.Size(155, 20);
            this.TXTMATERNOUSER.TabIndex = 1;
            this.TXTMATERNOUSER.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloLetras);
            // 
            // TXTNOMBRESUSER
            // 
            this.TXTNOMBRESUSER.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTNOMBRESUSER.Location = new System.Drawing.Point(155, 61);
            this.TXTNOMBRESUSER.Margin = new System.Windows.Forms.Padding(2);
            this.TXTNOMBRESUSER.Name = "TXTNOMBRESUSER";
            this.TXTNOMBRESUSER.Size = new System.Drawing.Size(454, 20);
            this.TXTNOMBRESUSER.TabIndex = 2;
            this.TXTNOMBRESUSER.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloLetras);
            // 
            // NACIMIENTO_USER_DATE
            // 
            this.NACIMIENTO_USER_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NACIMIENTO_USER_DATE.Location = new System.Drawing.Point(155, 173);
            this.NACIMIENTO_USER_DATE.Margin = new System.Windows.Forms.Padding(2);
            this.NACIMIENTO_USER_DATE.MaxDate = new System.DateTime(2017, 6, 5, 0, 0, 0, 0);
            this.NACIMIENTO_USER_DATE.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.NACIMIENTO_USER_DATE.Name = "NACIMIENTO_USER_DATE";
            this.NACIMIENTO_USER_DATE.Size = new System.Drawing.Size(219, 20);
            this.NACIMIENTO_USER_DATE.TabIndex = 6;
            this.NACIMIENTO_USER_DATE.Value = new System.DateTime(2017, 6, 5, 0, 0, 0, 0);
            this.NACIMIENTO_USER_DATE.ValueChanged += new System.EventHandler(this.NACIMIENTO_USER_DATE_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 174);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "EDAD";
            // 
            // TXTEDADUSER
            // 
            this.TXTEDADUSER.Enabled = false;
            this.TXTEDADUSER.Location = new System.Drawing.Point(454, 173);
            this.TXTEDADUSER.Margin = new System.Windows.Forms.Padding(2);
            this.TXTEDADUSER.Name = "TXTEDADUSER";
            this.TXTEDADUSER.Size = new System.Drawing.Size(155, 20);
            this.TXTEDADUSER.TabIndex = 7;
            this.TXTEDADUSER.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // TXTCORREOUSER
            // 
            this.TXTCORREOUSER.Location = new System.Drawing.Point(155, 210);
            this.TXTCORREOUSER.Margin = new System.Windows.Forms.Padding(2);
            this.TXTCORREOUSER.Name = "TXTCORREOUSER";
            this.TXTCORREOUSER.Size = new System.Drawing.Size(454, 20);
            this.TXTCORREOUSER.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 137);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "SEXO";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RBMASCULINO);
            this.panel1.Controls.Add(this.RBFEMENINO);
            this.panel1.Location = new System.Drawing.Point(155, 121);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 37);
            this.panel1.TabIndex = 10;
            // 
            // RBMASCULINO
            // 
            this.RBMASCULINO.AutoSize = true;
            this.RBMASCULINO.Location = new System.Drawing.Point(228, 13);
            this.RBMASCULINO.Margin = new System.Windows.Forms.Padding(2);
            this.RBMASCULINO.Name = "RBMASCULINO";
            this.RBMASCULINO.Size = new System.Drawing.Size(88, 17);
            this.RBMASCULINO.TabIndex = 5;
            this.RBMASCULINO.TabStop = true;
            this.RBMASCULINO.Text = "MASCULINO";
            this.RBMASCULINO.UseVisualStyleBackColor = true;
            // 
            // RBFEMENINO
            // 
            this.RBFEMENINO.AutoSize = true;
            this.RBFEMENINO.Location = new System.Drawing.Point(12, 13);
            this.RBFEMENINO.Margin = new System.Windows.Forms.Padding(2);
            this.RBFEMENINO.Name = "RBFEMENINO";
            this.RBFEMENINO.Size = new System.Drawing.Size(81, 17);
            this.RBFEMENINO.TabIndex = 4;
            this.RBFEMENINO.TabStop = true;
            this.RBFEMENINO.Text = "FEMENINO";
            this.RBFEMENINO.UseVisualStyleBackColor = true;
            // 
            // BTNFOTOUSUARIO
            // 
            this.BTNFOTOUSUARIO.Location = new System.Drawing.Point(643, 175);
            this.BTNFOTOUSUARIO.Margin = new System.Windows.Forms.Padding(2);
            this.BTNFOTOUSUARIO.Name = "BTNFOTOUSUARIO";
            this.BTNFOTOUSUARIO.Size = new System.Drawing.Size(128, 26);
            this.BTNFOTOUSUARIO.TabIndex = 30;
            this.BTNFOTOUSUARIO.Text = "CARGAR FOTO";
            this.BTNFOTOUSUARIO.UseVisualStyleBackColor = true;
            this.BTNFOTOUSUARIO.Click += new System.EventHandler(this.BTNFOTOUSUARIO_Click);
            // 
            // CBDEPARTAMENTOS
            // 
            this.CBDEPARTAMENTOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBDEPARTAMENTOS.FormattingEnabled = true;
            this.CBDEPARTAMENTOS.Location = new System.Drawing.Point(134, 256);
            this.CBDEPARTAMENTOS.Margin = new System.Windows.Forms.Padding(2);
            this.CBDEPARTAMENTOS.Name = "CBDEPARTAMENTOS";
            this.CBDEPARTAMENTOS.Size = new System.Drawing.Size(153, 21);
            this.CBDEPARTAMENTOS.TabIndex = 9;
            this.CBDEPARTAMENTOS.SelectedIndexChanged += new System.EventHandler(this.CBDEPARTAMENTOS_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 256);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "REGION";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(300, 261);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "PROVINCIA";
            // 
            // CBPROVINCIA
            // 
            this.CBPROVINCIA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBPROVINCIA.FormattingEnabled = true;
            this.CBPROVINCIA.Location = new System.Drawing.Point(375, 256);
            this.CBPROVINCIA.Margin = new System.Windows.Forms.Padding(2);
            this.CBPROVINCIA.Name = "CBPROVINCIA";
            this.CBPROVINCIA.Size = new System.Drawing.Size(153, 21);
            this.CBPROVINCIA.TabIndex = 11;
            this.CBPROVINCIA.SelectedIndexChanged += new System.EventHandler(this.CBPROVINCIAS_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 102);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "DNI";
            // 
            // TXTDNI
            // 
            this.TXTDNI.Location = new System.Drawing.Point(155, 98);
            this.TXTDNI.Margin = new System.Windows.Forms.Padding(2);
            this.TXTDNI.Name = "TXTDNI";
            this.TXTDNI.Size = new System.Drawing.Size(153, 20);
            this.TXTDNI.TabIndex = 3;
            this.TXTDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(542, 258);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "DISTRITO";
            // 
            // CBDISTRITO
            // 
            this.CBDISTRITO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBDISTRITO.FormattingEnabled = true;
            this.CBDISTRITO.Location = new System.Drawing.Point(617, 259);
            this.CBDISTRITO.Margin = new System.Windows.Forms.Padding(2);
            this.CBDISTRITO.Name = "CBDISTRITO";
            this.CBDISTRITO.Size = new System.Drawing.Size(155, 21);
            this.CBDISTRITO.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(381, 302);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "DIRECCION";
            // 
            // TXTDIRECCIONUSER
            // 
            this.TXTDIRECCIONUSER.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTDIRECCIONUSER.Location = new System.Drawing.Point(480, 298);
            this.TXTDIRECCIONUSER.Margin = new System.Windows.Forms.Padding(2);
            this.TXTDIRECCIONUSER.Name = "TXTDIRECCIONUSER";
            this.TXTDIRECCIONUSER.Size = new System.Drawing.Size(292, 20);
            this.TXTDIRECCIONUSER.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 351);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(141, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "GRADO DE INSTRUCCION";
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
            this.CBINSTRUCCION.Location = new System.Drawing.Point(167, 346);
            this.CBINSTRUCCION.Margin = new System.Windows.Forms.Padding(2);
            this.CBINSTRUCCION.Name = "CBINSTRUCCION";
            this.CBINSTRUCCION.Size = new System.Drawing.Size(207, 21);
            this.CBINSTRUCCION.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(391, 352);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "TELEFONO";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(590, 352);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "CELULAR";
            // 
            // TXTCELULARUSER
            // 
            this.TXTCELULARUSER.Location = new System.Drawing.Point(660, 349);
            this.TXTCELULARUSER.Margin = new System.Windows.Forms.Padding(2);
            this.TXTCELULARUSER.Name = "TXTCELULARUSER";
            this.TXTCELULARUSER.Size = new System.Drawing.Size(112, 20);
            this.TXTCELULARUSER.TabIndex = 17;
            this.TXTCELULARUSER.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // TXTTELEFONOUSER
            // 
            this.TXTTELEFONOUSER.Location = new System.Drawing.Point(462, 349);
            this.TXTTELEFONOUSER.Margin = new System.Windows.Forms.Padding(2);
            this.TXTTELEFONOUSER.Name = "TXTTELEFONOUSER";
            this.TXTTELEFONOUSER.Size = new System.Drawing.Size(112, 20);
            this.TXTTELEFONOUSER.TabIndex = 16;
            this.TXTTELEFONOUSER.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // RBADMINISTRADOR
            // 
            this.RBADMINISTRADOR.AutoSize = true;
            this.RBADMINISTRADOR.Location = new System.Drawing.Point(122, 33);
            this.RBADMINISTRADOR.Margin = new System.Windows.Forms.Padding(2);
            this.RBADMINISTRADOR.Name = "RBADMINISTRADOR";
            this.RBADMINISTRADOR.Size = new System.Drawing.Size(116, 17);
            this.RBADMINISTRADOR.TabIndex = 38;
            this.RBADMINISTRADOR.TabStop = true;
            this.RBADMINISTRADOR.Text = "ADMINISTRADOR";
            this.RBADMINISTRADOR.UseVisualStyleBackColor = true;
            // 
            // RBSECRETARIO
            // 
            this.RBSECRETARIO.AutoSize = true;
            this.RBSECRETARIO.Location = new System.Drawing.Point(251, 33);
            this.RBSECRETARIO.Margin = new System.Windows.Forms.Padding(2);
            this.RBSECRETARIO.Name = "RBSECRETARIO";
            this.RBSECRETARIO.Size = new System.Drawing.Size(94, 17);
            this.RBSECRETARIO.TabIndex = 39;
            this.RBSECRETARIO.TabStop = true;
            this.RBSECRETARIO.Text = "SECRETARIO";
            this.RBSECRETARIO.UseVisualStyleBackColor = true;
            // 
            // RBPROFESOR
            // 
            this.RBPROFESOR.AutoSize = true;
            this.RBPROFESOR.Location = new System.Drawing.Point(16, 33);
            this.RBPROFESOR.Margin = new System.Windows.Forms.Padding(2);
            this.RBPROFESOR.Name = "RBPROFESOR";
            this.RBPROFESOR.Size = new System.Drawing.Size(84, 17);
            this.RBPROFESOR.TabIndex = 18;
            this.RBPROFESOR.TabStop = true;
            this.RBPROFESOR.Text = "PROFESOR";
            this.RBPROFESOR.UseVisualStyleBackColor = true;
            // 
            // ERRORTXTVACIO
            // 
            this.ERRORTXTVACIO.ContainerControl = this;
            // 
            // GBROLTRABAJADOR
            // 
            this.GBROLTRABAJADOR.Controls.Add(this.RBSECPRINCIPAL);
            this.GBROLTRABAJADOR.Controls.Add(this.RBACADEMICA);
            this.GBROLTRABAJADOR.Controls.Add(this.RBPROFESOR);
            this.GBROLTRABAJADOR.Controls.Add(this.RBADMINISTRADOR);
            this.GBROLTRABAJADOR.Controls.Add(this.RBSECRETARIO);
            this.GBROLTRABAJADOR.Location = new System.Drawing.Point(12, 386);
            this.GBROLTRABAJADOR.Margin = new System.Windows.Forms.Padding(2);
            this.GBROLTRABAJADOR.Name = "GBROLTRABAJADOR";
            this.GBROLTRABAJADOR.Padding = new System.Windows.Forms.Padding(2);
            this.GBROLTRABAJADOR.Size = new System.Drawing.Size(396, 98);
            this.GBROLTRABAJADOR.TabIndex = 41;
            this.GBROLTRABAJADOR.TabStop = false;
            this.GBROLTRABAJADOR.Text = "ROL DEL TRABAJADOR";
            // 
            // RBSECPRINCIPAL
            // 
            this.RBSECPRINCIPAL.AutoSize = true;
            this.RBSECPRINCIPAL.Location = new System.Drawing.Point(152, 64);
            this.RBSECPRINCIPAL.Name = "RBSECPRINCIPAL";
            this.RBSECPRINCIPAL.Size = new System.Drawing.Size(152, 17);
            this.RBSECPRINCIPAL.TabIndex = 41;
            this.RBSECPRINCIPAL.TabStop = true;
            this.RBSECPRINCIPAL.Text = "SECRETARIA PRINCIPAL";
            this.RBSECPRINCIPAL.UseVisualStyleBackColor = true;
            // 
            // RBACADEMICA
            // 
            this.RBACADEMICA.AutoSize = true;
            this.RBACADEMICA.Location = new System.Drawing.Point(45, 64);
            this.RBACADEMICA.Name = "RBACADEMICA";
            this.RBACADEMICA.Size = new System.Drawing.Size(87, 17);
            this.RBACADEMICA.TabIndex = 40;
            this.RBACADEMICA.TabStop = true;
            this.RBACADEMICA.Text = "ACADEMICA";
            this.RBACADEMICA.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 302);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 13);
            this.label18.TabIndex = 51;
            this.label18.Text = "PROCEDENCIA";
            // 
            // TXTPROCEDENCIA
            // 
            this.TXTPROCEDENCIA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTPROCEDENCIA.Location = new System.Drawing.Point(155, 298);
            this.TXTPROCEDENCIA.Margin = new System.Windows.Forms.Padding(2);
            this.TXTPROCEDENCIA.Name = "TXTPROCEDENCIA";
            this.TXTPROCEDENCIA.Size = new System.Drawing.Size(210, 20);
            this.TXTPROCEDENCIA.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(437, 401);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "USUARIO";
            // 
            // TXTUSUARIOUSER
            // 
            this.TXTUSUARIOUSER.Location = new System.Drawing.Point(439, 418);
            this.TXTUSUARIOUSER.Margin = new System.Windows.Forms.Padding(2);
            this.TXTUSUARIOUSER.Name = "TXTUSUARIOUSER";
            this.TXTUSUARIOUSER.Size = new System.Drawing.Size(119, 20);
            this.TXTUSUARIOUSER.TabIndex = 54;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(617, 401);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 13);
            this.label19.TabIndex = 55;
            this.label19.Text = "CONTRASEÑA";
            // 
            // TXTPASSWORDUSER
            // 
            this.TXTPASSWORDUSER.Location = new System.Drawing.Point(617, 418);
            this.TXTPASSWORDUSER.Margin = new System.Windows.Forms.Padding(2);
            this.TXTPASSWORDUSER.Name = "TXTPASSWORDUSER";
            this.TXTPASSWORDUSER.Size = new System.Drawing.Size(118, 20);
            this.TXTPASSWORDUSER.TabIndex = 56;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BTNREGISTRARUSER);
            this.panel2.Controls.Add(this.TXTPASSWORDUSER);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.TXTPATERNOUSER);
            this.panel2.Controls.Add(this.TXTUSUARIOUSER);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.TXTPROCEDENCIA);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.GBROLTRABAJADOR);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.TXTMATERNOUSER);
            this.panel2.Controls.Add(this.TXTTELEFONOUSER);
            this.panel2.Controls.Add(this.TXTNOMBRESUSER);
            this.panel2.Controls.Add(this.TXTCELULARUSER);
            this.panel2.Controls.Add(this.NACIMIENTO_USER_DATE);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.TXTEDADUSER);
            this.panel2.Controls.Add(this.CBINSTRUCCION);
            this.panel2.Controls.Add(this.TXTCORREOUSER);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.TXTDIRECCIONUSER);
            this.panel2.Controls.Add(this.FOTOUSER);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.BTNFOTOUSUARIO);
            this.panel2.Controls.Add(this.CBDISTRITO);
            this.panel2.Controls.Add(this.CBDEPARTAMENTOS);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.TXTDNI);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.CBPROVINCIA);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 509);
            this.panel2.TabIndex = 57;
            // 
            // BTNREGISTRARUSER
            // 
            this.BTNREGISTRARUSER.Depth = 0;
            this.BTNREGISTRARUSER.Location = new System.Drawing.Point(607, 462);
            this.BTNREGISTRARUSER.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTNREGISTRARUSER.Name = "BTNREGISTRARUSER";
            this.BTNREGISTRARUSER.Primary = true;
            this.BTNREGISTRARUSER.Size = new System.Drawing.Size(164, 32);
            this.BTNREGISTRARUSER.TabIndex = 57;
            this.BTNREGISTRARUSER.Text = "REGISTRAR USUARIO";
            this.BTNREGISTRARUSER.UseVisualStyleBackColor = true;
            this.BTNREGISTRARUSER.Click += new System.EventHandler(this.BTNREGISTRARUSER_Click);
            // 
            // FOTOUSER
            // 
            this.FOTOUSER.Location = new System.Drawing.Point(643, 25);
            this.FOTOUSER.Margin = new System.Windows.Forms.Padding(2);
            this.FOTOUSER.Name = "FOTOUSER";
            this.FOTOUSER.Size = new System.Drawing.Size(128, 133);
            this.FOTOUSER.TabIndex = 16;
            this.FOTOUSER.TabStop = false;
            // 
            // frmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(791, 572);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmRegistrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO DE USUARIO";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ERRORTXTVACIO)).EndInit();
            this.GBROLTRABAJADOR.ResumeLayout(false);
            this.GBROLTRABAJADOR.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FOTOUSER)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TXTPATERNOUSER;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXTMATERNOUSER;
        private System.Windows.Forms.TextBox TXTNOMBRESUSER;
        private System.Windows.Forms.DateTimePicker NACIMIENTO_USER_DATE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXTEDADUSER;
        private System.Windows.Forms.TextBox TXTCORREOUSER;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton RBFEMENINO;
        private System.Windows.Forms.RadioButton RBMASCULINO;
        private System.Windows.Forms.PictureBox FOTOUSER;
        private System.Windows.Forms.Button BTNFOTOUSUARIO;
        private System.Windows.Forms.ComboBox CBDEPARTAMENTOS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CBPROVINCIA;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TXTDNI;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox CBDISTRITO;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TXTDIRECCIONUSER;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox CBINSTRUCCION;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TXTCELULARUSER;
        private System.Windows.Forms.TextBox TXTTELEFONOUSER;
        private System.Windows.Forms.RadioButton RBADMINISTRADOR;
        private System.Windows.Forms.RadioButton RBSECRETARIO;
        private System.Windows.Forms.RadioButton RBPROFESOR;
        private System.Windows.Forms.ErrorProvider ERRORTXTVACIO;
        private System.Windows.Forms.GroupBox GBROLTRABAJADOR;
        private System.Windows.Forms.TextBox TXTPROCEDENCIA;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TXTPASSWORDUSER;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TXTUSUARIOUSER;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialRaisedButton BTNREGISTRARUSER;
        private System.Windows.Forms.RadioButton RBSECPRINCIPAL;
        private System.Windows.Forms.RadioButton RBACADEMICA;
    }
}