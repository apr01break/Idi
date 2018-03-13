using MaterialSkin.Controls;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstitutoDeIdiomas.ReportForms
{
    public partial class frmRptAsistenciaGrupo : MaterialForm
    {
        DataTable dt = new DataTable();
        String ano, idioma, ciclo, docente, mes, nivel, numero;
        public frmRptAsistenciaGrupo(DataTable dt,String ano, String idioma, String ciclo, String docente, String mes, String nivel, String numero)
        {
            InitializeComponent();
            this.dt = dt;
            this.ano = ano;
            this.idioma = idioma;
            this.ciclo = ciclo;
            this.docente = docente;
            this.mes = mes;
            this.nivel = nivel;
            this.numero = Path.GetFileNameWithoutExtension(numero).Remove(4, 3);
        }

        private void frmRptAsistenciaGrupo_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("dsAsistenciaGrupo", dt);
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pAno",ano),
                new Microsoft.Reporting.WinForms.ReportParameter("pIdioma",idioma),
                new Microsoft.Reporting.WinForms.ReportParameter("pCiclo",ciclo),
                new Microsoft.Reporting.WinForms.ReportParameter("pDocente",docente),
                new Microsoft.Reporting.WinForms.ReportParameter("pMes",mes),
                new Microsoft.Reporting.WinForms.ReportParameter("pNivel",nivel),
                new Microsoft.Reporting.WinForms.ReportParameter("pNumero",numero)
            };
            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
