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
    public partial class frmVerGrupoAgregarAlumno : MaterialForm
    {
        MsSqlConnection configurarConexion = new MsSqlConnection();
        public static SqlConnection _SqlConnection = new SqlConnection();
        int id, num;
        public frmVerGrupoAgregarAlumno(int numero)
        {
            InitializeComponent();
            _SqlConnection.ConnectionString = configurarConexion._ConnectionString;
            habilitarBoton(numero);
        }

        public void habilitarBoton(int num)
        {
            if (num == 1)
            {
                btnAgregarAlumno.Visible = true;
                cargarGrupos("listar_grupo");
            }
            else if (num == 2 || num == 4)
            {
                btnVerNotas.Visible = true;
                cargarGrupos("listar_ver_notas_grupo");
            }
            else if (num == 3)
            {
                btnAgregarAlumno.Visible = true;
                cargarGrupos("listar_grupos_pasados");
            }
        }

        public void cargarGrupos(String proc)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewGrupo.DataSource = dt;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow row = dt.Rows[i];
                    if (!DBNull.Value.Equals(row["HORA INICIO"]))
                    {
                        String datime = Convert.ToDateTime(row["HORA INICIO"]).ToString("HH:mm");
                        row["HORA INICIO"] = datime;
                    }
                    if (!DBNull.Value.Equals(row["HORA FINAL"]))
                    {
                        String datime = Convert.ToDateTime(row["HORA FINAL"]).ToString("HH:mm");
                        row["HORA FINAL"] = datime;
                    }
                }
                dataGridViewGrupo.Columns["idGrupo"].Visible = false;
                dataGridViewGrupo.Columns["CICLO"].Width = 62;
                dataGridViewGrupo.Columns["SALON"].Width = 62;


                dataGridViewGrupo.Rows[0].Visible = false;
                dataGridViewGrupo.CurrentCell = null;
                dataGridViewGrupo.Rows[1].Visible = false;

                dataGridViewGrupo.Columns["HORA INICIO"].Width = 72;
                dataGridViewGrupo.Columns["HORA FINAL"].Width = 72;
                dataGridViewGrupo.Columns["PROFESOR"].Width = 232;
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

        public void evaluarGrupos()
        {
            CurrencyManager cm = (CurrencyManager)BindingContext[dataGridViewGrupo.DataSource];
            cm.SuspendBinding();
            for (int i = 0; i < dataGridViewGrupo.RowCount; i++)
            {
                int idGrupo = (int)dataGridViewGrupo.Rows[i].Cells["idGrupo"].Value;
                try
                {
                    SqlCommand cmd = new SqlCommand("buscar_asistencia", _SqlConnection);
                    if (cmd.Connection.State == ConnectionState.Closed)
                    {
                        cmd.Connection.Open();
                    }
                    cmd.Parameters.Add(new SqlParameter("@idGrupo", idGrupo));
                    cmd.CommandType = CommandType.StoredProcedure;
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    if (dt.Rows.Count != 0)
                    {
                        dataGridViewGrupo.Rows[i].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            new frmAsignarAlumnosToGroup(id).Show();
        }

        private void btnVerNotas_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            new frmVerNotas(id).Show();
        }

        private void dataGridViewGrupo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewGrupo.RowCount)
            {
                try
                {
                    DataGridViewRow row = dataGridViewGrupo.Rows[e.RowIndex];
                    id = (int)row.Cells["idGrupo"].Value;
                    btnAgregarAlumno.Enabled = true;
                    btnVerNotas.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void frmVerGrupoAgregarAlumno_Load(object sender, EventArgs e)
        {
            if (num == 3) evaluarGrupos();
        }
    }
}
