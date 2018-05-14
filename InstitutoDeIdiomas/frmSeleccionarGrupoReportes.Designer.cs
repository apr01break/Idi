namespace InstitutoDeIdiomas
{
    partial class frmSeleccionarGrupoReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvwListaGrupos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGenerarReporte = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwListaGrupos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvwListaGrupos
            // 
            this.dgvwListaGrupos.AllowUserToAddRows = false;
            this.dgvwListaGrupos.AllowUserToDeleteRows = false;
            this.dgvwListaGrupos.AllowUserToResizeColumns = false;
            this.dgvwListaGrupos.AllowUserToResizeRows = false;
            this.dgvwListaGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwListaGrupos.Location = new System.Drawing.Point(11, 48);
            this.dgvwListaGrupos.Name = "dgvwListaGrupos";
            this.dgvwListaGrupos.ReadOnly = true;
            this.dgvwListaGrupos.RowHeadersVisible = false;
            this.dgvwListaGrupos.Size = new System.Drawing.Size(605, 200);
            this.dgvwListaGrupos.TabIndex = 1;
            this.dgvwListaGrupos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwListaGrupos_CellClick);
            this.dgvwListaGrupos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwListaGrupos_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese numero de grupo";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnGenerarReporte);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvwListaGrupos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 307);
            this.panel1.TabIndex = 3;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Depth = 0;
            this.btnGenerarReporte.Enabled = false;
            this.btnGenerarReporte.Location = new System.Drawing.Point(356, 259);
            this.btnGenerarReporte.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Primary = true;
            this.btnGenerarReporte.Size = new System.Drawing.Size(260, 35);
            this.btnGenerarReporte.TabIndex = 4;
            this.btnGenerarReporte.Text = "GENERAR REPORTE DE ASISTENCIAS";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(175, 17);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(261, 20);
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // frmSeleccionarGrupoReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 371);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmSeleccionarGrupoReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SELECCIONAR GRUPO";
            this.Load += new System.EventHandler(this.frmAsistenciasPorGrupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvwListaGrupos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvwListaGrupos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBuscar;
        private MaterialSkin.Controls.MaterialRaisedButton btnGenerarReporte;
    }
}