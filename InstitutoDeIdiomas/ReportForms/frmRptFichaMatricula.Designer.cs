namespace InstitutoDeIdiomas.ReportForms
{
    partial class frmRptFichaMatricula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRptFichaMatricula));
            this.FICHAMATRICULARPT = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // FICHAMATRICULARPT
            // 
            this.FICHAMATRICULARPT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FICHAMATRICULARPT.LocalReport.ReportEmbeddedResource = "InstitutoDeIdiomas.Reportes.rptFichaDeMatricula.rdlc";
            this.FICHAMATRICULARPT.Location = new System.Drawing.Point(0, 64);
            this.FICHAMATRICULARPT.Margin = new System.Windows.Forms.Padding(2);
            this.FICHAMATRICULARPT.Name = "FICHAMATRICULARPT";
            this.FICHAMATRICULARPT.ServerReport.BearerToken = null;
            this.FICHAMATRICULARPT.Size = new System.Drawing.Size(740, 591);
            this.FICHAMATRICULARPT.TabIndex = 0;
            // 
            // frmRptFichaMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 655);
            this.Controls.Add(this.FICHAMATRICULARPT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRptFichaMatricula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE DE FICHA DE MATRICULA";
            this.Load += new System.EventHandler(this.frmRptFichaMatricula_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer FICHAMATRICULARPT;
    }
}