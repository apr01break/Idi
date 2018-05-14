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
    public partial class frmCrearPago : MaterialForm
    {
        String idcodigo;
        MsSqlConnection configurarConexion = new MsSqlConnection();
        DataTable dtSaldos = new DataTable();
        public static SqlConnection _SqlConnection = new SqlConnection();
        double refe = 0;
        string usuario, idalumno, dni, idPago;
        string nom, ape, sex, eda, grad, tlf, cel, email, naci, dep, dire, dist, prov, observaciones = "";
        string idioma, nivel, ciclo, modalidad, fechamat, monto, recibo, encargado, personaencargo;
        DataTable studentpic;
        string codigoAlumno;
        String horarioRef;
        DataTable dtLegend = new DataTable();
        DataSet resultados = new DataSet();

        public frmCrearPago(String codigo)
        {
            InitializeComponent();
            idcodigo = codigo;
            _SqlConnection.ConnectionString = configurarConexion._ConnectionString;
            FOTOALUMNOAPAGAR.SizeMode = PictureBoxSizeMode.StretchImage;
            GRIDVIEWCONSALUPAGO.RowHeadersVisible = false;
            GRIDVIEWTIPOSPAGOS.RowHeadersVisible = false;
            this.GRIDVIEWTIPOSPAGOS.AlternatingRowsDefaultCellStyle.BackColor =
    Color.PowderBlue;
            listarHorarios();
            buscarUsuario(codigo);
        }

        private void buscarUsuario(string idUsuario)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand comando = new SqlCommand("buscar_usuario_porid", _SqlConnection);
                comando.CommandType = CommandType.StoredProcedure;
                if (comando.Connection.State == ConnectionState.Closed)
                {
                    comando.Connection.Open();
                }
                comando.Parameters.Add(new SqlParameter("@idUsuario", idUsuario));
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                if (comando.Connection.State == ConnectionState.Open)
                {
                    comando.Connection.Close();
                }
                usuario = dt.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CBLISTBOX_CheckedChanged(object sender, EventArgs e)
        {

        }
        public void guardarSaldo()
        {
            decimal mr = Convert.ToDecimal(TXTMONTORECIBO.Text);
            decimal mp = Convert.ToDecimal(TXTMONTO.Text);
            if (mr - mp > 0)
            {
                SqlCommand cmd = new SqlCommand("crear_nuevo_saldo", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@montoSaldo", (mr - mp)));
                cmd.Parameters.Add(new SqlParameter("@numRecibo", TXTNUMERORECIBO.Text.Trim().ToString()));
                cmd.ExecuteNonQuery();
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                MessageBox.Show("Saldo guardado exitosamente: " + (mr - mp) + " soles");
            }
        }
        private double calcularSaldo()
        {
            double monto = 0;
            foreach (DataGridViewRow r in dgvwSaldo.Rows)
            {
                DataGridViewCheckBoxCell ck = r.Cells["SELECCIONAR"] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(ck.Value))
                {
                    double cantidad = Convert.ToDouble(r.Cells[2].Value.ToString());
                    monto = monto + cantidad;
                }
            }
            return monto;
        }
        private bool validarSaldo()
        {
            DataTable dtS = new DataTable();
            dtS.Columns.Add("idSaldo");
            dtS.Columns.Add("numRecibo");
            dtS.Columns.Add("monto");
            double monto = 0;
            if (TXTMONTORECIBO.Text != "")
            {
                monto = Convert.ToDouble(TXTMONTORECIBO.Text);
            }
            double montoCalculado = Convert.ToDouble(TXTMONTO.Text);
            bool nomas = false;
            foreach (DataGridViewRow r in dgvwSaldo.Rows)
            {

                DataGridViewCheckBoxCell ck = r.Cells["SELECCIONAR"] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(ck.Value))
                {
                    DataRow rw = dtS.NewRow();
                    rw[0] = r.Cells[0].Value;
                    rw[1] = r.Cells[1].Value;
                    rw[2] = r.Cells[2].Value;
                    if (nomas)
                    {
                        MessageBox.Show("Reconsidere el uso de los saldos");
                        return false;
                    }
                    double cantidad = Convert.ToDouble(r.Cells[2].Value.ToString());
                    monto = monto + cantidad;
                    dtS.Rows.Add(rw);
                    if (monto >= montoCalculado)
                    {
                        nomas = true;
                    }
                }
            }
            if (monto < montoCalculado) {
                MessageBox.Show("El monto de los saldos no es suficiente para el pago");
                return false;
            }
            dtSaldos.Clear();
            dtSaldos = dtS.Copy();
            return true;

        }
        private bool validarSaldoSaldo()
        {
            DataTable dtS = new DataTable();
            dtS.Columns.Add("idSaldo");
            dtS.Columns.Add("numRecibo");
            dtS.Columns.Add("monto");
            double monto = 0;
            double montoCalculado = Convert.ToDouble(TXTMONTO.Text);
            bool nomas = false;
            foreach (DataGridViewRow r in dgvwSaldo.Rows)
            {

                DataGridViewCheckBoxCell ck = r.Cells["SELECCIONAR"] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(ck.Value))
                {
                    DataRow rw = dtS.NewRow();
                    rw[0] = r.Cells[0].Value;
                    rw[1] = r.Cells[1].Value;
                    rw[2] = r.Cells[2].Value;
                    if (nomas)
                    {
                        MessageBox.Show("Reconsidere el uso de los saldos");
                        return false;
                    }
                    double cantidad = Convert.ToDouble(r.Cells[2].Value.ToString());
                    monto = monto + cantidad;
                    dtS.Rows.Add(rw);
                    if (monto >= montoCalculado)
                    {
                        nomas = true;
                    }
                }
            }
            if (monto < montoCalculado)
            {
                MessageBox.Show("El monto de los saldos no es suficiente para el pago");
                return false;
            }
            dtSaldos.Clear();
            dtSaldos = dtS.Copy();
            return true;

        }
        public void actualizarMontoSaldo(double monto, string idSaldo)
        {
            SqlCommand cmd = new SqlCommand("actualizar_saldo", _SqlConnection);
            if (cmd.Connection.State == ConnectionState.Closed)
            {
                cmd.Connection.Open();
            }
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@idSaldo", idSaldo));
            cmd.Parameters.Add(new SqlParameter("@monto", monto));
            cmd.ExecuteNonQuery();
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
        }
        public void crearPagoSaldo(double monto, string idSaldo)
        {
            SqlCommand cmd = new SqlCommand("crear_pagosaldo", _SqlConnection);
            if (cmd.Connection.State == ConnectionState.Closed)
            {
                cmd.Connection.Open();
            }
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@numRecibo", TXTNUMERORECIBO.Text.Trim().ToString()));
            cmd.Parameters.Add(new SqlParameter("@idSaldo", idSaldo));
            cmd.Parameters.Add(new SqlParameter("@monto", monto));
            cmd.ExecuteNonQuery();
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
        }
        public void crearPagoSoloSaldo(double monto, string idSaldo)
        {
            SqlCommand cmd = new SqlCommand("crear_pagosaldo_solosaldo", _SqlConnection);
            if (cmd.Connection.State == ConnectionState.Closed)
            {
                cmd.Connection.Open();
            }
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@idSaldo", idSaldo));
            cmd.Parameters.Add(new SqlParameter("@monto", monto));
            cmd.ExecuteNonQuery();
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
        }

        public Boolean verificarRecibo()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("verificar_recibo_pago", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                DataTable dt = new DataTable();
                cmd.Parameters.Add(new SqlParameter("@nro_recibo", TXTNUMERORECIBO.Text));
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Numero de recibo ya existente");
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void BTNGUARDARPAGO_Click(object sender, EventArgs e)
        {
            if (verificarRecibo())
            {
                return;
            }
            if(GBMODALIDADMATRICULA.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked) != null)
            {
                string modalidad = GBMODALIDADMATRICULA.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
                if (modalidad == "EXAMEN DE UBICACION" && (txtNotaUbicacion.Text.Trim() == "" || txtExpedienteUbicacion.Text.Trim() == ""))
                {
                    MessageBox.Show("Complete los datos del examen de ubicación.");
                    return;
                }
            }
            
            if((TXTMONTORECIBO.Text=="" || TXTNUMERORECIBO.Text == "") && chboxSaldo.Checked == false)
            {
                MessageBox.Show("Revise el pago");
            }else if (chboxSaldo.Checked == true && (TXTMONTORECIBO.Text == "" || TXTNUMERORECIBO.Text == ""))
            {
                //MessageBox.Show("guardar aqui per");
                double montoCalculado = Convert.ToDouble(TXTMONTO.Text);
                double saldo = calcularSaldo();
                if (saldo == 0)
                {
                    MessageBox.Show("Si no utilizara el saldo, no marque el casillero."); return;
                }
                if (!validarSaldoSaldo())
                {
                    return;
                }
                LIMPIAR_ERRORES();
                //pago sin saldo(normal)
                if (VALIDAR_MATRICULA() )
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("crear_nuevo_pago", _SqlConnection);
                        if (cmd.Connection.State == ConnectionState.Closed)
                        {
                            cmd.Connection.Open();
                        }
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@numero_recibo", null));
                        cmd.Parameters.Add(new SqlParameter("@fecha", null));
                        cmd.Parameters.Add(new SqlParameter("@codigo_alumno", LBLCODIGOALUMN.Text.ToString()));
                        cmd.Parameters.Add(new SqlParameter("@idtrabajador", idcodigo));
                        cmd.Parameters.Add(new SqlParameter("@montoRecibo", null));
                        cmd.Parameters.Add(new SqlParameter("@montoCalculado", TXTMONTO.Text));
                        cmd.ExecuteNonQuery();
                        if (cmd.Connection.State == ConnectionState.Open)
                        {
                            cmd.Connection.Close();
                        }
                        if (CBPAGARMATRICULA.CheckState == CheckState.Checked)
                        {
                            PAGAR_MATRICULA2();
                        }
                        GUARDAR_OTROS_PAGOS2();

                    }
                        catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                double monto = 0;
                    foreach (DataRow dr in dtSaldos.Rows)
                    {
                        monto += Convert.ToDouble(dr[2]);
                        if (monto <= montoCalculado)
                        {
                            crearPagoSoloSaldo(Convert.ToDouble(dr[2]), dr[0].ToString());
                            actualizarMontoSaldo(Convert.ToDouble(dr[2]), dr[0].ToString());
                        }
                        else
                        {
                            double sobrante = monto - montoCalculado;
                            double justo = Convert.ToDouble(dr[2]) - sobrante;
                            crearPagoSoloSaldo(justo, dr[0].ToString());
                            actualizarMontoSaldo(justo, dr[0].ToString());
                        }
                    }
                    MessageBox.Show("PAGO REALIZADO CON EXITO");
                    LIMPIAR_DATOS();
                    limpiarRadioButtons();
                }
            }
            else
            {
                double montoRecibo = Convert.ToDouble(TXTMONTORECIBO.Text);
                double montoCalculado = Convert.ToDouble(TXTMONTO.Text);
                if (chboxSaldo.Checked == true && montoRecibo >= montoCalculado)
                {
                    MessageBox.Show("No es necesario el uso del saldo, reconsidere el pago.");
                }
                else if (chboxSaldo.Checked == false && montoRecibo < montoCalculado)
                {
                    MessageBox.Show("El monto del recibo no es suficiente para el pago");
                    
                }
                else
                {

                    if (chboxSaldo.Checked == true)
                    {
                        double saldo = calcularSaldo();
                        if (saldo == 0)
                        {
                            MessageBox.Show("Si no utilizara el saldo, no marque el casillero."); return;
                        }
                        if (!validarSaldo())
                        {
                            return;
                        }
                        double monto = montoRecibo;
                        LIMPIAR_ERRORES();
                        if (VALIDAR_MATRICULA() && VALIDAR_PAGO())
                        {
                            try
                            {
                                SqlCommand cmd = new SqlCommand("crear_nuevo_pago", _SqlConnection);
                                if (cmd.Connection.State == ConnectionState.Closed)
                                {
                                    cmd.Connection.Open();
                                }
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add(new SqlParameter("@numero_recibo", TXTNUMERORECIBO.Text.Trim().ToString()));
                                cmd.Parameters.Add(new SqlParameter("@fecha", FECHARECIBO.Value));
                                cmd.Parameters.Add(new SqlParameter("@codigo_alumno", LBLCODIGOALUMN.Text.ToString()));
                                cmd.Parameters.Add(new SqlParameter("@idtrabajador", idcodigo));
                                cmd.Parameters.Add(new SqlParameter("@montoRecibo", TXTMONTORECIBO.Text));
                                cmd.Parameters.Add(new SqlParameter("@montoCalculado", TXTMONTO.Text));
                                cmd.ExecuteNonQuery();
                                if (cmd.Connection.State == ConnectionState.Open)
                                {
                                    cmd.Connection.Close();
                                }
                                if (CBPAGARMATRICULA.CheckState == CheckState.Checked)
                                {
                                    PAGAR_MATRICULA();
                                }
                                GUARDAR_OTROS_PAGOS();

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            foreach (DataRow dr in dtSaldos.Rows)
                            {
                                monto += Convert.ToDouble(dr[2]);
                                if (monto <= montoCalculado)
                                {
                                    crearPagoSaldo(Convert.ToDouble(dr[2]), dr[0].ToString());
                                    actualizarMontoSaldo(Convert.ToDouble(dr[2]), dr[0].ToString());
                                }
                                else
                                {
                                    double sobrante = monto - montoCalculado;
                                    double justo = Convert.ToDouble(dr[2]) - sobrante;
                                    crearPagoSaldo(justo, dr[0].ToString());
                                    actualizarMontoSaldo(justo, dr[0].ToString());
                                }
                            }
                            guardarSaldo();
                            MessageBox.Show("PAGO REALIZADO CON EXITO");
                            LIMPIAR_DATOS();
                            limpiarRadioButtons();
                        }

                    }
                    else
                    {
                        LIMPIAR_ERRORES();
                        if (VALIDAR_MATRICULA() && VALIDAR_PAGO())
                        {
                            try
                            {
                                SqlCommand cmd = new SqlCommand("crear_nuevo_pago", _SqlConnection);
                                if (cmd.Connection.State == ConnectionState.Closed)
                                {
                                    cmd.Connection.Open();
                                }
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.Add(new SqlParameter("@numero_recibo", TXTNUMERORECIBO.Text.Trim().ToString()));
                                cmd.Parameters.Add(new SqlParameter("@fecha", FECHARECIBO.Value));
                                cmd.Parameters.Add(new SqlParameter("@codigo_alumno", LBLCODIGOALUMN.Text.ToString()));
                                cmd.Parameters.Add(new SqlParameter("@idtrabajador", idcodigo));
                                cmd.Parameters.Add(new SqlParameter("@montoRecibo", TXTMONTORECIBO.Text));
                                cmd.Parameters.Add(new SqlParameter("@montoCalculado", TXTMONTO.Text));
                                cmd.ExecuteNonQuery();
                                if (cmd.Connection.State == ConnectionState.Open)
                                {
                                    cmd.Connection.Close();
                                }
                                if (CBPAGARMATRICULA.CheckState == CheckState.Checked)
                                {
                                    PAGAR_MATRICULA();
                                }
                                GUARDAR_OTROS_PAGOS();
                                guardarSaldo();
                                MessageBox.Show("PAGO REALIZADO CON EXITO");
                                LIMPIAR_DATOS();
                                limpiarRadioButtons();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
            }
            
        }
        private void PAGAR_MATRICULA2()
        {
            var rbmod = GBMODALIDADMATRICULA.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            var rbidi = GBIDIOMA.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            var rbniv = GBNIVEL.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            string mod = rbmod.Text.ToString();
            string idio = rbidi.Text.ToString();
            string niv = rbniv.Text.ToString();
            string cic = NUMCICLO.Value.ToString();
            double monto = 20;
            if (rbTupa2018.Checked == true)
            {
                if (LBLTIPOALUMN.Text == "FAUSTINIANO")
                {
                    if (RBBASICO.Checked == true)
                    {
                        monto = 100;
                    }
                    else if (RBINTERMEDIO.Checked == true)
                    {
                        monto = 110;
                    }
                    else if (RBAVANZADO.Checked == true)
                    {
                        monto = 120;
                    }
                }
                else if (LBLTIPOALUMN.Text == "PARTICULAR")
                {
                    if (RBBASICO.Checked == true)
                    {
                        monto = 120;
                    }
                    else if (RBINTERMEDIO.Checked == true)
                    {
                        monto = 130;
                    }
                    else if (RBAVANZADO.Checked == true)
                    {
                        monto = 140;
                    }
                }
                if (chAdministrativo.Checked)
                {
                    mod = mod + "-BENEFICIO";
                    monto = monto * 0.9;
                }
            }

            int idhorario = (int)((DataRowView)cbHorario.SelectedItem)["id"];
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("crear_detalle_matricula2", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@idioma", idio));
                cmd.Parameters.Add(new SqlParameter("@nivel", niv));
                cmd.Parameters.Add(new SqlParameter("@modalidad", mod));
                cmd.Parameters.Add(new SqlParameter("@ciclo", cic));
                cmd.Parameters.Add(new SqlParameter("@fecha", DateTime.Now));
                cmd.Parameters.Add(new SqlParameter("@monto", monto));
                cmd.Parameters.Add(new SqlParameter("@idhorario", idhorario));
                //cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if(mod=="EXAMEN DE UBICACION")
            {
                try
                {
                    string id = dt.Rows[0][0].ToString();
                    SqlCommand cmd = new SqlCommand("insert_nota_examen_ubicacion", _SqlConnection);
                    if (cmd.Connection.State == ConnectionState.Closed)
                    {
                        cmd.Connection.Open();
                    }
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@idPagoMatricula", id));
                    cmd.Parameters.Add(new SqlParameter("@nroExpediente", txtExpedienteUbicacion.Text));
                    cmd.Parameters.Add(new SqlParameter("@nota", txtNotaUbicacion.Text));
                    cmd.ExecuteNonQuery();
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
        }
        private void PAGAR_MATRICULA()
        {
            var rbmod = GBMODALIDADMATRICULA.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            var rbidi = GBIDIOMA.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            var rbniv = GBNIVEL.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            string mod = rbmod.Text.ToString();
            string idio = rbidi.Text.ToString();
            string niv = rbniv.Text.ToString();
            string cic = NUMCICLO.Value.ToString();
            double monto = 20;
            if (rbTupa2018.Checked == true)
            {
                if (LBLTIPOALUMN.Text == "FAUSTINIANO")
                {
                    if (RBBASICO.Checked == true)
                    {
                        monto = 100;
                    }
                    else if (RBINTERMEDIO.Checked == true)
                    {
                        monto = 110;
                    }
                    else if (RBAVANZADO.Checked == true)
                    {
                        monto = 120;
                    }
                }
                else if (LBLTIPOALUMN.Text == "PARTICULAR")
                {
                    if (RBBASICO.Checked == true)
                    {
                        monto = 120;
                    }
                    else if (RBINTERMEDIO.Checked == true)
                    {
                        monto = 130;
                    }
                    else if (RBAVANZADO.Checked == true)
                    {
                        monto = 140;
                    }
                }
                if (chAdministrativo.Checked)
                {
                    mod = mod + "-BENEFICIO";
                    monto = monto * 0.88;
                }
            }

            int idhorario = (int)((DataRowView)cbHorario.SelectedItem)["id"];
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("crear_detalle_matricula", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@idioma", idio));
                cmd.Parameters.Add(new SqlParameter("@nivel", niv));
                cmd.Parameters.Add(new SqlParameter("@modalidad", mod));
                cmd.Parameters.Add(new SqlParameter("@ciclo", cic));
                cmd.Parameters.Add(new SqlParameter("@fecha", DateTime.Now));
                cmd.Parameters.Add(new SqlParameter("@monto", monto));
                cmd.Parameters.Add(new SqlParameter("@numero_recibo", TXTNUMERORECIBO.Text.Trim().ToString()));
                cmd.Parameters.Add(new SqlParameter("@idhorario", idhorario));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (mod == "EXAMEN DE UBICACION")
            {
                try
                {
                    string id = dt.Rows[0][0].ToString();
                    SqlCommand cmd = new SqlCommand("insert_nota_examen_ubicacion", _SqlConnection);
                    if (cmd.Connection.State == ConnectionState.Closed)
                    {
                        cmd.Connection.Open();
                    }
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@idPagoMatricula", id));
                    cmd.Parameters.Add(new SqlParameter("@nroExpediente", txtExpedienteUbicacion.Text));
                    cmd.Parameters.Add(new SqlParameter("@nota", txtNotaUbicacion.Text));
                    cmd.ExecuteNonQuery();
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
        }
        private void GUARDAR_OTROS_PAGOS()
        {
            foreach (DataGridViewRow r in GRIDVIEWTIPOSPAGOS.Rows)
            {
                DataGridViewCheckBoxCell ck = r.Cells["SELECCIONAR"] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(ck.Value))
                {
                    int idpago = Convert.ToInt32(r.Cells[0].Value.ToString());
                    String idDetallePAgo = "";
                    try
                    {
                        SqlCommand cmd = new SqlCommand("crear_detalle_pago", _SqlConnection);
                        if (cmd.Connection.State == ConnectionState.Closed)
                        {
                            cmd.Connection.Open();
                        }
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@idtipo", idpago));
                        cmd.Parameters.Add(new SqlParameter("@numerorecibo", TXTNUMERORECIBO.Text.Trim().ToString()));

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        idDetallePAgo = dt.Rows[0][0].ToString();
                        if (cmd.Connection.State == ConnectionState.Open)
                        {
                            cmd.Connection.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    if (idpago == 29)
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("insert_alumno_ex_ubicacion", _SqlConnection);
                            if (cmd.Connection.State == ConnectionState.Closed)
                            {
                                cmd.Connection.Open();
                            }
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add(new SqlParameter("@idDetallePago", idDetallePAgo));

                            cmd.ExecuteNonQuery();
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
                    
                }
            }
        }
        private void GUARDAR_OTROS_PAGOS2()
        {
            foreach (DataGridViewRow r in GRIDVIEWTIPOSPAGOS.Rows)
            {
                DataGridViewCheckBoxCell ck = r.Cells["SELECCIONAR"] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(ck.Value))
                {
                    int idpago = Convert.ToInt32(r.Cells[0].Value.ToString());
                    String idDetallePAgo = "";
                    try
                    {
                        SqlCommand cmd = new SqlCommand("crear_detalle_pago2", _SqlConnection);
                        if (cmd.Connection.State == ConnectionState.Closed)
                        {
                            cmd.Connection.Open();
                        }
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@idtipo", idpago));

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        idDetallePAgo = dt.Rows[0][0].ToString();
                        if (cmd.Connection.State == ConnectionState.Open)
                        {
                            cmd.Connection.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    if (idpago == 29)
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("insert_alumno_ex_ubicacion", _SqlConnection);
                            if (cmd.Connection.State == ConnectionState.Closed)
                            {
                                cmd.Connection.Open();
                            }
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add(new SqlParameter("@idDetallePago", idDetallePAgo));

                            cmd.ExecuteNonQuery();
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
                }
            }
        }
        private void LIMPIAR_DATOS()
        {
            TXTMONTO.Text = "0";
            TXTNUMERORECIBO.Text = "";
            CBPAGARMATRICULA.CheckState = CheckState.Unchecked;
            dgvwSaldo.DataSource = null;
            dgvwSaldo.Columns.Clear();
            dgvwSaldo.Rows.Clear();
            GRIDVIEWTIPOSPAGOS.DataSource = null;
            GRIDVIEWTIPOSPAGOS.Columns.Clear();
            GRIDVIEWTIPOSPAGOS.Rows.Clear();
            TXTMONTORECIBO.Text = "";
            NUMCICLO.Value = 1;
            cbHorario.ResetText();
            cbHorario.SelectedIndex = -1;
            txtExpedienteUbicacion.Text = "";
            txtNotaUbicacion.Text = "";

        }
        private bool VALIDAR_MATRICULA()
        {
            bool ok = true;
            if (PANELMATRICULA.Enabled == true)
            {
                if (RBMATREGULAR.Checked == false && RBMATUBICACION.Checked == false)
                {
                    ok = false;
                    MISSINGDATA.SetError(GBMODALIDADMATRICULA, "SELECCIONA UNA MODALIDAD");
                }
                if (RBINGLES.Checked == false && RBITALIANO.Checked == false && RBFRANCES.Checked == false && RBPORTUGUES.Checked == false && RBALEMAN.Checked == false && RBQUECHUA.Checked == false && RBCHINO.Checked == false && RBOTRO.Checked == false)
                {
                    ok = false;
                    MISSINGDATA.SetError(GBIDIOMA, "SELECCIONA UN IDIOMA");
                }
                if (RBBASICO.Checked == false && RBINTERMEDIO.Checked == false && RBAVANZADO.Checked == false)
                {
                    ok = false;
                    MISSINGDATA.SetError(GBNIVEL, "SELECCIONA UN NIVEL");
                }
                if (cbHorario.Text=="")
                {
                    ok = false;
                    MISSINGDATA.SetError(cbHorario, "SELECCIONA UN HORARIO");
                }
            }
            return ok;
        }
        private bool VALIDAR_PAGO()
        {
            bool ok = true;
            if (TXTMONTO.Text.ToString() == "0")
            {
                MISSINGDATA.SetError(TXTMONTO, "EL MONTO A GUARDAR NO PUEDE SER CERO");
                ok = false;
            }
            if (TXTNUMERORECIBO.Text.Trim().ToString() == "" && TXTNUMERORECIBO.ReadOnly == false)
            {
                MISSINGDATA.SetError(TXTMONTO, "INGRESA UN NUMERO DE RECIBO");
                ok = false;
            }
            if (TXTNUMERORECIBO.Text.Trim() != "")
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("verificar_recibo", _SqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (cmd.Connection.State == ConnectionState.Closed)
                    {
                        cmd.Connection.Open();
                    }
                    cmd.Parameters.Add(new SqlParameter("@numrecibo", TXTNUMERORECIBO.Text));
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            ok = false;
                            MISSINGDATA.SetError(TXTNUMERORECIBO, "ESTE NUMERO DE RECIBO YA HA SIDO REGISTRADO!!!");
                        }
                    }
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

            return ok;
        }
        private void LIMPIAR_ERRORES()
        {
            MISSINGDATA.SetError(GBMODALIDADMATRICULA, null);
            MISSINGDATA.SetError(GBIDIOMA, null);
            MISSINGDATA.SetError(GBNIVEL, null);
            MISSINGDATA.SetError(cbHorario, null);
        }
        private void LISTBOXRAZONES_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //CARGA EL GRID VIEW EN LA CONSULTA DE NOMBRES CON LISTENER POR TECLEADO
        private void TXTNOMBRESBUSCA_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                _SqlConnection.Open();
                SqlCommand cmd = new SqlCommand("buscarAlumnoApellido", _SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@txt", TXTINGNOMBRE.Text.Trim()));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                GRIDVIEWCONSALUPAGO.DataSource = dt;
                GRIDVIEWCONSALUPAGO.Columns[0].Width = 300;
                GRIDVIEWCONSALUPAGO.Columns[2].Width = 80;
                GRIDVIEWCONSALUPAGO.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                GRIDVIEWCONSALUPAGO.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                GRIDVIEWCONSALUPAGO.Columns[1].Width = 80;
                GRIDVIEWCONSALUPAGO.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                GRIDVIEWCONSALUPAGO.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                GRIDVIEWCONSALUPAGO.Columns[3].Width = 100;
                GRIDVIEWCONSALUPAGO.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                GRIDVIEWCONSALUPAGO.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //GRIDVIEWCONSALUPAGO.Columns[4].Width = 200;
                this.GRIDVIEWCONSALUPAGO.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

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
        //CARGA EL GRID VIEW EN LA CONSULTA POR DNI
        private void btnBuscarPorDni_Click(object sender, EventArgs e)
        {
            try
            {
                _SqlConnection.Open();
                SqlCommand cmd = new SqlCommand("buscarPorDNI", _SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@dni", dni));

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GRIDVIEWCONSALUPAGO.DataSource = dt;
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
        public void buscarSaldo()
        {
            DataTable dt = new DataTable();
            SqlCommand comando = new SqlCommand("mostrar_Saldo_alumno", _SqlConnection);
            comando.CommandType = CommandType.StoredProcedure;
            if (comando.Connection.State == ConnectionState.Closed)
            {
                comando.Connection.Open();
            }
            comando.Parameters.Add(new SqlParameter("@numcarnet", LBLCODIGOALUMN.Text));
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                dgvwSaldo.DataSource = dt;
                dgvwSaldo.Columns[0].Visible = false;
                dgvwSaldo.Columns[1].HeaderText = "N° recibo";
                dgvwSaldo.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvwSaldo.Columns[2].Width = 80;
                dgvwSaldo.Columns[1].ReadOnly = true;
                dgvwSaldo.Columns[2].HeaderText = "Monto";
                dgvwSaldo.Columns[2].Width = 70;
                dgvwSaldo.Columns[2].ReadOnly = true;
                dgvwSaldo.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DataGridViewCheckBoxColumn checkerColumn = new DataGridViewCheckBoxColumn();
                checkerColumn.HeaderCell.Value = "Seleccionar";
                checkerColumn.Name = "Seleccionar";
                checkerColumn.ReadOnly = false;
                dgvwSaldo.Columns.Add(checkerColumn);
                dgvwSaldo.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvwSaldo.Columns[3].Width = 87;
                dgvwSaldo.RowHeadersVisible = false;
            }

        }
        public void listarPagos(string idalumno)
        {
            int cod = Convert.ToInt32(idalumno);
            DataTable dt = new DataTable();
            try
            {

                SqlCommand comando = new SqlCommand("mostrar_relacion", _SqlConnection);
                comando.CommandType = CommandType.StoredProcedure;
                if (comando.Connection.State == ConnectionState.Closed)
                {
                    comando.Connection.Open();
                }
                comando.Parameters.Add(new SqlParameter("@cod", cod));
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                dgvwPagos.DataSource = dt;
                dgvwPagos.Columns[0].Visible = false;
                dgvwPagos.Columns[1].Width = 210;
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

        //LISTENER PARA LA CONSULTA DE PERSONAS EN EL GRIDVIEW
        private void GridViewNombres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LIMPIAR_DATOS();
            limpiarRadioButtons();
            chboxCambiarTipoAlumno.Checked = false;

            dgvwSaldo.DataSource = null;
            dgvwSaldo.Columns.Clear();
            dgvwSaldo.Rows.Clear();
            chboxSaldo.Checked = false;
            chboxCambiarTipoAlumno.Enabled = true;
            btnAgregarSaldo.Enabled = true;
            if (e.RowIndex >= 0 && e.RowIndex < GRIDVIEWCONSALUPAGO.RowCount - 1)
            {
                DataGridViewRow row = this.GRIDVIEWCONSALUPAGO.Rows[e.RowIndex];
                dni = row.Cells["DNI"].Value.ToString();
                CBPAGARMATRICULA.Enabled = true;
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
                    LBLTIPOALUMN.Text = dt.Rows[0][6].ToString();
                    LBLCODIGOALUMN.Text = dt.Rows[0][7].ToString();
                    idalumno = dt.Rows[0][8].ToString();
                    buscarSaldo();
                    if (comando.Connection.State == ConnectionState.Open)
                    {
                        comando.Connection.Close();
                    }
                    LBLTIPOALUMN_TextChanged(null,null);
                    listarPagos(dt.Rows[0][8].ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //IDENTIFICA EL TIPO DE ALUMNO DEL LABEL LBLTIPOALUMN Y CARGA EL GRIDVIEW CON LOS MONTOS Y PAGOS CORRESPONDIENTES
        private void LBLTIPOALUMN_TextChanged(object sender, EventArgs e)
        {
            GRIDVIEWTIPOSPAGOS.DataSource = null;
            GRIDVIEWTIPOSPAGOS.Columns.Clear();
            GRIDVIEWTIPOSPAGOS.Rows.Clear();
            

            if (LBLTIPOALUMN.Text == "FAUSTINIANO")
            {
                try
                {
                    DataGridViewCheckBoxColumn dgvcbc = new DataGridViewCheckBoxColumn();
                    dgvcbc.HeaderCell.Value = "SELECCIONAR";
                    dgvcbc.Name = "SELECCIONAR";
                    dgvcbc.ReadOnly = false;
                    SqlCommand cmd = new SqlCommand("cargar_tipos_pagos_faustinianos", _SqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (cmd.Connection.State == ConnectionState.Closed)
                    {
                        cmd.Connection.Open();
                    }
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    GRIDVIEWTIPOSPAGOS.DataSource = dt;
                    if (cmd.Connection.State == ConnectionState.Open)
                    {
                        cmd.Connection.Close();
                    }
                    GRIDVIEWTIPOSPAGOS.Columns["ID"].ReadOnly = true;
                    GRIDVIEWTIPOSPAGOS.Columns["ID"].Width = 40;
                    GRIDVIEWTIPOSPAGOS.Columns["RAZON"].ReadOnly = true;
                    GRIDVIEWTIPOSPAGOS.Columns["RAZON"].Width = 300;
                    GRIDVIEWTIPOSPAGOS.Columns["MONTO"].ReadOnly = true;
                    GRIDVIEWTIPOSPAGOS.Columns["MONTO"].Width = 50;
                    GRIDVIEWTIPOSPAGOS.Columns.Add(dgvcbc);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (LBLTIPOALUMN.Text == "PARTICULAR")
            {
                try
                {
                    DataGridViewCheckBoxColumn dgvcbc = new DataGridViewCheckBoxColumn();
                    dgvcbc.HeaderCell.Value = "SELECCIONAR";
                    dgvcbc.Name = "SELECCIONAR";
                    dgvcbc.ReadOnly = false;
                    SqlCommand cmd = new SqlCommand("cargar_tipos_pagos_particulares", _SqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (cmd.Connection.State == ConnectionState.Closed)
                    {
                        cmd.Connection.Open();
                    }
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    GRIDVIEWTIPOSPAGOS.DataSource = dt;
                    if (cmd.Connection.State == ConnectionState.Open)
                    {
                        cmd.Connection.Close();
                    }
                    GRIDVIEWTIPOSPAGOS.Columns["ID"].ReadOnly = true;
                    GRIDVIEWTIPOSPAGOS.Columns["ID"].Width = 40;
                    GRIDVIEWTIPOSPAGOS.Columns["RAZON"].ReadOnly = true;
                    GRIDVIEWTIPOSPAGOS.Columns["RAZON"].Width = 300;
                    GRIDVIEWTIPOSPAGOS.Columns["MONTO"].ReadOnly = true;
                    GRIDVIEWTIPOSPAGOS.Columns["MONTO"].Width = 50;
                    GRIDVIEWTIPOSPAGOS.Columns.Add(dgvcbc);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //CONTROLA EL CAMBIO DEL CHECBOX DENTRO DEL GRIDVIEW
        private void dgvStandingOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //CONCLUSION DE LA EDICION DEL DATAGRIDVIEW
        private void dgvStandingOrder_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            GRIDVIEWTIPOSPAGOS.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        //VERIFICA QUE LA CELDA SELECCIONADA SEA DE TIPO CHECKBOX
        private void dgvStandingOrder_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (GRIDVIEWTIPOSPAGOS.CurrentCell is DataGridViewCheckBoxCell)
            {
                GRIDVIEWTIPOSPAGOS.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        //EVENTOS DEL CHECBOX PARA PAGAR LA MTRICULA
        private void CBPAGARMATRICULA_CheckedChanged(object sender, EventArgs e)
        {
            if (CBPAGARMATRICULA.CheckState == CheckState.Checked)
            {
                gbMat.Enabled = true;
            }
            else
            {
                LIMPIAR_ERRORES();
                gbMat.Enabled = false;
                rbMatriculaNormal.Checked = false;
                rbTupa2018.Checked= false;
            }
        }
        private void TXTMONTO_TextChanged(object sender, EventArgs e)
        {
            if (TXTMONTO.Text.ToString() != "0")
            {
                TXTNUMERORECIBO.Enabled = true;
                FECHARECIBO.Enabled = true;
                TXTMONTORECIBO.Enabled = true;
                if (dgvwSaldo.RowCount == 0)
                    chboxSaldo.Enabled = false;
                else
                    chboxSaldo.Enabled = true;
            }
            if (TXTMONTO.Text.ToString() == "0")
            {
                TXTNUMERORECIBO.Enabled = false;
                FECHARECIBO.Enabled = false;
                chboxSaldo.Enabled = false;
                TXTMONTORECIBO.Enabled = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void btnEditarMonto_Click(object sender, EventArgs e)
        {
            TXTMONTO.Enabled = true;
            TXTMONTO.ReadOnly = false;
        }
        //KEYLISTENER QUE VERIFICA EL INGRESO DE NUMEROS
        public void SoloNumeros(object sender, KeyPressEventArgs e)
        {

        }

        private void RBMATUBICACION_CheckedChanged(object sender, EventArgs e)
        {
            if (RBMATUBICACION.Checked)
            {
                txtExpedienteUbicacion.Enabled = true;
                txtNotaUbicacion.Enabled = true;
            }
        }

        private void RBMATREGULAR_CheckedChanged(object sender, EventArgs e)
        {
            if (RBMATREGULAR.Checked)
            {
                txtExpedienteUbicacion.Enabled = false;
                txtNotaUbicacion.Enabled = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        private void CALCULAR_MONTO_A_PAGAR()
        {
            double monto = 0;
            foreach (DataGridViewRow r in GRIDVIEWTIPOSPAGOS.Rows)
            {
                DataGridViewCheckBoxCell ck = r.Cells["SELECCIONAR"] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(ck.Value))
                {
                    double cantidad = Convert.ToDouble(r.Cells[2].Value.ToString());
                    monto = monto + cantidad;
                }
            }
            if (rbMatriculaNormal.Checked == true)
            {
                monto = monto + 20;
            }
            
            if (rbTupa2018.Checked == true)
            {
                if (LBLTIPOALUMN.Text == "FAUSTINIANO")
                {
                    if (RBBASICO.Checked == true)
                    {
                        monto = monto + 100;
                        refe = 100;
                    }
                    else if (RBINTERMEDIO.Checked == true)
                    {
                        monto = monto + 110;
                        refe = 110;
                    }
                    else if (RBAVANZADO.Checked == true)
                    {
                        monto = monto + 120;
                        refe = 120;
                    }
                }
                else if (LBLTIPOALUMN.Text == "PARTICULAR")
                {
                    if (RBBASICO.Checked == true)
                    {
                        monto = monto + 120;
                        refe = 120;
                    }
                    else if (RBINTERMEDIO.Checked == true)
                    {
                        monto = monto + 130;
                        refe = 130;
                    }
                    else if (RBAVANZADO.Checked == true)
                    {
                        monto = monto + 140;
                        refe = 140;
                    }
                }
                if (chAdministrativo.Checked)
                {
                    double descuento = refe * 0.10;
                    monto = monto - descuento;
                }
            }
            TXTMONTO.Text = "" + monto;
        }

        private void chboxSaldo_CheckedChanged(object sender, EventArgs e)
        {
            if (chboxSaldo.Checked == true)
            {
                dgvwSaldo.Enabled = true;
            }
            else
            {
                dgvwSaldo.Enabled = false;
            }
        }

        private void GRIDVIEWTIPOSPAGOS_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            GRIDVIEWTIPOSPAGOS.CommitEdit(DataGridViewDataErrorContexts.Commit);
            CALCULAR_MONTO_A_PAGAR();
        }

        private void frmCrearPago_Load(object sender, EventArgs e)
        {
            this.ActiveControl = TXTINGNOMBRE;
        }

        private void btnAgregarSaldo_Click(object sender, EventArgs e)
        {
            string codigotrabajador = idcodigo;
            string codigoalumno = LBLCODIGOALUMN.Text.ToString();
            new frmAgregarSaldo(codigotrabajador, codigoalumno).Show();
        }
        

        private void chboxCambiarTipoAlumno_CheckedChanged(object sender, EventArgs e)
        {
            if (chboxCambiarTipoAlumno.Checked)
            {
                MessageBox.Show("Solo utilice esta opción cuando sea necesaria");
                if (LBLTIPOALUMN.Text == "FAUSTINIANO")
                    LBLTIPOALUMN.Text = "PARTICULAR";
                else if (LBLTIPOALUMN.Text == "PARTICULAR")
                    LBLTIPOALUMN.Text = "FAUSTINIANO";
            }
            else if (!chboxCambiarTipoAlumno.Checked)
            {
                if (LBLTIPOALUMN.Text == "FAUSTINIANO")
                    LBLTIPOALUMN.Text = "PARTICULAR";
                else if (LBLTIPOALUMN.Text == "PARTICULAR")
                    LBLTIPOALUMN.Text = "FAUSTINIANO";
            }
            CALCULAR_MONTO_A_PAGAR();
        }

        private void GBIDIOMA_Enter(object sender, EventArgs e)
        {

        }

        private void rbMatriculaNormal_CheckedChanged(object sender, EventArgs e)
        {
            CALCULAR_MONTO_A_PAGAR();
            if (rbMatriculaNormal.Checked == true)
            {
                PANELMATRICULA.Enabled = true;
                resetRb();
            }
            else
            {
                LIMPIAR_ERRORES();
                resetRb();
                PANELMATRICULA.Enabled = false;
            }
            RBMATREGULAR.Text = "MATRICULA REGULAR (2016-2017)";
        }

        private void rbTupa2018_CheckedChanged(object sender, EventArgs e)
        {
            CALCULAR_MONTO_A_PAGAR();
            if (rbTupa2018.Checked == true)
            {
                PANELMATRICULA.Enabled = true;
                resetRb();
            }
            else
            {
                LIMPIAR_ERRORES();
                resetRb();
                PANELMATRICULA.Enabled = false;
            }
            RBMATREGULAR.Text = "MATRICULA REGULAR";
        }
        private void resetRb()
        {
            RBMATREGULAR.Checked = false;
            RBMATUBICACION.Checked = false;
            RBINGLES.Checked = false;
            RBFRANCES.Checked = false;
            RBALEMAN.Checked = false;
            RBPORTUGUES.Checked = false;
            RBOTRO.Checked = false;
            RBCHINO.Checked = false;
            RBQUECHUA.Checked = false;
            RBITALIANO.Checked = false;
            RBBASICO.Checked = false;
            RBINTERMEDIO.Checked = false;
            RBAVANZADO.Checked = false;
        }
        private void limpiarRadioButtons()
        {
            rbTupa2018.Checked = false;
            rbMatriculaNormal.Checked = false;
            RBMATREGULAR.Checked = false;
            RBMATUBICACION.Checked = false;
            RBINGLES.Checked = false;
            RBFRANCES.Checked = false;
            RBALEMAN.Checked = false;
            RBPORTUGUES.Checked = false;
            RBOTRO.Checked = false;
            RBCHINO.Checked = false;
            RBQUECHUA.Checked = false;
            RBITALIANO.Checked = false;
            RBBASICO.Checked = false;
            RBINTERMEDIO.Checked = false;
            RBAVANZADO.Checked = false;
            chAdministrativo.Enabled = false;
        }

        private void RBBASICO_CheckedChanged(object sender, EventArgs e)
        {
            CALCULAR_MONTO_A_PAGAR();
            chAdministrativo.Enabled = true;
        }

        private void RBINTERMEDIO_CheckedChanged(object sender, EventArgs e)
        {
            CALCULAR_MONTO_A_PAGAR();
            chAdministrativo.Enabled = true;
        }

        private void RBAVANZADO_CheckedChanged(object sender, EventArgs e)
        {
            CALCULAR_MONTO_A_PAGAR();
            chAdministrativo.Enabled = true;
        }
        public void listarHorarios()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("listar_horarios_referencia", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                cbHorario.DisplayMember = "descripcion";
                cbHorario.DataSource = dt;
                cbHorario.ValueMember = "id";
                cbHorario.SelectedIndex = cbHorario.FindStringExact("Ninguno");
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

        private void btnNuevoHorario_Click(object sender, EventArgs e)
        {
            new frmAgregarHorarioReferencia(this).Show();
        }

        private void chAdministrativo_CheckedChanged(object sender, EventArgs e)
        {
            CALCULAR_MONTO_A_PAGAR();
        }
        private DataTable CARGARLISTADEPAGOS(String codalu)
        {
            int cod = Convert.ToInt32(codalu);
            DataTable dt = new DataTable();
            try
            {

                SqlCommand comando = new SqlCommand("mostrar_relacion", _SqlConnection);
                comando.CommandType = CommandType.StoredProcedure;
                if (comando.Connection.State == ConnectionState.Closed)
                {
                    comando.Connection.Open();
                }
                comando.Parameters.Add(new SqlParameter("@cod", cod));
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                dgvwPagos.DataSource = dt;
                dgvwPagos.Columns[0].Visible = false;
                dgvwPagos.Columns[1].Width = 210;
                if (comando.Connection.State == ConnectionState.Open)
                {
                    comando.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        public void buscarRecibosLeyenda(string idPago, string simbolo)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand comando = new SqlCommand("obtener_recibos_pago_saldo", _SqlConnection);
                comando.CommandType = CommandType.StoredProcedure;
                if (comando.Connection.State == ConnectionState.Closed)
                {
                    comando.Connection.Open();
                }
                comando.Parameters.Add(new SqlParameter("@idPago", idPago));
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                if (comando.Connection.State == ConnectionState.Open)
                {
                    comando.Connection.Close();
                }
                //agregar filas a dtLegend
                dt.Columns.Add("simbolo");
                foreach (DataRow row in dt.Rows)
                {
                    row["simbolo"] = simbolo;
                    dtLegend.ImportRow(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFichaMatricula_Click(object sender, EventArgs e)
        {
            //------------------------------

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+ "buscar_foto_alumno");
            }
            if(1==1)
            {
                DataTable dt = new DataTable();
                SqlCommand comando = new SqlCommand("mostrar_detalle_matricula_por_id", _SqlConnection);
                comando.CommandType = CommandType.StoredProcedure;
                if (comando.Connection.State == ConnectionState.Closed)
                {
                    comando.Connection.Open();
                }
                comando.Parameters.Add(new SqlParameter("@id", idPago));
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
            try
            {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //horarioRef = dataGridView2.Rows[0].Cells[4].Value.ToString();
            using (frmRptFichaMatricula frm = new frmRptFichaMatricula(ape, nom, dni, sex, naci, eda, grad, tlf, cel, email, dire, dist, prov, dep, idioma, nivel, ciclo, fechamat, personaencargo, recibo, monto, modalidad, studentpic, observaciones, codigoAlumno, horarioRef))
            {
                frm.ShowDialog();
            }
        }

        private void dgvwPagos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvwPagos.RowCount)
            {
                DataGridViewRow row = this.dgvwPagos.Rows[e.RowIndex];
                idPago = row.Cells[0].Value.ToString();
                horarioRef = row.Cells[6].Value.ToString();
                if (horarioRef == "") btnFichaMatricula.Enabled = false;
                else btnFichaMatricula.Enabled = true;
            }
        }

        public DataTable buscarSaldoReporte()
        {
            DataTable dt = new DataTable();
            SqlCommand comando = new SqlCommand("mostrar_Saldo_alumno", _SqlConnection);
            comando.CommandType = CommandType.StoredProcedure;
            if (comando.Connection.State == ConnectionState.Closed)
            {
                comando.Connection.Open();
            }
            comando.Parameters.Add(new SqlParameter("@numcarnet", LBLCODIGOALUMN.Text));
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);

            if (comando.Connection.State == ConnectionState.Open)
            {
                comando.Connection.Close();
            }
            return dt;
        }

        private void btnRecorEconomico_Click(object sender, EventArgs e)
        {
            
            DataTable dtalumno = new DataTable();
            try
            {
                SqlCommand comando = new SqlCommand("small_buscar_pordni", _SqlConnection);
                comando.CommandType = CommandType.StoredProcedure;
                if (comando.Connection.State == ConnectionState.Closed)
                {
                    comando.Connection.Open();
                }
                comando.Parameters.Add(new SqlParameter("@dni", dni));
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dtalumno);
                idalumno = dtalumno.Rows[0][8].ToString();
                if (comando.Connection.State == ConnectionState.Open)
                {
                    comando.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DataTable tabledata = CARGARLISTADEPAGOS(idalumno);
            dtLegend.Clear();
            //List<string> ListaSaldos = new List<string>();
            string simbolo = "*";
            tabledata.Columns.Add("simbolo");
            tabledata.Columns.Add("fecha");
            foreach (DataRow item in tabledata.Rows)
            {

                if (item["fech"].ToString() == "")
                {
                    buscarRecibosLeyenda(item[0].ToString(), simbolo);
                    item["simbolo"] = simbolo;
                    simbolo = simbolo + "*";
                }
                else
                {
                    string fecha = Convert.ToDateTime(item["fech"]).ToString("dd/MM/yyyy");
                    item["fecha"] = fecha;
                }
            }
            DataTable dtSaldo = buscarSaldoReporte();
            dtSaldo.Columns["numero_recibo"].ColumnName = "nro_recibo";
            using (frmRptListaDePagos frm = new frmRptListaDePagos(tabledata, dtalumno, usuario, dtLegend, dtSaldo))
            {
                frm.ShowDialog();
            }
        }
    }
}