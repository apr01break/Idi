namespace InstitutoDeIdiomas
{
    partial class frmVerAsistencia
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
            this.cbFechas = new System.Windows.Forms.ComboBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnReporteAsistencia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnReporteAsistencia);
            this.panel1.Controls.Add(this.btnBorrar);
            this.panel1.Controls.Add(this.cbFechas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 167);
            this.panel1.TabIndex = 0;
            // 
            // cbFechas
            // 
            this.cbFechas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFechas.FormattingEnabled = true;
            this.cbFechas.Location = new System.Drawing.Point(35, 50);
            this.cbFechas.Name = "cbFechas";
            this.cbFechas.Size = new System.Drawing.Size(189, 21);
            this.cbFechas.TabIndex = 0;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(255, 48);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(105, 23);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.Text = "Borrar Asistencia";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnReporteAsistencia
            // 
            this.btnReporteAsistencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnReporteAsistencia.FlatAppearance.BorderSize = 0;
            this.btnReporteAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteAsistencia.ForeColor = System.Drawing.Color.White;
            this.btnReporteAsistencia.Location = new System.Drawing.Point(109, 106);
            this.btnReporteAsistencia.Name = "btnReporteAsistencia";
            this.btnReporteAsistencia.Size = new System.Drawing.Size(189, 37);
            this.btnReporteAsistencia.TabIndex = 2;
            this.btnReporteAsistencia.Text = "REPORTE ASISTENCIAS";
            this.btnReporteAsistencia.UseVisualStyleBackColor = false;
            this.btnReporteAsistencia.Click += new System.EventHandler(this.btnReporteAsistencia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione fecha a eliminar";
            // 
            // frmVerAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 231);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmVerAsistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VER ASISTENCIAS";
            this.Load += new System.EventHandler(this.frmVerAsistencia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReporteAsistencia;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ComboBox cbFechas;
        private System.Windows.Forms.Label label1;
    }
}