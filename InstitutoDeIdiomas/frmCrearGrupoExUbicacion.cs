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
    public partial class frmCrearGrupoExUbicacion : MaterialForm
    {
        MsSqlConnection configurarConexion = new MsSqlConnection();
        public static SqlConnection _SqlConnection = new SqlConnection();
        public frmCrearGrupoExUbicacion()
        {
            InitializeComponent();
            _SqlConnection.ConnectionString = configurarConexion._ConnectionString;
        }

        private void frmCrearGrupoExUbicacion_Load(object sender, EventArgs e)
        {
            listaIdioma();
            listaSalon();
            listarProfesor();
            dtmHoraInicio.Format = DateTimePickerFormat.Custom;
            dtmHoraFinal.Format = DateTimePickerFormat.Custom;
            dtmHoraInicio.CustomFormat = "HH:mm";
            dtmHoraFinal.CustomFormat = "HH:mm";
            listarNumeros();
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

        private void btnCrearGrupo_Click(object sender, EventArgs e)
        {
            if (cbNumero.Text.Trim() == "" || cbAno.Text == "")
            {
                MessageBox.Show("Elige un número de grupo");
            }
            else
            {
                crearGrupo();

            }
        }
        public void crearGrupo()
        {
            //try
            //{

                int idioma = (int)((DataRowView)cmbIdioma.SelectedItem)["idIdioma"];
                int salon = (int)((DataRowView)cmbSalon.SelectedItem)["idSalon"];
                int profesor = (int)((DataRowView)cmbProfesor.SelectedItem)["idtrabajador"];

                SqlCommand cmd = new SqlCommand("insert_grupo_ex_ubicacion", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.Parameters.Add(new SqlParameter("@idtrabajador", profesor));
                cmd.Parameters.Add(new SqlParameter("@idIdioma", idioma));
                cmd.Parameters.Add(new SqlParameter("@numero", cbNumero.Text + "-" + cbAno.Text));
                cmd.Parameters.Add(new SqlParameter("@fecha", dtFecha.Value));
                cmd.Parameters.Add(new SqlParameter("@horaInicio", dtmHoraInicio.Value));
                cmd.Parameters.Add(new SqlParameter("@horaFin", dtmHoraFinal.Value));
                
                
                
                cmd.Parameters.Add(new SqlParameter("@idSalon", salon));
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                MessageBox.Show("GRUPO CREADO SATISFACTORIAMENTE");
                this.Dispose();
                this.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
