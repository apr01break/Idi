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
    public partial class frmActualizarUsuario : MaterialForm
    {
        MsSqlConnection configurarConexion = new MsSqlConnection();
        public static SqlConnection _SqlConnection = new SqlConnection();
        public frmActualizarUsuario()
        {
            InitializeComponent();
            _SqlConnection.ConnectionString = configurarConexion._ConnectionString;
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                _SqlConnection.Open();
                SqlCommand cmd = new SqlCommand("buscarUsuarioApellido", _SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@txt", txtBuscar.Text.Trim()));
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                dt.Clear();

                da.Fill(dt);


                dgvwUsuarios.DataSource = dt;
                dgvwUsuarios.Columns[0].Width = 205;
                dgvwUsuarios.Columns["DNI"].Width = 90;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                _SqlConnection.Close();
            }
        }

        private void dgvwUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvwUsuarios.RowCount)
            {
                DataGridViewRow row = this.dgvwUsuarios.Rows[e.RowIndex];
                String dni = row.Cells["DNI"].Value.ToString();
                try
                {
                    DataTable dt = new DataTable();
                    SqlCommand comando = new SqlCommand("buscarUsuario", _SqlConnection);
                    comando.CommandType = CommandType.StoredProcedure;
                    if (comando.Connection.State == ConnectionState.Closed)
                    {
                        comando.Connection.Open();
                    }
                    comando.Parameters.Add(new SqlParameter("@dni", dni));
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    da.Fill(dt);
                    byte[] img = (byte[])(dt.Rows[0][11]);
                    if (img == null)
                    {
                        FOTOUSER.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        FOTOUSER.Image = Image.FromStream(ms);
                    }
                    lblIdPersona.Text = dt.Rows[0][0].ToString();
                    TXTDNI.Text = dt.Rows[0][1].ToString();
                    TXTNOMBRESUSER.Text = dt.Rows[0][2].ToString();
                    TXTPATERNOUSER.Text = dt.Rows[0][3].ToString();
                    if (dt.Rows[0][4].ToString() == "MASCULINO")
                    {
                        CBSEXO.SelectedIndex = 0;
                    }
                    else
                    {
                        CBSEXO.SelectedIndex = 1;
                    }
                    TXTMATERNOUSER.Text = dt.Rows[0][5].ToString();
                    CBINSTRUCCION.Text = dt.Rows[0][8].ToString();
                    TXTTELEFONOUSER.Text = dt.Rows[0][9].ToString();
                    TXTCELULARUSER.Text = dt.Rows[0][10].ToString();
                    TXTCORREOUSER.Text = dt.Rows[0][12].ToString();
                    NACIMIENTO_USER_DATE.Value = DateTime.Parse(dt.Rows[0][13].ToString());

                    if (comando.Connection.State == ConnectionState.Open)
                    {
                        comando.Connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                btnGuardar.Enabled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand comando = new SqlCommand("actualizarPersona", _SqlConnection);
                comando.CommandType = CommandType.StoredProcedure;
                if (comando.Connection.State == ConnectionState.Closed)
                {
                    comando.Connection.Open();
                }
                comando.Parameters.Add(new SqlParameter("@id", lblIdPersona.Text.ToString()));
                comando.Parameters.Add(new SqlParameter("@paterno", TXTPATERNOUSER.Text.Trim()));
                comando.Parameters.Add(new SqlParameter("@dni", TXTDNI.Text.Trim()));
                comando.Parameters.Add(new SqlParameter("@nombre", TXTNOMBRESUSER.Text.Trim()));
                comando.Parameters.Add(new SqlParameter("@materno", TXTMATERNOUSER.Text.Trim()));
                comando.Parameters.Add(new SqlParameter("@sexo", CBSEXO.SelectedItem.ToString()));
                comando.Parameters.Add(new SqlParameter("@edad", TXTEDADUSER.Text.Trim()));
                comando.Parameters.Add(new SqlParameter("@celular", TXTCELULARUSER.Text.Trim()));
                comando.Parameters.Add(new SqlParameter("@telefono", TXTTELEFONOUSER.Text.Trim()));
                comando.Parameters.Add(new SqlParameter("@correo", TXTCORREOUSER.Text.Trim()));
                comando.Parameters.Add(new SqlParameter("@nacimiento", NACIMIENTO_USER_DATE.Value));
                comando.Parameters.Add("@foto", System.Data.SqlDbType.Image);
                //asignando el valor de la imagen
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                //se guarda la imagen en el buffer
                FOTOUSER.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                //se extraen los bytes del buffer para asignarlos como valor para el parametro
                comando.Parameters["@foto"].Value = ms.GetBuffer();
                comando.ExecuteNonQuery();
                //DESHABILITARCONTROLES();
                if (comando.Connection.State == ConnectionState.Open)
                {
                    comando.Connection.Close();
                }
                MessageBox.Show("REGISTRO ACTUALIZADO");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmActualizarUsuario_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtBuscar;
        }

        private void NACIMIENTO_USER_DATE_ValueChanged(object sender, EventArgs e)
        {
            if (NACIMIENTO_USER_DATE.Value < DateTime.Today)
            {
                //CODIGO USADO PARA CALCULAR LA EDAD AUTOMATICAMENTE
                TXTEDADUSER.Text = (DateTime.Today.AddTicks(-NACIMIENTO_USER_DATE.Value.Ticks).Year - 1).ToString();
            }
            else
            {
                NACIMIENTO_USER_DATE.Value = DateTime.Today;
            }
        }
    }
}
