namespace InstitutoDeIdiomas
{
    partial class frmCrearGrupo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrearGrupo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbAno = new System.Windows.Forms.ComboBox();
            this.cbNumero = new System.Windows.Forms.ComboBox();
            this.btnCrearGrupo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSalon = new System.Windows.Forms.ComboBox();
            this.cmbProfesor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbNivel = new System.Windows.Forms.ComboBox();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtmHoraFinal = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clbHorario = new System.Windows.Forms.CheckedListBox();
            this.dtmHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.numCiclo = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCiclo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbAno);
            this.panel1.Controls.Add(this.cbNumero);
            this.panel1.Controls.Add(this.btnCrearGrupo);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dtFechaFinal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbSalon);
            this.panel1.Controls.Add(this.cmbProfesor);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbNivel);
            this.panel1.Controls.Add(this.cmbIdioma);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtFechaInicio);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.numCiclo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 294);
            this.panel1.TabIndex = 63;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbAno
            // 
            this.cbAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAno.FormattingEnabled = true;
            this.cbAno.Items.AddRange(new object[] {
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026"});
            this.cbAno.Location = new System.Drawing.Point(122, 18);
            this.cbAno.Name = "cbAno";
            this.cbAno.Size = new System.Drawing.Size(66, 21);
            this.cbAno.TabIndex = 85;
            // 
            // cbNumero
            // 
            this.cbNumero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumero.FormattingEnabled = true;
            this.cbNumero.Location = new System.Drawing.Point(62, 18);
            this.cbNumero.Name = "cbNumero";
            this.cbNumero.Size = new System.Drawing.Size(54, 21);
            this.cbNumero.TabIndex = 83;
            // 
            // btnCrearGrupo
            // 
            this.btnCrearGrupo.Depth = 0;
            this.btnCrearGrupo.Location = new System.Drawing.Point(301, 240);
            this.btnCrearGrupo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCrearGrupo.Name = "btnCrearGrupo";
            this.btnCrearGrupo.Primary = true;
            this.btnCrearGrupo.Size = new System.Drawing.Size(121, 34);
            this.btnCrearGrupo.TabIndex = 81;
            this.btnCrearGrupo.Text = "CREAR GRUPO";
            this.btnCrearGrupo.UseVisualStyleBackColor = true;
            this.btnCrearGrupo.Click += new System.EventHandler(this.btnCrearGrupo_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(326, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 79;
            this.label11.Text = "Salón";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(219, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 78;
            this.label10.Text = "Ciclo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 77;
            this.label9.Text = "Número";
            // 
            // dtFechaFinal
            // 
            this.dtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFinal.Location = new System.Drawing.Point(221, 163);
            this.dtFechaFinal.Margin = new System.Windows.Forms.Padding(2);
            this.dtFechaFinal.Name = "dtFechaFinal";
            this.dtFechaFinal.Size = new System.Drawing.Size(201, 20);
            this.dtFechaFinal.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "FECHA FINAL";
            // 
            // cmbSalon
            // 
            this.cmbSalon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalon.FormattingEnabled = true;
            this.cmbSalon.Location = new System.Drawing.Point(372, 58);
            this.cmbSalon.Name = "cmbSalon";
            this.cmbSalon.Size = new System.Drawing.Size(50, 21);
            this.cmbSalon.TabIndex = 74;
            // 
            // cmbProfesor
            // 
            this.cmbProfesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfesor.FormattingEnabled = true;
            this.cmbProfesor.Location = new System.Drawing.Point(221, 206);
            this.cmbProfesor.Name = "cmbProfesor";
            this.cmbProfesor.Size = new System.Drawing.Size(201, 21);
            this.cmbProfesor.TabIndex = 73;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 72;
            this.label8.Text = "Nivel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(243, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 71;
            this.label7.Text = "Idioma";
            // 
            // cmbNivel
            // 
            this.cmbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNivel.FormattingEnabled = true;
            this.cmbNivel.Location = new System.Drawing.Point(53, 58);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.Size = new System.Drawing.Size(121, 21);
            this.cmbNivel.TabIndex = 70;
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Location = new System.Drawing.Point(301, 18);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(121, 21);
            this.cmbIdioma.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 190);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 67;
            this.label6.Text = "PROFESOR";
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaInicio.Location = new System.Drawing.Point(221, 116);
            this.dtFechaInicio.Margin = new System.Windows.Forms.Padding(2);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(201, 20);
            this.dtFechaInicio.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 65;
            this.label4.Text = "FECHA DE INICIO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtmHoraFinal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.clbHorario);
            this.groupBox1.Controls.Add(this.dtmHoraInicio);
            this.groupBox1.Location = new System.Drawing.Point(24, 88);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(179, 192);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HORARIO";
            // 
            // dtmHoraFinal
            // 
            this.dtmHoraFinal.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dtmHoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtmHoraFinal.Location = new System.Drawing.Point(78, 159);
            this.dtmHoraFinal.Margin = new System.Windows.Forms.Padding(2);
            this.dtmHoraFinal.Name = "dtmHoraFinal";
            this.dtmHoraFinal.ShowUpDown = true;
            this.dtmHoraFinal.Size = new System.Drawing.Size(86, 20);
            this.dtmHoraFinal.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 163);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "HORA FINAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "HORA INICIO";
            // 
            // clbHorario
            // 
            this.clbHorario.BackColor = System.Drawing.SystemColors.Menu;
            this.clbHorario.FormattingEnabled = true;
            this.clbHorario.Location = new System.Drawing.Point(5, 18);
            this.clbHorario.Name = "clbHorario";
            this.clbHorario.Size = new System.Drawing.Size(170, 109);
            this.clbHorario.TabIndex = 0;
            // 
            // dtmHoraInicio
            // 
            this.dtmHoraInicio.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dtmHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtmHoraInicio.Location = new System.Drawing.Point(78, 131);
            this.dtmHoraInicio.Margin = new System.Windows.Forms.Padding(2);
            this.dtmHoraInicio.Name = "dtmHoraInicio";
            this.dtmHoraInicio.ShowUpDown = true;
            this.dtmHoraInicio.Size = new System.Drawing.Size(86, 20);
            this.dtmHoraInicio.TabIndex = 8;
            // 
            // numCiclo
            // 
            this.numCiclo.Location = new System.Drawing.Point(256, 59);
            this.numCiclo.Margin = new System.Windows.Forms.Padding(2);
            this.numCiclo.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numCiclo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCiclo.Name = "numCiclo";
            this.numCiclo.Size = new System.Drawing.Size(48, 20);
            this.numCiclo.TabIndex = 63;
            this.numCiclo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmCrearGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 357);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCrearGrupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CREAR GRUPO DE ESTUDIOS";
            this.Load += new System.EventHandler(this.frmCrearGrupo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCiclo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtFechaFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSalon;
        private System.Windows.Forms.ComboBox cmbProfesor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbNivel;
        private System.Windows.Forms.ComboBox cmbIdioma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtmHoraFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox clbHorario;
        private System.Windows.Forms.DateTimePicker dtmHoraInicio;
        private System.Windows.Forms.NumericUpDown numCiclo;
        private MaterialSkin.Controls.MaterialRaisedButton btnCrearGrupo;
        private System.Windows.Forms.ComboBox cbNumero;
        private System.Windows.Forms.ComboBox cbAno;
    }
}