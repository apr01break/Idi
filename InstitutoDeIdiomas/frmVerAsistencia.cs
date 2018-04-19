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
using InstitutoDeIdiomas;
using InstitutoDeIdiomas.ReportForms;

namespace InstitutoDeIdiomas
{
    public partial class frmVerAsistencia : MaterialForm
    {
        MsSqlConnection configurarConexion = new MsSqlConnection();
        String ano, idioma, ciclo, docente, mes, nivel, numero,inicio,fin;
        public static SqlConnection _SqlConnection = new SqlConnection();
        int idGrupo;
        public frmVerAsistencia(int idGrupo)
        {
            InitializeComponent();
            _SqlConnection.ConnectionString = configurarConexion._ConnectionString;
            this.idGrupo = idGrupo;
        }

        private void frmVerAsistencia_Load(object sender, EventArgs e)
        {
            listarFechas();
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

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (cbFechas.Text!="")
            {
                if (MessageBox.Show("Se eliminara la asistencia del día " + cbFechas.Text + " \n ¿DESEAS CONTINUAR?", "ADVERTENCIA", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DataTable dtMain = new DataTable();
                    SqlCommand cmd3 = new SqlCommand("listar_asistencias_grupo", _SqlConnection);
                    if (cmd3.Connection.State == ConnectionState.Closed)
                    {
                        cmd3.Connection.Open();
                    }
                    cmd3.CommandType = CommandType.StoredProcedure;
                    cmd3.Parameters.Add(new SqlParameter("@idgrupo", idGrupo));
                    SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                    da3.Fill(dtMain);
                    if (cmd3.Connection.State == ConnectionState.Closed)
                    {
                        cmd3.Connection.Close();
                    }
                    foreach (DataRow item in dtMain.Rows)
                    {
                        string idAsis = item[0].ToString();
                        borrarAsistencia(idAsis);
                    }
                    MessageBox.Show("Asistencia del día " + cbFechas + " eliminada");
                    this.Dispose();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fecha");
            }
            
        }
        public void borrarAsistencia(string idAsis)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("elimar_asistencia", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.Parameters.Add(new SqlParameter("@idAsistencia", idAsis));
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "borrarAsistencia");
            }
        }
        public void cargarDatosGrupo()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("listar_grupo_seleccion", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.Parameters.Add(new SqlParameter("@idGrupo", idGrupo));
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                DataRow row2 = dt.Rows[0];
                idioma = row2[1].ToString();
                nivel = row2[2].ToString();
                ciclo = row2[3].ToString();
                ano = Convert.ToDateTime(row2[7]).ToString("yyyy");
                mes = Convert.ToDateTime(row2[7]).ToString("MMMMM").ToUpper();
                docente = row2[8].ToString();
                numero = row2[10].ToString();
                inicio = row2[7].ToString();
                fin = row2[9].ToString();
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "cargarDatosGrupo");
            }
        }
        private void btnReporteAsistencia_Click(object sender, EventArgs e)
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
                cmd3.Parameters.Add(new SqlParameter("@idgrupo", idGrupo));
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
                    foreach (DataRow row in dtMain.Rows)
                    {
                        row["fa"] = Convert.ToDateTime(row["fecha"]).ToString("dd/MM");
                        if (codigo != row["numerocarnet"].ToString())
                        {
                            codigo = row["numerocarnet"].ToString();
                            i++;
                        }
                        else
                        {

                        }
                        string d = i.ToString().PadLeft(2, '0');
                        row["numero"] = d;
                    }
                    dtMain.Columns.Remove("fecha");
                    dtMain.Columns["fa"].ColumnName = "fecha";
                    cargarDatosGrupo();


                    new frmRptAsistenciaGrupo(dtMain, ano, idioma, ciclo, docente, 
                        mes, nivel, numero,
                        Convert.ToDateTime(inicio).ToString("dd/MM/yy"),
                        Convert.ToDateTime(fin).ToString("dd/MM/yy")).Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
