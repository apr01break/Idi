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
using AForge.Video;
using AForge.Video.DirectShow;
using MaterialSkin.Controls;

namespace InstitutoDeIdiomas
{
    public partial class frmEntradaSalida : MaterialForm
    {
        MsSqlConnection configurarConexion = new MsSqlConnection();
        public static SqlConnection _SqlConnection = new SqlConnection();
        private VideoCaptureDevice videoSource;
        private FilterInfoCollection videoDevices;
        int idUsuario;
        public frmEntradaSalida( int idUsuario)
        {
            InitializeComponent();
            _SqlConnection.ConnectionString = configurarConexion._ConnectionString;
            this.idUsuario = idUsuario;
        }
        void NewFrame_event(object sender, NewFrameEventArgs e)
        {
            try
            {
                Bitmap image = (Bitmap)e.Frame.Clone();
                pictureBox1.Image = image;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void frmEntradaSalida_Load(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(NewFrame_event);
            videoSource.Start();
        }
        
        private void frmEntradaSalida_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.Stop();
                pictureBox1.Image = null;
                pictureBox1.Invalidate();
            }
        }

        private void rbEntrada_CheckedChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
        }

        private void rbSalida_CheckedChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string tipo = (gbTipo.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)).Text.ToString();
                SqlCommand cmd = new SqlCommand("registrar_asistencia_usuario", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.Parameters.Add(new SqlParameter("@idUsuario", idUsuario));
                cmd.Parameters.Add(new SqlParameter("@tipo", tipo));
                cmd.Parameters.Add("@foto", System.Data.SqlDbType.Image);
                //asignando el valor de la imagen
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                //se guarda la imagen en el buffer
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                //se extraen los bytes del buffer para asignarlos como valor para el parametro
                cmd.Parameters["@foto"].Value = ms.GetBuffer();

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                MessageBox.Show(tipo+" registrada exitosamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
    }
}
