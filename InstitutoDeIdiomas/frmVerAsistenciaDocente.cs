using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstitutoDeIdiomas
{
    public partial class frmVerAsistenciaDocente : MaterialForm
    {
        MsSqlConnection configurarConexion = new MsSqlConnection();
        public static SqlConnection _SqlConnection = new SqlConnection();
        int idUsuario;
        public frmVerAsistenciaDocente()
        {
            InitializeComponent();
            _SqlConnection.ConnectionString = configurarConexion._ConnectionString;
        }

        private void frmVerAsistenciaDocente_Load(object sender, EventArgs e)
        {
            cargarDocentes();
        }
        public void cargarDocentes()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("listar_profesor", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                dgvwDocentes.DataSource = dt;
                dgvwDocentes.Columns[0].Visible = false;
                dgvwDocentes.Columns[1].Visible = false;
                dgvwDocentes.Columns[2].Width = 250;
                dgvwDocentes.Columns[2].HeaderText = "Docentes";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"cargaProfesor");
            }
        }

        private void dgvwDocentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvwDocentes.RowCount)
            {
                DataGridViewRow row = dgvwDocentes.Rows[e.RowIndex];
                idUsuario = (int)row.Cells[0].Value;
                try
                {
                    SqlCommand cmd = new SqlCommand("listar_asistencias_docente", _SqlConnection);
                    if (cmd.Connection.State == ConnectionState.Closed)
                    {
                        cmd.Connection.Open();
                    }
                    cmd.Parameters.Add(new SqlParameter("@idUsuario", idUsuario));
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (cmd.Connection.State == ConnectionState.Open)
                    {
                        cmd.Connection.Close();
                    }
                    dgvwAsistencias.DataSource = dt;
                    dgvwAsistencias.Columns[0].Visible = false;
                    dgvwAsistencias.Columns[1].Visible = false;
                    dgvwAsistencias.Columns[2].HeaderText = "Tipo";
                    dgvwAsistencias.Columns[4].HeaderText = "Fecha";
                    dgvwAsistencias.Columns[3].Visible = false;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvwAsistencias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvwDocentes.RowCount)
            {
                DataGridViewRow row = dgvwAsistencias.Rows[e.RowIndex];
                if (!DBNull.Value.Equals(row.Cells[3].Value))
                {
                    byte[] img = (byte[])(row.Cells[3].Value);
                    if (img == null)
                    {
                        fotoImagen.Image = null;
                    }
                    else
                    {
                        fotoImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                        MemoryStream ms = new MemoryStream(img);
                        fotoImagen.Image = Image.FromStream(ms);
                    }
                }
            }
                
        }
    }
}
