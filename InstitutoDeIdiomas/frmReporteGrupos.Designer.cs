namespace InstitutoDeIdiomas
{
    partial class frmReporteGrupos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.cbAnho = new System.Windows.Forms.ComboBox();
            this.btnReporte = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "AÑO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "MES";
            // 
            // cbMes
            // 
            this.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Items.AddRange(new object[] {
            "ENERO",
            "FEBRERO",
            "MARZO",
            "ABRIL",
            "MAYO",
            "JUNIO",
            "JULIO",
            "AGOSTO",
            "SETIEMBRE",
            "OCTUBRE",
            "NOVIEMBRE",
            "DICIEMBRE"});
            this.cbMes.Location = new System.Drawing.Point(114, 22);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(80, 21);
            this.cbMes.TabIndex = 2;
            // 
            // cbAnho
            // 
            this.cbAnho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnho.FormattingEnabled = true;
            this.cbAnho.Items.AddRange(new object[] {
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
            this.cbAnho.Location = new System.Drawing.Point(114, 65);
            this.cbAnho.Name = "cbAnho";
            this.cbAnho.Size = new System.Drawing.Size(80, 21);
            this.cbAnho.TabIndex = 3;
            // 
            // btnReporte
            // 
            this.btnReporte.Depth = 0;
            this.btnReporte.Location = new System.Drawing.Point(105, 107);
            this.btnReporte.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Primary = true;
            this.btnReporte.Size = new System.Drawing.Size(79, 24);
            this.btnReporte.TabIndex = 4;
            this.btnReporte.Text = "GRUPOS";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnReporte);
            this.panel1.Controls.Add(this.cbAnho);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbMes);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 150);
            this.panel1.TabIndex = 5;
            // 
            // frmReporteGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 214);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmReporteGrupos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE  DE GRUPOS POR MES";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.ComboBox cbAnho;
        private MaterialSkin.Controls.MaterialRaisedButton btnReporte;
        private System.Windows.Forms.Panel panel1;
    }
}