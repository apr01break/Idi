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
    public partial class frmReporteGrupos : MaterialForm
    {
        MsSqlConnection configurarConexion = new MsSqlConnection();
        public static SqlConnection _SqlConnection = new SqlConnection();
        public frmReporteGrupos()
        {
            InitializeComponent();
            _SqlConnection.ConnectionString = configurarConexion._ConnectionString;
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            if (cbMes.Text == "" || cbAnho.Text == "")
            {
                MessageBox.Show("Seleccione una opción");
            }
            else
            {
                int mes = 0;
                if (cbMes.Text == "ENERO")
                {
                    mes = 1;
                }
                else if (cbMes.Text == "FEBRERO")
                {
                    mes = 2;
                }
                else if (cbMes.Text == "MARZO")
                {
                    mes = 3;
                }
                else if (cbMes.Text == "ABRIL")
                {
                    mes = 4;
                }

                else if (cbMes.Text == "MAYO")
                {
                    mes = 5;
                }
                else if (cbMes.Text == "JUNIO")
                {
                    mes = 6;
                }
                else if (cbMes.Text == "JULIO")
                {
                    mes = 7;
                }
                else if (cbMes.Text == "AGOSTO")
                {
                    mes = 8;
                }
                else if (cbMes.Text == "SETIEMBRE")
                {
                    mes = 9;
                }
                else if (cbMes.Text == "OCTUBRE")
                {
                    mes = 10;
                }
                else if (cbMes.Text == "NOVIEMBRE")
                {
                    mes = 11;
                }
                else if (cbMes.Text == "DICIEMBRE")
                {
                    mes = 12;
                }

                DataTable dtBasico = ListarGruposBasico(mes, cbAnho.Text, "BASICO");
                DataTable dtIntermedio = ListarGruposBasico(mes, cbAnho.Text, "INTERMEDIO");
                DataTable dtAvanzado = ListarGruposBasico(mes, cbAnho.Text, "AVANZADO");
                new frmRptGrupos(dtBasico,dtIntermedio,dtAvanzado, cbMes.Text).Show();
            }
        }

        public DataTable ListarGruposBasico(int mes, string anho, string nivel)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("listar_grupos_nivel", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.Parameters.Add(new SqlParameter("@mes", mes));
                cmd.Parameters.Add(new SqlParameter("@anho", cbAnho.Text));
                cmd.Parameters.Add(new SqlParameter("@nivel", nivel));
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                dt.Columns.Add("dias");
                foreach (DataRow row in dt.Rows)
                {
                    string dias = cargarDias(row["idGrupo"].ToString());
                    row["dias"] = dias;
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public string cargarDias(string idGrupo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("listar_dias_grupo", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.Parameters.Add(new SqlParameter("@idGrupo", Convert.ToInt32(idGrupo)));
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                String xx = "";
                foreach (DataRow row in dt.Rows)
                {
                    xx = xx + row[0].ToString().ToUpperInvariant() + " - ";
                }
                xx = xx.Trim();
                if (xx != "") xx = xx.Remove(xx.Length - 1);
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                return xx;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "cargarDias");
                return null;
            }
        }
    }
}