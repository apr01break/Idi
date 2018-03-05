﻿using MaterialSkin.Controls;
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
    public partial class frmSeleccionarGrupo : MaterialForm
    {
        int idGrupo;
        MsSqlConnection configurarConexion = new MsSqlConnection();
        public static SqlConnection _SqlConnection = new SqlConnection();
        public frmSeleccionarGrupo(String idtrabajador, int opcion)
        {
            InitializeComponent();
            _SqlConnection.ConnectionString = configurarConexion._ConnectionString;
            cargarGrupos(idtrabajador);
            cargarNombre(idtrabajador);
            if (opcion == 0) btnRegistroAuxiliar.Visible = true;
            else if (opcion == 1) btnRegistrarNotas.Visible = true;
            else if (opcion == 2) btnRegistrarAsistencias.Visible = true;
            
        }


        public void cargarNombre(String id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("obtener_nomb", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.Parameters.Add(new SqlParameter("@idusuario", id));
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                lblNombre.Text = dt.Rows[0][0].ToString();



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

        public void cargarGrupos(String id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("listar_grupo_profesor", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.Parameters.Add(new SqlParameter("@idusuario", id));
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvwGrupo.DataSource = dt;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow row = dt.Rows[i];
                    if (!DBNull.Value.Equals(row["HORA DE INICIO"]))
                    {
                        String datime = Convert.ToDateTime(row["HORA DE INICIO"]).ToString("HH:mm tt");
                        row["HORA DE INICIO"] = datime;
                    }
                    if (!DBNull.Value.Equals(row["HORA DE TERMINO"]))
                    {
                        String datime = Convert.ToDateTime(row["HORA DE TERMINO"]).ToString("HH:mm tt");
                        row["HORA DE TERMINO"] = datime;
                    }
                }
                dgvwGrupo.Columns["idGrupo"].Visible = false;

                
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

        private void dgvwGrupo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvwGrupo.RowCount)
            {
                btnRegistrarNotas.Enabled = true;
                btnRegistroAuxiliar.Enabled = true;
                btnRegistrarAsistencias.Enabled = true;
                try
                {
                    DataGridViewRow row = dgvwGrupo.Rows[e.RowIndex];
                    idGrupo = (int)row.Cells["idGrupo"].Value;
                    btnRegistroAuxiliar.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRegistroAuxiliar registroAuxiliar = new frmRegistroAuxiliar(idGrupo);
            this.Close();
            registroAuxiliar.Show();
        }

        private void btnRegistrarNotas_Click(object sender, EventArgs e)
        {
            frmRegistrarNotas frmRegistrarNotas = new frmRegistrarNotas(idGrupo);
            this.Close();
            frmRegistrarNotas.Show();
        }

        private void btnRegistrarAsistencias_Click(object sender, EventArgs e)
        {
            frmRegistrarAsistencia frmRegistrarAsistencia = new frmRegistrarAsistencia(idGrupo);
            this.Close();
            frmRegistrarAsistencia.Show();
        }
    }
}
