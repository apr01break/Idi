using MaterialSkin.Controls;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstitutoDeIdiomas.ReportForms
{
    public partial class frmRptEstadisticas : MaterialForm
    {
        DataTable dt;
        string extra, anho;
        public frmRptEstadisticas( DataTable dt, string extra, string anho)
        {
            InitializeComponent();
            this.dt = dt;
            this.extra = extra;
            this.anho = anho;
        }

        private void frmRptEstadisticas_Load(object sender, EventArgs e)
        {
            ReportDataSource rds2 = new ReportDataSource("dsEstadistica", dt);
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pExtra",extra),
                new Microsoft.Reporting.WinForms.ReportParameter("pAnho",anho)
            };
            this.reportViewer1.LocalReport.SetParameters(para);

            this.reportViewer1.LocalReport.DataSources.Add(rds2);
            this.reportViewer1.RefreshReport();
        }
    }
}
