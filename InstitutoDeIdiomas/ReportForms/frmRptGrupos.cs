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
    public partial class frmRptGrupos : MaterialForm
    {
        DataTable dtBasico, dtIntermedio, dtAvanzado;
        string mes;

        private void frmRptGrupos_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("dsGrupoBasico", dtBasico);
            ReportDataSource rds2 = new ReportDataSource("dsGrupoIntermedio", dtIntermedio);
            ReportDataSource rds3 = new ReportDataSource("dsGrupoAvanzado", dtAvanzado);
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pMes",mes)
            };
            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.DataSources.Add(rds2);
            this.reportViewer1.LocalReport.DataSources.Add(rds3);
            this.reportViewer1.RefreshReport();
        }

        public frmRptGrupos(DataTable dtBasico, DataTable dtIntermedio, DataTable dtAvanzado, string mes)
        {
            InitializeComponent();
            this.dtBasico = dtBasico;
            this.dtIntermedio = dtIntermedio;
            this.dtAvanzado = dtAvanzado;
            this.mes = mes;
        }
    }
}
