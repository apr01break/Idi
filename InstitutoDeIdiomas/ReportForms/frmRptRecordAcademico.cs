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
    public partial class frmRptRecordAcademico : MaterialForm
    {
        DataTable dt = new DataTable();
        String numcarnet, nombre, idioma;
        public frmRptRecordAcademico(DataTable dt, String numcarnet, String nombre, String idioma)
        {
            this.dt = dt;
            this.numcarnet = numcarnet;
            this.nombre = nombre;
            this.idioma = idioma;
            InitializeComponent();
        }

        private void frmRptRecordAcademico_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("DataSetRecordAcademico", dt);
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pCodigo",numcarnet),
                new Microsoft.Reporting.WinForms.ReportParameter("pNombre",nombre),
                new Microsoft.Reporting.WinForms.ReportParameter("pIdioma",idioma),
            };
            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
