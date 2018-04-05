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
    public partial class frmAgregarNotasExtemporaneo : MaterialForm
    {
        MsSqlConnection configurarConexion = new MsSqlConnection();
        public static SqlConnection _SqlConnection = new SqlConnection();
        int idGrupo;
        string fecha;
        List<RichTextBox> lblListListening = new List<RichTextBox>();
        List<TextBox> txtListListening = new List<TextBox>();
        List<RichTextBox> lblListWriting = new List<RichTextBox>();
        List<TextBox> txtListWriting = new List<TextBox>();
        List<RichTextBox> lblListSpeaking = new List<RichTextBox>();
        List<TextBox> txtListSpeaking = new List<TextBox>();
        List<RichTextBox> lblListReading = new List<RichTextBox>();
        List<TextBox> txtListReading = new List<TextBox>();
        List<RichTextBox> lblListUseOfEnglish = new List<RichTextBox>();
        List<TextBox> txtListUseOfEnglish = new List<TextBox>();
        frmAgregarAlumnoExtemporaneo frmAgregarAlumnoExtemporaneo;
        public frmAgregarNotasExtemporaneo(int idGrupo, string fecha, frmAgregarAlumnoExtemporaneo frmAgregarAlumnoExtemporaneo)
        {
            InitializeComponent();
            _SqlConnection.ConnectionString = configurarConexion._ConnectionString;
            this.idGrupo = idGrupo;
            this.fecha = fecha;
            this.frmAgregarAlumnoExtemporaneo = frmAgregarAlumnoExtemporaneo;
        }
        public void cargarListening()
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
            int d = 180;
            foreach (DataRow row in dt.Rows)
            {
                String criterio = row[0].ToString();
                RichTextBox newLbl = new RichTextBox() { Text = criterio };
                newLbl.Location = new Point(d, 31);
                newLbl.AutoSize = false;
                newLbl.ReadOnly = true;
                newLbl.Size = new Size(100, 21);
                lblListListening.Add(newLbl);
                panel1.Controls.Add(newLbl);
                TextBox newTxt = new TextBox();
                newTxt.Location = new Point(d, 55);
                newTxt.KeyPress += (s, e) => validarNumeros(s,e);
                txtListListening.Add(newTxt);
                panel1.Controls.Add(newTxt);
                d += 20;
            }
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
        }

        public void cargarWriting()
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
            int d = 180;
            foreach (DataRow row in dt.Rows)
            {
                String criterio = row[0].ToString();
                RichTextBox newLbl = new RichTextBox() { Text = criterio };
                newLbl.Location = new Point(d, 93);
                newLbl.AutoSize = false;
                newLbl.ReadOnly = true;
                newLbl.Size = new Size(100, 21);
                lblListWriting.Add(newLbl);
                panel1.Controls.Add(newLbl);
                TextBox newTxt = new TextBox();
                newTxt.Location = new Point(d, 117);
                newTxt.KeyPress += (s, e) => validarNumeros(s, e);
                txtListWriting.Add(newTxt);
                panel1.Controls.Add(newTxt);
                d += 20;
            }
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
        }

        public void cargarSpeaking()
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
            int d = 180;
            foreach (DataRow row in dt.Rows)
            {
                String criterio = row[0].ToString();
                RichTextBox newLbl = new RichTextBox() { Text = criterio };
                newLbl.Location = new Point(d, 155);
                newLbl.AutoSize = false;
                newLbl.ReadOnly = true;
                newLbl.Size = new Size(100, 21);
                lblListSpeaking.Add(newLbl);
                panel1.Controls.Add(newLbl);
                TextBox newTxt = new TextBox();
                newTxt.Location = new Point(d, 179);
                newTxt.KeyPress += (s, e) => validarNumeros(s, e);
                txtListSpeaking.Add(newTxt);
                panel1.Controls.Add(newTxt);
                d += 20;
            }
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
        }

        public void cargarReading()
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
            int d = 180;
            foreach (DataRow row in dt.Rows)
            {
                String criterio = row[0].ToString();
                RichTextBox newLbl = new RichTextBox() { Text = criterio };
                newLbl.Location = new Point(d, 217);
                newLbl.AutoSize = false;
                newLbl.ReadOnly = true;
                newLbl.Size = new Size(100, 21);
                lblListReading.Add(newLbl);
                panel1.Controls.Add(newLbl);
                TextBox newTxt = new TextBox();
                newTxt.Location = new Point(d, 241);
                newTxt.KeyPress += (s, e) => validarNumeros(s, e);
                txtListReading.Add(newTxt);
                panel1.Controls.Add(newTxt);
                d += 20;
            }
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
        }

        public void cargarUseOfEnglish()
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
            int d = 180;
            foreach (DataRow row in dt.Rows)
            {
                String criterio = row[0].ToString();
                RichTextBox newLbl = new RichTextBox() { Text = criterio };
                newLbl.Location = new Point(d, 279);
                newLbl.AutoSize = false;
                newLbl.ReadOnly = true;
                newLbl.Size = new Size(100, 21);
                lblListUseOfEnglish.Add(newLbl);
                panel1.Controls.Add(newLbl);
                TextBox newTxt = new TextBox();
                newTxt.Location = new Point(d, 303);
                newTxt.KeyPress += (s, e) => validarNumeros(s, e);
                txtListUseOfEnglish.Add(newTxt);
                panel1.Controls.Add(newTxt);
                d += 20;
            }
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
        }

        private void frmAgregarNotasExtemporaneo_Load(object sender, EventArgs e)
        {
            cargarListening();
            cargarWriting();
            cargarSpeaking();
            cargarReading();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public Boolean verificarVacios()
        {
            foreach (TextBox txt in txtListListening)
            {
                if (txt.Text.Trim() == "" || Convert.ToInt32(txt.Text)<0 || Convert.ToInt32(txt.Text) > 20) return false;
            }
            foreach (TextBox txt in txtListReading)
            {
                if (txt.Text.Trim() == "" || Convert.ToInt32(txt.Text) < 0 || Convert.ToInt32(txt.Text) > 20) return false;
            }
            foreach (TextBox txt in txtListSpeaking)
            {
                if (txt.Text.Trim() == "" || Convert.ToInt32(txt.Text) < 0 || Convert.ToInt32(txt.Text) > 20) return false;
            }
            foreach (TextBox txt in txtListWriting)
            {
                if (txt.Text.Trim() == "" || Convert.ToInt32(txt.Text) < 0 || Convert.ToInt32(txt.Text) > 20) return false;
            }
            foreach (TextBox txt in txtListUseOfEnglish)
            {
                if (txt.Text.Trim() == "" || Convert.ToInt32(txt.Text) < 0 || Convert.ToInt32(txt.Text) > 20) return false;
            }
            return true;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!verificarVacios())
            {
                MessageBox.Show("Verifique las notas");
            }
            else
            {
                
                for (int i = 0; i < lblListListening.Count; i++)
                {
                    string[,] x = new string[1, 4];
                    x[0, 0] = "listening";
                    x[0, 1] = fecha;
                    x[0, 2] = lblListListening[i].Text;
                    x[0, 3] = txtListListening[i].Text;
                    frmAgregarAlumnoExtemporaneo.notasList.Add(x);
                }
                for (int i = 0; i < lblListWriting.Count; i++)
                {
                    string[,] x = new string[1, 4];
                    x[0, 0] = "writing";
                    x[0, 1] = fecha;
                    x[0, 2] = lblListWriting[i].Text;
                    x[0, 3] = txtListWriting[i].Text;
                    frmAgregarAlumnoExtemporaneo.notasList.Add(x);
                }
                for (int i = 0; i < lblListSpeaking.Count; i++)
                {
                    string[,] x = new string[1, 4];
                    x[0, 0] = "speaking";
                    x[0, 1] = fecha;
                    x[0, 2] = lblListSpeaking[i].Text;
                    x[0, 3] = txtListSpeaking[i].Text;
                    frmAgregarAlumnoExtemporaneo.notasList.Add(x);
                }
                for (int i = 0; i < lblListReading.Count; i++)
                {
                    string[,] x = new string[1, 4];
                    x[0, 0] = "reading";
                    x[0, 1] = fecha;
                    x[0, 2] = lblListReading[i].Text;
                    x[0, 3] = txtListReading[i].Text;
                    frmAgregarAlumnoExtemporaneo.notasList.Add(x);
                }
                for (int i = 0; i < lblListUseOfEnglish.Count; i++)
                {
                    string[,] x = new string[1, 4];
                    x[0, 0] = "use of english";
                    x[0, 1] = fecha;
                    x[0, 2] = lblListUseOfEnglish[i].Text;
                    x[0, 3] = txtListUseOfEnglish[i].Text;
                    frmAgregarAlumnoExtemporaneo.notasList.Add(x);
                }
                
                this.Dispose();
                this.Close();

            }
        }
        public void guardarListening()
        {

        }

        private void validarNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if(e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }
    }
}
