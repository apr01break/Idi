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
    public partial class frmPermisoProfesorAsistenciaLibre : MaterialForm
    {
        MsSqlConnection configurarConexion = new MsSqlConnection();
        public static SqlConnection _SqlConnection = new SqlConnection();
        public frmPermisoProfesorAsistenciaLibre()
        {
            InitializeComponent();
            _SqlConnection.ConnectionString = configurarConexion._ConnectionString;
            
        }
        
        
        private void dgvwLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvwLista.Rows)
            {
                String permiso;
                DataGridViewCheckBoxCell x = (DataGridViewCheckBoxCell)row.Cells["Permiso"];
                if (Convert.ToBoolean(x.Value))
                {
                    permiso = "1";
                }
                else
                {
                    permiso = "0";
                }
                SqlCommand cmd = new SqlCommand("actualizar_permiso_asistencia", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@idTrabajador", row.Cells[0].Value.ToString()));
                cmd.Parameters.Add(new SqlParameter("@num",permiso));
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
            MessageBox.Show("Guardado exitosamente");

        }

        private void frmPermisoProfesorAsistenciaLibre_Load(object sender, EventArgs e)
        {
            len();
        }
        public void len()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("listar_profesores_asistencia", _SqlConnection);
            if (cmd.Connection.State == ConnectionState.Closed)
            {
                cmd.Connection.Open();
            }
            
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
            dt.Clear();
            da.Fill(dt);
            dgvwLista.DataSource = dt;
            dgvwLista.Columns[0].Visible = false;
            dgvwLista.Columns[1].Width = 230;
            dgvwLista.Columns[1].ReadOnly = true;
            dgvwLista.Columns[2].Visible = false;
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
            DataGridViewCheckBoxColumn c = new DataGridViewCheckBoxColumn();
            dgvwLista.Columns.Add(c);
            c.HeaderCell.Value = "Permiso";
            c.Name = "Permiso";
            foreach (DataGridViewRow row in dgvwLista.Rows)
            {
                if (row.Cells["permisoAsistencia"].Value.ToString() == "1")
                {
                    DataGridViewCheckBoxCell x = (DataGridViewCheckBoxCell)row.Cells["Permiso"];
                    x.Value = true;
                }
                
            }
        }
    }
}
