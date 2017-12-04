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
    public partial class frmAgregarSaldo : Form
    {
        public static SqlConnection _SqlConnection = new SqlConnection();
        MsSqlConnection configurarConexion = new MsSqlConnection();
        String codTrabajador, codAlumno;
        public frmAgregarSaldo(String codTrabajador,string codAlumno)
        {
            InitializeComponent();
            _SqlConnection.ConnectionString = configurarConexion._ConnectionString;
            this.codTrabajador = codTrabajador;
            this.codAlumno = codAlumno;
        }
        public void guardarPago()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("crear_nuevo_pago", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@numero_recibo", txtNumeroRecibo.Text.Trim().ToString()));
                cmd.Parameters.Add(new SqlParameter("@fecha", dateRecibo.Value));
                cmd.Parameters.Add(new SqlParameter("@codigo_alumno", codAlumno));
                cmd.Parameters.Add(new SqlParameter("@idtrabajador", codTrabajador));
                cmd.Parameters.Add(new SqlParameter("@montoRecibo", txtMontoRecibo.Text));
                cmd.Parameters.Add(new SqlParameter("@montoCalculado", "0"));
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
        public void guardarSaldo()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("crear_nuevo_saldo", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@montoSaldo", txtMontoRecibo.Text));
                cmd.Parameters.Add(new SqlParameter("@numRecibo", txtNumeroRecibo.Text.Trim().ToString()));
                cmd.ExecuteNonQuery();
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                MessageBox.Show("Saldo de "+txtMontoRecibo.Text+" soles guardado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmAgregarSaldo_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardarPago();
            guardarSaldo();
            this.Close();
        }
    }
}