using InstitutoDeIdiomas.DataSetsIdiomas;

namespace InstitutoDeIdiomas
{
    partial class frmVerNotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerNotas));
            this.label11 = new System.Windows.Forms.Label();
            this.txtHorario2 = new System.Windows.Forms.TextBox();
            this.txtSalon = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.txtCiclo = new System.Windows.Forms.TextBox();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.txtIdioma = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvwNotas = new System.Windows.Forms.DataGridView();
            this.cmbTipoNota = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvwBase = new System.Windows.Forms.DataGridView();
            this.dgvwListening = new System.Windows.Forms.DataGridView();
            this.dgvwReading = new System.Windows.Forms.DataGridView();
            this.dgvwSpeaking = new System.Windows.Forms.DataGridView();
            this.dgvwWriting = new System.Windows.Forms.DataGridView();
            this.dgvwUseOfEnglish = new System.Windows.Forms.DataGridView();
            this.btnConcluirGrupo = new System.Windows.Forms.Button();
            this.btnRelacionAlumno = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDocente = new System.Windows.Forms.TextBox();
            this.btnRelacionAlumnos = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRecordEconomico = new System.Windows.Forms.Button();
            this.btnVerAsistencias = new System.Windows.Forms.Button();
            this.btnEliminarAlumno = new System.Windows.Forms.Button();
            this.btnAgregarExtemporaneo = new System.Windows.Forms.Button();
            this.txtFin = new System.Windows.Forms.TextBox();
            this.txtInicio = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.RichTextBox();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvwNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwListening)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwReading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwSpeaking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwWriting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwUseOfEnglish)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(323, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 58;
            this.label11.Text = "--";
            // 
            // txtHorario2
            // 
            this.txtHorario2.Location = new System.Drawing.Point(337, 68);
            this.txtHorario2.Margin = new System.Windows.Forms.Padding(2);
            this.txtHorario2.Name = "txtHorario2";
            this.txtHorario2.ReadOnly = true;
            this.txtHorario2.Size = new System.Drawing.Size(48, 20);
            this.txtHorario2.TabIndex = 57;
            // 
            // txtSalon
            // 
            this.txtSalon.Location = new System.Drawing.Point(72, 95);
            this.txtSalon.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalon.Name = "txtSalon";
            this.txtSalon.ReadOnly = true;
            this.txtSalon.Size = new System.Drawing.Size(122, 20);
            this.txtSalon.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 98);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 55;
            this.label10.Text = "SALON";
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(274, 68);
            this.txtHorario.Margin = new System.Windows.Forms.Padding(2);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.ReadOnly = true;
            this.txtHorario.Size = new System.Drawing.Size(48, 20);
            this.txtHorario.TabIndex = 54;
            // 
            // txtCiclo
            // 
            this.txtCiclo.Location = new System.Drawing.Point(274, 43);
            this.txtCiclo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCiclo.Name = "txtCiclo";
            this.txtCiclo.ReadOnly = true;
            this.txtCiclo.Size = new System.Drawing.Size(122, 20);
            this.txtCiclo.TabIndex = 53;
            // 
            // txtNivel
            // 
            this.txtNivel.Location = new System.Drawing.Point(72, 68);
            this.txtNivel.Margin = new System.Windows.Forms.Padding(2);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.ReadOnly = true;
            this.txtNivel.Size = new System.Drawing.Size(122, 20);
            this.txtNivel.TabIndex = 52;
            // 
            // txtIdioma
            // 
            this.txtIdioma.Location = new System.Drawing.Point(72, 43);
            this.txtIdioma.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdioma.Name = "txtIdioma";
            this.txtIdioma.ReadOnly = true;
            this.txtIdioma.Size = new System.Drawing.Size(122, 20);
            this.txtIdioma.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 71);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "NIVEL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "CICLO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "HORARIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "IDIOMA";
            // 
            // dgvwNotas
            // 
            this.dgvwNotas.AllowUserToAddRows = false;
            this.dgvwNotas.AllowUserToResizeRows = false;
            this.dgvwNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwNotas.Location = new System.Drawing.Point(14, 239);
            this.dgvwNotas.Name = "dgvwNotas";
            this.dgvwNotas.ReadOnly = true;
            this.dgvwNotas.RowHeadersVisible = false;
            this.dgvwNotas.Size = new System.Drawing.Size(865, 381);
            this.dgvwNotas.TabIndex = 60;
            this.dgvwNotas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwNotas_CellClick);
            // 
            // cmbTipoNota
            // 
            this.cmbTipoNota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoNota.FormattingEnabled = true;
            this.cmbTipoNota.Items.AddRange(new object[] {
            "LISTENING",
            "READING",
            "WRITING",
            "SPEAKING",
            "USE OF ENGLISH",
            "RESULTADOS HASTA AHORA"});
            this.cmbTipoNota.Location = new System.Drawing.Point(235, 153);
            this.cmbTipoNota.Name = "cmbTipoNota";
            this.cmbTipoNota.Size = new System.Drawing.Size(229, 21);
            this.cmbTipoNota.TabIndex = 61;
            this.cmbTipoNota.TextChanged += new System.EventHandler(this.cmbTipoNota_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Selecciona el criterio de nota o resultado";
            // 
            // dgvwBase
            // 
            this.dgvwBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwBase.Location = new System.Drawing.Point(743, 540);
            this.dgvwBase.Name = "dgvwBase";
            this.dgvwBase.Size = new System.Drawing.Size(40, 34);
            this.dgvwBase.TabIndex = 64;
            this.dgvwBase.Visible = false;
            // 
            // dgvwListening
            // 
            this.dgvwListening.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwListening.Location = new System.Drawing.Point(767, 559);
            this.dgvwListening.Name = "dgvwListening";
            this.dgvwListening.Size = new System.Drawing.Size(39, 28);
            this.dgvwListening.TabIndex = 65;
            // 
            // dgvwReading
            // 
            this.dgvwReading.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwReading.Location = new System.Drawing.Point(767, 560);
            this.dgvwReading.Name = "dgvwReading";
            this.dgvwReading.Size = new System.Drawing.Size(39, 28);
            this.dgvwReading.TabIndex = 66;
            // 
            // dgvwSpeaking
            // 
            this.dgvwSpeaking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwSpeaking.Location = new System.Drawing.Point(762, 560);
            this.dgvwSpeaking.Name = "dgvwSpeaking";
            this.dgvwSpeaking.Size = new System.Drawing.Size(44, 28);
            this.dgvwSpeaking.TabIndex = 67;
            // 
            // dgvwWriting
            // 
            this.dgvwWriting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwWriting.Location = new System.Drawing.Point(765, 559);
            this.dgvwWriting.Name = "dgvwWriting";
            this.dgvwWriting.Size = new System.Drawing.Size(41, 29);
            this.dgvwWriting.TabIndex = 68;
            // 
            // dgvwUseOfEnglish
            // 
            this.dgvwUseOfEnglish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwUseOfEnglish.Location = new System.Drawing.Point(767, 560);
            this.dgvwUseOfEnglish.Name = "dgvwUseOfEnglish";
            this.dgvwUseOfEnglish.Size = new System.Drawing.Size(39, 28);
            this.dgvwUseOfEnglish.TabIndex = 69;
            // 
            // btnConcluirGrupo
            // 
            this.btnConcluirGrupo.BackColor = System.Drawing.Color.Olive;
            this.btnConcluirGrupo.FlatAppearance.BorderSize = 0;
            this.btnConcluirGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConcluirGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluirGrupo.ForeColor = System.Drawing.Color.White;
            this.btnConcluirGrupo.Location = new System.Drawing.Point(688, 16);
            this.btnConcluirGrupo.Name = "btnConcluirGrupo";
            this.btnConcluirGrupo.Size = new System.Drawing.Size(179, 44);
            this.btnConcluirGrupo.TabIndex = 70;
            this.btnConcluirGrupo.Text = "CONCLUIR GRUPO";
            this.btnConcluirGrupo.UseVisualStyleBackColor = false;
            this.btnConcluirGrupo.Click += new System.EventHandler(this.btnConcluirGrupo_Click);
            // 
            // btnRelacionAlumno
            // 
            this.btnRelacionAlumno.BackColor = System.Drawing.Color.Purple;
            this.btnRelacionAlumno.FlatAppearance.BorderSize = 0;
            this.btnRelacionAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelacionAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelacionAlumno.ForeColor = System.Drawing.Color.White;
            this.btnRelacionAlumno.Location = new System.Drawing.Point(688, 125);
            this.btnRelacionAlumno.Name = "btnRelacionAlumno";
            this.btnRelacionAlumno.Size = new System.Drawing.Size(179, 44);
            this.btnRelacionAlumno.TabIndex = 71;
            this.btnRelacionAlumno.Text = "ACTA FINAL";
            this.btnRelacionAlumno.UseVisualStyleBackColor = false;
            this.btnRelacionAlumno.Click += new System.EventHandler(this.btnRelacionAlumno_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 125);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 72;
            this.label8.Text = "DOCENTE";
            // 
            // txtDocente
            // 
            this.txtDocente.Location = new System.Drawing.Point(72, 121);
            this.txtDocente.Margin = new System.Windows.Forms.Padding(2);
            this.txtDocente.Name = "txtDocente";
            this.txtDocente.ReadOnly = true;
            this.txtDocente.Size = new System.Drawing.Size(238, 20);
            this.txtDocente.TabIndex = 73;
            // 
            // btnRelacionAlumnos
            // 
            this.btnRelacionAlumnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRelacionAlumnos.FlatAppearance.BorderSize = 0;
            this.btnRelacionAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelacionAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelacionAlumnos.ForeColor = System.Drawing.Color.White;
            this.btnRelacionAlumnos.Location = new System.Drawing.Point(688, 70);
            this.btnRelacionAlumnos.Name = "btnRelacionAlumnos";
            this.btnRelacionAlumnos.Size = new System.Drawing.Size(179, 44);
            this.btnRelacionAlumnos.TabIndex = 75;
            this.btnRelacionAlumnos.Text = "RELACION DE ALUMNOS";
            this.btnRelacionAlumnos.UseVisualStyleBackColor = false;
            this.btnRelacionAlumnos.Click += new System.EventHandler(this.btnRelacionAlumnos_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(72, 16);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(122, 20);
            this.txtNumero.TabIndex = 77;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 19);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 76;
            this.label9.Text = "GRUPO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnRecordEconomico);
            this.panel1.Controls.Add(this.btnVerAsistencias);
            this.panel1.Controls.Add(this.btnEliminarAlumno);
            this.panel1.Controls.Add(this.btnAgregarExtemporaneo);
            this.panel1.Controls.Add(this.txtFin);
            this.panel1.Controls.Add(this.txtInicio);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDias);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvwNotas);
            this.panel1.Controls.Add(this.txtNumero);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnRelacionAlumnos);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDocente);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnRelacionAlumno);
            this.panel1.Controls.Add(this.txtIdioma);
            this.panel1.Controls.Add(this.btnConcluirGrupo);
            this.panel1.Controls.Add(this.txtNivel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCiclo);
            this.panel1.Controls.Add(this.txtHorario);
            this.panel1.Controls.Add(this.cmbTipoNota);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtSalon);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtHorario2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 662);
            this.panel1.TabIndex = 78;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(510, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 44);
            this.button1.TabIndex = 88;
            this.button1.Text = "ACTA DE NOTAS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRecordEconomico
            // 
            this.btnRecordEconomico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRecordEconomico.FlatAppearance.BorderSize = 0;
            this.btnRecordEconomico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecordEconomico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecordEconomico.ForeColor = System.Drawing.Color.White;
            this.btnRecordEconomico.Location = new System.Drawing.Point(510, 70);
            this.btnRecordEconomico.Name = "btnRecordEconomico";
            this.btnRecordEconomico.Size = new System.Drawing.Size(168, 44);
            this.btnRecordEconomico.TabIndex = 87;
            this.btnRecordEconomico.Text = "RECORD ECONOMICO";
            this.btnRecordEconomico.UseVisualStyleBackColor = false;
            this.btnRecordEconomico.Click += new System.EventHandler(this.btnRecordEconomico_Click);
            // 
            // btnVerAsistencias
            // 
            this.btnVerAsistencias.BackColor = System.Drawing.Color.SeaGreen;
            this.btnVerAsistencias.FlatAppearance.BorderSize = 0;
            this.btnVerAsistencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerAsistencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerAsistencias.ForeColor = System.Drawing.Color.White;
            this.btnVerAsistencias.Location = new System.Drawing.Point(510, 16);
            this.btnVerAsistencias.Name = "btnVerAsistencias";
            this.btnVerAsistencias.Size = new System.Drawing.Size(168, 44);
            this.btnVerAsistencias.TabIndex = 86;
            this.btnVerAsistencias.Text = "VER ASISTENCIAS";
            this.btnVerAsistencias.UseVisualStyleBackColor = false;
            this.btnVerAsistencias.Click += new System.EventHandler(this.btnVerAsistencias_Click);
            // 
            // btnEliminarAlumno
            // 
            this.btnEliminarAlumno.BackColor = System.Drawing.Color.Red;
            this.btnEliminarAlumno.Enabled = false;
            this.btnEliminarAlumno.FlatAppearance.BorderSize = 0;
            this.btnEliminarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAlumno.ForeColor = System.Drawing.Color.White;
            this.btnEliminarAlumno.Location = new System.Drawing.Point(760, 626);
            this.btnEliminarAlumno.Name = "btnEliminarAlumno";
            this.btnEliminarAlumno.Size = new System.Drawing.Size(119, 23);
            this.btnEliminarAlumno.TabIndex = 85;
            this.btnEliminarAlumno.Text = "Eliminar Alumno";
            this.btnEliminarAlumno.UseVisualStyleBackColor = false;
            this.btnEliminarAlumno.Click += new System.EventHandler(this.btnEliminarAlumno_Click);
            // 
            // btnAgregarExtemporaneo
            // 
            this.btnAgregarExtemporaneo.BackColor = System.Drawing.Color.Teal;
            this.btnAgregarExtemporaneo.FlatAppearance.BorderSize = 0;
            this.btnAgregarExtemporaneo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarExtemporaneo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarExtemporaneo.ForeColor = System.Drawing.Color.White;
            this.btnAgregarExtemporaneo.Location = new System.Drawing.Point(688, 179);
            this.btnAgregarExtemporaneo.Name = "btnAgregarExtemporaneo";
            this.btnAgregarExtemporaneo.Size = new System.Drawing.Size(179, 44);
            this.btnAgregarExtemporaneo.TabIndex = 84;
            this.btnAgregarExtemporaneo.Text = "AGREGAR ALUMNOS EXTEMPORANEOS";
            this.btnAgregarExtemporaneo.UseVisualStyleBackColor = false;
            this.btnAgregarExtemporaneo.Click += new System.EventHandler(this.btnAgregarExtemporaneo_Click);
            // 
            // txtFin
            // 
            this.txtFin.Location = new System.Drawing.Point(349, 95);
            this.txtFin.Name = "txtFin";
            this.txtFin.ReadOnly = true;
            this.txtFin.Size = new System.Drawing.Size(66, 20);
            this.txtFin.TabIndex = 83;
            // 
            // txtInicio
            // 
            this.txtInicio.Location = new System.Drawing.Point(274, 95);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.ReadOnly = true;
            this.txtInicio.Size = new System.Drawing.Size(66, 20);
            this.txtInicio.TabIndex = 82;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(210, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 81;
            this.label12.Text = "INICIO-FIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "DÍAS";
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(274, 16);
            this.txtDias.Name = "txtDias";
            this.txtDias.ReadOnly = true;
            this.txtDias.Size = new System.Drawing.Size(206, 20);
            this.txtDias.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(21, 189);
            this.label1.Name = "label1";
            this.label1.ReadOnly = true;
            this.label1.Size = new System.Drawing.Size(592, 34);
            this.label1.TabIndex = 78;
            this.label1.Text = "";
            this.label1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // frmVerNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 726);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvwBase);
            this.Controls.Add(this.dgvwUseOfEnglish);
            this.Controls.Add(this.dgvwWriting);
            this.Controls.Add(this.dgvwSpeaking);
            this.Controls.Add(this.dgvwReading);
            this.Controls.Add(this.dgvwListening);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmVerNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VER NOTAS";
            this.Load += new System.EventHandler(this.frmVerNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvwNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwListening)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwReading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwSpeaking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwWriting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwUseOfEnglish)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtHorario2;
        private System.Windows.Forms.TextBox txtSalon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.TextBox txtCiclo;
        private System.Windows.Forms.TextBox txtNivel;
        private System.Windows.Forms.TextBox txtIdioma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoNota;
        private System.Windows.Forms.DataGridView dgvwNotas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvwBase;
        private System.Windows.Forms.DataGridView dgvwListening;
        private System.Windows.Forms.DataGridView dgvwReading;
        private System.Windows.Forms.DataGridView dgvwSpeaking;
        private System.Windows.Forms.DataGridView dgvwWriting;
        private System.Windows.Forms.DataGridView dgvwUseOfEnglish;
        private System.Windows.Forms.Button btnConcluirGrupo;
        private System.Windows.Forms.Button btnRelacionAlumno;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private System.Windows.Forms.TextBox txtDocente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRelacionAlumnos;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.TextBox txtFin;
        private System.Windows.Forms.TextBox txtInicio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAgregarExtemporaneo;
        private System.Windows.Forms.Button btnEliminarAlumno;
        private System.Windows.Forms.Button btnVerAsistencias;
        private System.Windows.Forms.Button btnRecordEconomico;
        private System.Windows.Forms.Button button1;
    }
}