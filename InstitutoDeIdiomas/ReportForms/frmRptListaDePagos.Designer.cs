namespace InstitutoDeIdiomas.ReportForms
{
    partial class frmRptListaDePagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRptListaDePagos));
            this.dsListaDePagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsListaDePagos = new InstitutoDeIdiomas.DataSetsIdiomas.dsListaDePagos();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dsListaDePagosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListaDePagos)).BeginInit();
            this.SuspendLayout();
            // 
            // dsListaDePagosBindingSource
            // 
            this.dsListaDePagosBindingSource.DataSource = this.dsListaDePagos;
            this.dsListaDePagosBindingSource.Position = 0;
            // 
            // dsListaDePagos
            // 
            this.dsListaDePagos.DataSetName = "dsListaDePagos";
            this.dsListaDePagos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "InstitutoDeIdiomas.Reportes.rptListaDePagos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 64);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(724, 552);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmRptListaDePagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 616);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRptListaDePagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE DE LISTA DE PAGOS";
            this.Load += new System.EventHandler(this.frmRptListaDePagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsListaDePagosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListaDePagos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dsListaDePagosBindingSource;
        private DataSetsIdiomas.dsListaDePagos dsListaDePagos;
    }
}