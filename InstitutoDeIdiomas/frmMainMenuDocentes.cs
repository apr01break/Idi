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
    public partial class frmMainMenuDocentes : Form
    {
        String id;
        MsSqlConnection configurarConexion = new MsSqlConnection();
        public static SqlConnection _SqlConnection = new SqlConnection();
        public frmMainMenuDocentes(String id,String nombre, String tipoTrabajador)
        {
            InitializeComponent();
            this.id = id;
            _SqlConnection.ConnectionString = configurarConexion._ConnectionString;
            TXTCODUSER.Text = id;
            TXTBIENBUSER.Text = nombre;
            TXTBIENBUSER.SelectionAlignment = HorizontalAlignment.Center;
            lblClave.Text = CrearPassword(10);

            if (id == "1034")
            {
                panelAsistencia.Visible = true;
            }
            else
            {
                panelDocentes.Visible = true;
            }
        }
        
        private void btnRegistroAuxiliar_Click(object sender, EventArgs e)
        {
            frmSeleccionarGrupo selectGrupo = new frmSeleccionarGrupo(id,0);
            selectGrupo.Show();
        }

        public string CrearPassword(int longitud)
        {
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < longitud--)
            {
                res.Append(caracteres[rnd.Next(caracteres.Length)]);
            }
            return res.ToString();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistrarAsistencia_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("verificar_permiso_asistencia", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@idUsuario", id));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                dt.Clear();
                da.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    new frmSeleccionarGrupo(id, 2).Show();
                }
                else
                {
                    MessageBox.Show("No tiene permiso.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void btnRegistrarNotas_Click(object sender, EventArgs e)
        {
            frmSeleccionarGrupo selectGrupo = new frmSeleccionarGrupo(id, 1);
            selectGrupo.Show();
        }

        private void btnPermisoAsistencia_Click(object sender, EventArgs e)
        {
            new frmPermisoProfesorAsistenciaLibre().Show();
        }

        private void btnJustificarInasistencia_Click(object sender, EventArgs e)
        {
            new frmJustificarInasistencia().Show();
        }

        private void btnCambiarClave_Click(object sender, EventArgs e)
        {
            new frmCambiarClave(id).Show();
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

        private void frmMainMenuDocentes_Load(object sender, EventArgs e)
        {

        }

        private void panelConfiguracion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDocentes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelAsistencia_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCambiarClave_Click_1(object sender, EventArgs e)
        {
            panelConfiguracion.Visible = false;
            new frmCambiarClave(id).Show();
        }
    }
}
