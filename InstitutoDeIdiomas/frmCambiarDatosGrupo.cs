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
    public partial class frmCambiarDatosGrupo : MaterialForm
    {
        MsSqlConnection configurarConexion = new MsSqlConnection();
        public static SqlConnection _SqlConnection = new SqlConnection();
        int idGrupo;
        frmAsignarAlumnosToGroup frmAsignarAlumnosToGroup;
        public frmCambiarDatosGrupo(int idGrupo, frmAsignarAlumnosToGroup frmAsignarAlumnosToGroup)
        {
            InitializeComponent();
            _SqlConnection.ConnectionString = configurarConexion._ConnectionString;
            this.idGrupo = idGrupo;
            this.frmAsignarAlumnosToGroup = frmAsignarAlumnosToGroup;
        }
        public void cargarDatosGrupo(int idGrupo)
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
                if (!DBNull.Value.Equals(row2["horaInicio"]))
                {
                    String datime = Convert.ToDateTime(row2["horaInicio"]).ToString("HH:mm");
                    row2["horaInicio"] = datime;
                }
                if (!DBNull.Value.Equals(row2["horaFinal"]))
                {
                    String datime = Convert.ToDateTime(row2["horaFinal"]).ToString("HH:mm");
                    row2["horaFinal"] = datime;
                }
                cmbIdioma.Text= row2[1].ToString();
                cmbNivel.Text = row2[2].ToString();
                numCiclo.Value = Convert.ToInt32(row2[3].ToString());
                cmbSalon.Text = row2[4].ToString();
                dtmHoraInicio.Value = Convert.ToDateTime( row2[5].ToString());
                dtmHoraFinal.Value = Convert.ToDateTime(row2[6].ToString());
                //anho = Convert.ToDateTime(row2[7]).ToString("yyyy");
                //mes = Convert.ToDateTime(row2[7]).ToString("MMMMM").ToUpper();
                dtFechaInicio.Value = Convert.ToDateTime(row2[7].ToString());
                dtFechaFinal.Value = Convert.ToDateTime(row2[9].ToString());
                cmbProfesor.Text = row2[8].ToString();
                string numero = row2[10].ToString();
                cbNumero.Text = numero.Substring(0,3);
                cbAno.Text = numero.Substring(4, 4);
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
        private void frmCambiarDatosGrupo_Load(object sender, EventArgs e)
        {
            listaIdioma();
            listaNivel();
            listaSalon();
            listarProfesor();
            dtmHoraInicio.Format = DateTimePickerFormat.Custom;
            dtmHoraFinal.Format = DateTimePickerFormat.Custom;
            dtmHoraInicio.CustomFormat = "HH:mm";
            dtmHoraFinal.CustomFormat = "HH:mm";
            listarNumeros();
            cargarDatosGrupo(idGrupo);
        }

        public void listarNumeros()
        {
            for (int i = 1; i < 33; i++)
            {
                cbNumero.Items.Add(i.ToString().PadLeft(3, '0'));
            }
        }
        public void listaIdioma()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("listar_idioma", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                cmbIdioma.DisplayMember = "nombreIdioma";
                cmbIdioma.DataSource = dt;
                cmbIdioma.ValueMember = "idIdioma";
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

        public void listaNivel()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("listar_nivel", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                cmbNivel.DisplayMember = "nombreNivel";
                cmbNivel.DataSource = dt;
                cmbNivel.ValueMember = "idNivel";
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

        public void listaSalon()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("listar_salon", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                cmbSalon.DisplayMember = "nombreSalon";
                cmbSalon.DataSource = dt;
                cmbSalon.ValueMember = "idSalon";
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

        public void listarProfesor()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("listar_profesor", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                cmbProfesor.DisplayMember = "NomProf";
                cmbProfesor.DataSource = dt;
                cmbProfesor.ValueMember = "idtrabajador";
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int idioma = (int)((DataRowView)cmbIdioma.SelectedItem)["idIdioma"];
                int nivel = (int)((DataRowView)cmbNivel.SelectedItem)["idNivel"];
                int salon = (int)((DataRowView)cmbSalon.SelectedItem)["idSalon"];
                int profesor = (int)((DataRowView)cmbProfesor.SelectedItem)["idtrabajador"];

                SqlCommand cmd = new SqlCommand("modificar_grupo", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }

                cmd.Parameters.Add(new SqlParameter("@idGrupo", idGrupo));
                cmd.Parameters.Add(new SqlParameter("@idtrabajador", profesor));
                cmd.Parameters.Add(new SqlParameter("@horaInicio", dtmHoraInicio.Value));
                cmd.Parameters.Add(new SqlParameter("@horaFinal", dtmHoraFinal.Value));
                cmd.Parameters.Add(new SqlParameter("@fechaInicio", dtFechaInicio.Value));
                cmd.Parameters.Add(new SqlParameter("@fechaFinal", dtFechaFinal.Value));
                cmd.Parameters.Add(new SqlParameter("@idIdioma", idioma));
                cmd.Parameters.Add(new SqlParameter("@idNivel", nivel));
                cmd.Parameters.Add(new SqlParameter("@ciclo", numCiclo.Value));
                cmd.Parameters.Add(new SqlParameter("@numero", cbNumero.Text + "-" + cbAno.Text));
                cmd.Parameters.Add(new SqlParameter("@idSalon", salon));
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                MessageBox.Show("GRUPO MODIFICADO SATISFACTORIAMENTE");
                frmAsignarAlumnosToGroup.cargarDatosGrupo(idGrupo);
                this.Dispose();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
