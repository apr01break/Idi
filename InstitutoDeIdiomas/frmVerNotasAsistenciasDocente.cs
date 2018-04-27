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
    public partial class frmVerNotasAsistenciasDocente : MaterialForm
    {
        MsSqlConnection configurarConexion = new MsSqlConnection();
        public static SqlConnection _SqlConnection = new SqlConnection();
        int codigoGrupo;
        String anho, mes;
        DataTable dtListaAlumno = new DataTable();
        string nroCarnet;
        string nombreAlumno="";
        public frmVerNotasAsistenciasDocente(int id)
        {
            InitializeComponent();
            _SqlConnection.ConnectionString = configurarConexion._ConnectionString;
            cargarDatosGrupo(id);
            codigoGrupo = id;
            cargarAlumnosBase(id);
            cargarAlumnoTabla();

            listarNotasListening(id);
            listarNotasReading(id);
            listarNotasSpeaking(id);
            listarNotasUseOfEnglish(id);
            listarNotasWriting(id);
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
                cmd.Parameters.Add(new SqlParameter("@idGrupo", codigoGrupo));
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                String xx = "";
                foreach (DataRow row in dt.Rows)
                {
                    xx = xx + row[0].ToString().ToUpperInvariant() + " - ";
                }
                xx=xx.Trim();
                if(xx!="") xx = xx.Remove(xx.Length - 1);
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                txtDias.Text = xx;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"cargarDias");
            }
        }

        public void cargarAlumnosBase(int idGrupo)
        {
            SqlCommand cmd = new SqlCommand("listar_alumno_nota", _SqlConnection);
            if (cmd.Connection.State == ConnectionState.Closed)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.Add(new SqlParameter("@idGrupo", idGrupo));
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dtListaAlumno = dt.Copy();
            dgvwBase.DataSource = dt;
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
        }

        public void cargarAlumnoTabla()
        {
                dgvwNotas.DataSource = null;
                dgvwNotas.Columns.Clear();
                dgvwNotas.Rows.Clear();
                
                    for (int i = 0; i < dgvwBase.ColumnCount; i++)
                    {
                        DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                        dgvwNotas.Columns.Add(column);
                        column.Name = dgvwBase.Columns[i].HeaderText.ToString();
                        column.HeaderText = column.Name;
                        
                        for (int j = 0; j < dgvwBase.RowCount - 1; j++)
                        {
                            if (i == 0)
                            {
                                dgvwNotas.Rows.Add();
                            }
                            String nota = dgvwBase.Rows[j].Cells[i].Value.ToString();
                            dgvwNotas.Rows[j].Cells[i].Value = nota;
                        }
                    }
            dgvwNotas.Columns["CODIGO ALUMNO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvwNotas.Columns["CODIGO ALUMNO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvwNotas.Columns["APELLIDOS Y NOMBRES"].Width = 253;
             

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
                    String datime = Convert.ToDateTime(row2["horaInicio"]).ToString("HH:mm");
                    row2["horaInicio"] = datime;
                }
                if (!DBNull.Value.Equals(row2["horaFinal"]))
                {
                    String datime = Convert.ToDateTime(row2["horaFinal"]).ToString("HH:mm");
                    row2["horaFinal"] = datime;
                }
                txtIdioma.Text = row2[1].ToString();
                txtNivel.Text = row2[2].ToString();
                txtCiclo.Text = row2[3].ToString();
                txtSalon.Text = row2[4].ToString();
                txtHorario.Text = row2[5].ToString();
                txtHorario2.Text = row2[6].ToString();
                anho = Convert.ToDateTime(row2[7]).ToString("yyyy");
                mes = Convert.ToDateTime(row2[7]).ToString("MMMMM").ToUpper();
                txtInicio.Text = row2[7].ToString();
                txtFin.Text = row2[9].ToString();
                txtDocente.Text = row2[8].ToString();
                txtNumero.Text = row2[10].ToString();
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+ "cargarDatosGrupo");
            }
        }

        public void listarNotasListening(int idGrupo)
        {
            SqlCommand cmd = new SqlCommand("listar_listening", _SqlConnection);
            if (cmd.Connection.State == ConnectionState.Closed)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.Add(new SqlParameter("@idGrupo", idGrupo));
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvwListening.DataSource = dt;
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
        }

        public void listarNotasSpeaking(int idGrupo)
        {
            SqlCommand cmd = new SqlCommand("listar_speaking", _SqlConnection);
            if (cmd.Connection.State == ConnectionState.Closed)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.Add(new SqlParameter("@idGrupo", idGrupo));
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvwSpeaking.DataSource = dt;
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
        }

        public void listarNotasReading(int idGrupo)
        {
            SqlCommand cmd = new SqlCommand("listar_reading", _SqlConnection);
            if (cmd.Connection.State == ConnectionState.Closed)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.Add(new SqlParameter("@idGrupo", idGrupo));
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvwReading.DataSource = dt;
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
        }

        public void listarNotasWriting(int idGrupo)
        {
            SqlCommand cmd = new SqlCommand("listar_writing", _SqlConnection);
            if (cmd.Connection.State == ConnectionState.Closed)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.Add(new SqlParameter("@idGrupo", idGrupo));
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvwWriting.DataSource = dt;
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
        }

        public void listarNotasUseOfEnglish(int idGrupo)
        {
            SqlCommand cmd = new SqlCommand("listar_use_of_english", _SqlConnection);
            if (cmd.Connection.State == ConnectionState.Closed)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.Add(new SqlParameter("@idGrupo", idGrupo));
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvwUseOfEnglish.DataSource = dt;
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
        }

        public void listarListening()
        {
            int x = 0;
            for (int i = 2; i <= ((dgvwListening.RowCount - 1) / dgvwNotas.RowCount) + 1; i++)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                dgvwNotas.Columns.Add(column);
                column.Name = dgvwListening.Rows[x].Cells[0].Value.ToString();
                column.HeaderText = column.Name;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                for (int j = x; j < (i - 1) * dgvwNotas.RowCount; j++)
                {
                    String nota = dgvwListening.Rows[j].Cells[1].Value.ToString();
                    int d = j - (dgvwNotas.RowCount * (i - 2));
                    dgvwNotas.Rows[j - (dgvwNotas.RowCount * (i - 2))].Cells[i].Value = nota;
                    x++;
                }
            }
        }

        public void listarSpeaking()
        {
            int x = 0;
            for (int i = 2; i <= ((dgvwSpeaking.RowCount - 1) / dgvwNotas.RowCount) + 1; i++)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                dgvwNotas.Columns.Add(column);
                column.Name = dgvwSpeaking.Rows[x].Cells[0].Value.ToString();
                column.HeaderText = column.Name;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                for (int j = x; j < (i - 1) * (dgvwNotas.RowCount); j++)
                {
                    String nota = dgvwSpeaking.Rows[j].Cells[1].Value.ToString();

                    dgvwNotas.Rows[j - (dgvwNotas.RowCount * (i - 2))].Cells[i].Value = nota;
                    x++;
                }
            }
        }

        public void listarWriting()
        {
            int x = 0;
            for (int i = 2; i <= ((dgvwWriting.RowCount - 1) / dgvwNotas.RowCount) + 1; i++)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                dgvwNotas.Columns.Add(column);
                column.Name = dgvwWriting.Rows[x].Cells[0].Value.ToString();
                column.HeaderText = column.Name;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                for (int j = x; j < (i - 1) * dgvwNotas.RowCount; j++)
                {
                    String nota = dgvwWriting.Rows[j].Cells[1].Value.ToString();

                    dgvwNotas.Rows[j - (dgvwNotas.RowCount * (i - 2))].Cells[i].Value = nota;
                    x++;
                }
            }
        }

        public void listarReading()
        {
            int x = 0;
            for (int i = 2; i <= ((dgvwReading.RowCount - 1) / dgvwNotas.RowCount) + 1; i++)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                dgvwNotas.Columns.Add(column);
                column.Name = dgvwReading.Rows[x].Cells[0].Value.ToString();
                column.HeaderText = column.Name;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                for (int j = x; j < (i - 1) * dgvwNotas.RowCount; j++)
                {
                    String nota = dgvwReading.Rows[j].Cells[1].Value.ToString();

                    dgvwNotas.Rows[j - (dgvwNotas.RowCount * (i - 2))].Cells[i].Value = nota;
                    x++;
                }
            }
        }

        public void listarUseOfEnglish()
        {
            int x = 0;
            for (int i = 2; i <= ((dgvwUseOfEnglish.RowCount - 1) / dgvwNotas.RowCount) + 1; i++)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                dgvwNotas.Columns.Add(column);
                column.Name = dgvwUseOfEnglish.Rows[x].Cells[0].Value.ToString();
                column.HeaderText = column.Name;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                for (int j = x; j < (i - 1) * dgvwNotas.RowCount; j++)
                {
                    String nota = dgvwUseOfEnglish.Rows[j].Cells[1].Value.ToString();

                    dgvwNotas.Rows[j - (dgvwNotas.RowCount * (i - 2))].Cells[i].Value = nota;
                    x++;
                }
            }
        }

        public void cargarResultados()
        {
            try
            {

                cargarListening();
                cargarSpeaking();
                cargarReading();
                cargarWriting();
                cargarUseOfEnglish();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"cargarResultados");
            }

        }

        public void cargarListening()
        {
            if (dgvwListening.RowCount != 1)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                dgvwNotas.Columns.Add(column);
                column.HeaderText = "Listening";
                column.Name = "Listening";
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                for (int i = 0; i < dgvwNotas.RowCount; i++)
                {
                    Double numeroDeNotas = (dgvwListening.RowCount - 1) / (dgvwNotas.RowCount);
                    Double sumaNotas = 0;

                    for (int j = i; j < dgvwListening.RowCount - 1; j = j + (dgvwNotas.RowCount))
                    {
                        String nota = dgvwListening.Rows[j].Cells[1].Value.ToString();
                        if (nota.Equals("-1"))
                        {
                            numeroDeNotas--;
                        }
                        else
                        {
                            sumaNotas = sumaNotas + Convert.ToInt32(nota);
                        }
                    }
                    Double promedioReading = sumaNotas / numeroDeNotas;
                    dgvwNotas.Rows[i].Cells["LISTENING"].Value = Math.Round(promedioReading, 2);
                }
            }

        }
        public void cargarSpeaking()
        {
            if (dgvwSpeaking.RowCount != 1)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                dgvwNotas.Columns.Add(column);
                column.HeaderText = "Speaking";
                column.Name = "Speaking";
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                for (int i = 0; i < dgvwNotas.RowCount; i++)
                {
                    Double numeroDeNotas = (dgvwSpeaking.RowCount - 1) / (dgvwNotas.RowCount);
                    Double sumaNotas = 0;

                    for (int j = i; j < dgvwSpeaking.RowCount - 1; j = j + (dgvwNotas.RowCount))
                    {
                        String nota = dgvwSpeaking.Rows[j].Cells[1].Value.ToString();
                        if (nota.Equals("-1"))
                        {
                            numeroDeNotas--;
                        }
                        else
                        {
                            sumaNotas = sumaNotas + Convert.ToInt32(nota);
                        }
                    }
                    Double promedioReading = sumaNotas / numeroDeNotas;
                    dgvwNotas.Rows[i].Cells["SPEAKING"].Value = Math.Round(promedioReading, 2);
                }
            }

        }
        public void cargarReading()
        {
            if (dgvwReading.RowCount != 1)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                dgvwNotas.Columns.Add(column);
                column.HeaderText = "Reading";
                column.Name = "Reading";
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                for (int i = 0; i < dgvwNotas.RowCount; i++)
                {
                    Double numeroDeNotas = (dgvwReading.RowCount - 1) / (dgvwNotas.RowCount);
                    Double sumaNotas = 0;

                    for (int j = i; j < dgvwReading.RowCount - 1; j = j + (dgvwNotas.RowCount))
                    {
                        String nota = dgvwReading.Rows[j].Cells[1].Value.ToString();
                        if (nota.Equals("-1"))
                        {
                            numeroDeNotas--;
                        }
                        else
                        {
                            sumaNotas = sumaNotas + Convert.ToInt32(nota);
                        }
                    }
                    Double promedioReading = sumaNotas / numeroDeNotas;
                    dgvwNotas.Rows[i].Cells["READING"].Value = Math.Round(promedioReading, 2);
                }
            }

        }
        public void cargarWriting()
        {
            if (dgvwWriting.RowCount != 1)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                dgvwNotas.Columns.Add(column);
                column.HeaderText = "Writing";
                column.Name = "Writing";
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                for (int i = 0; i < dgvwNotas.RowCount; i++)
                {
                    Double numeroDeNotas = (dgvwWriting.RowCount - 1) / (dgvwNotas.RowCount);
                    Double sumaNotas = 0;

                    for (int j = i; j < dgvwWriting.RowCount - 1; j = j + (dgvwNotas.RowCount))
                    {
                        String nota = dgvwWriting.Rows[j].Cells[1].Value.ToString();
                        if (nota.Equals("-1"))
                        {
                            numeroDeNotas--;
                        }
                        else
                        {
                            sumaNotas = sumaNotas + Convert.ToInt32(nota);
                        }
                    }
                    Double promedioReading = sumaNotas / numeroDeNotas;
                    dgvwNotas.Rows[i].Cells["WRITING"].Value = Math.Round(promedioReading, 2);
                }
            }

        }
        public void cargarUseOfEnglish()
        {
            if (dgvwUseOfEnglish.RowCount != 1)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                dgvwNotas.Columns.Add(column);
                column.HeaderText = "UseOfEnglish";
                column.Name = "UseOfEnglish";
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                for (int i = 0; i < dgvwNotas.RowCount; i++)
                {
                    Double numeroDeNotas = (dgvwUseOfEnglish.RowCount - 1) / (dgvwNotas.RowCount);
                    Double sumaNotas = 0;

                    for (int j = i; j < dgvwUseOfEnglish.RowCount - 1; j = j + (dgvwNotas.RowCount))
                    {
                        String nota = dgvwUseOfEnglish.Rows[j].Cells[1].Value.ToString();
                        if (nota.Equals("-1"))
                        {
                            numeroDeNotas--;
                        }
                        else
                        {
                            sumaNotas = sumaNotas + Convert.ToInt32(nota);
                        }
                    }
                    Double promedioReading = sumaNotas / numeroDeNotas;
                    dgvwNotas.Rows[i].Cells["UseOfEnglish"].Value = Math.Round(promedioReading, 2);
                }
            }
        }

        public void corregirNota()
        {
            try
            {
                for (int i = 1; i < dgvwNotas.ColumnCount; i++)
                {
                    for (int j = 0; j < dgvwNotas.RowCount - 1; j++)
                    {
                        if (dgvwNotas.Rows[j].Cells[i].Value.Equals("-1"))
                        {
                            dgvwNotas.Rows[j].Cells[i].Value = "J";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"corregirNota");
            }

        }

        public void cargarNotasTabla(String tipoNota)
        {
            try
            {
                label1.Visible = true;
                if (tipoNota.Equals("LISTENING"))
                {
                    label1.Text = "NOTAS DE LISTENING";
                    cargarAlumnoTabla();
                    listarListening();
                    corregirNota();
                }
                if (tipoNota.Equals("SPEAKING"))
                {
                    label1.Text = "NOTAS DE SPEAKING";
                    cargarAlumnoTabla();
                    listarSpeaking();
                    corregirNota();
                }
                if (tipoNota.Equals("WRITING"))
                {
                    label1.Text = "NOTAS DE WRITING";
                    cargarAlumnoTabla();
                    listarWriting();
                    corregirNota();
                }
                if (tipoNota.Equals("READING"))
                {
                    label1.Text = "NOTAS DE READING";
                    cargarAlumnoTabla();
                    listarReading();
                    corregirNota();
                }
                if (tipoNota.Equals("USE OF ENGLISH"))
                {
                    label1.Text = "NOTAS DE USE OF ENGLISH";
                    cargarAlumnoTabla();
                    listarUseOfEnglish();
                    corregirNota();
                }
                if (tipoNota.Equals("RESULTADOS HASTA AHORA"))
                {
                    label1.Text = "RESULTADOS HASTA AHORA";
                    cargarAlumnoTabla();
                    cargarResultados();
                    corregirNota();
                    //this.reportViewer1.ProcessingMode = ProcessingMode.Local;
                    ////String rptact=Application.StartupPath+ "\\Report2.rdlc";
                    ////this.reportViewer1.LocalReport.ReportPath = "D:\\CENTRO DE IDIOMAS\\2\\InstitutoDeIdiomas\\InstitutoDeIdiomas\\Report2.rdlc";
                    //DataSet ds = new DataSet();
                    //ds.Tables.Add();
                    //int filas = dgvwNotas.RowCount;
                    //ds.Tables[0].Columns.Add();
                    //ds.Tables[0].Columns.Add();
                    //ds.Tables[0].Columns.Add();
                    //ds.Tables[0].Columns.Add();
                    //ds.Tables[0].Columns.Add();
                    //ds.Tables[0].Columns.Add();
                    //for (int i = 0; i < filas - 1; i++)
                    //{

                    //    ds.Tables[0].Rows.Add
                    //        (new object[] {
                    //        dgvwNotas[0,i].Value.ToString(),
                    //        dgvwNotas[1,i].Value.ToString(),
                    //        dgvwNotas[2,i].Value.ToString(),
                    //        dgvwNotas[3,i].Value.ToString(),
                    //        dgvwNotas[4,i].Value.ToString()
                    //        //,
                    //        //dgvwNotas[5,i].Value.ToString()
                    //        });
                    //}

                    //ReportDataSource rds = new ReportDataSource();
                    //reportViewer1.LocalReport.DataSources.Clear();
                    //rds.Value = ds.Tables[0];
                    //rds.Name = "DataSetRelacionAlumno";

                    //reportViewer1.LocalReport.DataSources.Add(rds);
                    //this.reportViewer1.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"cargarNotasTabla");
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cmbTipoNota_TextChanged(object sender, EventArgs e)
        {
            cargarNotasTabla(cmbTipoNota.SelectedItem.ToString());
            label1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btnConcluirGrupo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("EL GRUPO SERÁ CULMINADO \n ¿DESEAS CONTINUAR?", "ADVERTENCIA", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("concluir_grupo", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.Parameters.Add(new SqlParameter("@idGrupo", codigoGrupo));
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                MessageBox.Show("EL GRUPO HA SIDO CULMINADO");
                this.Close();
            }

        }

        private void btnRelacionAlumno_Click(object sender, EventArgs e)
        {
            cargarAlumnoTabla();
            cargarResultados();
            corregirNota();
            if (dgvwNotas.ColumnCount != 7)
            {
                MessageBox.Show("Es necesario tener notas de todos los criterios");
                return;
            }
            DataTable dt = new DataTable();
            //int x = 1;
            //for (int i = 0; i < dgvwNotas.RowCount; i++)
            //{
            //    dt.Rows.Add();
            //    for (int j = 0; j < dgvwNotas.ColumnCount; j++)
            //    {
            //        if (x <= 7)
            //        {
            //            dt.Columns.Add();
            //        }
            //        dt.Rows[i][j] = dgvwNotas.Rows[i].Cells[j];
            //        x++;
            //    }
            //}
            //dt.Columns.Add("Codigo");
            //dt.Columns.Add("Nombres",typeof(System.String));
            //dt.Columns.Add("Listening",typeof(System.Double));
            //dt.Columns.Add("Speaking", typeof(System.Double));
            //dt.Columns.Add("Reading", typeof(System.Double));
            //dt.Columns.Add("Writing", typeof(System.Double));
            //dt.Columns.Add("UseOfEnglish", typeof(System.Double));
            //foreach (DataGridViewRow row in dgvwNotas.Rows)
            //{

            //    DataRow rw = dt.NewRow();
            //    for (int i = 0; i < dgvwNotas.ColumnCount; i++)
            //    {
            //        rw[i] = row.Cells[i].Value;
            //    }
            //    dt.Rows.Add(rw);

            //}
            dt.Columns.Add("numero");
            dt.Columns.Add("codigo");
            dt.Columns.Add("nombre");
            dt.Columns.Add("notaNum");
            dt.Columns.Add("notaLet");
            int p = 1, aprobados = 0, desaprobados = 0;
            foreach (DataGridViewRow row in dgvwNotas.Rows)
            {
                DataRow rw = dt.NewRow();
                rw[0] = p;
                p++;
                decimal nota = 0;

                for (int i = 0; i < dgvwNotas.ColumnCount; i++)
                {
                    if (i < dgvwNotas.ColumnCount - 5) rw[i + 1] = row.Cells[i].Value;
                    else
                    {
                        nota = nota + Convert.ToDecimal(row.Cells[i].Value);
                    }
                }
                nota = nota / 5;
                nota = decimal.Round(nota, 0);
                rw[3] = nota + "";
                if (nota == 0) rw[4] = "CERO";
                else if (nota == 1) rw[4] = "UNO";
                else if (nota == 2) rw[4] = "DOS";
                else if (nota == 3) rw[4] = "TRES";
                else if (nota == 4) rw[4] = "CUATRO";
                else if (nota == 5) rw[4] = "CINCO";
                else if (nota == 6) rw[4] = "SEIS";
                else if (nota == 7) rw[4] = "SIETE";
                else if (nota == 8) rw[4] = "OCHO";
                else if (nota == 9) rw[4] = "NUEVE";
                else if (nota == 10) rw[4] = "DIEZ";
                else if (nota == 11) rw[4] = "ONCE";
                else if (nota == 12) rw[4] = "DOCE";
                else if (nota == 13) rw[4] = "TRECE";
                else if (nota == 14) rw[4] = "CATORCE";
                else if (nota == 15) rw[4] = "QUINCE";
                else if (nota == 16) rw[4] = "DIECISEIS";
                else if (nota == 17) rw[4] = "DIECISIETE";
                else if (nota == 18) rw[4] = "DIECIOCHO";
                else if (nota == 19) rw[4] = "DIECINUEVE";
                else if (nota == 20) rw[4] = "VEINTE";
                if (nota < 14) desaprobados++;
                else if (nota >= 14) aprobados++;
                dt.Rows.Add(rw);
            }
            int total = aprobados + desaprobados;
            using (frmRptActaFinal frm = new frmRptActaFinal(dt, anho, txtIdioma.Text, txtCiclo.Text,
                txtDocente.Text, mes, txtNivel.Text, aprobados.ToString(), desaprobados.ToString(), total.ToString(),txtNumero.Text))
            {
                frm.ShowDialog();
            }


        }



        private void btnRelacionAlumnos_Click(object sender, EventArgs e)
        {
            dtListaAlumno.Columns[0].ColumnName = "codigo";
            dtListaAlumno.Columns[1].ColumnName = "nombre";
            dtListaAlumno.Columns.Add("numero");
            for (int i = 0; i < dtListaAlumno.Rows.Count; i++)
            {
                dtListaAlumno.Rows[i]["numero"] = i + 1 + "";
            }
            using (frmRptRelacionAlumnos frm = new frmRptRelacionAlumnos(dtListaAlumno, txtIdioma.Text, txtNivel.Text, txtCiclo.Text,
                txtDocente.Text, txtSalon.Text, txtHorario.Text, txtHorario2.Text,txtNumero.Text,txtInicio.Text,txtFin.Text,txtDias.Text))
            {
                frm.ShowDialog();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btnEliminarAlumno_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("EL ALUMNO "+nombreAlumno+" SERÁ ELIMINADO DEL GRUPO, LOS REGISTROS DE SUS ASISTENCIAS Y NOTAS TAMBIÉN SERÁN BORRADAS \n ¿DESEAS CONTINUAR?", "ADVERTENCIA", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //buscar idallumnogrupo y borrarlo
                string idAlumnoGrupo = buscarAlumnoGrupo(nroCarnet);
                eliminarAsistenciaNotas(idAlumnoGrupo);
                nroCarnet = "";
                MessageBox.Show("Alumno eliminado exitosamente");
                dgvwNotas.DataSource = null;
                dgvwNotas.Columns.Clear();
                dgvwNotas.Rows.Clear();
                cargarAlumnosBase(codigoGrupo);
                cargarAlumnoTabla();

                listarNotasListening(codigoGrupo);
                listarNotasReading(codigoGrupo);
                listarNotasSpeaking(codigoGrupo);
                listarNotasUseOfEnglish(codigoGrupo);
                listarNotasWriting(codigoGrupo);
            }
        }
        public void eliminarAsistenciaNotas(string idAlumnoGrupo)
        {
            SqlCommand comando = new SqlCommand("eliminar_asistencia_y_notas", _SqlConnection);
            comando.CommandType = CommandType.StoredProcedure;
            if (comando.Connection.State == ConnectionState.Closed)
            {
                comando.Connection.Open();
            }
            comando.Parameters.Add(new SqlParameter("@idAlumnoGrupo", idAlumnoGrupo));
            comando.ExecuteNonQuery();
            if (comando.Connection.State == ConnectionState.Open)
            {
                comando.Connection.Close();
            }
        }
        

        public string buscarAlumnoGrupo(string nrocar)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("buscar_idalumnogrupo_carnet", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.Parameters.Add(new SqlParameter("@nroCarnet", nroCarnet));
                cmd.Parameters.Add(new SqlParameter("@idGrupo", codigoGrupo));
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                string idAlumnoGrupo = dt.Rows[0][0].ToString();
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                return idAlumnoGrupo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
        }

        private void dgvwNotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnAsistencias_Click(object sender, EventArgs e)
        {
            DataTable dtMain = new DataTable();
            try
            {
                SqlCommand cmd3 = new SqlCommand("listar_asistencias_grupo", _SqlConnection);
                if (cmd3.Connection.State == ConnectionState.Closed)
                {
                    cmd3.Connection.Open();
                }
                cmd3.CommandType = CommandType.StoredProcedure;
                cmd3.Parameters.Add(new SqlParameter("@idgrupo", codigoGrupo));
                SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                da3.Fill(dtMain);
                if (cmd3.Connection.State == ConnectionState.Closed)
                {
                    cmd3.Connection.Close();
                }
                
                dtMain.Columns.Add("fa");
                dtMain.Columns.Add("numero");
                dtMain.Columns.Add("porcentaje");
                int i = 1;
                if (dtMain.Rows.Count > 0)
                {
                    string codigo = dtMain.Rows[0]["numerocarnet"].ToString();
                    double start = 0;
                    double end;
                    double asis = 0;
                    for (int j = 0; j < dtMain.Rows.Count; j++)
                    {
                        dtMain.Rows[j]["fa"] = Convert.ToDateTime(dtMain.Rows[j]["fecha"]).ToString("dd/MM");
                        if (codigo != dtMain.Rows[j]["numerocarnet"].ToString())
                        {
                            codigo = dtMain.Rows[j]["numerocarnet"].ToString();
                            i++;
                            end = j - 1;
                            double porcentaje = Math.Round(asis / (end - start + 1) * 100, 2);
                            //MessageBox.Show(porcentaje + "");
                            for (int w = (int)start; w < (int)end; w++)
                            {
                                dtMain.Rows[w]["porcentaje"] = porcentaje;
                            }
                            asis = 0;
                            start = j;
                            end = 0;
                        }
                        else
                        {

                        }
                        if (dtMain.Rows[j]["Asistencia"].ToString() == "A" || dtMain.Rows[j]["numerocarnet"].ToString() == "J")
                        {
                            asis++;
                        }
                        dtMain.Rows[j]["numero"] = i.ToString().PadLeft(2, '0');
                        if (j == dtMain.Rows.Count - 1)
                        {
                            end = j;
                            double porcentaje = Math.Round(asis / (end - start + 1) * 100, 2);
                            for (int w = (int)start; w < (int)end; w++)
                            {
                                dtMain.Rows[w]["porcentaje"] = porcentaje;
                            }
                        }
                    }
                    dtMain.Columns.Remove("fecha");
                    dtMain.Columns["fa"].ColumnName = "fecha";

                    new frmRptAsistenciaGrupo(dtMain, anho, txtIdioma.Text, txtCiclo.Text,
                    txtDocente.Text, mes, txtNivel.Text, txtNumero.Text,
                    Convert.ToDateTime(txtInicio.Text).ToString("dd/MM/yy"),
                        Convert.ToDateTime(txtFin.Text).ToString("dd/MM/yy")).Show();
                }



                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmVerNotasAsistenciasDocente_Load(object sender, EventArgs e)
        {


        }
    }
}
