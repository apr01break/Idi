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
    public partial class frmAgregarHorarioReferencia : MaterialForm
    {
        frmCrearPago frmCrearPago;
        public static SqlConnection _SqlConnection = new SqlConnection();
        MsSqlConnection configurarConexion = new MsSqlConnection();
        public frmAgregarHorarioReferencia(frmCrearPago frmCrearPago)
        {
            InitializeComponent();
            this.frmCrearPago = frmCrearPago;
            _SqlConnection.ConnectionString = configurarConexion._ConnectionString;
            dtmHoraInicio.CustomFormat = "HH:mm";
            dtmHoraFinal.CustomFormat = "HH:mm";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String horario="";
            if (cbAno.Text.Trim() == "" || cbMes.Text.Trim() == "" || cbDias.CheckedItems.Count == 0)
            {
                MessageBox.Show("Completa todos los campos");
            }
            else
            {
                
                foreach (String dia in cbDias.CheckedItems)
                {
                    horario += dia + "-";
                }
                horario = horario.Remove(horario.Length - 1);
                horario += " " + Convert.ToDateTime(dtmHoraInicio.Value).ToString("HH:mm")+"-"+ Convert.ToDateTime(dtmHoraFinal.Value).ToString("HH:mm");
                horario += " " + cbMes.Text + " " + cbAno.Text;
                try
                {
                    SqlCommand cmd = new SqlCommand("insertar_horario_referencia", _SqlConnection);
                    if (cmd.Connection.State == ConnectionState.Closed)
                    {
                        cmd.Connection.Open();
                    }
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@descripcion", horario));
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
                frmCrearPago.listarHorarios();
                this.Dispose();
                this.Close();
            }
            
        }
    }
}
