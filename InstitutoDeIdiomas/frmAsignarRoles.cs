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
    public partial class frmAsignarRoles : MaterialForm
    {
        MsSqlConnection configurarConexion = new MsSqlConnection();
        public static SqlConnection _SqlConnection = new SqlConnection();
        int idUsuario;
        public frmAsignarRoles()
        {
            InitializeComponent();
            _SqlConnection.ConnectionString = configurarConexion._ConnectionString;
            listarUsuarios();
        }

        private void cmbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idusuario = Convert.ToInt32((cmbUsuarios.SelectedItem as dynamic).Value);
            this.idUsuario = idusuario;
            listarRoles(idusuario);
        }
        

        public void listarRoles(int idusuario)
        {
            dgvwRoles.DataSource = null;
            dgvwRoles.Columns.Clear();
            dgvwRoles.Rows.Clear();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("listar_roles_usuario", _SqlConnection);
            if (cmd.Connection.State == ConnectionState.Closed)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.Add(new SqlParameter("@idUsuario", idusuario));
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
            dt.Clear();
            da.Fill(dt);
            dgvwRoles.DataSource = dt;
            dgvwRoles.Columns[0].Visible = false;
            dgvwRoles.Columns[2].Visible = false;
            dgvwRoles.Columns[1].Width = 230;
            //dgvwRoles.Columns[1].ReadOnly = true;
            //dgvwRoles.Columns[2].Visible = false;
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
            DataGridViewCheckBoxColumn c = new DataGridViewCheckBoxColumn();
            dgvwRoles.Columns.Add(c);
            c.HeaderCell.Value = "AUTORIZACION";
            c.Name = "AUTORIZACION";
            
            foreach (DataGridViewRow row in dgvwRoles.Rows)
            {
                if (row.Cells["estado"].Value.ToString() == "1")
                {
                    DataGridViewCheckBoxCell x = (DataGridViewCheckBoxCell)row.Cells["AUTORIZACION"];
                    x.Value = true;
                }

            }
        }
        public void listarUsuarios()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("listar_usuarios", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                cmbUsuarios.DisplayMember = "Text";
                cmbUsuarios.ValueMember = "Value";
                foreach (DataRow row in dt.Rows)
                {
                    string texto = row[1]+"";
                    cmbUsuarios.Items.Add(new { Text = texto, Value = row[0] });
                }

                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void frmAsignarRoles_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvwRoles.Rows)
            {
                String permiso;
                DataGridViewCheckBoxCell x = (DataGridViewCheckBoxCell)row.Cells["AUTORIZACION"];
                if (Convert.ToBoolean(x.Value))
                {
                    permiso = "1";
                }
                else
                {
                    permiso = "0";
                }
                SqlCommand cmd = new SqlCommand("actualizar_rol_usuario", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@idRolUsuario", row.Cells[0].Value.ToString()));
                cmd.Parameters.Add(new SqlParameter("@estado", permiso));
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
            MessageBox.Show("Guardado exitosamente");
            this.Dispose();
            this.Close();
        }
    }
}
