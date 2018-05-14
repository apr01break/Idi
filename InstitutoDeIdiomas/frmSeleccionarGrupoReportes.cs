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
    public partial class frmSeleccionarGrupoReportes : MaterialForm
    {
        MsSqlConnection configurarConexion = new MsSqlConnection();
        public static SqlConnection _SqlConnection = new SqlConnection();
        int idGrupo;
        String ano, idioma, ciclo, docente, mes, nivel, numero, inicio, fin, salon, horaInicio, horaFin,dias;
        string tipoReporte;

        private void dgvwListaGrupos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarReporte();
        }

        private void frmAsistenciasPorGrupo_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtBuscar;
            btnGenerarReporte.Text = tipoReporte;
            

        }

        public frmSeleccionarGrupoReportes(string tipoReporte)
        {
            InitializeComponent();
            _SqlConnection.ConnectionString = configurarConexion._ConnectionString;
            this.tipoReporte = tipoReporte;
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
        public void cargarDias()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("listar_dias_grupo", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.Parameters.Add(new SqlParameter("@idGrupo", idGrupo));
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
                dias = xx;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "cargarDias");
            }
        }

        public void cargarReporte()
        {
            cargarDatosGrupo();
            cargarDias();
            if (tipoReporte == "Reporte asistencia") reporteAsistencias();
            else if (tipoReporte == "Record económico") recordEconomico();
            else if (tipoReporte == "Relación de alumnos") relacionAlumnos();
            else if (tipoReporte == "Acta de notas") actaNotas();
            else if (tipoReporte == "Acta final") actaFinal();
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
                salon = row2[3].ToString();
                horaInicio = row2[5].ToString();
                horaFin = row2[6].ToString();
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
        public void reporteAsistencias()
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
                    double start=0;
                    double end;
                    double asis = 0;
                    for (int j = 0; j < dtMain.Rows.Count; j++)
                    {
                        dtMain.Rows[j]["fa"] = Convert.ToDateTime(dtMain.Rows[j]["fecha"]).ToString("dd/MM");
                        if (codigo != dtMain.Rows[j]["numerocarnet"].ToString())
                        {
                            codigo = dtMain.Rows[j]["numerocarnet"].ToString();
                            i++;
                            end = j - 1;
                            double porcentaje = Math.Round(asis / (end - start + 1) * 100, 2);
                            //MessageBox.Show(porcentaje + "");
                            for (int w = (int)start; w < (int)end; w++)
                            {
                                dtMain.Rows[w]["porcentaje"] = porcentaje;
                            }
                            asis = 0;
                            start = j;
                            end = 0;
                        }
                        else
                        {

                        }
                        if(dtMain.Rows[j]["Asistencia"].ToString()=="A" || dtMain.Rows[j]["numerocarnet"].ToString() == "J")
                        {
                            asis++;
                        }
                        dtMain.Rows[j]["numero"] = i.ToString().PadLeft(2, '0');
                        if (j == dtMain.Rows.Count - 1)
                        {
                            end = j;
                            double porcentaje = Math.Round(asis / (end - start+1) * 100, 2);
                            for (int w = (int)start; w < (int)end; w++)
                            {
                                dtMain.Rows[w]["porcentaje"] = porcentaje;
                            }
                        }
                    }
                    dtMain.Columns.Remove("fecha");
                    dtMain.Columns["fa"].ColumnName = "fecha";
                    

                    new frmRptAsistenciaGrupo(dtMain, ano, idioma, ciclo, docente, mes, nivel, numero,
                        Convert.ToDateTime(inicio).ToString("dd/MM/yy"),
                        Convert.ToDateTime(fin).ToString("dd/MM/yy"),
                        Convert.ToDateTime(horaInicio).ToString("HH:mm"),
                        Convert.ToDateTime(horaFin).ToString("HH:mm"),dias).Show();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void relacionAlumnos()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("listar_alumno_grupo", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.Parameters.Add(new SqlParameter("@idGrupo", idGrupo));
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                dt.Columns[0].ColumnName = "codigo";
                dt.Columns[1].ColumnName = "nombre";
                dt.Columns.Add("numero");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["numero"] = i + 1 + "";
                }
                using (frmRptRelacionAlumnos frm = new frmRptRelacionAlumnos(dt, idioma, nivel, ciclo,
                    docente, salon, Convert.ToDateTime(horaInicio).ToString("HH:mm"), Convert.ToDateTime(horaFin).ToString("HH:mm"), numero, inicio, fin, dias))
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "cargarAlumnoGrupo");
            }
            
        }

        public void recordEconomico()
        {
            SqlCommand cmd = new SqlCommand("listar_pagos_grupo", _SqlConnection);
            if (cmd.Connection.State == ConnectionState.Closed)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.Add(new SqlParameter("@idGrupo", idGrupo));
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
            dt.Columns.Add("fecha");
            foreach (DataRow item in dt.Rows)
            {
                item["fecha"] = Convert.ToDateTime(item["fechax"]).ToString("dd/MM/yy");
            }

            new frmRptRecordEconomicoGrupo(dt, idioma, nivel, ciclo,
                docente, salon, Convert.ToDateTime(horaInicio).ToString("HH:mm"), Convert.ToDateTime(horaFin).ToString("HH:mm"),
                numero, inicio, fin, dias).Show();
        }
        public void actaNotas()
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
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void actaFinal()
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
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            cargarReporte();
        }
    }
}
