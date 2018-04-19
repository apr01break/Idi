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
    public partial class frmAsistenciasPorGrupo : MaterialForm
    {
        MsSqlConnection configurarConexion = new MsSqlConnection();
        public static SqlConnection _SqlConnection = new SqlConnection();
        int idGrupo;
        String ano, idioma, ciclo, docente, mes, nivel, numero, inicio, fin;

        private void dgvwListaGrupos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dd();
        }

        private void frmAsistenciasPorGrupo_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtBuscar;
        }

        public frmAsistenciasPorGrupo()
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
                SqlCommand cmd = new SqlCommand("buscar_grupos_por_numero", _SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@txt", txtBuscar.Text.Trim()));
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                dt.Clear();
                da.Fill(dt);
                dgvwListaGrupos.DataSource = dt;
                dgvwListaGrupos.Columns[0].Visible = false;
                dgvwListaGrupos.Columns[1].Width = 75;
                dgvwListaGrupos.Columns["Docente"].Width = 230;
                dgvwListaGrupos.Columns["Ciclo"].Width = 70;
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
        
        private void dgvwListaGrupos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvwListaGrupos.RowCount)
                {
                    btnGenerarReporte.Enabled = true;
                    DataGridViewRow row = dgvwListaGrupos.Rows[e.RowIndex];
                    idGrupo = (int)row.Cells[0].Value;
                } 
            }
            catch (Exception)
            {

                throw;
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
        public void dd()
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
                    

                    new frmRptAsistenciaGrupo(dtMain, ano, idioma, ciclo, docente, mes, nivel, numero,
                        Convert.ToDateTime(inicio).ToString("dd/MM/yy"),
                        Convert.ToDateTime(fin).ToString("dd/MM/yy")).Show();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            dd();
        }
    }
}
