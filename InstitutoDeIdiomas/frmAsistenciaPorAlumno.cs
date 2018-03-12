using MaterialSkin.Controls;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace InstitutoDeIdiomas
{
    public partial class frmAsistenciaPorAlumno : MaterialForm
    {
        MsSqlConnection configurarConexion = new MsSqlConnection();
        public static SqlConnection _SqlConnection = new SqlConnection();
        String numcarnet, nombre;
        public frmAsistenciaPorAlumno()
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
                SqlCommand cmd = new SqlCommand("buscar_record", _SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@txt", txtBuscar.Text.Trim()));
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                dt.Clear();
                da.Fill(dt);
                dgvwLista.DataSource = dt;
                dgvwLista.Columns["APELLIDOS Y NOMBRES"].Width = 285;
                //dgvwLista.Columns["numerocarnet"].Visible = false;
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
        public void listaIdioma()
        {
            try
            {
                cmbIdiomas.DataSource = null;
                cmbIdiomas.Items.Clear();
                SqlCommand cmd = new SqlCommand("buscar_idiomas_asistencia", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@numerocarnet", numcarnet));
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
                cmbIdiomas.DisplayMember = "Text";
                cmbIdiomas.ValueMember = "Value";
                foreach (DataRow row in dt.Rows)
                {
                    cmbIdiomas.Items.Add(new { Text = row[1], Value = row[0] });
                }
                
                cmbIdiomas.Enabled = true;
                if (dt.Rows.Count == 0) cmbIdiomas.Enabled = false;


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

        private void frmAsistenciaPorAlumno_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtBuscar;

        }

        public void cargarGrupos()
        {
            try
            {
                cmbGrupos.DataSource = null;
                cmbGrupos.Items.Clear();
                SqlCommand cmd = new SqlCommand("listar_grupos_alumno", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@nrocarnet", numcarnet));
                cmd.Parameters.Add(new SqlParameter("@idioma", cmbIdiomas.Text));
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
                cmbGrupos.DisplayMember = "Text";
                cmbGrupos.ValueMember = "Value";
                foreach (DataRow row in dt.Rows)
                {
                    string texto = row[1]+" "+row[2]+" "+row[3];
                    cmbGrupos.Items.Add(new { Text = texto, Value = row[0] });
                }
                cmbGrupos.Enabled = true;


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
        private void cmbIdiomas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cargarGrupos();
        }

        private void cmbGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idGrupo = Convert.ToInt32((cmbGrupos.SelectedItem as dynamic).Value);
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("listar_asistencia_alumno", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@nrocarnet", numcarnet));
                cmd.Parameters.Add(new SqlParameter("@idgrupo", idGrupo));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _SqlConnection.Close();
            }
            dgvwAsistencia.DataSource = dt;
            dgvwAsistencia.Columns[0].Visible = false ;
            dgvwAsistencia.Columns[1].Visible = false;
            dgvwAsistencia.Columns[3].HeaderText = "ASISTENCIA";
            dgvwAsistencia.Columns[2].HeaderText = "FECHA";
            //ReportDataSource rds = new ReportDataSource("dsAsistenciaAlumno", dt);
            //Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            //{
            //    //new Microsoft.Reporting.WinForms.ReportParameter("pIdioma",idioma)

            //};
            //this.reportViewer1.LocalReport.SetParameters(para);
            //this.reportViewer1.LocalReport.DataSources.Add(rds);
            //this.reportViewer1.RefreshReport();
        }

        private void dgvwLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvwLista.RowCount)
                {
                    DataGridViewRow row = this.dgvwLista.Rows[e.RowIndex];
                    numcarnet = row.Cells[0].Value.ToString();
                    nombre = row.Cells[2].Value.ToString();
                    listaIdioma();
                    cmbGrupos.Items.Clear();
                    dgvwAsistencia.DataSource = null;
                    dgvwAsistencia.Columns.Clear();
                    dgvwAsistencia.Rows.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
