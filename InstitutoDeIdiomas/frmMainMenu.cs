using InstitutoDeIdiomas.ReportForms;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstitutoDeIdiomas
{
    public partial class frmMainMenu : Form
    {
        String idCodigo;
        String nombreUsuario;
        public frmMainMenu(String id, String nombre, String tipoTrabajador)
        {
            InitializeComponent();            
            txtUser.Text = nombre;
            txtUser.SelectionAlignment = HorizontalAlignment.Center;
            txtMain.SelectionAlignment = HorizontalAlignment.Center;
            TXTCODUSER.Text = id;
            idCodigo = id;
            nombreUsuario = nombre;
            verificarTrabajador(tipoTrabajador);
        }

        private void verificarTrabajador(String tipoTrabajador)
        {
            if(tipoTrabajador == "SECRETARIA PRINCIPAL" || tipoTrabajador =="ADMINISTRADOR")
            {
                lblCorregirPago.Visible = true;
                btnCorregirPago.Visible = true;
            }
        }

        private void REGISTRARMENU_Click(object sender, EventArgs e)
        {
            new frmRegistrarAlumnos(idCodigo).Show();
        }

        private void REGISTRARPAGOMENU_Click(object sender, EventArgs e)
        {
            new frmCrearPago(idCodigo).Show();
        }

        private void CONSULTARMENU_Click(object sender, EventArgs e)
        {
            new frmConsultarAlumno(idCodigo).Show();
        }

        private void GENERALCONSMENU_Click(object sender, EventArgs e)
        {
            new frmConsultarPago().Show();
        }

        private void cREARPAGOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new Form1().Show();
        }

        private void crearGrupo_Click(object sender, EventArgs e)
        {
            new frmCrearGrupo().Show();
        }

        private void agregarAlumnosAGrupo_Click(object sender, EventArgs e)
        {
            new frmVerGrupoAgregarAlumno(1).Show();
        }

        private void cREARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRegistrar forma = new frmRegistrar();
            forma.Show();
        }
        

        private void verGrupo_Click(object sender, EventArgs e)
        {
            new frmVerGrupoAgregarAlumno(2).Show();
        }

        private void FICHAMATRICULATOOL_Click(object sender, EventArgs e)
        {
            new frmGenerarFichaMatricula().Show();
        }

        private void DEUDORESCONSMENU_Click(object sender, EventArgs e)
        {
            new frmConsultarDeudores().Show();
        }

        private void REPORTEMENUTOOL_Click(object sender, EventArgs e)
        {
            new frmRptReporte().Show();
        }

        private void ACTUALIZAROPTIONMENU_Click(object sender, EventArgs e)
        {
            new frmActualizarAlumno().Show();
        }

        private void rECORDACADEMICOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmRecordAcademico().Show();
        }

        private void cORREGIRPAGOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmCorregirPago().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
        private void ocultarPaneles()
        {
            panelPago.Visible = false;
            panelGrupos.Visible = false;
            panelReportes.Visible = false;
            panelUsuario.Visible = false;
            panelAlumno.Visible = false;
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnAlumnos.Height;
            sidePanel.Top = btnAlumnos.Top;
            ocultarPaneles();
            panelAlumno.Visible = true;
            txtMain.Text = "ALUMNOS";
            txtMain.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnPagos.Height;
            sidePanel.Top = btnPagos.Top;
            ocultarPaneles();
            panelPago.Visible = true;
            txtMain.Text = "PAGOS";
            txtMain.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btnGrupos_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnGrupos.Height;
            sidePanel.Top = btnGrupos.Top;
            ocultarPaneles();
            panelGrupos.Visible = true;
            txtMain.Text = "GRUPOS";
            txtMain.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnUsuarios.Height;
            sidePanel.Top = btnUsuarios.Top;
            ocultarPaneles();
            panelUsuario.Visible = true;
            txtMain.Text = "USUARIOS";
            txtMain.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnReportes.Height;
            sidePanel.Top = btnReportes.Top;
            ocultarPaneles();
            panelReportes.Visible = true;
            txtMain.Text = "REPORTES";
            txtMain.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            panelAlumno.Visible = true;
        }
        
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            new frmRegistrarAlumnos(idCodigo).Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            new frmConsultarAlumno(idCodigo).Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            new frmActualizarAlumno().Show();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            new frmRecordAcademico().Show();
        }
        


        private void panelPago_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            new frmCrearPago(idCodigo).Show();
        }

        private void btnConsultaEspecificaPago_Click_1(object sender, EventArgs e)
        {
            new frmConsultarPago().Show();
        }

        private void btnConsultaGeneralPago_Click_1(object sender, EventArgs e)
        {
            new frmConsultarDeudores().Show();
        }

        private void btnCorregirPago_Click_1(object sender, EventArgs e)
        {
            new frmCorregirPago().Show();
        }

        private void btnCrearGrupo_Click_1(object sender, EventArgs e)
        {
            new frmCrearGrupo().Show();
        }

        private void btnGruposEmpezados_Click_1(object sender, EventArgs e)
        {
            new frmVerGrupoAgregarAlumno(2).Show();
        }

        private void btnAsignarAlumnosGrupo_Click_1(object sender, EventArgs e)
        {
            new frmVerGrupoAgregarAlumno(1).Show();
        }

        private void btnNuevoUsuario_Click_1(object sender, EventArgs e)
        {
            new frmRegistrar().Show();
        }

        private void btnFichaMatricula_Click(object sender, EventArgs e)
        {
            new frmGenerarFichaMatricula().Show();
        }
        

        private void btnNuevoUsuario_Click_3(object sender, EventArgs e)
        {
            new frmRegistrar().Show();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAsistenciaGrupoReportes_Click(object sender, EventArgs e)
        {
            new frmAsistenciasPorGrupo().Show();
        }

        private void btnAsistenciaAlumnoReportes_Click(object sender, EventArgs e)
        {
            new frmAsistenciaPorAlumno().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmPermisoProfesorAsistenciaLibre().Show();
        }

        private void btnPagosReporte_Click(object sender, EventArgs e)
        {
            new frmConsultarDeudores().Show();
        }
    }
}
