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
        DataTable dtLeyenda;
        DataTable alumno;
        DataTable dtsaldo;
        string usuario;
        public frmRptListaDePagos(DataTable dt,DataTable dtal, string usuario, DataTable dtLeyenda, DataTable dtSaldo)
        {
            InitializeComponent();
            tabledata = dt;
            alumno = dtal;
            this.dtLeyenda = dtLeyenda;
            this.usuario = usuario;
            this.dtsaldo = dtSaldo;
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
            ReportDataSource rds2 = new ReportDataSource("dsLeyenda", dtLeyenda);
            ReportDataSource rds3 = new ReportDataSource("dsSaldo", dtsaldo);
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pUsuario",usuario)
            };
            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
            this.reportViewer1.LocalReport.DataSources.Add(rds2);
            this.reportViewer1.LocalReport.DataSources.Add(rds3);
            this.reportViewer1.RefreshReport();
        }
    }
}
