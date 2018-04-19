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
    public partial class frmAgregarAlumnoExtemporaneo : MaterialForm
    {
        MsSqlConnection configurarConexion = new MsSqlConnection();
        public static SqlConnection _SqlConnection = new SqlConnection();
        frmVerNotas frmVerNotas;
        string codigoAlumno;
        
        int idGrupo;
        List<Label> labelList = new List<Label>();
        List<Button> buttonList = new List<Button>();
        List<ComboBox> comboBoxList = new List<ComboBox>();
        public List<string[,]> notasList = new List<string[,]>();
        public frmAgregarAlumnoExtemporaneo(int idGrupo, frmVerNotas frmVerNotas)
        {
            InitializeComponent();
            _SqlConnection.ConnectionString = configurarConexion._ConnectionString;
            this.idGrupo = idGrupo;
            this.frmVerNotas = frmVerNotas;
        }

        private void frmAgregarAlumnoExtemporaneo_Load(object sender, EventArgs e)
        {
            dgvwNotas.Columns.Add("Criterio", "Criterio");
            dgvwNotas.Columns.Add("Fecha", "Fecha");
            dgvwNotas.Columns.Add("Titulo", "Titulo");
            dgvwNotas.Columns.Add("Nota", "Nota");
            dgvwNotas.Columns[0].ReadOnly = true;
            dgvwNotas.Columns[1].ReadOnly = true;
            dgvwNotas.Columns[2].ReadOnly = true;
            cargarFechasClase();
        }
        public Boolean verificarAlumnoGrupo(String codAlu, String codGrupo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("verificar_alumno_grupo", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.Parameters.Add(new SqlParameter("@idalumno", codigoAlumno));
                cmd.Parameters.Add(new SqlParameter("@idgrupo", codGrupo));
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                if (dt.Rows.Count == 0)
                {
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public void cargarFechasClase()
        {
            //try
            //{
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
                
                int d = 40;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    String fecha = Convert.ToDateTime(dt.Rows[i][0]).ToString("dd/MM/yy");
                    Label newLbl = new Label() { Text = ""+ fecha };
                    newLbl.Size = new Size(65, 21);
                    newLbl.Location = new Point(360, d);
                    labelList.Add(newLbl);
                    panel1.Controls.Add(newLbl);
                    Button newBtn = new Button() { Text = "Agregar" };
                    newBtn.Location = new Point(560, d-6);
                    newBtn.Enabled = false;
                    newBtn.Click += (s, e) => clickBtn(fecha);
                    buttonList.Add(newBtn);
                    panel1.Controls.Add(newBtn);

                    ComboBox newCb = new ComboBox();
                    newCb.Size = new Size(60,21);
                    newCb.Location = new Point(440, d - 5);
                    newCb.DisplayMember = "Text";
                    newCb.ValueMember = "Value";
                    newCb.Items.Add(new { Text = "A", Value = "1" });
                    newCb.Items.Add(new { Text = "F", Value = "2" });
                    newCb.Items.Add(new { Text = "J", Value = "3" });
                    cargarListening(fecha);
                    cargarWriting(fecha);
                    cargarSpeaking(fecha);
                    cargarReading(fecha);
                    cargarUseOfEnglish(fecha);
                    newCb.DropDownStyle = ComboBoxStyle.DropDownList;
                    newCb.SelectedIndexChanged += (s, e) => selectIndexChangesCB(newCb,fecha);
                    newCb.SelectedIndex=0;
                    comboBoxList.Add(newCb);
                    panel1.Controls.Add(newCb);
                    d = d + 50;
                }
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
        public void cargarListening(string fecha)
        {
            SqlCommand cmd = new SqlCommand("listar_criterios_listening", _SqlConnection);
            if (cmd.Connection.State == ConnectionState.Closed)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.Add(new SqlParameter("@idGrupo", idGrupo));
            cmd.Parameters.Add(new SqlParameter("@fecha", fecha));
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                String criterio = row[0].ToString();
                dgvwNotas.Rows.Add("LISTENING", fecha, criterio, "");
            }
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
        }
        public void cargarWriting(string fecha)
        {
            SqlCommand cmd = new SqlCommand("listar_criterios_writing", _SqlConnection);
            if (cmd.Connection.State == ConnectionState.Closed)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.Add(new SqlParameter("@idGrupo", idGrupo));
            cmd.Parameters.Add(new SqlParameter("@fecha", fecha));
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                String criterio = row[0].ToString();
                dgvwNotas.Rows.Add("WRITING", fecha, criterio, "");
            }
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
        }
        public void cargarSpeaking(string fecha)
        {
            SqlCommand cmd = new SqlCommand("listar_criterios_speaking", _SqlConnection);
            if (cmd.Connection.State == ConnectionState.Closed)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.Add(new SqlParameter("@idGrupo", idGrupo));
            cmd.Parameters.Add(new SqlParameter("@fecha", fecha));
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                String criterio = row[0].ToString();
                dgvwNotas.Rows.Add("SPEAKING", fecha, criterio, "");
            }
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
        }
        public void cargarReading(string fecha)
        {
            SqlCommand cmd = new SqlCommand("listar_criterios_reading", _SqlConnection);
            if (cmd.Connection.State == ConnectionState.Closed)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.Add(new SqlParameter("@idGrupo", idGrupo));
            cmd.Parameters.Add(new SqlParameter("@fecha", fecha));
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                String criterio = row[0].ToString();
                dgvwNotas.Rows.Add("READING", fecha, criterio, "");
            }
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
        }
        public void cargarUseOfEnglish(string fecha)
        {
            SqlCommand cmd = new SqlCommand("listar_criterios_useofenglish", _SqlConnection);
            if (cmd.Connection.State == ConnectionState.Closed)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.Add(new SqlParameter("@idGrupo", idGrupo));
            cmd.Parameters.Add(new SqlParameter("@fecha", fecha));
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                String criterio = row[0].ToString();
                dgvwNotas.Rows.Add("USE OF ENGLISH", fecha, criterio, "");
            }
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
        }
        public void clickBtn(String fecha)
        {
            new frmAgregarNotasExtemporaneo(idGrupo,fecha,this).ShowDialog();
        }
        public void selectIndexChangesCB(ComboBox newCb, string fecha)
        {
            if (newCb.Text == "A")
            {
                foreach (DataGridViewRow item in dgvwNotas.Rows)
                {
                    if (item.Cells[1].Value.ToString() == fecha)
                    {
                        item.Cells[3].Value = "";
                        item.Cells[3].ReadOnly = false;
                    }
                }
            }
            else if (newCb.Text == "F")
            {
                foreach (DataGridViewRow item in dgvwNotas.Rows)
                {
                    if (item.Cells[1].Value.ToString() == fecha)
                    {
                        item.Cells[3].Value = "0";
                        item.Cells[3].ReadOnly = true;
                    }
                }
            }
            else if (newCb.Text == "J")
            {
                foreach (DataGridViewRow item in dgvwNotas.Rows)
                {
                    if (item.Cells[1].Value.ToString() == fecha)
                    {
                        item.Cells[3].Value = "-1";
                        item.Cells[3].ReadOnly = true;
                    }
                }
            }

        }
        

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                String d = txtBuscar.Text;
                if (d.Equals(""))
                {
                    d = "wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww";
                }
                SqlCommand cmd = new SqlCommand("buscar_alumno_grupo_apellido", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.Parameters.Add(new SqlParameter("@apellido", d));
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvwAlumnos.DataSource = dt;
                dgvwAlumnos.Columns["CODIGO ALUMNO"].Visible = false;
                dgvwAlumnos.Columns["NOMBRE"].Width = 260;
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
        public void insertarAlumnoGrupo(string codigoAlumno, string codigoGrupo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert_alumno_grupo", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.Parameters.Add(new SqlParameter("@idalumno", codigoAlumno));
                cmd.Parameters.Add(new SqlParameter("@idgrupo", codigoGrupo));
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
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
        public string buscarIdAlumnoGrupo(string idAlumno)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("buscar_idalumnogrupo", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.Parameters.Add(new SqlParameter("@idAlumno", idAlumno));
                cmd.Parameters.Add(new SqlParameter("@idGrupo", idGrupo));
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

        private void guardarAsistencia(string idAlumnoGrupo, string idTipoAsistencia, string fecha)
        {
            SqlCommand cmd = new SqlCommand("insertar_asistencia", _SqlConnection);
            if (cmd.Connection.State == ConnectionState.Closed)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.Add(new SqlParameter("@idAlumnoGrupo", idAlumnoGrupo));
            cmd.Parameters.Add(new SqlParameter("@idTipoAsistencia", idTipoAsistencia));
            cmd.Parameters.Add(new SqlParameter("@fecha", fecha));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(!verificarAlumnoGrupo(codigoAlumno, idGrupo.ToString()))
            {
                if (verificarVacios() == 1)
                {
                    if (verificarNota() == 1)
                    {
                        insertarAlumnoGrupo(codigoAlumno, idGrupo.ToString());
                        string idAlumnoGrupo = buscarIdAlumnoGrupo(codigoAlumno);

                        for (int i = 0; i < comboBoxList.Count; i++)
                        {
                            string fecha = labelList[i].Text;
                            string idTipoAsistencia = Convert.ToString((comboBoxList[i].SelectedItem as dynamic).Value);
                            guardarAsistencia(idAlumnoGrupo, idTipoAsistencia, fecha);
                            //MessageBox.Show(idAlumnoGrupo + " " + fecha + " " + idTipoAsistencia);
                        }
                        foreach (DataGridViewRow item in dgvwNotas.Rows)
                        {
                            string criterio = item.Cells[0].Value.ToString().ToLower();
                            string fecha = item.Cells[1].Value.ToString();
                            string titulo = item.Cells[2].Value.ToString();
                            string nota = item.Cells[3].Value.ToString();
                            insertarNota(idAlumnoGrupo, criterio, fecha, titulo, nota);
                            //MessageBox.Show(criterio + " " + fecha + " " + titulo + " " + nota);
                        }
                        MessageBox.Show("El alumno se agregó exitosamente.");
                        dgvwNotas.DataSource = null;
                        dgvwNotas.Columns.Clear();
                        dgvwNotas.Rows.Clear();
                        frmVerNotas.cargarAlumnosBase(idGrupo);
                        frmVerNotas.cargarAlumnoTabla();
                        frmVerNotas.listarNotasListening(idGrupo);
                        frmVerNotas.listarNotasReading(idGrupo);
                        frmVerNotas.listarNotasSpeaking(idGrupo);
                        frmVerNotas.listarNotasUseOfEnglish(idGrupo);
                        frmVerNotas.listarNotasWriting(idGrupo);
                        this.Dispose();
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("El alumno ya pertenece a este grupo");
            }
            
        }

        public void insertarNota(string idAlumnoGrupo, string criterio, string fecha, string titulo, string nota)
        {
            string procedimiento = "";
            if (criterio == "listening")
            {
                procedimiento = "insert_listening";
            }
            else if(criterio == "writing")
            {
                procedimiento = "insert_writing";
            }
            else if (criterio == "speaking")
            {
                procedimiento = "insert_speaking";
            }
            else if (criterio == "reading")
            {
                procedimiento = "insert_reading";
            }
            else if (criterio == "use of english")
            {
                procedimiento = "insert_use_of_english";
            }
            try
            {
                SqlCommand cmd = new SqlCommand(procedimiento, _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.Parameters.Add(new SqlParameter("@idAlumnoGrupo", idAlumnoGrupo));
                cmd.Parameters.Add(new SqlParameter("@criterio", titulo));
                cmd.Parameters.Add(new SqlParameter("@nota", nota));
                cmd.Parameters.Add(new SqlParameter("@fecha", fecha));
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
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

        private void dgvwAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvwAlumnos.RowCount)
            {
                try
                {
                    DataGridViewRow row = dgvwAlumnos.Rows[e.RowIndex];
                    codigoAlumno = row.Cells["CODIGO ALUMNO"].Value.ToString();
                    btnGuardar.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
                
        }
        public int verificarNota()
        {
            try
            {
                for (int i = 0; i < dgvwNotas.RowCount; i++)
                {
                    int nota = Convert.ToInt32(dgvwNotas.Rows[i].Cells[3].Value);
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
                for (int i = 0; i < dgvwNotas.RowCount; i++)
                {
                    String nota = Convert.ToString(dgvwNotas.Rows[i].Cells[3].Value);
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
        private void dgvwNotas_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(Control_KeyPress);
        }

        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }
    }
}
