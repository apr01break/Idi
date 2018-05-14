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
    public partial class frmRptActaNotas : MaterialForm
    {
        DataTable dtListening,dtReading,dtWriting,dtSpeaking,dtUseOfEnglish, dtAlumnos, dtPromedios;
        string idioma, nivel, ciclo, ano, mes, docente, numero, inicio, fin, horaInicio, horaFin, dias;
        public frmRptActaNotas(DataTable dtListening, DataTable dtReading, DataTable dtWriting,
            DataTable dtSpeaking, DataTable dtUseOfEnglish, DataTable dtAlumnos, DataTable dtPromedios,
            string idioma, string nivel, string ciclo, string ano, string mes, string docente,
            string numero, string inicio, string fin, string horaInicio, string horaFin, string dias)
        {
            InitializeComponent();
            this.dtListening = dtListening;
            this.dtReading = dtReading;
            this.dtWriting = dtWriting;
            this.dtSpeaking = dtSpeaking;
            this.dtUseOfEnglish = dtUseOfEnglish;
            this.dtAlumnos = dtAlumnos;
            this.dtPromedios = dtPromedios;
            this.idioma = idioma;
            this.nivel = nivel;
            this.ciclo = ciclo;
            this.ano = ano;
            this.mes = mes;
            this.docente = docente;
            this.numero = numero;
            this.inicio = inicio;
            this.fin = fin;
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;
            this.dias = dias;
        }

        private void frmRptActaNotas_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("dsListening", dtListening);
            ReportDataSource rds2 = new ReportDataSource("dsReading", dtReading);
            ReportDataSource rds3 = new ReportDataSource("dsWriting", dtWriting);
            ReportDataSource rds4 = new ReportDataSource("dsSpeaking", dtSpeaking);
            ReportDataSource rds5 = new ReportDataSource("dsUseOfEnglish", dtUseOfEnglish);
            ReportDataSource rds6 = new ReportDataSource("dsAlumnos", dtAlumnos);
            ReportDataSource rds7 = new ReportDataSource("dsPromedios", dtPromedios);
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pIdioma",idioma),
                new Microsoft.Reporting.WinForms.ReportParameter("pNivel",nivel),
                new Microsoft.Reporting.WinForms.ReportParameter("pCiclo",ciclo),
                new Microsoft.Reporting.WinForms.ReportParameter("pAno",ano),
                new Microsoft.Reporting.WinForms.ReportParameter("pMes",mes),
                new Microsoft.Reporting.WinForms.ReportParameter("pDocente",docente),
                new Microsoft.Reporting.WinForms.ReportParameter("pNumero",numero),
                new Microsoft.Reporting.WinForms.ReportParameter("pInicio",inicio),
                new Microsoft.Reporting.WinForms.ReportParameter("pFin",fin),
                new Microsoft.Reporting.WinForms.ReportParameter("pHoraInicio",horaInicio),
                new Microsoft.Reporting.WinForms.ReportParameter("pHoraFin",horaFin),
                new Microsoft.Reporting.WinForms.ReportParameter("pDias",dias),
           };
            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.DataSources.Add(rds2);
            this.reportViewer1.LocalReport.DataSources.Add(rds3);
            this.reportViewer1.LocalReport.DataSources.Add(rds4);
            this.reportViewer1.LocalReport.DataSources.Add(rds5);
            this.reportViewer1.LocalReport.DataSources.Add(rds6);
            this.reportViewer1.LocalReport.DataSources.Add(rds7);
            this.reportViewer1.RefreshReport();
        }
    }
}
