﻿using MaterialSkin.Controls;
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
    public partial class frmActualizarAlumno : MaterialForm
    {
        MsSqlConnection configurarConexion = new MsSqlConnection();
        private Panel panel1;
        private MaterialRaisedButton BTNGUARDAR;
        private TextBox TXTEDAD;
        private Label label12;
        private Label label11;
        private TextBox TXTTELEFONO;
        private TextBox TXTCELULAR;
        private Label label10;
        private TextBox TXTCORREO;
        private Label label9;
        private DateTimePicker DTNACIMIENTO;
        private Label label8;
        private Button BTNFOTO;
        private ComboBox CBSEXO;
        private Label label7;
        private Label label6;
        private TextBox TXTDNI;
        private Label label5;
        private TextBox TXTNOMBRE;
        private PictureBox ALUMNOIMAGE;
        private Label label4;
        private TextBox TXTMATERNO;
        private Label label3;
        private TextBox TXTPATERNO;
        private Label LBLIDPERSONA;
        private Button BTNACTUALIZAR;
        private DataGridView GVALUMNOS;
        private Label label2;
        private TextBox TXTALUSEARCH;
        private Label label1;
        private TextBox txtDireccion;
        public static SqlConnection _SqlConnection = new SqlConnection();
        public frmActualizarAlumno()
        {
            InitializeComponent();
            _SqlConnection.ConnectionString = configurarConexion._ConnectionString;
            ALUMNOIMAGE.SizeMode = PictureBoxSizeMode.StretchImage;
            GVALUMNOS.RowHeadersVisible = false;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActualizarAlumno));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNGUARDAR = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TXTEDAD = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TXTTELEFONO = new System.Windows.Forms.TextBox();
            this.TXTCELULAR = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TXTCORREO = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DTNACIMIENTO = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.BTNFOTO = new System.Windows.Forms.Button();
            this.CBSEXO = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TXTDNI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTNOMBRE = new System.Windows.Forms.TextBox();
            this.ALUMNOIMAGE = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTMATERNO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTPATERNO = new System.Windows.Forms.TextBox();
            this.LBLIDPERSONA = new System.Windows.Forms.Label();
            this.BTNACTUALIZAR = new System.Windows.Forms.Button();
            this.GVALUMNOS = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTALUSEARCH = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ALUMNOIMAGE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVALUMNOS)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.BTNGUARDAR);
            this.panel1.Controls.Add(this.TXTEDAD);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.TXTTELEFONO);
            this.panel1.Controls.Add(this.TXTCELULAR);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.TXTCORREO);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.DTNACIMIENTO);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.BTNFOTO);
            this.panel1.Controls.Add(this.CBSEXO);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TXTDNI);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TXTNOMBRE);
            this.panel1.Controls.Add(this.ALUMNOIMAGE);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TXTMATERNO);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TXTPATERNO);
            this.panel1.Controls.Add(this.LBLIDPERSONA);
            this.panel1.Controls.Add(this.BTNACTUALIZAR);
            this.panel1.Controls.Add(this.GVALUMNOS);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TXTALUSEARCH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 406);
            this.panel1.TabIndex = 71;
            // 
            // BTNGUARDAR
            // 
            this.BTNGUARDAR.Depth = 0;
            this.BTNGUARDAR.Location = new System.Drawing.Point(811, 334);
            this.BTNGUARDAR.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTNGUARDAR.Name = "BTNGUARDAR";
            this.BTNGUARDAR.Primary = true;
            this.BTNGUARDAR.Size = new System.Drawing.Size(123, 37);
            this.BTNGUARDAR.TabIndex = 100;
            this.BTNGUARDAR.Text = "GUARDAR";
            this.BTNGUARDAR.UseVisualStyleBackColor = true;
            this.BTNGUARDAR.Click += new System.EventHandler(this.BTNGUARDAR_Click);
            // 
            // TXTEDAD
            // 
            this.TXTEDAD.Enabled = false;
            this.TXTEDAD.Location = new System.Drawing.Point(561, 199);
            this.TXTEDAD.Margin = new System.Windows.Forms.Padding(2);
            this.TXTEDAD.Name = "TXTEDAD";
            this.TXTEDAD.ReadOnly = true;
            this.TXTEDAD.Size = new System.Drawing.Size(138, 20);
            this.TXTEDAD.TabIndex = 97;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(521, 202);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 96;
            this.label12.Text = "EDAD";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(731, 277);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 95;
            this.label11.Text = "TELEFONO";
            // 
            // TXTTELEFONO
            // 
            this.TXTTELEFONO.Location = new System.Drawing.Point(798, 274);
            this.TXTTELEFONO.Margin = new System.Windows.Forms.Padding(2);
            this.TXTTELEFONO.Name = "TXTTELEFONO";
            this.TXTTELEFONO.ReadOnly = true;
            this.TXTTELEFONO.Size = new System.Drawing.Size(138, 20);
            this.TXTTELEFONO.TabIndex = 94;
            // 
            // TXTCELULAR
            // 
            this.TXTCELULAR.Location = new System.Drawing.Point(561, 274);
            this.TXTCELULAR.Margin = new System.Windows.Forms.Padding(2);
            this.TXTCELULAR.Name = "TXTCELULAR";
            this.TXTCELULAR.ReadOnly = true;
            this.TXTCELULAR.Size = new System.Drawing.Size(138, 20);
            this.TXTCELULAR.TabIndex = 93;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(501, 277);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 92;
            this.label10.Text = "CELULAR";
            // 
            // TXTCORREO
            // 
            this.TXTCORREO.Location = new System.Drawing.Point(561, 251);
            this.TXTCORREO.Margin = new System.Windows.Forms.Padding(2);
            this.TXTCORREO.Name = "TXTCORREO";
            this.TXTCORREO.ReadOnly = true;
            this.TXTCORREO.Size = new System.Drawing.Size(376, 20);
            this.TXTCORREO.TabIndex = 91;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(427, 254);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 13);
            this.label9.TabIndex = 90;
            this.label9.Text = "CORREO ELECTRONICO";
            // 
            // DTNACIMIENTO
            // 
            this.DTNACIMIENTO.Enabled = false;
            this.DTNACIMIENTO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTNACIMIENTO.Location = new System.Drawing.Point(561, 176);
            this.DTNACIMIENTO.Margin = new System.Windows.Forms.Padding(2);
            this.DTNACIMIENTO.Name = "DTNACIMIENTO";
            this.DTNACIMIENTO.ShowUpDown = true;
            this.DTNACIMIENTO.Size = new System.Drawing.Size(248, 20);
            this.DTNACIMIENTO.TabIndex = 89;
            this.DTNACIMIENTO.ValueChanged += new System.EventHandler(this.DTNACIMIENTO_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(430, 179);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 13);
            this.label8.TabIndex = 88;
            this.label8.Text = "FECHA DE NACIMIENTO";
            // 
            // BTNFOTO
            // 
            this.BTNFOTO.Enabled = false;
            this.BTNFOTO.Location = new System.Drawing.Point(811, 216);
            this.BTNFOTO.Margin = new System.Windows.Forms.Padding(2);
            this.BTNFOTO.Name = "BTNFOTO";
            this.BTNFOTO.Size = new System.Drawing.Size(124, 29);
            this.BTNFOTO.TabIndex = 87;
            this.BTNFOTO.Text = "CAMBIAR FOTO";
            this.BTNFOTO.UseVisualStyleBackColor = true;
            this.BTNFOTO.Click += new System.EventHandler(this.BTNFOTO_Click);
            // 
            // CBSEXO
            // 
            this.CBSEXO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBSEXO.Enabled = false;
            this.CBSEXO.FormattingEnabled = true;
            this.CBSEXO.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.CBSEXO.Location = new System.Drawing.Point(561, 152);
            this.CBSEXO.Margin = new System.Windows.Forms.Padding(2);
            this.CBSEXO.Name = "CBSEXO";
            this.CBSEXO.Size = new System.Drawing.Size(248, 21);
            this.CBSEXO.TabIndex = 86;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(521, 156);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 85;
            this.label7.Text = "SEXO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(523, 133);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 84;
            this.label6.Text = "D.N.I.";
            // 
            // TXTDNI
            // 
            this.TXTDNI.Location = new System.Drawing.Point(560, 129);
            this.TXTDNI.Margin = new System.Windows.Forms.Padding(2);
            this.TXTDNI.Name = "TXTDNI";
            this.TXTDNI.ReadOnly = true;
            this.TXTDNI.Size = new System.Drawing.Size(248, 20);
            this.TXTDNI.TabIndex = 83;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(498, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 82;
            this.label5.Text = "NOMBRES";
            // 
            // TXTNOMBRE
            // 
            this.TXTNOMBRE.Location = new System.Drawing.Point(560, 106);
            this.TXTNOMBRE.Margin = new System.Windows.Forms.Padding(2);
            this.TXTNOMBRE.Name = "TXTNOMBRE";
            this.TXTNOMBRE.ReadOnly = true;
            this.TXTNOMBRE.Size = new System.Drawing.Size(248, 20);
            this.TXTNOMBRE.TabIndex = 81;
            // 
            // ALUMNOIMAGE
            // 
            this.ALUMNOIMAGE.Location = new System.Drawing.Point(811, 60);
            this.ALUMNOIMAGE.Margin = new System.Windows.Forms.Padding(2);
            this.ALUMNOIMAGE.Name = "ALUMNOIMAGE";
            this.ALUMNOIMAGE.Size = new System.Drawing.Size(124, 151);
            this.ALUMNOIMAGE.TabIndex = 80;
            this.ALUMNOIMAGE.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(443, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 79;
            this.label4.Text = "APELLIDO MATERNO";
            // 
            // TXTMATERNO
            // 
            this.TXTMATERNO.Location = new System.Drawing.Point(559, 83);
            this.TXTMATERNO.Margin = new System.Windows.Forms.Padding(2);
            this.TXTMATERNO.Name = "TXTMATERNO";
            this.TXTMATERNO.ReadOnly = true;
            this.TXTMATERNO.Size = new System.Drawing.Size(248, 20);
            this.TXTMATERNO.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(444, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "APELLIDO PATERNO";
            // 
            // TXTPATERNO
            // 
            this.TXTPATERNO.Location = new System.Drawing.Point(559, 60);
            this.TXTPATERNO.Margin = new System.Windows.Forms.Padding(2);
            this.TXTPATERNO.Name = "TXTPATERNO";
            this.TXTPATERNO.ReadOnly = true;
            this.TXTPATERNO.Size = new System.Drawing.Size(248, 20);
            this.TXTPATERNO.TabIndex = 76;
            // 
            // LBLIDPERSONA
            // 
            this.LBLIDPERSONA.AutoSize = true;
            this.LBLIDPERSONA.ForeColor = System.Drawing.Color.White;
            this.LBLIDPERSONA.Location = new System.Drawing.Point(433, 372);
            this.LBLIDPERSONA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLIDPERSONA.Name = "LBLIDPERSONA";
            this.LBLIDPERSONA.Size = new System.Drawing.Size(42, 13);
            this.LBLIDPERSONA.TabIndex = 75;
            this.LBLIDPERSONA.Text = "XXXXX";
            // 
            // BTNACTUALIZAR
            // 
            this.BTNACTUALIZAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BTNACTUALIZAR.FlatAppearance.BorderSize = 0;
            this.BTNACTUALIZAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNACTUALIZAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNACTUALIZAR.ForeColor = System.Drawing.Color.White;
            this.BTNACTUALIZAR.Location = new System.Drawing.Point(672, 334);
            this.BTNACTUALIZAR.Margin = new System.Windows.Forms.Padding(2);
            this.BTNACTUALIZAR.Name = "BTNACTUALIZAR";
            this.BTNACTUALIZAR.Size = new System.Drawing.Size(123, 37);
            this.BTNACTUALIZAR.TabIndex = 74;
            this.BTNACTUALIZAR.Text = "ACTUALIZAR";
            this.BTNACTUALIZAR.UseVisualStyleBackColor = false;
            this.BTNACTUALIZAR.Click += new System.EventHandler(this.BTNACTUALIZAR_Click);
            // 
            // GVALUMNOS
            // 
            this.GVALUMNOS.AllowUserToAddRows = false;
            this.GVALUMNOS.AllowUserToDeleteRows = false;
            this.GVALUMNOS.AllowUserToResizeRows = false;
            this.GVALUMNOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVALUMNOS.Location = new System.Drawing.Point(10, 57);
            this.GVALUMNOS.Margin = new System.Windows.Forms.Padding(2);
            this.GVALUMNOS.Name = "GVALUMNOS";
            this.GVALUMNOS.ReadOnly = true;
            this.GVALUMNOS.RowHeadersVisible = false;
            this.GVALUMNOS.RowTemplate.Height = 24;
            this.GVALUMNOS.Size = new System.Drawing.Size(400, 336);
            this.GVALUMNOS.TabIndex = 73;
            this.GVALUMNOS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVALUMNOS_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "Ingresa el nombre del alumno a buscar";
            // 
            // TXTALUSEARCH
            // 
            this.TXTALUSEARCH.Location = new System.Drawing.Point(11, 32);
            this.TXTALUSEARCH.Margin = new System.Windows.Forms.Padding(2);
            this.TXTALUSEARCH.Name = "TXTALUSEARCH";
            this.TXTALUSEARCH.Size = new System.Drawing.Size(293, 20);
            this.TXTALUSEARCH.TabIndex = 71;
            this.TXTALUSEARCH.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXTALUSEARCH_KeyUp);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(561, 225);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(245, 20);
            this.txtDireccion.TabIndex = 101;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(491, 228);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 102;
            this.label1.Text = "DIRECCION";
            // 
            // frmActualizarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 469);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmActualizarAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACTUALIZAR ALUMNO";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ALUMNOIMAGE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVALUMNOS)).EndInit();
            this.ResumeLayout(false);

        }

        private void TXTALUSEARCH_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                _SqlConnection.Open();
                SqlCommand cmd = new SqlCommand("buscarAlumnoApellido", _SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@txt", TXTALUSEARCH.Text.Trim()));
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                dt.Clear();

                da.Fill(dt);


                GVALUMNOS.DataSource = dt;
                GVALUMNOS.Columns[0].Width = 205;
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

        private void GVALUMNOS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < GVALUMNOS.RowCount )
            {
                DataGridViewRow row = this.GVALUMNOS.Rows[e.RowIndex];
                String dni = row.Cells["DNI"].Value.ToString();               
                try {
                    DataTable dt = new DataTable();
                    SqlCommand comando = new SqlCommand("buscarPersona", _SqlConnection);
                    comando.CommandType = CommandType.StoredProcedure;
                    if (comando.Connection.State == ConnectionState.Closed)
                    {
                        comando.Connection.Open();
                    }
                    comando.Parameters.Add(new SqlParameter("@dni", dni));
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    da.Fill(dt);
                    byte[] img = (byte[])(dt.Rows[0][7]);
                    if (img == null)
                    {
                        ALUMNOIMAGE.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        ALUMNOIMAGE.Image = Image.FromStream(ms);
                    }
                    LBLIDPERSONA.Text = dt.Rows[0][0].ToString();
                    TXTPATERNO.Text = dt.Rows[0][1].ToString();
                    TXTMATERNO.Text = dt.Rows[0][2].ToString();
                    TXTNOMBRE.Text = dt.Rows[0][3].ToString();
                    TXTEDAD.Text = dt.Rows[0][4].ToString();
                    DTNACIMIENTO.Value = DateTime.Parse(dt.Rows[0][5].ToString());
                    TXTCORREO.Text = dt.Rows[0][6].ToString();
                    TXTTELEFONO.Text = dt.Rows[0][8].ToString();
                    TXTCELULAR.Text = dt.Rows[0][9].ToString();
                    if (dt.Rows[0][10].ToString() == "MASCULINO")
                    {
                        CBSEXO.SelectedIndex = 0;
                    }
                    else {
                        CBSEXO.SelectedIndex = 1;
                    }
                    TXTDNI.Text = dt.Rows[0][11].ToString();
                    txtDireccion.Text = dt.Rows[0][12].ToString();
                    if (comando.Connection.State == ConnectionState.Open)
                    {
                        comando.Connection.Close();
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BTNACTUALIZAR_Click(object sender, EventArgs e)
        {
            HABILITARCONTROLES();
        }
        private void HABILITARCONTROLES() {
            TXTPATERNO.ReadOnly = false;
            TXTMATERNO.ReadOnly = false;
            TXTNOMBRE.ReadOnly = false;
            TXTDNI.ReadOnly = false;
            CBSEXO.Enabled = true;
            DTNACIMIENTO.Enabled = true;
            TXTCORREO.ReadOnly = false;
            TXTCELULAR.ReadOnly = false;
            TXTTELEFONO.ReadOnly = false;
            BTNGUARDAR.Enabled = true;
            BTNFOTO.Enabled = true;
            BTNACTUALIZAR.Enabled = false;
            txtDireccion.ReadOnly = false;
        }
        private void DESHABILITARCONTROLES() {
            TXTPATERNO.ReadOnly = true;
            TXTMATERNO.ReadOnly = true;
            TXTNOMBRE.ReadOnly = true;
            TXTDNI.ReadOnly = true;
            CBSEXO.Enabled = false;
            DTNACIMIENTO.Enabled = false;
            TXTCORREO.ReadOnly = true;
            TXTCELULAR.ReadOnly = true;
            TXTTELEFONO.ReadOnly = true;
            BTNGUARDAR.Enabled = false;
            BTNFOTO.Enabled = false;
            BTNACTUALIZAR.Enabled = true ;
            txtDireccion.ReadOnly = true;
        }
        private void BTNGUARDAR_Click(object sender, EventArgs e)
        {            
            try {
                actualizarUbigeo(LBLIDPERSONA.Text);
                SqlCommand comando = new SqlCommand("actualizarPersona", _SqlConnection);
                comando.CommandType = CommandType.StoredProcedure;
                if (comando.Connection.State == ConnectionState.Closed)
                {
                    comando.Connection.Open();
                }
                comando.Parameters.Add(new SqlParameter("@id", LBLIDPERSONA.Text.ToString()));
                comando.Parameters.Add(new SqlParameter("@paterno", TXTPATERNO.Text.Trim()));
                comando.Parameters.Add(new SqlParameter("@dni", TXTDNI.Text.Trim()));
                comando.Parameters.Add(new SqlParameter("@nombre", TXTNOMBRE.Text.Trim()));              
                comando.Parameters.Add(new SqlParameter("@materno", TXTMATERNO.Text.Trim()));
                comando.Parameters.Add(new SqlParameter("@sexo", CBSEXO.SelectedItem.ToString()));
                comando.Parameters.Add(new SqlParameter("@edad", TXTEDAD.Text.Trim()));                                                
                comando.Parameters.Add(new SqlParameter("@celular", TXTCELULAR.Text.Trim()));               
                comando.Parameters.Add(new SqlParameter("@telefono", TXTTELEFONO.Text.Trim()));
                comando.Parameters.Add(new SqlParameter("@correo", TXTCORREO.Text.Trim()));
                comando.Parameters.Add(new SqlParameter("@nacimiento", DTNACIMIENTO.Value));
                comando.Parameters.Add("@foto", System.Data.SqlDbType.Image);
                //asignando el valor de la imagen
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                //se guarda la imagen en el buffer
                ALUMNOIMAGE.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                //se extraen los bytes del buffer para asignarlos como valor para el parametro
                comando.Parameters["@foto"].Value = ms.GetBuffer();
                comando.ExecuteNonQuery();
                DESHABILITARCONTROLES();
                if (comando.Connection.State == ConnectionState.Open)
                {
                    comando.Connection.Close();
                }
                MessageBox.Show("REGISTRO ACTUALIZADO");
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        public void actualizarUbigeo(string idPersona)
        {
            SqlCommand comando = new SqlCommand("actualizar_ubigeo", _SqlConnection);
            comando.CommandType = CommandType.StoredProcedure;
            if (comando.Connection.State == ConnectionState.Closed)
            {
                comando.Connection.Open();
            }
            comando.Parameters.Add(new SqlParameter("@idPersona", LBLIDPERSONA.Text.ToString()));
            comando.Parameters.Add(new SqlParameter("@direccion", txtDireccion.Text));
            comando.ExecuteNonQuery();
            if (comando.Connection.State == ConnectionState.Open)
            {
                comando.Connection.Close();
            }
        }

        private void BTNFOTO_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                ALUMNOIMAGE.SizeMode = PictureBoxSizeMode.StretchImage;
                ALUMNOIMAGE.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void DTNACIMIENTO_ValueChanged(object sender, EventArgs e)
        {
            if (DTNACIMIENTO.Value < DateTime.Today)
            {
                //CODIGO USADO PARA CALCULAR LA EDAD AUTOMATICAMENTE
                TXTEDAD.Text = (DateTime.Today.AddTicks(-DTNACIMIENTO.Value.Ticks).Year - 1).ToString();
            }
            else
            {
                DTNACIMIENTO.Value = DateTime.Today;
            }
        }
    }
}
