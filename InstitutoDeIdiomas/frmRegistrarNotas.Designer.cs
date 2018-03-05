namespace InstitutoDeIdiomas
{
    partial class frmRegistrarNotas
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.cbFechas = new System.Windows.Forms.ComboBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.dgvwAlumnos = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCiclo = new System.Windows.Forms.TextBox();
            this.txtHoraFinal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarCriterio = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipoNota = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCriterio = new System.Windows.Forms.TextBox();
            this.txtIdioma = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtInicioCurso = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSalon = new System.Windows.Forms.TextBox();
            this.txtHoraInicio = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFinSpeaking = new System.Windows.Forms.Button();
            this.btnFinReading = new System.Windows.Forms.Button();
            this.btnFinWriting = new System.Windows.Forms.Button();
            this.btnFinListening = new System.Windows.Forms.Button();
            this.btnFinUseOfEnglish = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtDias);
            this.panel2.Controls.Add(this.cbFechas);
            this.panel2.Controls.Add(this.txtNumero);
            this.panel2.Controls.Add(this.dgvwAlumnos);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtCiclo);
            this.panel2.Controls.Add(this.txtHoraFinal);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnAgregarCriterio);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cmbTipoNota);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtCriterio);
            this.panel2.Controls.Add(this.txtIdioma);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.txtNivel);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtInicioCurso);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtSalon);
            this.panel2.Controls.Add(this.txtHoraInicio);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btnFinSpeaking);
            this.panel2.Controls.Add(this.btnFinReading);
            this.panel2.Controls.Add(this.btnFinWriting);
            this.panel2.Controls.Add(this.btnFinListening);
            this.panel2.Controls.Add(this.btnFinUseOfEnglish);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(814, 618);
            this.panel2.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(558, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "DÍAS";
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(606, 126);
            this.txtDias.Name = "txtDias";
            this.txtDias.ReadOnly = true;
            this.txtDias.Size = new System.Drawing.Size(183, 20);
            this.txtDias.TabIndex = 42;
            // 
            // cbFechas
            // 
            this.cbFechas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFechas.FormattingEnabled = true;
            this.cbFechas.Location = new System.Drawing.Point(50, 79);
            this.cbFechas.Name = "cbFechas";
            this.cbFechas.Size = new System.Drawing.Size(170, 21);
            this.cbFechas.TabIndex = 0;
            this.cbFechas.TextChanged += new System.EventHandler(this.cbFechas_TextChanged);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(105, 27);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(137, 20);
            this.txtNumero.TabIndex = 35;
            // 
            // dgvwAlumnos
            // 
            this.dgvwAlumnos.AllowUserToAddRows = false;
            this.dgvwAlumnos.AllowUserToDeleteRows = false;
            this.dgvwAlumnos.AllowUserToResizeRows = false;
            this.dgvwAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvwAlumnos.Location = new System.Drawing.Point(19, 229);
            this.dgvwAlumnos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvwAlumnos.Name = "dgvwAlumnos";
            this.dgvwAlumnos.RowHeadersVisible = false;
            this.dgvwAlumnos.RowTemplate.Height = 24;
            this.dgvwAlumnos.Size = new System.Drawing.Size(532, 315);
            this.dgvwAlumnos.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 31);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "NUMERO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(555, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "SALON";
            // 
            // txtCiclo
            // 
            this.txtCiclo.Location = new System.Drawing.Point(626, 27);
            this.txtCiclo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCiclo.Name = "txtCiclo";
            this.txtCiclo.ReadOnly = true;
            this.txtCiclo.Size = new System.Drawing.Size(163, 20);
            this.txtCiclo.TabIndex = 26;
            // 
            // txtHoraFinal
            // 
            this.txtHoraFinal.Location = new System.Drawing.Point(719, 80);
            this.txtHoraFinal.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoraFinal.Name = "txtHoraFinal";
            this.txtHoraFinal.ReadOnly = true;
            this.txtHoraFinal.Size = new System.Drawing.Size(70, 20);
            this.txtHoraFinal.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(701, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "--";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CURSO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NIVEL";
            // 
            // btnAgregarCriterio
            // 
            this.btnAgregarCriterio.Enabled = false;
            this.btnAgregarCriterio.Location = new System.Drawing.Point(468, 180);
            this.btnAgregarCriterio.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarCriterio.Name = "btnAgregarCriterio";
            this.btnAgregarCriterio.Size = new System.Drawing.Size(115, 32);
            this.btnAgregarCriterio.TabIndex = 21;
            this.btnAgregarCriterio.Text = "AÑADIR CRITERIO";
            this.btnAgregarCriterio.UseVisualStyleBackColor = true;
            this.btnAgregarCriterio.Click += new System.EventHandler(this.btnAgregarCriterio_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "INICIO DEL CURSO";
            // 
            // cmbTipoNota
            // 
            this.cmbTipoNota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoNota.Enabled = false;
            this.cmbTipoNota.FormattingEnabled = true;
            this.cmbTipoNota.Items.AddRange(new object[] {
            "USE OF ENGLISH",
            "READING",
            "WRITING",
            "LISTENING",
            "SPEAKING"});
            this.cmbTipoNota.Location = new System.Drawing.Point(19, 180);
            this.cmbTipoNota.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoNota.Name = "cmbTipoNota";
            this.cmbTipoNota.Size = new System.Drawing.Size(135, 21);
            this.cmbTipoNota.TabIndex = 16;
            this.cmbTipoNota.TextChanged += new System.EventHandler(this.cmbTipoNota_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(556, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CICLO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(556, 83);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "HORARIO";
            // 
            // txtCriterio
            // 
            this.txtCriterio.Enabled = false;
            this.txtCriterio.Location = new System.Drawing.Point(164, 180);
            this.txtCriterio.Margin = new System.Windows.Forms.Padding(2);
            this.txtCriterio.Multiline = true;
            this.txtCriterio.Name = "txtCriterio";
            this.txtCriterio.Size = new System.Drawing.Size(283, 32);
            this.txtCriterio.TabIndex = 15;
            // 
            // txtIdioma
            // 
            this.txtIdioma.Location = new System.Drawing.Point(380, 27);
            this.txtIdioma.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdioma.Name = "txtIdioma";
            this.txtIdioma.ReadOnly = true;
            this.txtIdioma.Size = new System.Drawing.Size(144, 20);
            this.txtIdioma.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(17, 151);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(133, 16);
            this.label17.TabIndex = 14;
            this.label17.Text = "Seleccione el criterio";
            // 
            // txtNivel
            // 
            this.txtNivel.Location = new System.Drawing.Point(380, 53);
            this.txtNivel.Margin = new System.Windows.Forms.Padding(2);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.ReadOnly = true;
            this.txtNivel.Size = new System.Drawing.Size(144, 20);
            this.txtNivel.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(20, 57);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(237, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "SELECCIONE FECHA DE CLASE ";
            // 
            // txtInicioCurso
            // 
            this.txtInicioCurso.Location = new System.Drawing.Point(380, 79);
            this.txtInicioCurso.Margin = new System.Windows.Forms.Padding(2);
            this.txtInicioCurso.Name = "txtInicioCurso";
            this.txtInicioCurso.ReadOnly = true;
            this.txtInicioCurso.Size = new System.Drawing.Size(144, 20);
            this.txtInicioCurso.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(252, 126);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "NOTAS";
            // 
            // txtSalon
            // 
            this.txtSalon.Location = new System.Drawing.Point(626, 54);
            this.txtSalon.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalon.Name = "txtSalon";
            this.txtSalon.ReadOnly = true;
            this.txtSalon.Size = new System.Drawing.Size(163, 20);
            this.txtSalon.TabIndex = 10;
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.Location = new System.Drawing.Point(626, 80);
            this.txtHoraInicio.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.ReadOnly = true;
            this.txtHoraInicio.Size = new System.Drawing.Size(70, 20);
            this.txtHoraInicio.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(14, 108);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 10);
            this.panel1.TabIndex = 13;
            // 
            // btnFinSpeaking
            // 
            this.btnFinSpeaking.Location = new System.Drawing.Point(19, 560);
            this.btnFinSpeaking.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinSpeaking.Name = "btnFinSpeaking";
            this.btnFinSpeaking.Size = new System.Drawing.Size(532, 48);
            this.btnFinSpeaking.TabIndex = 28;
            this.btnFinSpeaking.Text = "GUARDAR NOTAS SPEAKING";
            this.btnFinSpeaking.UseVisualStyleBackColor = true;
            this.btnFinSpeaking.Visible = false;
            this.btnFinSpeaking.Click += new System.EventHandler(this.btnFinSpeaking_Click);
            // 
            // btnFinReading
            // 
            this.btnFinReading.Location = new System.Drawing.Point(19, 560);
            this.btnFinReading.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinReading.Name = "btnFinReading";
            this.btnFinReading.Size = new System.Drawing.Size(532, 48);
            this.btnFinReading.TabIndex = 29;
            this.btnFinReading.Text = "GUARDAR NOTAS READING";
            this.btnFinReading.UseVisualStyleBackColor = true;
            this.btnFinReading.Visible = false;
            this.btnFinReading.Click += new System.EventHandler(this.btnFinReading_Click);
            // 
            // btnFinWriting
            // 
            this.btnFinWriting.Location = new System.Drawing.Point(19, 560);
            this.btnFinWriting.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinWriting.Name = "btnFinWriting";
            this.btnFinWriting.Size = new System.Drawing.Size(532, 48);
            this.btnFinWriting.TabIndex = 30;
            this.btnFinWriting.Text = "GUARDAR NOTAS WRITING";
            this.btnFinWriting.UseVisualStyleBackColor = true;
            this.btnFinWriting.Visible = false;
            this.btnFinWriting.Click += new System.EventHandler(this.btnFinWriting_Click);
            // 
            // btnFinListening
            // 
            this.btnFinListening.Location = new System.Drawing.Point(19, 560);
            this.btnFinListening.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinListening.Name = "btnFinListening";
            this.btnFinListening.Size = new System.Drawing.Size(532, 48);
            this.btnFinListening.TabIndex = 31;
            this.btnFinListening.Text = "GUARDAR NOTAS LISTENING";
            this.btnFinListening.UseVisualStyleBackColor = true;
            this.btnFinListening.Visible = false;
            this.btnFinListening.Click += new System.EventHandler(this.btnFinListening_Click);
            // 
            // btnFinUseOfEnglish
            // 
            this.btnFinUseOfEnglish.Location = new System.Drawing.Point(19, 560);
            this.btnFinUseOfEnglish.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinUseOfEnglish.Name = "btnFinUseOfEnglish";
            this.btnFinUseOfEnglish.Size = new System.Drawing.Size(532, 48);
            this.btnFinUseOfEnglish.TabIndex = 32;
            this.btnFinUseOfEnglish.Text = "GUARDAR NOTAS USE OF ENGLISH";
            this.btnFinUseOfEnglish.UseVisualStyleBackColor = true;
            this.btnFinUseOfEnglish.Visible = false;
            this.btnFinUseOfEnglish.Click += new System.EventHandler(this.btnFinUseOfEnglish_Click);
            // 
            // frmRegistrarNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 682);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "frmRegistrarNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRAR NOTAS";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.DataGridView dgvwAlumnos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCiclo;
        private System.Windows.Forms.TextBox txtHoraFinal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregarCriterio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipoNota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCriterio;
        private System.Windows.Forms.TextBox txtIdioma;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtNivel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtInicioCurso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSalon;
        private System.Windows.Forms.TextBox txtHoraInicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFinSpeaking;
        private System.Windows.Forms.Button btnFinReading;
        private System.Windows.Forms.Button btnFinWriting;
        private System.Windows.Forms.Button btnFinListening;
        private System.Windows.Forms.Button btnFinUseOfEnglish;
        private System.Windows.Forms.ComboBox cbFechas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDias;
    }
}