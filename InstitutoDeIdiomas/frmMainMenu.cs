using InstitutoDeIdiomas.ReportForms;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        List<string> listaRoles = new List<string>();
        MsSqlConnection configurarConexion = new MsSqlConnection();
        public static SqlConnection _SqlConnection = new SqlConnection();
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public frmMainMenu(String id, String nombre, String tipoTrabajador)
        {
            _SqlConnection.ConnectionString = configurarConexion._ConnectionString;
            idCodigo = id;
            listarRoles();
            InitializeComponent();
            txtUser.Text = nombre;
            txtUser.SelectionAlignment = HorizontalAlignment.Center;
            txtMain.SelectionAlignment = HorizontalAlignment.Center;
            TXTCODUSER.Text = id;
            nombreUsuario = nombre;
            //verificarTrabajador(tipoTrabajador);
        }

        private void verificarTrabajador(String tipoTrabajador)
        {
            if(tipoTrabajador == "SECRETARIA PRINCIPAL" || tipoTrabajador =="ADMINISTRADOR")
            {
                lblCorregirPago.Visible = true;
                btnCorregirPago.Visible = true;
            }
            if(idCodigo=="3")
            {
                button1.Visible = true;
                button2.Visible = true;
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
        

        private void agregarAlumnosAGrupo_Click(object sender, EventArgs e)
        {
            new frmVerGrupoAgregarAlumno(1,idCodigo).Show();
        }

        private void cREARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRegistrar forma = new frmRegistrar();
            forma.Show();
        }
        

        private void verGrupo_Click(object sender, EventArgs e)
        {
            new frmVerGrupoAgregarAlumno(2,idCodigo).Show();
        }

        private void FICHAMATRICULATOOL_Click(object sender, EventArgs e)
        {
            new frmGenerarFichaMatricula().Show();
        }

        private void DEUDORESCONSMENU_Click(object sender, EventArgs e)
        {
            new frmConsultarDeudores(idCodigo).Show();
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
            panelGruposPasados.Visible = false;
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
            //if (idCodigo == "5" || idCodigo == "25" || idCodigo == "3" || idCodigo=="4")
            //{
            //    btnGruposPasados.Visible = true;
            //}
            
        }

        public void listarRoles()
        {
            try
            {
                DataTable dt = new DataTable();
                _SqlConnection.Open();
                SqlCommand cmd = new SqlCommand("listar_roles_activos_usuario", _SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@idUsuario", idCodigo));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                _SqlConnection.Close();
                foreach(DataRow row in dt.Rows)
                {
                    listaRoles.Add(row[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Boolean verificarRol(string nombre)
        {
            try
            {
                foreach (string item in listaRoles)
                {
                    if (item == nombre) return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
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
            new frmConsultarDeudores(idCodigo).Show();
        }

        private void btnCorregirPago_Click_1(object sender, EventArgs e)
        {
            new frmCorregirPago().Show();
        }

        private void btnCrearGrupo_Click_1(object sender, EventArgs e)
        {
            new frmCrearGrupo("xd").Show();
        }

        private void btnGruposEmpezados_Click_1(object sender, EventArgs e)
        {
            new frmVerGrupoAgregarAlumno(2,idCodigo).Show();
        }

        private void btnAsignarAlumnosGrupo_Click_1(object sender, EventArgs e)
        {
            new frmVerGrupoAgregarAlumno(1,idCodigo).Show();
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
            new frmConsultarDeudores(idCodigo).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmJustificarInasistencia().Show();
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            if (panelConfiguracion.Visible)
            {
                panelConfiguracion.Visible = false;
                btnConfiguracion.BackColor = SystemColors.Control;
            }
            else
            {
                panelConfiguracion.Visible = true;
                btnConfiguracion.BackColor = Color.Khaki;
            }
        }

        private void btnCambiarClave_Click(object sender, EventArgs e)
        {
            panelConfiguracion.Visible = false;
            new frmCambiarClave(idCodigo).Show();
        }

        private void btnActualizarUsuario_Click(object sender, EventArgs e)
        {
            new frmActualizarUsuario().Show();
        }

        private void btnGruposPasados_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnGruposPasados.Height;
            sidePanel.Top = btnGruposPasados.Top;
            ocultarPaneles();
            panelGruposPasados.Visible = true;
            txtMain.Text = "GRUPOS PASADOS";
            txtMain.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearGrupoPasado_Click(object sender, EventArgs e)
        {
            new frmCrearGrupo(idCodigo).Show();
        }

        private void btnAgregarAlumnoGrupoPasado_Click(object sender, EventArgs e)
        {
            new frmVerGrupoAgregarAlumno(3,idCodigo).Show();
        }

        private void btnAgregarAsistenciaNotaPasada_Click(object sender, EventArgs e)
        {
            new frmSeleccionarGrupo(idCodigo,2).Show();
        }

        private void btnVerNotasPasadas_Click(object sender, EventArgs e)
        {
            new frmVerGrupoAgregarAlumno(4,idCodigo).Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lblCorregirPago_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearGrupoPasado_Layout(object sender, LayoutEventArgs e)
        {
            string nombre = "CrearGrupoPasado";
            if (verificarRol(nombre)) btnCrearGrupoPasado.Visible = true;
            else btnCrearGrupoPasado.Visible = false;
        }

        private void btnAgregarAlumnoGrupoPasado_Layout(object sender, LayoutEventArgs e)
        {
            string nombre = "AgregarAlumnoGrupoPasado";
            if (verificarRol(nombre)) btnAgregarAlumnoGrupoPasado.Visible = true;
            else btnAgregarAlumnoGrupoPasado.Visible = false;
        }

        private void btnAgregarAsistenciaNotaPasada_Layout(object sender, LayoutEventArgs e)
        {
            string nombre = "AgregarAsistenciaNotaPasada";
            if (verificarRol(nombre)) btnAgregarAsistenciaNotaPasada.Visible = true;
            else btnAgregarAsistenciaNotaPasada.Visible = false;
        }

        private void btnVerNotasPasadas_Layout(object sender, LayoutEventArgs e)
        {
            string nombre = "VerNotasPasadas";
            if (verificarRol(nombre)) btnVerNotasPasadas.Visible = true;
            else btnVerNotasPasadas.Visible = false;
        }

        private void btnRegistrarPago_Layout(object sender, LayoutEventArgs e)
        {
            string nombre = "RegistrarPago";
            if (verificarRol(nombre)) btnRegistrarPago.Visible = true;
            else btnRegistrarPago.Visible = false;
        }

        private void btnConsultaEspecificaPago_Layout(object sender, LayoutEventArgs e)
        {
            string nombre = "ConsultaEspecificaPago";
            if (verificarRol(nombre)) btnConsultaEspecificaPago.Visible = true;
            else btnConsultaEspecificaPago.Visible = false;
        }

        private void btnConsultaGeneralPago_Layout(object sender, LayoutEventArgs e)
        {
            string nombre = "ConsultaGeneralPago";
            if (verificarRol(nombre)) btnConsultaGeneralPago.Visible = true;
            else btnConsultaGeneralPago.Visible = false;
        }

        private void btnCorregirPago_Layout(object sender, LayoutEventArgs e)
        {
            string nombre = "CorregirPago";
            if (verificarRol(nombre)) btnCorregirPago.Visible = true;
            else btnCorregirPago.Visible = false;
        }

        private void btnRegistrarAlumno_Layout(object sender, LayoutEventArgs e)
        {
            string nombre = "RegistrarAlumno";
            if (verificarRol(nombre)) btnRegistrarAlumno.Visible = true;
            else btnRegistrarAlumno.Visible = false;
        }

        private void btnActualizarAlumno_Layout(object sender, LayoutEventArgs e)
        {
            string nombre = "ActualizarAlumno";
            if (verificarRol(nombre)) btnActualizarAlumno.Visible = true;
            else btnActualizarAlumno.Visible = false;
        }

        private void btnConsultarAlumno_Layout(object sender, LayoutEventArgs e)
        {
            string nombre = "ConsultarAlumno";
            if (verificarRol(nombre)) btnConsultarAlumno.Visible = true;
            else btnConsultarAlumno.Visible = false;
        }

        private void btnNuevoUsuario_Layout(object sender, LayoutEventArgs e)
        {
            string nombre = "NuevoUsuario";
            if (verificarRol(nombre)) btnNuevoUsuario.Visible = true;
            else btnNuevoUsuario.Visible = false;
        }

        private void btnActualizarUsuario_Layout(object sender, LayoutEventArgs e)
        {
            string nombre = "ActualizarUsuario";
            if (verificarRol(nombre)) btnActualizarUsuario.Visible = true;
            else btnActualizarUsuario.Visible = false;
        }

        private void btnFichaMatricula_Layout(object sender, LayoutEventArgs e)
        {
            string nombre = "FichaMatricula";
            if (verificarRol(nombre)) btnFichaMatricula.Visible = true;
            else btnFichaMatricula.Visible = false;
        }

        private void btnPagosReporte_Layout(object sender, LayoutEventArgs e)
        {
            string nombre = "PagosReporte";
            if (verificarRol(nombre)) btnPagosReporte.Visible = true;
            else btnPagosReporte.Visible = false;
        }

        private void btnRecordAlumno_Layout(object sender, LayoutEventArgs e)
        {
            string nombre = "RecordAlumno";
            if (verificarRol(nombre)) btnRecordAlumno.Visible = true;
            else btnRecordAlumno.Visible = false;
        }

        private void btnAsistenciaGrupoReportes_Layout(object sender, LayoutEventArgs e)
        {
            string nombre = "AsistenciaGrupoReportes";
            if (verificarRol(nombre)) btnAsistenciaGrupoReportes.Visible = true;
            else btnAsistenciaGrupoReportes.Visible = false;
        }

        private void btnAsistenciaAlumnoReportes_Layout(object sender, LayoutEventArgs e)
        {
            string nombre = "AsistenciaAlumnoReportes";
            if (verificarRol(nombre)) btnAsistenciaAlumnoReportes.Visible = true;
            else btnAsistenciaAlumnoReportes.Visible = false;
        }

        private void btnCrearGrupo_Layout(object sender, LayoutEventArgs e)
        {
            string nombre = "CrearGrupo";
            if (verificarRol(nombre)) btnCrearGrupo.Visible = true;
            else btnCrearGrupo.Visible = false;
        }

        private void btnGruposEmpezados_Layout(object sender, LayoutEventArgs e)
        {
            string nombre = "GruposEmpezados";
            if (verificarRol(nombre)) btnGruposEmpezados.Visible = true;
            else btnGruposEmpezados.Visible = false;
        }

        private void btnAsignarAlumnosGrupo_Layout(object sender, LayoutEventArgs e)
        {
            string nombre = "AsignarAlumnosGrupo";
            if (verificarRol(nombre)) btnAsignarAlumnosGrupo.Visible = true;
            else btnAsignarAlumnosGrupo.Visible = false;
        }

        private void btnAsignarRoles_Click(object sender, EventArgs e)
        {
            new frmAsignarRoles().Show();
        }

        private void btnAsignarRoles_Layout(object sender, LayoutEventArgs e)
        {
            string nombre = "AsignarRoles";
            if (verificarRol(nombre)) btnAsignarRoles.Visible = true;
            else btnAsignarRoles.Visible = false;
        }

        private void btnReporteGrupos_Click(object sender, EventArgs e)
        {
            new frmReporteGrupos().Show();
        }

        private void frmMainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void frmMainMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }

        }

        private void frmMainMenu_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
