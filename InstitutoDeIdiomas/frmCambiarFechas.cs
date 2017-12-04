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
    public partial class frmCambiarFechas : Form
    {
        frmAsignarAlumnosToGroup frmAsignarAlumnosToGrou;
        MsSqlConnection configurarConexion = new MsSqlConnection();
        public static SqlConnection _SqlConnection = new SqlConnection();
        int idGrupo;
        public frmCambiarFechas(frmAsignarAlumnosToGroup frmAsignarAlumnosToGroup, string inicio, string fin, int id)
        {
            InitializeComponent();
            _SqlConnection.ConnectionString = configurarConexion._ConnectionString;
            this.frmAsignarAlumnosToGrou = frmAsignarAlumnosToGroup;
            this.idGrupo = id;
            cargarComponentes(inicio, fin);
        }

        public void cargarComponentes(string inicio, string fin)
        {
            dtFechInicio.Text = inicio;
            dtFechFin.Text = fin;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAsignarAlumnosToGrou.txtFeInicio.Text = Convert.ToDateTime(dtFechInicio.Value).ToString("dd/MM/yyyy");
            frmAsignarAlumnosToGrou.txtFeFin.Text = Convert.ToDateTime(dtFechFin.Value).ToString("dd/MM/yyyy");
            SqlCommand cmd = new SqlCommand("cambiar_fechas", _SqlConnection);
            if (cmd.Connection.State == ConnectionState.Closed)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.Add(new SqlParameter("@fechaInicio", dtFechInicio.Value));
            cmd.Parameters.Add(new SqlParameter("@fechaFinal", dtFechFin.Value));
            cmd.Parameters.Add(new SqlParameter("@idGrupo", idGrupo));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
            this.Dispose();
            this.Close();
        }
    }
}
