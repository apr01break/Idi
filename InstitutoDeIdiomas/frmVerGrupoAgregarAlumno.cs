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
        string idUsuario;
        public frmVerGrupoAgregarAlumno(int numero, string idUsuario)
        {
            InitializeComponent();
            _SqlConnection.ConnectionString = configurarConexion._ConnectionString;
            
            this.num = numero;
            this.idUsuario = idUsuario;
        }

        public void habilitarBoton(int num)
        {
            if (num == 1)
            {
                btnAgregarAlumno.Visible = true;
                cargarGrupos("listar_grupo");
            }
            else if (num == 2)
            {
                btnVerNotas.Visible = true;
                cargarGrupos("listar_ver_notas_grupo");
            }
            else if (num == 3)
            {
                btnAgregarAlumno.Visible = true;
                cargarGruposAgregarPasados("listar_grupos_pasados");
            }
            else if(num == 4)
            {
                btnVerNotas.Visible = true;
                cargarGruposVerPasados("listar_ver_notas_pasadas");
            }
            else if(num == 5)
            {
                btnVerNotas.Visible = true;
                cargarGrupos("listar_ver_notas_grupo_concluidos");
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
        public void cargarGruposVerPasados(String proc)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.Parameters.Add(new SqlParameter("@idUsuario", idUsuario));
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
        public void cargarGruposAgregarPasados(String proc)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.Parameters.Add(new SqlParameter("@idUsuario", idUsuario));
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

        private void dataGridViewGrupo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
            this.Dispose();
            if(btnAgregarAlumno.Visible) new frmAsignarAlumnosToGroup(id).Show();
            else new frmVerNotas(id).Show();
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewGrupo.Rows)
            {
                
                if (!row.Cells["NUMERO"].Value.ToString().Contains(txtBuscar.Text))
                {
                    row.Visible = false;
                } else if (row.Cells["NUMERO"].Value.ToString().Contains(txtBuscar.Text))
                {
                    row.Visible = true;
                }
            }
        }

        private void frmVerGrupoAgregarAlumno_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtBuscar;
            habilitarBoton(num);
            if (num == 3 || num == 1) evaluarGrupos();

        }
    }
}
