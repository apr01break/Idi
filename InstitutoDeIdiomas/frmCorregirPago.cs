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
    public partial class frmCorregirPago : MaterialForm
    {
        MsSqlConnection configurarConexion = new MsSqlConnection();
        public static SqlConnection _SqlConnection = new SqlConnection();
        string idPago;
        public frmCorregirPago()
        {
            InitializeComponent();
            _SqlConnection.ConnectionString = configurarConexion._ConnectionString;
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (rbRecibo.Checked == true)
            {
                try
                {
                    DataTable dt = new DataTable();
                    _SqlConnection.Open();
                    SqlCommand cmd = new SqlCommand("buscar_pago_por_recibo", _SqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@txt", txtBuscar.Text.Trim()));
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dt.Clear();
                    da.Fill(dt);
                    dgvwPagos.DataSource = dt;

                    dgvwPagos.Columns[0].Visible = false;
                    dgvwPagos.Columns[1].Width = 239;
                    dgvwPagos.Columns[2].Width = 71;
                    dgvwPagos.Columns[4].Width = 83;
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
            else if (rbNombre.Checked == true)
            {
                try
                {
                    DataTable dt = new DataTable();
                    _SqlConnection.Open();
                    SqlCommand cmd = new SqlCommand("buscar_pago_por_nombre", _SqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@txt", txtBuscar.Text.Trim()));
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dt.Clear();
                    da.Fill(dt);
                    dgvwPagos.DataSource = dt;

                    dgvwPagos.Columns[0].Visible = false;
                    dgvwPagos.Columns[1].Width = 240;
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

        private void dgvwPagos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvwPagos.RowCount)
            {
                DataGridViewRow row = this.dgvwPagos.Rows[e.RowIndex];
                String nroRecibo = row.Cells[3].Value.ToString();
                txtRecibo.Text = nroRecibo;
                txtNuevoRecibo.Focus();
                btnCambiar.Enabled = true;
                idPago = row.Cells[0].Value.ToString();
            }
        }

        private void frmCorregirPago_Load(object sender, EventArgs e)
        {
            txtBuscar.Focus();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            if (txtNuevoRecibo.Text == "")
            {
                MessageBox.Show("Escriba el nuevo número de recibo");
            }
            else
            {
                try
                {
                    DataTable dt = new DataTable();
                    _SqlConnection.Open();
                    SqlCommand cmd = new SqlCommand("cambiar_numero_recibo", _SqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@recibo", txtRecibo.Text.Trim()));
                    cmd.Parameters.Add(new SqlParameter("@nuevorecibo", txtNuevoRecibo.Text.Trim()));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Número de recibo cambiado");
                    txtNuevoRecibo.Text = "";
                    txtRecibo.Text = "";
                    txtBuscar.Text = "";
                    dgvwPagos.DataSource = null;
                    dgvwPagos.Columns.Clear();
                    dgvwPagos.Rows.Clear();
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

        private void btnEliminarPago_Click(object sender, EventArgs e)
        {
            if (verificarSaldosPagos(idPago))
            {
                if (MessageBox.Show("EL PAGO SERÁ ELIMINADO POR COMPLETO \n ¿DESEAS CONTINUAR?", "ADVERTENCIA", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("eliminar_pago_no_saldo", _SqlConnection);
                        if (cmd.Connection.State == ConnectionState.Closed)
                        {
                            cmd.Connection.Open();
                        }
                        cmd.Parameters.Add(new SqlParameter("@idPago", idPago));
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                        if (cmd.Connection.State == ConnectionState.Open)
                        {
                            cmd.Connection.Close();
                        }
                        MessageBox.Show("Eliminado exitosamente");
                        txtBuscar_KeyUp(null,null);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Este pago utiliza el concepto de saldos");
            }
        }
        public Boolean verificarSaldosPagos(string idPago)
        {
            SqlCommand cmd = new SqlCommand("verificar_saldo_pago", _SqlConnection);
            if (cmd.Connection.State == ConnectionState.Closed)
            {
                cmd.Connection.Open();
            }
            //MessageBox.Show(idPago);
            cmd.Parameters.Add(new SqlParameter("@idPago", idPago));
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
            if (dt.Rows.Count == 0) return true;
            else return false;
        }
    }
}
