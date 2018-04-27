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
    public partial class frmEstadisticas : MaterialForm
    {
        MsSqlConnection configurarConexion = new MsSqlConnection();
        public static SqlConnection _SqlConnection = new SqlConnection();
        List<string> listMeses = new List<string>();
        public frmEstadisticas()
        {
            InitializeComponent();
            _SqlConnection.ConnectionString = configurarConexion._ConnectionString;
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            
            string criterio = cbCriterio.Text;
            string anho = cbAnho.Text;
            if (criterio == "" || anho == "")
            {
                MessageBox.Show("Seleccione los datos");
            }
            else
            {
                string meses = "";
                if (cbTodos.Checked == false)
                {
                    foreach (string drv in clbMeses.CheckedItems)
                    {
                        meses += Convert.ToDateTime(drv + " 01, 1900").Month.ToString() + ",";
                    }
                    if (meses.Length > 0) meses = meses.Substring(0, meses.Length - 1);
                    else { MessageBox.Show("Seleccione los meses"); return; }
                }
                else if (cbTodos.Checked == true)
                {
                    meses = "1,2,3,4,5,6,7,8,9,10,11,12";
                }
                if (criterio == "Matriculados") Matriculados(meses, anho);
                else if (criterio == "Género") genero(meses, anho);
                else if (criterio == "Tipo de alumno") tipoAlumno(meses, anho);
                else if (criterio == "Facultad") facultad(meses, anho);
            }
        }
        public void Matriculados(string meses,string anho)
        {
            DataTable dt = new DataTable();
            string extra = "M";
            try
            {

                SqlCommand comando = new SqlCommand("select concat(p.apaterno,' ',p.amaterno,' ',p.nombre)as nombre,DATENAME(month, g.fechaInicio) mes from Alumno a "
                + " inner join AlumnoGrupo ag on a.idalumno = ag.idalumno "
                + " inner join Grupo g on ag.idGrupo = g.idGrupo "
                + " inner join Persona p on a.idpersona = p.idpersona "
                + " where MONTH(g.fechaInicio) in (" + meses + ") and g.idNivel = 1 and g.ciclo = 1  and YEAR(g.fechaInicio)= "+anho
                + " order by MONTH(g.fechaInicio)", _SqlConnection);
                if (comando.Connection.State == ConnectionState.Closed)
                {
                    comando.Connection.Open();
                }
                //comando.Parameters.Add(new SqlParameter("@cod", cod));
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                if (comando.Connection.State == ConnectionState.Open)
                {
                    comando.Connection.Close();
                }
                new frmRptEstadisticas(dt,extra,anho).Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void genero(string meses, string anho)
        {
            DataTable dt = new DataTable();
            string extra = "Género";
            try
            {

                SqlCommand comando = new SqlCommand("select concat(p.apaterno,' ',p.amaterno,' ',p.nombre)as nombre,DATENAME(month, g.fechaInicio) mes, p.sexo extra from Alumno a "
                + " inner join AlumnoGrupo ag on a.idalumno = ag.idalumno "
                + " inner join Grupo g on ag.idGrupo = g.idGrupo "
                + " inner join Persona p on a.idpersona = p.idpersona "
                + " where MONTH(g.fechaInicio) in (" + meses + ") and g.idNivel = 1 and g.ciclo = 1 and YEAR(g.fechaInicio)= " + anho
                + " order by MONTH(g.fechaInicio),p.sexo,concat(p.apaterno,' ',p.amaterno,' ',p.nombre)", _SqlConnection);
                if (comando.Connection.State == ConnectionState.Closed)
                {
                    comando.Connection.Open();
                }
                //comando.Parameters.Add(new SqlParameter("@cod", cod));
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                if (comando.Connection.State == ConnectionState.Open)
                {
                    comando.Connection.Close();
                }
                new frmRptEstadisticas(dt,extra,anho).Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void tipoAlumno(string meses, string anho)
        {
            DataTable dt = new DataTable();
            string extra = "Tipo de alumno";
            try
            {
                SqlCommand comando = new SqlCommand("select concat(p.apaterno,' ',p.amaterno,' ',p.nombre)as nombre,DATENAME(month, g.fechaInicio) mes,ta.Descripcion extra from Alumno a"
                +" inner join AlumnoGrupo ag on a.idalumno = ag.idalumno"
                +" inner join Grupo g on ag.idGrupo = g.idGrupo"
                +" inner join Persona p on a.idpersona = p.idpersona"
                +" inner join TipoAlumno ta on a.idTipoAlumno = ta.idTipoAlumno"
                +" where MONTH(g.fechaInicio) in ("+meses+") and g.idNivel = 1 and g.ciclo = 1  and YEAR(g.fechaInicio) ="+anho
                +" order by MONTH(g.fechaInicio), ta.Descripcion, concat(p.apaterno, ' ', p.amaterno, ' ', p.nombre)", _SqlConnection);
                if (comando.Connection.State == ConnectionState.Closed)
                {
                    comando.Connection.Open();
                }
                //comando.Parameters.Add(new SqlParameter("@cod", cod));
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                if (comando.Connection.State == ConnectionState.Open)
                {
                    comando.Connection.Close();
                }
                new frmRptEstadisticas(dt, extra,anho).Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void facultad(string meses, string anho)
        {
            DataTable dt = new DataTable();
            string extra = "Facultad";
            try
            {
                SqlCommand comando = new SqlCommand("select concat(p.apaterno,' ',p.amaterno,' ',p.nombre)as nombre,DATENAME(month, g.fechaInicio) mes, f.facultad extra from Alumno a"
                + " inner join AlumnoGrupo ag on a.idalumno = ag.idalumno"
                + " inner join Grupo g on ag.idGrupo = g.idGrupo"
                + " inner join Persona p on a.idpersona = p.idpersona"
                + " inner join TipoAlumno ta on a.idTipoAlumno = ta.idTipoAlumno"
                + " inner join Faustiniano f on ta.idDescripcion = f.idDescripcion"
                + " where MONTH(g.fechaInicio) in ("+meses+") and g.idNivel = 1 and g.ciclo = 1  and YEAR(g.fechaInicio) = "+anho
                + " order by MONTH(g.fechaInicio), f.facultad, concat(p.apaterno, ' ', p.amaterno, ' ', p.nombre)", _SqlConnection);
                if (comando.Connection.State == ConnectionState.Closed)
                {
                    comando.Connection.Open();
                }
                //comando.Parameters.Add(new SqlParameter("@cod", cod));
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                if (comando.Connection.State == ConnectionState.Open)
                {
                    comando.Connection.Close();
                }
                new frmRptEstadisticas(dt, extra, anho).Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTodos.Checked)
            {
                clbMeses.Enabled = false;
                return;
            }
            clbMeses.Enabled = true;
        }
    }
}
