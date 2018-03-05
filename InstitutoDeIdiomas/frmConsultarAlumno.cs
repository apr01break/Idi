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

        DataSet resultados = new DataSet();
        public frmConsultarAlumno(String id)
        {
            InitializeComponent();
            _SqlConnection.ConnectionString = configurarConexion._ConnectionString;
            dataGridViewApellido.RowHeadersVisible = false;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            


        }

        private void frmConsultarAlumno_Load(object sender, EventArgs e)
        {
        }

        private void txtApellido_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                _SqlConnection.Open();
                SqlCommand cmd = new SqlCommand("buscarAlumnoApellido", _SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@txt", txtApellido.Text.Trim()));
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                dt.Clear();

                da.Fill(dt);


                dataGridViewApellido.DataSource = dt;
                dataGridViewApellido.Columns[0].Width =205;
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

        private void dataGridViewDNI_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void dataGridViewApellido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewApellido.RowCount)
            {
                try
                {
                    DataTable dt = new DataTable();
                    DataGridViewRow row = this.dataGridViewApellido.Rows[e.RowIndex];
                    String dni = row.Cells[1].Value.ToString();
                    String tipo = row.Cells[2].Value.ToString();
                    _SqlConnection.Open();
                    SqlCommand cmd = new SqlCommand("buscarTodo", _SqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@dni", dni));
                    cmd.Parameters.Add(new SqlParameter("@tipoalu", tipo));

                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(dt);
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

        }


    

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
