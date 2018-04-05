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
    public partial class frmRptListaDePagos : MaterialForm
    {
        DataTable tabledata;
        DataTable alumno;
        DataTable dtResumen;
        string usuario;
        public frmRptListaDePagos(DataTable dt,DataTable dtal, DataTable dtResumen, string usuario)
        {
            InitializeComponent();
            tabledata = dt;
            alumno = dtal;
            this.dtResumen = dtResumen;
            this.usuario = usuario;
        }

        private void frmRptListaDePagos_Load(object sender, EventArgs e)
        {
            //DataTable xd = new DataTable();
            //xd.Columns.Add("Wan");
            //xd.Columns.Add("MontoTotal");
            //DataRow r = xd.NewRow();
            //r[0] = "Matri";
            //r[1] = "120";
            //xd.Rows.Add(r);
            ReportDataSource rds = new ReportDataSource("dsListado",tabledata);
            ReportDataSource rds1 = new ReportDataSource("dsAlumno", alumno);
            ReportDataSource rds2 = new ReportDataSource("dsResumen", dtResumen);
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pUsuario",usuario)
            };
            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
            this.reportViewer1.LocalReport.DataSources.Add(rds2);
            this.reportViewer1.RefreshReport();
        }
    }
}
