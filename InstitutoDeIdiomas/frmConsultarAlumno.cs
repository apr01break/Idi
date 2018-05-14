using InstitutoDeIdiomas.ReportForms;
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
    public partial class frmConsultarAlumno : MaterialForm
    {
        MsSqlConnection configurarConexion = new MsSqlConnection();
        public static SqlConnection _SqlConnection = new SqlConnection();
        int idalumno;
        string dni, usuario, numcarnet, nombre;
        DataTable dtLegend = new DataTable();
        DataSet resultados = new DataSet();
        public frmConsultarAlumno(String id)
        {
            InitializeComponent();
            _SqlConnection.ConnectionString = configurarConexion._ConnectionString;
            dataGridViewApellido.RowHeadersVisible = false;
            buscarUsuario(id);
        }

        private void buscarUsuario(string idUsuario)
        {
            SqlCommand comando = new SqlCommand("buscar_usuario_porid", _SqlConnection);
            try
            {
                DataTable dt = new DataTable();
                
                comando.CommandType = CommandType.StoredProcedure;
                if (comando.Connection.State == ConnectionState.Closed)
                {
                    comando.Connection.Open();
                }
                comando.Parameters.Add(new SqlParameter("@idUsuario", idUsuario));
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                if (comando.Connection.State == ConnectionState.Open)
                {
                    comando.Connection.Close();
                }
                usuario = dt.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (comando.Connection.State == ConnectionState.Open)
                {
                    comando.Connection.Close();
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            


        }

        private void frmConsultarAlumno_Load(object sender, EventArgs e)
        {
        }

        private void txtApellido_KeyUp(object sender, KeyEventArgs e)
        {
            SqlCommand cmd = new SqlCommand("buscar_alumno_consultar", _SqlConnection);
            try
            {
                DataTable dt = new DataTable();
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    _SqlConnection.Open();
                }
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@txt", txtApellido.Text.Trim()));
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                dt.Clear();

                da.Fill(dt);
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    _SqlConnection.Close();
                }
                    

                dataGridViewApellido.DataSource = dt;
                dataGridViewApellido.Columns[0].Width =205;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }

        }

        private void dataGridViewDNI_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void dataGridViewApellido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnRecordAcademico.Enabled = true;
            btnPagos.Enabled = true;
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewApellido.RowCount)
            {
                SqlCommand cmd = new SqlCommand("buscarTodo", _SqlConnection);
                //try
                //{
                    DataTable dt = new DataTable();
                    DataGridViewRow row = this.dataGridViewApellido.Rows[e.RowIndex];
                    dni = row.Cells["DNI"].Value.ToString();
                    String tipo = row.Cells["Tipo de Alumno"].Value.ToString();
                    idalumno = (int)row.Cells["idalumno"].Value;
                    
                    if (cmd.Connection.State == ConnectionState.Closed)
                    {
                        _SqlConnection.Open();
                    }
                    
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@dni", dni));
                    cmd.Parameters.Add(new SqlParameter("@tipoalu", tipo));
                    
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(dt);
                    if (cmd.Connection.State == ConnectionState.Closed)
                    {
                        _SqlConnection.Close();
                    }
                    dataGridView1.DataSource = dt;
                    DataGridViewRow rowo = dataGridView1.Rows[0];

                    txtApePaterno.Text = rowo.Cells[0].Value.ToString();
                    txtApeMaterno.Text = rowo.Cells[1].Value.ToString();
                    txtNombres.Text = rowo.Cells[2].Value.ToString();
                    txtDni2.Text = rowo.Cells[3].Value.ToString();
                    txtSexo.Text = rowo.Cells[4].Value.ToString();
                    if (!DBNull.Value.Equals(rowo.Cells[5].Value))
                    {
                        txtFechaNaci.Text = Convert.ToDateTime(rowo.Cells[5].Value).ToString("dd/MM/yy");
                    }
                    txtEdad.Text = rowo.Cells[6].Value.ToString();
                    fotoimagen.Image = null;

                    if (!DBNull.Value.Equals(rowo.Cells[7].Value))
                    {
                        byte[] img = (byte[])(dt.Rows[0][7]);
                        if (img == null)
                        {
                            fotoimagen.Image = null;
                        }
                        else
                        {
                            fotoimagen.SizeMode = PictureBoxSizeMode.StretchImage;
                            MemoryStream ms = new MemoryStream(img);
                            fotoimagen.Image = Image.FromStream(ms);
                        }
                    }


                    txtCorreo.Text = rowo.Cells[8].Value.ToString();
                    txtDepartamento.Text = rowo.Cells[9].Value.ToString();
                    txtProvincia.Text = rowo.Cells[10].Value.ToString();
                    txtDistrito.Text = rowo.Cells[11].Value.ToString();
                    txtProcedencia.Text = rowo.Cells[12].Value.ToString();
                    txtDireccion.Text = rowo.Cells[13].Value.ToString();
                    txtGradoInstru.Text = rowo.Cells[14].Value.ToString();
                    txtCelular.Text = rowo.Cells[15].Value.ToString();
                    txtTelefono.Text = rowo.Cells[16].Value.ToString();
                    txtTipoAlu2.Text = rowo.Cells[17].Value.ToString();
                    if (rowo.Cells[17].Value.ToString() == "FAUSTINIANO")
                    {
                        panel1.Visible = false;
                        panel2.Visible = true;
                        txtFacultad.Visible = true;
                        txtEscuela.Visible = true;
                        txtFacultad.Text = rowo.Cells[18].Value.ToString();
                        txtEscuela.Text = rowo.Cells[19].Value.ToString();
                    }
                    else if (rowo.Cells[17].Value.ToString() == "PARTICULAR")
                    {
                        panel2.Visible = false;
                        panel1.Visible = true;
                        lblColeUni.Visible = true;
                        if (rowo.Cells.Count >= 19)
                        {
                            txtColeUni.Visible = true;
                            lblColeUni.Text = rowo.Cells[18].Value.ToString();
                            if (lblColeUni.Text == "COLEGIO")
                            {
                                txtColeUni.Text = rowo.Cells[19].Value.ToString();
                            }
                            else if (lblColeUni.Text == "UNIVERSIDAD")
                            {
                                txtColeUni.Text = rowo.Cells[19].Value.ToString();
                            }
                        }
                        else
                        {                        
                            lblColeUni.Text = "NINGUNO";
                            txtColeUni.Visible = false;
                        }
                    }
                    lblNumCarnet.Text = rowo.Cells[20].Value.ToString();
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //    if (cmd.Connection.State == ConnectionState.Open)
                //    {
                //        cmd.Connection.Close();
                //    }
                //}
                numcarnet = row.Cells[1].Value.ToString();
                nombre = row.Cells[0].Value.ToString();
                cmbIdiomas.Enabled = true;
                listaIdioma();
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

                //cmbIdiomas.DisplayMember = "nombreIdioma";
                //cmbIdiomas.DataSource = dt;
                //cmbIdiomas.ValueMember = "idIdioma";
                cmbIdiomas.Enabled = false;
                cmbIdiomas.DisplayMember = "Text";
                cmbIdiomas.ValueMember = "Value";
                foreach (DataRow row in dt.Rows)
                {
                    cmbIdiomas.Items.Add(new { Text = row[1], Value = row[0] });
                }

                cmbIdiomas.Enabled = true;
                if (dt.Rows.Count == 0) 
                if (dt.Rows.Count > 0)
                {
                    
                    btnRecordAcademico.Enabled = true;
                }
                else
                {
                    cmbIdiomas.Enabled = false;
                    btnRecordAcademico.Enabled = false;
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




        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private DataTable CARGARLISTADEPAGOS(int codalu)
        {
            DataTable dt = new DataTable();
            SqlCommand comando = new SqlCommand("mostrar_relacion", _SqlConnection);
            try
            { 
                comando.CommandType = CommandType.StoredProcedure;
                if (comando.Connection.State == ConnectionState.Closed)
                {
                    comando.Connection.Open();
                }
                comando.Parameters.Add(new SqlParameter("@cod", codalu));
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                if (comando.Connection.State == ConnectionState.Open)
                {
                    comando.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (comando.Connection.State == ConnectionState.Open)
                {
                    comando.Connection.Close();
                }
            }
            return dt;
        }

        public void buscarRecibosLeyenda(string idPago, string simbolo)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand comando = new SqlCommand("obtener_recibos_pago_saldo", _SqlConnection);
                comando.CommandType = CommandType.StoredProcedure;
                if (comando.Connection.State == ConnectionState.Closed)
                {
                    comando.Connection.Open();
                }
                comando.Parameters.Add(new SqlParameter("@idPago", idPago));
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                if (comando.Connection.State == ConnectionState.Open)
                {
                    comando.Connection.Close();
                }
                //agregar filas a dtLegend
                dt.Columns.Add("simbolo");
                foreach (DataRow row in dt.Rows)
                {
                    row["simbolo"] = simbolo;
                    dtLegend.ImportRow(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable buscarSaldo()
        {
            DataTable dt = new DataTable();
            SqlCommand comando = new SqlCommand("mostrar_Saldo_alumno", _SqlConnection);
            comando.CommandType = CommandType.StoredProcedure;
            if (comando.Connection.State == ConnectionState.Closed)
            {
                comando.Connection.Open();
            }
            comando.Parameters.Add(new SqlParameter("@numcarnet", lblNumCarnet.Text));
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);

            if (comando.Connection.State == ConnectionState.Open)
            {
                comando.Connection.Close();
            }
            return dt;
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            DataTable tabledata = CARGARLISTADEPAGOS(idalumno);
            DataTable dtalumno = new DataTable();
            try
            {
                SqlCommand comando = new SqlCommand("small_buscar_pordni", _SqlConnection);
                comando.CommandType = CommandType.StoredProcedure;
                if (comando.Connection.State == ConnectionState.Closed)
                {
                    comando.Connection.Open();
                }
                comando.Parameters.Add(new SqlParameter("@dni", dni));
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dtalumno);
                if (comando.Connection.State == ConnectionState.Open)
                {
                    comando.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dtLegend.Clear();
            //List<string> ListaSaldos = new List<string>();
            string simbolo = "*";
            tabledata.Columns.Add("simbolo");
            tabledata.Columns.Add("fecha");
            foreach (DataRow item in tabledata.Rows)
            {

                if (item["fech"].ToString() == "")
                {
                    buscarRecibosLeyenda(item[0].ToString(), simbolo);
                    item["simbolo"] = simbolo;
                    simbolo = simbolo + "*";
                }
                else
                {
                    string fecha = Convert.ToDateTime(item["fech"]).ToString("dd/MM/yyyy");
                    item["fecha"] = fecha;
                }
            }
            DataTable dtSaldo = buscarSaldo();
            dtSaldo.Columns["numero_recibo"].ColumnName = "nro_recibo";
            using (frmRptListaDePagos frm = new frmRptListaDePagos(tabledata, dtalumno, usuario, dtLegend, dtSaldo))
            {
                frm.ShowDialog();
            }
        }

        private void btnRecordAcademico_Click(object sender, EventArgs e)
        {
            if (cmbIdiomas.Text == "")
            {
                MessageBox.Show("Selecciona un idioma"); return;
            }
            try
            {
                //int idioma = (int)((DataRowView)cmbIdiomas.SelectedItem)["idIdioma"];
                int idioma = Convert.ToInt32((cmbIdiomas.SelectedItem as dynamic).Value);
                String idiom = (cmbIdiomas.SelectedItem as dynamic).Text.ToString();
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
                    if(a1==-1 || a2==-1 || a3==-1 || a4==-1 || a5==-1)
                    {
                        MessageBox.Show("El grupo no tiene notas de todos los criterios");
                    }
                    else
                    {
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
                }
                dataGridView1.DataSource = dtReport;
                new frmRptRecordAcademico(dtReport, numcarnet, nombre, idiom).Show();
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
                if (dt.Rows.Count == 0) return -1;
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
                if (dt.Rows.Count == 0) return -1;
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
                if (dt.Rows.Count == 0) return -1;
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

        private void cmbIdiomas_SelectedIndexChanged(object sender, EventArgs e)
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
                    string texto = row[1] + " " + row[2] + " " + row[3];
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
            dgvwAsistencia.Columns[0].Visible = false;
            dgvwAsistencia.Columns[1].Visible = false;
            dgvwAsistencia.Columns[3].HeaderText = "ASISTENCIA";
            dgvwAsistencia.Columns[2].HeaderText = "FECHA";
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
                if (dt.Rows.Count == 0) return -1;
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
                if (dt.Rows.Count == 0) return -1;
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

        private void frmConsultarAlumno_Load_1(object sender, EventArgs e)
        {

        }
    }
}
