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
using InstitutoDeIdiomas.ReportForms;
using System.IO;
using MaterialSkin.Controls;

namespace InstitutoDeIdiomas
{
    public partial class frmGenerarFichaMatricula : MaterialForm
    {
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private TextBox TXTBUSCALUMN;
        public static SqlConnection _SqlConnection = new SqlConnection();
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ErrorProvider errorProvider1;
        private IContainer components;
        private Panel panel1;
        private MaterialRaisedButton BTNGENERAR;
        MsSqlConnection configurarConexion = new MsSqlConnection();
        public frmGenerarFichaMatricula()
        {
            InitializeComponent();
            _SqlConnection.ConnectionString = configurarConexion._ConnectionString;
             pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            dataGridView1.RowHeadersVisible = false;
            dataGridView2.RowHeadersVisible = false;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor =
    Color.PowderBlue;
            this.dataGridView2.AlternatingRowsDefaultCellStyle.BackColor =
    Color.PowderBlue;
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenerarFichaMatricula));
            this.TXTBUSCALUMN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNGENERAR = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TXTBUSCALUMN
            // 
            this.TXTBUSCALUMN.Location = new System.Drawing.Point(8, 38);
            this.TXTBUSCALUMN.Name = "TXTBUSCALUMN";
            this.TXTBUSCALUMN.Size = new System.Drawing.Size(543, 20);
            this.TXTBUSCALUMN.TabIndex = 0;
            this.TXTBUSCALUMN.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXTBUSCALUMN_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "BUSCAR ALUMNO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(657, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewNombres_CellClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(11, 280);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(831, 122);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewMatriculas_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "MATRICULAS REALIZADAS POR EL ALUMNO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "CODIGO DE MATRICULA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "XXXXXXX";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "ID ALUMNO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "XXX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(759, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "XXXX";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(671, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "CODIGO";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(671, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 191);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BTNGENERAR);
            this.panel1.Controls.Add(this.TXTBUSCALUMN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 492);
            this.panel1.TabIndex = 16;
            // 
            // BTNGENERAR
            // 
            this.BTNGENERAR.Depth = 0;
            this.BTNGENERAR.Location = new System.Drawing.Point(588, 434);
            this.BTNGENERAR.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTNGENERAR.Name = "BTNGENERAR";
            this.BTNGENERAR.Primary = true;
            this.BTNGENERAR.Size = new System.Drawing.Size(233, 33);
            this.BTNGENERAR.TabIndex = 16;
            this.BTNGENERAR.Text = "GENERAR FICHA DE MATRICULA";
            this.BTNGENERAR.UseVisualStyleBackColor = true;
            this.BTNGENERAR.Click += new System.EventHandler(this.BTNGENERAR_Click);
            // 
            // frmGenerarFichaMatricula
            // 
            this.ClientSize = new System.Drawing.Size(874, 556);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGenerarFichaMatricula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GENERAR FICHA DE MATRICULA";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void TXTBUSCALUMN_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                _SqlConnection.Open();
                SqlCommand cmd = new SqlCommand("buscarAlumnoApellido", _SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@txt", TXTBUSCALUMN.Text.Trim()));

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                dt.Clear();

                da.Fill(dt);


               dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Width = 300;
                dataGridView1.Columns[2].Width = 150;
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
        private void GridViewNombres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.RowCount)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                String dni = row.Cells["DNI"].Value.ToString();               
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
                        pictureBox1.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                    //LBLTIPOALUMN.Text = dt.Rows[0][6].ToString();
                    label7.Text = dt.Rows[0][7].ToString();
                    label6.Text = dt.Rows[0][8].ToString();
                    if (comando.Connection.State == ConnectionState.Open)
                    {
                        comando.Connection.Close();
                    }
                    CARGAR_MATRICULAS(Convert.ToInt32(label6.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void CARGAR_MATRICULAS(int id) {
            try
            {
                _SqlConnection.Open();
                SqlCommand cmd = new SqlCommand("relacion_matriculas", _SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@idalumno", id));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                dataGridView2.Columns[0].Visible = false;
                dataGridView2.Columns["idioma"].Width = 85;
                dataGridView2.Columns[3].Width = 85;
                dataGridView2.Columns["ciclo"].Width = 65;
                dataGridView2.Columns[4].Width = 195;
                dataGridView2.Columns[5].Width = 180;
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
        private void GridViewMatriculas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView2.RowCount)
            {
                limpiarError();
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                String codigo = row.Cells[0].Value.ToString();
                label4.Text = codigo;
            }
        }
        string dni, nom, ape, sex, eda, grad, tlf, cel, email, naci, dep, dire, dist, prov,observaciones="";

        private void TXTOBSERVACION_KeyUp(object sender, KeyEventArgs e)
        {
            validar();
        }
        private bool validar() {
            bool ok = true;
            
            if (label4.Text == "XXXXXXX") {
                errorProvider1.SetError(label2, "SELECCIONA UNA DE LAS MATRICULAS DEL CUADRO INFERIOR");
                ok = false;
            }
            return ok;
        }
        private void limpiarError() {
            errorProvider1.SetError(label2, null);
        }
        string idioma, nivel, ciclo, modalidad, fechamat, monto, recibo, encargado,personaencargo;
        DataTable studentpic;
        string codigoAlumno;
        String horarioRef;
        private void BTNGENERAR_Click(object sender, EventArgs e)
        {          
            

            string idalumno = label6.Text;
            string idmatricula = label4.Text;
            //------------------------------
            if (validar())
            {
                try
                {
                    DataTable dt = new DataTable();
                    SqlCommand comando = new SqlCommand("detalle_alumno_por_id", _SqlConnection);
                    comando.CommandType = CommandType.StoredProcedure;
                    if (comando.Connection.State == ConnectionState.Closed)
                    {
                        comando.Connection.Open();
                    }
                    comando.Parameters.Add(new SqlParameter("@id", idalumno));
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    da.Fill(dt);
                    dni = dt.Rows[0][0].ToString();
                    nom = dt.Rows[0][1].ToString();
                    ape = dt.Rows[0][2].ToString();
                    sex = dt.Rows[0][3].ToString();
                  
                    grad = dt.Rows[0][5].ToString();
                    tlf = dt.Rows[0][6].ToString();
                    cel = dt.Rows[0][7].ToString();
                    email = dt.Rows[0][9].ToString();
                    naci = Convert.ToDateTime(dt.Rows[0][10]).ToString("dd/MM/yy");
                    //eda = dt.Rows[0][4].ToString();
                    eda = (DateTime.Today.AddTicks(-Convert.ToDateTime(dt.Rows[0][10]).Ticks).Year - 1).ToString();
                    dep = dt.Rows[0][11].ToString();
                    dire = dt.Rows[0][12].ToString();
                    dist = dt.Rows[0][13].ToString();
                    prov = dt.Rows[0][14].ToString();
                    codigoAlumno = dt.Rows[0][15].ToString();
                    if (comando.Connection.State == ConnectionState.Open)
                    {
                        comando.Connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    studentpic = new DataTable();
                    SqlCommand comando = new SqlCommand("buscar_foto_alumno", _SqlConnection);
                    comando.CommandType = CommandType.StoredProcedure;
                    if (comando.Connection.State == ConnectionState.Closed)
                    {
                        comando.Connection.Open();
                    }
                    comando.Parameters.Add(new SqlParameter("@id", idalumno));
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    da.Fill(studentpic);
                    if (comando.Connection.State == ConnectionState.Open)
                    {
                        comando.Connection.Close();
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    DataTable dt = new DataTable();
                    SqlCommand comando = new SqlCommand("mostrar_detalle_matricula_por_id", _SqlConnection);
                    comando.CommandType = CommandType.StoredProcedure;
                    if (comando.Connection.State == ConnectionState.Closed)
                    {
                        comando.Connection.Open();
                    }
                    comando.Parameters.Add(new SqlParameter("@id", idmatricula));
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    da.Fill(dt);
                    idioma = dt.Rows[0][0].ToString();
                    nivel = dt.Rows[0][1].ToString();
                    modalidad = dt.Rows[0][2].ToString();
                    ciclo = dt.Rows[0][3].ToString();
                    fechamat = dt.Rows[0][4].ToString();
                    monto = dt.Rows[0][5].ToString();
                    recibo = dt.Rows[0][6].ToString();
                    encargado = dt.Rows[0][7].ToString();
                    if (comando.Connection.State == ConnectionState.Open)
                    {
                        comando.Connection.Close();
                    }                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try {
                    DataTable dt = new DataTable();
                    SqlCommand comando = new SqlCommand("mostrar_trabajador", _SqlConnection);
                    comando.CommandType = CommandType.StoredProcedure;
                    if (comando.Connection.State == ConnectionState.Closed)
                    {
                        comando.Connection.Open();
                    }
                    comando.Parameters.Add(new SqlParameter("@idtrabajador", encargado));
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    da.Fill(dt);
                    personaencargo = dt.Rows[0][0].ToString();
                    if (comando.Connection.State == ConnectionState.Open)
                    {
                        comando.Connection.Close();
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                horarioRef = dataGridView2.Rows[0].Cells[4].Value.ToString();
                cargar_reporte(dni, nom, ape, sex, eda, grad, tlf, cel, email, naci, dep, dire, dist, prov, idioma, nivel, modalidad, ciclo, fechamat, monto, personaencargo, recibo,studentpic,observaciones,codigoAlumno,horarioRef);
            }
           
        }
        private void cargar_reporte(string dni, string nom, string ape, string sex, string eda, string grad,string tlf, string cel,string email,string naci,string dep,string dire,string dist,string prov,string idioma,string nivel,string modalidad,string ciclo,string fecha,string monto,string responsable,string recibo,DataTable dt,string obs,string codAl,string horarioRef) {
            using (frmRptFichaMatricula frm = new frmRptFichaMatricula(ape, nom, dni, sex, naci, eda, grad, tlf, cel, email, dire, dist, prov, dep, idioma, nivel, ciclo, fecha, responsable, recibo, monto, modalidad,dt,obs,codAl,horarioRef)) {
                frm.ShowDialog();                
            }
        }
    }
}
