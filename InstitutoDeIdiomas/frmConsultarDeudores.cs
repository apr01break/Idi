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
    public partial class frmConsultarDeudores : MaterialForm
    {
        private Label label1;
        MsSqlConnection configurarConexion = new MsSqlConnection();
        public static SqlConnection _SqlConnection = new SqlConnection();
        private DataGridView dataGridView1;
        private Label label3;
        private DataGridView dataGridView2;
        private PictureBox FOTOALUMNOAPAGAR;
        private Label LBLCODIGOALUMN;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox TXT_SEARCH;
        private Panel panel1;
        private MaterialRaisedButton btnGenerarReportePagos;
        String idpago;
      
        public frmConsultarDeudores()
        {
            InitializeComponent();
            _SqlConnection.ConnectionString = configurarConexion._ConnectionString;
            FOTOALUMNOAPAGAR.SizeMode = PictureBoxSizeMode.StretchImage;
            dataGridView1.RowHeadersVisible = false;
            dataGridView2.RowHeadersVisible = false;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor =
    Color.PowderBlue;
            this.dataGridView2.AlternatingRowsDefaultCellStyle.BackColor =
    Color.PowderBlue;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarDeudores));
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_SEARCH = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.FOTOALUMNOAPAGAR = new System.Windows.Forms.PictureBox();
            this.LBLCODIGOALUMN = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGenerarReportePagos = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FOTOALUMNOAPAGAR)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "INGRESE NOMBRE DEL ALUMNO";
            // 
            // TXT_SEARCH
            // 
            this.TXT_SEARCH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TXT_SEARCH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TXT_SEARCH.Location = new System.Drawing.Point(15, 102);
            this.TXT_SEARCH.Name = "TXT_SEARCH";
            this.TXT_SEARCH.Size = new System.Drawing.Size(250, 20);
            this.TXT_SEARCH.TabIndex = 0;
            this.TXT_SEARCH.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXT_SEARCH_KeyUp);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(447, 288);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "RELACION DE PAGOS";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(492, 43);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(525, 333);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // FOTOALUMNOAPAGAR
            // 
            this.FOTOALUMNOAPAGAR.Location = new System.Drawing.Point(351, 19);
            this.FOTOALUMNOAPAGAR.Name = "FOTOALUMNOAPAGAR";
            this.FOTOALUMNOAPAGAR.Size = new System.Drawing.Size(107, 118);
            this.FOTOALUMNOAPAGAR.TabIndex = 7;
            this.FOTOALUMNOAPAGAR.TabStop = false;
            // 
            // LBLCODIGOALUMN
            // 
            this.LBLCODIGOALUMN.AutoSize = true;
            this.LBLCODIGOALUMN.Location = new System.Drawing.Point(281, 25);
            this.LBLCODIGOALUMN.Name = "LBLCODIGOALUMN";
            this.LBLCODIGOALUMN.Size = new System.Drawing.Size(51, 13);
            this.LBLCODIGOALUMN.TabIndex = 8;
            this.LBLCODIGOALUMN.Text = "codigope";
            this.LBLCODIGOALUMN.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(216, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "CODIGO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "DNI";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(281, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "dnipe";
            this.label7.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnGenerarReportePagos);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TXT_SEARCH);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.LBLCODIGOALUMN);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.FOTOALUMNOAPAGAR);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 449);
            this.panel1.TabIndex = 15;
            // 
            // btnGenerarReportePagos
            // 
            this.btnGenerarReportePagos.Depth = 0;
            this.btnGenerarReportePagos.Location = new System.Drawing.Point(648, 390);
            this.btnGenerarReportePagos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGenerarReportePagos.Name = "btnGenerarReportePagos";
            this.btnGenerarReportePagos.Primary = true;
            this.btnGenerarReportePagos.Size = new System.Drawing.Size(216, 39);
            this.btnGenerarReportePagos.TabIndex = 15;
            this.btnGenerarReportePagos.Text = "GENERAR REPORTE DE PAGOS";
            this.btnGenerarReportePagos.UseVisualStyleBackColor = true;
            this.btnGenerarReportePagos.Click += new System.EventHandler(this.btnGenerarReportePagos_Click);
            // 
            // frmConsultarDeudores
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1030, 513);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConsultarDeudores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTA DE PAGOS Y DEUDAS";
            this.Load += new System.EventHandler(this.frmConsultarDeudores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FOTOALUMNOAPAGAR)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }
     
        private void AutocompleteTexto() {         
            try
            {
                SqlDataReader dr = null;
                AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
                SqlCommand comando = new SqlCommand("select distinct CONCAT(persona.apaterno, ' ',Persona.amaterno, ' ',Persona.nombre) as 'names' from Persona Inner join Alumno on Persona.idpersona = Alumno.idpersona Inner join TipoAlumno on alumno.idTipoAlumno = TipoAlumno.idTipoAlumno", _SqlConnection);         
                if (comando.Connection.State == ConnectionState.Closed)
                {
                    comando.Connection.Open();
                }                
                dr = comando.ExecuteReader();
                while (dr.Read()) {
                    coll.Add(dr["names"].ToString());
                }
                dr.Close();
                TXT_SEARCH.AutoCompleteCustomSource = coll;
                if (comando.Connection.State == ConnectionState.Open)
                {
                    comando.Connection.Close();
                }            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmConsultarDeudores_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void TXT_SEARCH_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void frmConsultarDeudores_Load(object sender, EventArgs e)
        {       
        }

        private void TXT_SEARCH_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                _SqlConnection.Open();
                SqlCommand cmd = new SqlCommand("AutoCompleteName", _SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@txt", TXT_SEARCH.Text.Trim()));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Width = 320;
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.RowCount - 1)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                String dni = row.Cells[1].Value.ToString();
                label7.Text= row.Cells[1].Value.ToString();
                try
                {
                    DataTable dt = new DataTable();
                    SqlCommand comando = new SqlCommand("small_buscar_pordni", _SqlConnection);
                    comando.CommandType = CommandType.StoredProcedure;
                    if (comando.Connection.State == ConnectionState.Closed)
                    {
                        comando.Connection.Open();
                    }
                    comando.Parameters.Add(new SqlParameter("@dni", dni));
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    da.Fill(dt);
                    byte[] img = (byte[])(dt.Rows[0][4]);
                    if (img == null)
                    {
                        FOTOALUMNOAPAGAR.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        FOTOALUMNOAPAGAR.Image = Image.FromStream(ms);
                    }                    
                    LBLCODIGOALUMN.Text = dt.Rows[0][7].ToString();
                    if (comando.Connection.State == ConnectionState.Open)
                    {
                        comando.Connection.Close();
                    }
                    String codigoalum= dt.Rows[0][8].ToString();
                    label5.Text = dt.Rows[0][8].ToString();
                    label5.Visible = true;
                    label7.Visible = true;
                    LBLCODIGOALUMN.Visible = true;
                    CARGARLISTADEPAGOS(codigoalum);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private DataTable CARGARLISTADEPAGOS(String codalu) {            
            int cod = Convert.ToInt32(codalu);
            DataTable dt = new DataTable();
            try {
                
                SqlCommand comando = new SqlCommand("mostrar_relacion", _SqlConnection);
                comando.CommandType = CommandType.StoredProcedure;
                if (comando.Connection.State == ConnectionState.Closed)
                {
                    comando.Connection.Open();
                }
                comando.Parameters.Add(new SqlParameter("@cod", cod));
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                dataGridView2.Columns[0].Visible = false;
                dataGridView2.Columns[1].Width = 210;
                if (comando.Connection.State == ConnectionState.Open)
                {
                    comando.Connection.Close();
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        private void btnGenerarReportePagos_Click(object sender, EventArgs e)
        {
            if (LBLCODIGOALUMN.Text != "" && label7.Text != "" && label5.Text != "")
            {
                DataTable tabledata = CARGARLISTADEPAGOS(label5.Text);
                DataTable dtalumno = new DataTable();
                try
                {
                    SqlCommand comando = new SqlCommand("small_buscar_pordni", _SqlConnection);
                    comando.CommandType = CommandType.StoredProcedure;
                    if (comando.Connection.State == ConnectionState.Closed)
                    {
                        comando.Connection.Open();
                    }
                    comando.Parameters.Add(new SqlParameter("@dni", label7.Text));
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
                DataTable dtCloned = tabledata.Clone();
                dtCloned.Columns[2].DataType = typeof(String);
                foreach (DataRow row in tabledata.Rows)
                {
                    dtCloned.ImportRow(row);
                }
                DataTable dtResumen = new DataTable();
                dtResumen.Columns.Add("Wan");
                dtResumen.Columns.Add("MontoTotal");
                dtCloned.Columns.Add("Fecha");
                for (int i = 0; i < dtCloned.Rows.Count; i++)
                {
                    
                    if (dtCloned.Rows[i][3] != System.DBNull.Value)
                    {
                        string fech = Convert.ToDateTime(dtCloned.Rows[i][3]).ToString("dd/MM/yyyy");
                        dtCloned.Rows[i][5] = fech;
                    }
                    
                    bool xd=false;
                    for(int j=0; j<dtResumen.Rows.Count; j++)
                    {
                        if (dtCloned.Rows[i][0].ToString().Equals(dtResumen.Rows[j][0].ToString()))
                        {
                            dtResumen.Rows[j][1] = Convert.ToDecimal(dtResumen.Rows[j][1])+ Convert.ToDecimal(dtCloned.Rows[i][1]);
                            xd = true;
                        }
                    }
                    if (xd == false)
                    {
                        DataRow dr = dtResumen.NewRow();
                        dr[0] = dtCloned.Rows[i][1].ToString();
                        dr[1] = Convert.ToDecimal(dtCloned.Rows[i][2]);
                        dtResumen.Rows.Add(dr);
                    }
                }
                dtCloned.Columns.RemoveAt(3);
                using (frmRptListaDePagos frm = new frmRptListaDePagos(dtCloned, dtalumno, dtResumen))
                {
                    frm.ShowDialog();
                }
            }
            else {
                MessageBox.Show("Selecciona un alumno");
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.RowCount)
            {
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                idpago = row.Cells[0].Value.ToString();
            }
        }
    }
}
