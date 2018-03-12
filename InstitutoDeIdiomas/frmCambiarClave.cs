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
    public partial class frmCambiarClave : MaterialForm
    {
        MsSqlConnection configurarConexion = new MsSqlConnection();
        public static SqlConnection _SqlConnection = new SqlConnection();
        String idUsuario;
        public frmCambiarClave(String idUsuario)
        {
            InitializeComponent();
            _SqlConnection.ConnectionString = configurarConexion._ConnectionString;
            this.idUsuario = idUsuario;
        }

        public bool verificarClave()
        {
            try
            {
                _SqlConnection.Open();
                SqlCommand cmd = new SqlCommand("verificar_clave", _SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id", idUsuario));
                cmd.Parameters.Add(new SqlParameter("@password", txtClaveActual.Text));

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                _SqlConnection.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtClaveActual.Text.Trim() == "" || txtNuevaClave.Text.Trim() == "" || txtRepetirNuevaClave.Text.Trim() == "")
            {
                MessageBox.Show("Completa todos los campos");
            }
            else if (!verificarClave())
            {
                MessageBox.Show("Contraseña actual incorrecta", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(txtNuevaClave.Text != txtRepetirNuevaClave.Text)
            {
                MessageBox.Show("Ambas contraseñas deben coincidir", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("cambiar_clave", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.Parameters.Add(new SqlParameter("@id", idUsuario));
                cmd.Parameters.Add(new SqlParameter("@password", txtNuevaClave.Text));
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                MessageBox.Show("Cambio exitoso", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Dispose();
                this.Close();
            }
        }
    }
}
