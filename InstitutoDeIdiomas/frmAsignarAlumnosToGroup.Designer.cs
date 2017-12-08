namespace InstitutoDeIdiomas
{
    partial class frmAsignarAlumnosToGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsignarAlumnosToGroup));
            this.label11 = new System.Windows.Forms.Label();
            this.txtHorario2 = new System.Windows.Forms.TextBox();
            this.txtSalon = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBuscarDni = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBuscarApellido = new System.Windows.Forms.TextBox();
            this.dataGridViewAlumno = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.txtCiclo = new System.Windows.Forms.TextBox();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.txtIdioma = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewAlumnoGrupo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRelacionAlumnos = new System.Windows.Forms.Button();
            this.txtDocente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFeInicio = new System.Windows.Forms.TextBox();
            this.txtFeFin = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCambiarFechas = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnBorrarAlumno = new System.Windows.Forms.Button();
            this.btnEliminarGrupo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnoGrupo)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(766, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "--";
            // 
            // txtHorario2
            // 
            this.txtHorario2.Location = new System.Drawing.Point(780, 94);
            this.txtHorario2.Margin = new System.Windows.Forms.Padding(2);
            this.txtHorario2.Name = "txtHorario2";
            this.txtHorario2.ReadOnly = true;
            this.txtHorario2.Size = new System.Drawing.Size(53, 20);
            this.txtHorario2.TabIndex = 44;
            // 
            // txtSalon
            // 
            this.txtSalon.Location = new System.Drawing.Point(528, 94);
            this.txtSalon.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalon.Name = "txtSalon";
            this.txtSalon.ReadOnly = true;
            this.txtSalon.Size = new System.Drawing.Size(84, 20);
            this.txtSalon.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(463, 97);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "SALON";
            // 
            // txtBuscarDni
            // 
            this.txtBuscarDni.AutoCompleteCustomSource.AddRange(new string[] {
            "EJEMPLO DE AUTOCOMPLETE",
            "AUMNO X",
            "BALUMNO Y",
            "CALUMNO Z"});
            this.txtBuscarDni.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBuscarDni.Enabled = false;
            this.txtBuscarDni.Location = new System.Drawing.Point(465, 260);
            this.txtBuscarDni.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarDni.Name = "txtBuscarDni";
            this.txtBuscarDni.Size = new System.Drawing.Size(295, 20);
            this.txtBuscarDni.TabIndex = 41;
            this.txtBuscarDni.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarDni_KeyUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(467, 244);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "BUSCAR POR DNI";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(802, 218);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 64);
            this.btnAgregar.TabIndex = 39;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(467, 198);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "BUSCAR POR APELLIDO";
            // 
            // txtBuscarApellido
            // 
            this.txtBuscarApellido.AutoCompleteCustomSource.AddRange(new string[] {
            "EJEMPLO DE AUTOCOMPLETE",
            "AUMNO X",
            "BALUMNO Y",
            "CALUMNO Z"});
            this.txtBuscarApellido.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBuscarApellido.Enabled = false;
            this.txtBuscarApellido.Location = new System.Drawing.Point(465, 216);
            this.txtBuscarApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarApellido.Name = "txtBuscarApellido";
            this.txtBuscarApellido.Size = new System.Drawing.Size(295, 20);
            this.txtBuscarApellido.TabIndex = 37;
            this.txtBuscarApellido.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarApellido_KeyUp);
            // 
            // dataGridViewAlumno
            // 
            this.dataGridViewAlumno.AllowUserToAddRows = false;
            this.dataGridViewAlumno.AllowUserToDeleteRows = false;
            this.dataGridViewAlumno.AllowUserToResizeRows = false;
            this.dataGridViewAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlumno.Enabled = false;
            this.dataGridViewAlumno.Location = new System.Drawing.Point(470, 304);
            this.dataGridViewAlumno.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewAlumno.Name = "dataGridViewAlumno";
            this.dataGridViewAlumno.ReadOnly = true;
            this.dataGridViewAlumno.RowHeadersVisible = false;
            this.dataGridViewAlumno.RowTemplate.Height = 24;
            this.dataGridViewAlumno.Size = new System.Drawing.Size(426, 211);
            this.dataGridViewAlumno.TabIndex = 36;
            this.dataGridViewAlumno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAlumno_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(602, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "AGREGAR ALUMNOS";
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(711, 94);
            this.txtHorario.Margin = new System.Windows.Forms.Padding(2);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.ReadOnly = true;
            this.txtHorario.Size = new System.Drawing.Size(53, 20);
            this.txtHorario.TabIndex = 34;
            // 
            // txtCiclo
            // 
            this.txtCiclo.Location = new System.Drawing.Point(713, 67);
            this.txtCiclo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCiclo.Name = "txtCiclo";
            this.txtCiclo.ReadOnly = true;
            this.txtCiclo.Size = new System.Drawing.Size(122, 20);
            this.txtCiclo.TabIndex = 33;
            // 
            // txtNivel
            // 
            this.txtNivel.Location = new System.Drawing.Point(528, 67);
            this.txtNivel.Margin = new System.Windows.Forms.Padding(2);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.ReadOnly = true;
            this.txtNivel.Size = new System.Drawing.Size(107, 20);
            this.txtNivel.TabIndex = 32;
            // 
            // txtIdioma
            // 
            this.txtIdioma.Location = new System.Drawing.Point(713, 42);
            this.txtIdioma.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdioma.Name = "txtIdioma";
            this.txtIdioma.ReadOnly = true;
            this.txtIdioma.Size = new System.Drawing.Size(122, 20);
            this.txtIdioma.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(463, 70);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "NIVEL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(662, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "CICLO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(652, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "HORARIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(655, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "IDIOMA";
            // 
            // dataGridViewAlumnoGrupo
            // 
            this.dataGridViewAlumnoGrupo.AllowUserToAddRows = false;
            this.dataGridViewAlumnoGrupo.AllowUserToDeleteRows = false;
            this.dataGridViewAlumnoGrupo.AllowUserToResizeRows = false;
            this.dataGridViewAlumnoGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlumnoGrupo.Location = new System.Drawing.Point(29, 42);
            this.dataGridViewAlumnoGrupo.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewAlumnoGrupo.Name = "dataGridViewAlumnoGrupo";
            this.dataGridViewAlumnoGrupo.ReadOnly = true;
            this.dataGridViewAlumnoGrupo.RowHeadersVisible = false;
            this.dataGridViewAlumnoGrupo.RowTemplate.Height = 24;
            this.dataGridViewAlumnoGrupo.Size = new System.Drawing.Size(396, 411);
            this.dataGridViewAlumnoGrupo.TabIndex = 25;
            this.dataGridViewAlumnoGrupo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAlumnoGrupo_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "BIENVENIDO AQUI PODRA ASIGNAR ALUMNOS A LOS RESPECTIVOS GRUPOS CREADOS";
            // 
            // btnRelacionAlumnos
            // 
            this.btnRelacionAlumnos.Location = new System.Drawing.Point(161, 465);
            this.btnRelacionAlumnos.Name = "btnRelacionAlumnos";
            this.btnRelacionAlumnos.Size = new System.Drawing.Size(264, 42);
            this.btnRelacionAlumnos.TabIndex = 47;
            this.btnRelacionAlumnos.Text = "RELACION DE ALUMNOS";
            this.btnRelacionAlumnos.UseVisualStyleBackColor = true;
            this.btnRelacionAlumnos.Click += new System.EventHandler(this.btnRelacionAlumnos_Click);
            // 
            // txtDocente
            // 
            this.txtDocente.Location = new System.Drawing.Point(528, 120);
            this.txtDocente.Margin = new System.Windows.Forms.Padding(2);
            this.txtDocente.Name = "txtDocente";
            this.txtDocente.ReadOnly = true;
            this.txtDocente.Size = new System.Drawing.Size(247, 20);
            this.txtDocente.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "DOCENTE";
            // 
            // txtFeInicio
            // 
            this.txtFeInicio.Location = new System.Drawing.Point(528, 145);
            this.txtFeInicio.Name = "txtFeInicio";
            this.txtFeInicio.ReadOnly = true;
            this.txtFeInicio.Size = new System.Drawing.Size(73, 20);
            this.txtFeInicio.TabIndex = 51;
            // 
            // txtFeFin
            // 
            this.txtFeFin.Location = new System.Drawing.Point(658, 145);
            this.txtFeFin.Name = "txtFeFin";
            this.txtFeFin.ReadOnly = true;
            this.txtFeFin.Size = new System.Drawing.Size(73, 20);
            this.txtFeFin.TabIndex = 52;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(462, 148);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 53;
            this.label12.Text = "INICIO";
            // 
            // btnCambiarFechas
            // 
            this.btnCambiarFechas.Location = new System.Drawing.Point(746, 144);
            this.btnCambiarFechas.Name = "btnCambiarFechas";
            this.btnCambiarFechas.Size = new System.Drawing.Size(105, 23);
            this.btnCambiarFechas.TabIndex = 55;
            this.btnCambiarFechas.Text = "Cambiar Fechas";
            this.btnCambiarFechas.UseVisualStyleBackColor = true;
            this.btnCambiarFechas.Click += new System.EventHandler(this.btnCambiarFechas_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(619, 148);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 13);
            this.label14.TabIndex = 56;
            this.label14.Text = "FIN";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(528, 42);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(107, 20);
            this.txtNumero.TabIndex = 58;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(463, 45);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 57;
            this.label13.Text = "NUMERO";
            // 
            // btnBorrarAlumno
            // 
            this.btnBorrarAlumno.Enabled = false;
            this.btnBorrarAlumno.Location = new System.Drawing.Point(29, 465);
            this.btnBorrarAlumno.Name = "btnBorrarAlumno";
            this.btnBorrarAlumno.Size = new System.Drawing.Size(126, 42);
            this.btnBorrarAlumno.TabIndex = 59;
            this.btnBorrarAlumno.Text = "BORRAR ALUMNO";
            this.btnBorrarAlumno.UseVisualStyleBackColor = true;
            this.btnBorrarAlumno.Click += new System.EventHandler(this.btnBorrarAlumno_Click);
            // 
            // btnEliminarGrupo
            // 
            this.btnEliminarGrupo.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarGrupo.Image")));
            this.btnEliminarGrupo.Location = new System.Drawing.Point(855, 53);
            this.btnEliminarGrupo.Name = "btnEliminarGrupo";
            this.btnEliminarGrupo.Size = new System.Drawing.Size(41, 53);
            this.btnEliminarGrupo.TabIndex = 60;
            this.btnEliminarGrupo.UseVisualStyleBackColor = true;
            this.btnEliminarGrupo.Click += new System.EventHandler(this.btnEliminarGrupo_Click);
            // 
            // frmAsignarAlumnosToGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 526);
            this.Controls.Add(this.btnEliminarGrupo);
            this.Controls.Add(this.btnBorrarAlumno);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnCambiarFechas);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtFeFin);
            this.Controls.Add(this.txtFeInicio);
            this.Controls.Add(this.txtDocente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRelacionAlumnos);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtHorario2);
            this.Controls.Add(this.txtSalon);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBuscarDni);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBuscarApellido);
            this.Controls.Add(this.dataGridViewAlumno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.txtCiclo);
            this.Controls.Add(this.txtNivel);
            this.Controls.Add(this.txtIdioma);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewAlumnoGrupo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAsignarAlumnosToGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASIGNACION DE ALUMNOS A GRUPOS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnoGrupo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtHorario2;
        private System.Windows.Forms.TextBox txtSalon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBuscarDni;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtBuscarApellido;
        private System.Windows.Forms.DataGridView dataGridViewAlumno;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.TextBox txtCiclo;
        private System.Windows.Forms.TextBox txtNivel;
        private System.Windows.Forms.TextBox txtIdioma;
        private System.Windows.Forms.DataGridView dataGridViewAlumnoGrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRelacionAlumnos;
        private System.Windows.Forms.TextBox txtDocente;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtFeInicio;
        public System.Windows.Forms.TextBox txtFeFin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCambiarFechas;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnBorrarAlumno;
        private System.Windows.Forms.Button btnEliminarGrupo;
    }
}