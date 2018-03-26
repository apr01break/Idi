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
    public partial class frmRegistrarNotas : MaterialForm
    {
        MsSqlConnection configurarConexion = new MsSqlConnection();
        public static SqlConnection _SqlConnection = new SqlConnection();
        int idGrupo = 0;
        public frmRegistrarNotas(int id)
        {
            InitializeComponent();
            idGrupo = id;
            _SqlConnection.ConnectionString = configurarConexion._ConnectionString;
            cargarDatosGrupo(idGrupo);
            //cargarAlumnosGrupo(idGrupo);
            listarFechas();
            cargarDias();
        }
        public void cargarDias()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("listar_dias_grupo", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.Parameters.Add(new SqlParameter("@idGrupo", idGrupo));
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                String xx = "";
                foreach (DataRow row in dt.Rows)
                {
                    xx = xx + row[0].ToString().ToUpperInvariant() + " - ";
                }
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                txtDias.Text = xx;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void cargarDatosGrupo(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("listar_grupo_seleccion", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.Parameters.Add(new SqlParameter("@idGrupo", id));
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                DataRow row2 = dt.Rows[0];
                if (!DBNull.Value.Equals(row2["horaInicio"]))
                {
                    String datime = Convert.ToDateTime(row2["horaInicio"]).ToString("HH:mm tt");
                    row2["horaInicio"] = datime;
                }
                if (!DBNull.Value.Equals(row2["horaFinal"]))
                {
                    String datime = Convert.ToDateTime(row2["horaFinal"]).ToString("HH:mm tt");
                    row2["horaFinal"] = datime;
                }
                if (!DBNull.Value.Equals(row2["fechaInicio"]))
                {
                    String datime = Convert.ToDateTime(row2["fechaInicio"]).ToString("dd/MM/yyyy");
                    row2["fechaInicio"] = datime;
                }
                txtIdioma.Text = row2[1].ToString();
                txtNivel.Text = row2[2].ToString();
                txtCiclo.Text = row2[3].ToString();
                txtSalon.Text = row2[4].ToString();
                txtHoraInicio.Text = row2[5].ToString();
                txtHoraFinal.Text = row2[6].ToString();
                txtInicioCurso.Text = row2[7].ToString();
                txtNumero.Text = row2[10].ToString();

                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                //txtFechaHoy.Text = Convert.ToDateTime(DateTime.Now).ToString("dd/MM/yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void cargarAlumnosGrupo(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("listar_alumno_grupo_nota", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.Parameters.Add(new SqlParameter("@idGrupo", id));
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvwAlumnos.DataSource = dt;
                dgvwAlumnos.Columns["Nombre"].Width = 250;
                dgvwAlumnos.Columns["idAlumnoGrupo"].Visible = false;
                dgvwAlumnos.Columns["Nombre"].ReadOnly = true;
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

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void cmbTipoNota_TextChanged(object sender, EventArgs e)
        {
            if(cmbTipoNota.Text!="")
            {
                btnAgregarCriterio.Enabled = true;
                txtCriterio.Enabled = true;
            }
            
        }
        public void listarFechas()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("listar_fechas_grupo", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.Parameters.Add(new SqlParameter("@idgrupo", idGrupo));
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    cbFechas.Items.Add(Convert.ToDateTime(row[0].ToString()).ToString("dddd, dd MMMM yyyy"));
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

        private void btnAgregarCriterio_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCriterio.Equals(""))
                {
                    MessageBox.Show("El criterio de la nota no puede estar en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();
                    columna.Name = cmbTipoNota.Text;
                    columna.HeaderText = cmbTipoNota.Text;
                    dgvwAlumnos.Columns.Add(columna);
                    dgvwAlumnos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvwAlumnos.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvwAlumnos.Columns[3].Width = 120;
                    if (cmbTipoNota.Text == "READING")
                    {
                        btnFinReading.Visible = true;
                    }
                    if (cmbTipoNota.Text == "WRITING")
                    {
                        btnFinWriting.Visible = true;
                    }
                    if (cmbTipoNota.Text == "LISTENING")
                    {
                        btnFinListening.Visible = true;
                    }
                    if (cmbTipoNota.Text == "SPEAKING")
                    {
                        btnFinSpeaking.Visible = true;
                    }
                    if (cmbTipoNota.Text == "USE OF ENGLISH")
                    {
                        btnFinUseOfEnglish.Visible = true;
                    }
                    validarFaltas();
                    validarJustificaciones();
                    btnAgregarCriterio.Enabled = false;
                    cmbTipoNota.Enabled = false;
                    txtCriterio.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void validarFaltas()
        {
            try
            {
                for (int i = 0; i < dgvwAlumnos.RowCount; i++)
                {
                    String idTipoAsistencia = dgvwAlumnos.Rows[i].Cells[2].Value.ToString();
                    if (idTipoAsistencia == "F")
                    {
                        dgvwAlumnos.Rows[i].Cells[3].Value = "0";
                        dgvwAlumnos.Rows[i].Cells[3].ReadOnly = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "validarFaltas");
            }
        }

        public void validarJustificaciones()
        {
            try
            {
                for (int i = 0; i < dgvwAlumnos.RowCount; i++)
                {
                    String idTipoAsistencia = dgvwAlumnos.Rows[i].Cells[2].Value.ToString();
                    if (idTipoAsistencia == "J")
                    {
                        dgvwAlumnos.Rows[i].Cells[3].Value = "-1";
                        dgvwAlumnos.Rows[i].Cells[3].ReadOnly = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "validarJustificaciones");
            }
        }

        public void buscarTema(string fech)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("buscar_tema", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.Parameters.Add(new SqlParameter("@idgrupo", idGrupo));
                cmd.Parameters.Add(new SqlParameter("@fecha", fech));
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    string titulo = dt.Rows[0][0].ToString();
                    txtTituloTema.Text = titulo;
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

        private void cbFechas_TextChanged(object sender, EventArgs e)
        {
            if (cbFechas.Text != "")
            {
                cmbTipoNota.Enabled = true;
                try
                {
                    SqlCommand cmd = new SqlCommand("listar_asistencias_grupo_fecha", _SqlConnection);
                    if (cmd.Connection.State == ConnectionState.Closed)
                    {
                        cmd.Connection.Open();
                    }
                    String fech = Convert.ToDateTime(cbFechas.Text).ToString("yyyy-MM-dd");
                    cmd.Parameters.Add(new SqlParameter("@idgrupo", idGrupo));
                    cmd.Parameters.Add(new SqlParameter("@fecha", fech));
                    cmd.CommandType = CommandType.StoredProcedure;
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dgvwAlumnos.DataSource = dt;
                    dgvwAlumnos.Columns[0].Visible = false;
                    dgvwAlumnos.Columns[1].Width = 250;
                    dgvwAlumnos.Columns[1].ReadOnly = true;
                    dgvwAlumnos.Columns[2].ReadOnly = true;
                    foreach (DataGridViewColumn column in dgvwAlumnos.Columns)
                    {
                        if (column.HeaderText != "Alumno")
                        {
                            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        }
                        column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    }
                    if (cmd.Connection.State == ConnectionState.Open)
                    {
                        cmd.Connection.Close();
                    }
                    buscarTema(fech);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
                
        }

        private void btnFinSpeaking_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificarVacios() == 1)
                {
                    if (verificarNota() == 1)
                    {
                        for (int i = 0; i < dgvwAlumnos.RowCount; i++)
                        {
                            String idAlumnoGrupo = dgvwAlumnos.Rows[i].Cells["idAlumnoGrupo"].Value.ToString();
                            String nota = dgvwAlumnos.Rows[i].Cells["Speaking"].Value.ToString();
                            SqlCommand cmd = new SqlCommand("insert_speaking", _SqlConnection);
                            if (cmd.Connection.State == ConnectionState.Closed)
                            {
                                cmd.Connection.Open();
                            }
                            cmd.Parameters.Add(new SqlParameter("@idAlumnoGrupo", idAlumnoGrupo));
                            cmd.Parameters.Add(new SqlParameter("@criterio", txtCriterio.Text));
                            cmd.Parameters.Add(new SqlParameter("@nota", nota));
                            cmd.Parameters.Add(new SqlParameter("@fecha", Convert.ToDateTime(cbFechas.Text)));
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.ExecuteNonQuery();
                            if (cmd.Connection.State == ConnectionState.Open)
                            {
                                cmd.Connection.Close();
                            }
                        }
                        MessageBox.Show("NOTAS DE SPEAKING REGISTRADAS");
                        btnFinSpeaking.Visible = false;
                        finNota();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public int verificarNota()
        {
            try
            {
                for (int i = 0; i < dgvwAlumnos.RowCount; i++)
                {
                    int nota = Convert.ToInt32(dgvwAlumnos.Rows[i].Cells[3].Value);
                    if (nota > 20 || nota < -1)
                    {
                        MessageBox.Show("La nota debe ser de 0 a 20", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 0;
                    }
                }
                return 1;
            }
            catch (Exception)
            {
                MessageBox.Show("La nota debe ser en números");
                return 0;
            }
        }
        public int verificarVacios()
        {
            try
            {
                for (int i = 0; i < dgvwAlumnos.RowCount; i++)
                {
                    String nota = Convert.ToString(dgvwAlumnos.Rows[i].Cells[3].Value);
                    if (nota.Equals(""))
                    {
                        MessageBox.Show("Debe completar todas las notas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 0;
                    }
                }
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public void finNota()
        {
            dgvwAlumnos.Columns.RemoveAt(3);
            cmbTipoNota.Enabled = true;
            txtCriterio.Enabled = true;
            txtCriterio.Text = null;
            cmbTipoNota.SelectedItem = null;
            btnAgregarCriterio.Enabled = false;
        }

        private void btnFinReading_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificarVacios() == 1)
                {
                    if (verificarNota() == 1)
                    {
                        for (int i = 0; i < dgvwAlumnos.RowCount; i++)
                        {
                            String idAlumnoGrupo = dgvwAlumnos.Rows[i].Cells["idAlumnoGrupo"].Value.ToString();
                            String nota = dgvwAlumnos.Rows[i].Cells["Reading"].Value.ToString();
                            SqlCommand cmd = new SqlCommand("insert_reading", _SqlConnection);
                            if (cmd.Connection.State == ConnectionState.Closed)
                            {
                                cmd.Connection.Open();
                            }
                            cmd.Parameters.Add(new SqlParameter("@idAlumnoGrupo", idAlumnoGrupo));
                            cmd.Parameters.Add(new SqlParameter("@criterio", txtCriterio.Text));
                            cmd.Parameters.Add(new SqlParameter("@nota", nota));
                            cmd.Parameters.Add(new SqlParameter("@fecha", Convert.ToDateTime(cbFechas.Text)));
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.ExecuteNonQuery();
                            if (cmd.Connection.State == ConnectionState.Open)
                            {
                                cmd.Connection.Close();
                            }
                        }
                        MessageBox.Show("NOTAS DE READING REGISTRADAS");
                        btnFinReading.Visible = false;
                        finNota();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnFinWriting_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificarVacios() == 1)
                {
                    if (verificarNota() == 1)
                    {
                        for (int i = 0; i < dgvwAlumnos.RowCount; i++)
                        {
                            String idAlumnoGrupo = dgvwAlumnos.Rows[i].Cells["idAlumnoGrupo"].Value.ToString();
                            String nota = dgvwAlumnos.Rows[i].Cells["Writing"].Value.ToString();
                            SqlCommand cmd = new SqlCommand("insert_writing", _SqlConnection);
                            if (cmd.Connection.State == ConnectionState.Closed)
                            {
                                cmd.Connection.Open();
                            }
                            cmd.Parameters.Add(new SqlParameter("@idAlumnoGrupo", idAlumnoGrupo));
                            cmd.Parameters.Add(new SqlParameter("@criterio", txtCriterio.Text));
                            cmd.Parameters.Add(new SqlParameter("@nota", nota));
                            cmd.Parameters.Add(new SqlParameter("@fecha", Convert.ToDateTime(cbFechas.Text)));
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.ExecuteNonQuery();
                            if (cmd.Connection.State == ConnectionState.Open)
                            {
                                cmd.Connection.Close();
                            }
                        }
                        MessageBox.Show("NOTAS DE WRITING REGISTRADAS");
                        btnFinWriting.Visible = false;
                        finNota();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFinListening_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificarVacios() == 1)
                {
                    if (verificarNota() == 1)
                    {
                        for (int i = 0; i < dgvwAlumnos.RowCount; i++)
                        {
                            String idAlumnoGrupo = dgvwAlumnos.Rows[i].Cells["idAlumnoGrupo"].Value.ToString();
                            String nota = dgvwAlumnos.Rows[i].Cells["Listening"].Value.ToString();
                            SqlCommand cmd = new SqlCommand("insert_listening", _SqlConnection);
                            if (cmd.Connection.State == ConnectionState.Closed)
                            {
                                cmd.Connection.Open();
                            }
                            cmd.Parameters.Add(new SqlParameter("@idAlumnoGrupo", idAlumnoGrupo));
                            cmd.Parameters.Add(new SqlParameter("@criterio", txtCriterio.Text));
                            cmd.Parameters.Add(new SqlParameter("@nota", nota));
                            cmd.Parameters.Add(new SqlParameter("@fecha", Convert.ToDateTime(cbFechas.Text)));
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.ExecuteNonQuery();
                            if (cmd.Connection.State == ConnectionState.Open)
                            {
                                cmd.Connection.Close();
                            }
                        }
                        MessageBox.Show("NOTAS DE LISTENING REGISTRADAS");
                        btnFinListening.Visible = false;
                        finNota();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFinUseOfEnglish_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificarVacios() == 1)
                {
                    if (verificarNota() == 1)
                    {
                        for (int i = 0; i < dgvwAlumnos.RowCount; i++)
                        {
                            String idAlumnoGrupo = dgvwAlumnos.Rows[i].Cells["idAlumnoGrupo"].Value.ToString();
                            String nota = dgvwAlumnos.Rows[i].Cells["Use of english"].Value.ToString();
                            SqlCommand cmd = new SqlCommand("insert_use_of_english", _SqlConnection);
                            if (cmd.Connection.State == ConnectionState.Closed)
                            {
                                cmd.Connection.Open();
                            }
                            cmd.Parameters.Add(new SqlParameter("@idAlumnoGrupo", idAlumnoGrupo));
                            cmd.Parameters.Add(new SqlParameter("@criterio", txtCriterio.Text));
                            cmd.Parameters.Add(new SqlParameter("@nota", nota));
                            cmd.Parameters.Add(new SqlParameter("@fecha", Convert.ToDateTime(cbFechas.Text)));
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.ExecuteNonQuery();
                            if (cmd.Connection.State == ConnectionState.Open)
                            {
                                cmd.Connection.Close();
                            }
                        }
                        MessageBox.Show("NOTAS DE USE OF ENGLISH REGISTRADAS");
                        btnFinUseOfEnglish.Visible = false;
                        finNota();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmRegistrarNotas_Load(object sender, EventArgs e)
        {
        }
    }
}
