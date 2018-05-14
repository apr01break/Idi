namespace InstitutoDeIdiomas
{
    partial class frmCrearGrupoExUbicacion
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
            this.cbAno = new System.Windows.Forms.ComboBox();
            this.cbNumero = new System.Windows.Forms.ComboBox();
            this.btnCrearGrupo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbSalon = new System.Windows.Forms.ComboBox();
            this.cmbProfesor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtmHoraFinal = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtmHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbAno);
            this.panel1.Controls.Add(this.cbNumero);
            this.panel1.Controls.Add(this.btnCrearGrupo);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cmbSalon);
            this.panel1.Controls.Add(this.cmbProfesor);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbIdioma);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtFecha);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 222);
            this.panel1.TabIndex = 0;
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
            this.cbAno.Location = new System.Drawing.Point(125, 22);
            this.cbAno.Name = "cbAno";
            this.cbAno.Size = new System.Drawing.Size(66, 21);
            this.cbAno.TabIndex = 104;
            // 
            // cbNumero
            // 
            this.cbNumero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumero.FormattingEnabled = true;
            this.cbNumero.Location = new System.Drawing.Point(65, 22);
            this.cbNumero.Name = "cbNumero";
            this.cbNumero.Size = new System.Drawing.Size(54, 21);
            this.cbNumero.TabIndex = 103;
            // 
            // btnCrearGrupo
            // 
            this.btnCrearGrupo.Depth = 0;
            this.btnCrearGrupo.Location = new System.Drawing.Point(295, 162);
            this.btnCrearGrupo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCrearGrupo.Name = "btnCrearGrupo";
            this.btnCrearGrupo.Primary = true;
            this.btnCrearGrupo.Size = new System.Drawing.Size(121, 34);
            this.btnCrearGrupo.TabIndex = 102;
            this.btnCrearGrupo.Text = "CREAR GRUPO";
            this.btnCrearGrupo.UseVisualStyleBackColor = true;
            this.btnCrearGrupo.Click += new System.EventHandler(this.btnCrearGrupo_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(235, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 101;
            this.label11.Text = "Salón";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 99;
            this.label9.Text = "Número";
            // 
            // cmbSalon
            // 
            this.cmbSalon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalon.FormattingEnabled = true;
            this.cmbSalon.Location = new System.Drawing.Point(295, 59);
            this.cmbSalon.Name = "cmbSalon";
            this.cmbSalon.Size = new System.Drawing.Size(70, 21);
            this.cmbSalon.TabIndex = 96;
            // 
            // cmbProfesor
            // 
            this.cmbProfesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfesor.FormattingEnabled = true;
            this.cmbProfesor.Location = new System.Drawing.Point(22, 170);
            this.cmbProfesor.Name = "cmbProfesor";
            this.cmbProfesor.Size = new System.Drawing.Size(231, 21);
            this.cmbProfesor.TabIndex = 95;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 93;
            this.label7.Text = "Idioma";
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Location = new System.Drawing.Point(293, 22);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(121, 21);
            this.cmbIdioma.TabIndex = 91;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 153);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 90;
            this.label6.Text = "PROFESOR";
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(238, 112);
            this.dtFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(176, 20);
            this.dtFecha.TabIndex = 89;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 88;
            this.label4.Text = "FECHA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtmHoraFinal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtmHoraInicio);
            this.groupBox1.Location = new System.Drawing.Point(20, 61);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(179, 80);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HORARIO";
            // 
            // dtmHoraFinal
            // 
            this.dtmHoraFinal.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dtmHoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtmHoraFinal.Location = new System.Drawing.Point(78, 55);
            this.dtmHoraFinal.Margin = new System.Windows.Forms.Padding(2);
            this.dtmHoraFinal.Name = "dtmHoraFinal";
            this.dtmHoraFinal.ShowUpDown = true;
            this.dtmHoraFinal.Size = new System.Drawing.Size(86, 20);
            this.dtmHoraFinal.TabIndex = 10;
            this.dtmHoraFinal.Value = new System.DateTime(2018, 5, 9, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "HORA FINAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "HORA INICIO";
            // 
            // dtmHoraInicio
            // 
            this.dtmHoraInicio.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dtmHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtmHoraInicio.Location = new System.Drawing.Point(78, 27);
            this.dtmHoraInicio.Margin = new System.Windows.Forms.Padding(2);
            this.dtmHoraInicio.Name = "dtmHoraInicio";
            this.dtmHoraInicio.ShowUpDown = true;
            this.dtmHoraInicio.Size = new System.Drawing.Size(86, 20);
            this.dtmHoraInicio.TabIndex = 8;
            this.dtmHoraInicio.Value = new System.DateTime(2018, 5, 9, 0, 0, 0, 0);
            // 
            // frmCrearGrupoExUbicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 286);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmCrearGrupoExUbicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CREAR GRUPO DE EXAMEN DE UBICACION";
            this.Load += new System.EventHandler(this.frmCrearGrupoExUbicacion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbAno;
        private System.Windows.Forms.ComboBox cbNumero;
        private MaterialSkin.Controls.MaterialRaisedButton btnCrearGrupo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbSalon;
        private System.Windows.Forms.ComboBox cmbProfesor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbIdioma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtmHoraFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtmHoraInicio;
    }
}