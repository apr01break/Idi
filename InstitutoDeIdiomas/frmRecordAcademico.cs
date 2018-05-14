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
    public partial class frmRecordAcademico : MaterialForm
    {
        MsSqlConnection configurarConexion = new MsSqlConnection();
        public static SqlConnection _SqlConnection = new SqlConnection();
        String numcarnet, nombre;
        public frmRecordAcademico()
        {
            InitializeComponent();
            _SqlConnection.ConnectionString = configurarConexion._ConnectionString;
        }

        private void txtApellido_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                _SqlConnection.Open();
                SqlCommand cmd = new SqlCommand("buscar_record", _SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@txt", txtApellido.Text.Trim()));
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                dt.Clear();
                da.Fill(dt);
                dgvwLista.DataSource = dt;
                dgvwLista.Columns["APELLIDOS Y NOMBRES"].Width = 270;
                //dgvwLista.Columns["N° carnet"].Width = 70;
                dgvwLista.Columns["DNI"].Visible = false;
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
                SqlCommand cmd = new SqlCommand("buscar_idiomas_record", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@numerocarnet", numcarnet));
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                
                da.Fill(dt);
                
                cmbIdiomas.DisplayMember = "nombreIdioma";
                cmbIdiomas.DataSource = dt;
                cmbIdiomas.ValueMember = "idIdioma";
                if (dt.Rows.Count > 0)
                {
                    cmbIdiomas.SelectedIndex = 0;
                    btnGenerarRecord.Enabled = true;
                }

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


        private void btnGenerarRecord_Click(object sender, EventArgs e)
        {
            if (cmbIdiomas.Text == "")
            {
                MessageBox.Show("Selecciona un idioma"); return;
            }
            try
            {
                int idioma = (int)((DataRowView)cmbIdiomas.SelectedItem)["idIdioma"];
                String idiom = ((DataRowView)cmbIdiomas.SelectedItem)["nombreIdioma"].ToString();
                DataTable dtGrupos = new DataTable();
                DataTable dtReport = new DataTable();
                _SqlConnection.Open();
                SqlCommand cmd = new SqlCommand("buscar_grupos_por_idioma", _SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@numerocarnet", numcarnet));
                cmd.Parameters.Add(new SqlParameter("@idIdioma", idioma));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dtGrupos.Clear();
                da.Fill(dtGrupos);
                _SqlConnection.Close();
                dtReport.Columns.Add("nivel");
                dtReport.Columns.Add("ciclo");
                dtReport.Columns.Add("listening");
                dtReport.Columns.Add("speaking");
                dtReport.Columns.Add("reading");
                dtReport.Columns.Add("writing");
                dtReport.Columns.Add("useofenglish");
                dtReport.Columns.Add("promedio");
                decimal a1, a2, a3, a4, a5;
                for (int i = 0; i < dtGrupos.Rows.Count; i++)
                {
                    DataRow rw = dtReport.NewRow();
                    int idgrupo = Convert.ToInt32(dtGrupos.Rows[i][0]);
                    a1 = notaListening(idgrupo, numcarnet);
                    a2 = notaSpeaking(idgrupo, numcarnet);
                    a3 = notaReading(idgrupo, numcarnet);
                    a4 = notaWriting(idgrupo, numcarnet);
                    a5 = notaUseOfEnglish(idgrupo, numcarnet);
                    rw[0] = dtGrupos.Rows[i][1].ToString();
                    rw[1] = dtGrupos.Rows[i][2].ToString();
                    rw[2] = a1;
                    rw[3] = a2;
                    rw[4] = a3;
                    rw[5] = a4;
                    rw[6] = a5;
                    rw[7] = decimal.Round((a1 + a2 + a3 + a4 + a5) / 5, 0);
                    dtReport.Rows.Add(rw);
                }
                dataGridView1.DataSource = dtReport;
                new frmRptRecordAcademico(dtReport,numcarnet,nombre,idiom).Show();
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
        public decimal notaListening(int idgrupo, String numcarnet)
        {
            try
            {
                DataTable dt = new DataTable();
                _SqlConnection.Open();
                SqlCommand cmd = new SqlCommand("buscar_listening_record", _SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@idGrupo", idgrupo));
                cmd.Parameters.Add(new SqlParameter("@numerocarnet", numcarnet));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                decimal nota = 0;
                for(int i=0; i<dt.Rows.Count; i++)
                {
                    nota = nota + Convert.ToInt32(dt.Rows[i][0]);
                }
                nota = nota / dt.Rows.Count;
                nota = decimal.Round(nota, 2);
                return nota;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            finally
            {
                _SqlConnection.Close();
            }
        }

        public decimal notaSpeaking(int idgrupo, String numcarnet)
        {
            try
            {
                DataTable dt = new DataTable();
                _SqlConnection.Open();
                SqlCommand cmd = new SqlCommand("buscar_speaking_record", _SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@idGrupo", idgrupo));
                cmd.Parameters.Add(new SqlParameter("@numerocarnet", numcarnet));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                decimal nota = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    nota = nota + Convert.ToInt32(dt.Rows[i][0]);
                }
                nota = nota / dt.Rows.Count;
                nota = decimal.Round(nota, 2);
                return nota;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            finally
            {
                _SqlConnection.Close();
            }
        }

        public decimal notaReading(int idgrupo, String numcarnet)
        {
            try
            {
                DataTable dt = new DataTable();
                _SqlConnection.Open();
                SqlCommand cmd = new SqlCommand("buscar_reading_record", _SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@idGrupo", idgrupo));
                cmd.Parameters.Add(new SqlParameter("@numerocarnet", numcarnet));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                decimal nota = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    nota = nota + Convert.ToInt32(dt.Rows[i][0]);
                }
                nota = nota / dt.Rows.Count;
                nota = decimal.Round(nota, 2);
                return nota;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            finally
            {
                _SqlConnection.Close();
            }
        }

        public decimal notaWriting(int idgrupo, String numcarnet)
        {
            try
            {
                DataTable dt = new DataTable();
                _SqlConnection.Open();
                SqlCommand cmd = new SqlCommand("buscar_writing_record", _SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@idGrupo", idgrupo));
                cmd.Parameters.Add(new SqlParameter("@numerocarnet", numcarnet));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                decimal nota = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    nota = nota + Convert.ToInt32(dt.Rows[i][0]);
                }
                nota = nota / dt.Rows.Count;
                nota = decimal.Round(nota, 2);
                return nota;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            finally
            {
                _SqlConnection.Close();
            }
        }

        public decimal notaUseOfEnglish(int idgrupo, String numcarnet)
        {
            try
            {
                DataTable dt = new DataTable();
                _SqlConnection.Open();
                SqlCommand cmd = new SqlCommand("buscar_useofenglish_record", _SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@idGrupo", idgrupo));
                cmd.Parameters.Add(new SqlParameter("@numerocarnet", numcarnet));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                decimal nota = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    nota = nota + Convert.ToInt32(dt.Rows[i][0]);
                }
                nota = nota / dt.Rows.Count;
                nota = decimal.Round(nota, 2);
                return nota;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            finally
            {
                _SqlConnection.Close();
            }
        }

        private void frmRecordAcademico_Load(object sender, EventArgs e)
        {

        }

        private void dgvwLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvwLista.RowCount )
                {
                    btnGenerarRecord.Enabled = false;
                    DataGridViewRow row = this.dgvwLista.Rows[e.RowIndex];
                    numcarnet = row.Cells[0].Value.ToString();
                    nombre = row.Cells[2].Value.ToString();
                    cmbIdiomas.Enabled = true;
                    btnGenerarRecord.Enabled = true;
                    listaIdioma();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        
    }
}
