﻿namespace InstitutoDeIdiomas.ReportForms
{
    partial class frmRptActaFinal
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRptActaFinal));
            this.dataSetActaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetActa = new InstitutoDeIdiomas.DataSetsIdiomas.DataSetActa();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetActaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetActa)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetActaBindingSource
            // 
            this.dataSetActaBindingSource.DataSource = this.dataSetActa;
            this.dataSetActaBindingSource.Position = 0;
            // 
            // dataSetActa
            // 
            this.dataSetActa.DataSetName = "DataSetActa";
            this.dataSetActa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "dsActa";
            reportDataSource1.Value = this.dataSetActaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "InstitutoDeIdiomas.Reportes.rptActa.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 64);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(868, 635);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // frmRptActaFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 699);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmRptActaFinal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE DE ACTA FINAL";
            this.Load += new System.EventHandler(this.frmRptActaFinal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetActaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetActa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataSetActaBindingSource;
        private DataSetsIdiomas.DataSetActa dataSetActa;
    }
}