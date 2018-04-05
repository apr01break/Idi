namespace InstitutoDeIdiomas
{
    partial class frmAgregarAlumnoExtemporaneo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvwNotas = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvwAlumnos = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvwNotas);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvwAlumnos);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 342);
            this.panel1.TabIndex = 77;
            // 
            // dgvwNotas
            // 
            this.dgvwNotas.AllowUserToAddRows = false;
            this.dgvwNotas.AllowUserToDeleteRows = false;
            this.dgvwNotas.AllowUserToResizeRows = false;
            this.dgvwNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwNotas.Location = new System.Drawing.Point(523, 11);
            this.dgvwNotas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvwNotas.Name = "dgvwNotas";
            this.dgvwNotas.RowHeadersVisible = false;
            this.dgvwNotas.RowTemplate.Height = 24;
            this.dgvwNotas.Size = new System.Drawing.Size(410, 318);
            this.dgvwNotas.TabIndex = 78;
            this.dgvwNotas.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvwNotas_EditingControlShowing);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(107, 292);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = true;
            this.btnGuardar.Size = new System.Drawing.Size(134, 39);
            this.btnGuardar.TabIndex = 77;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 76;
            this.label1.Text = "Ingrese el nombre de alumno";
            // 
            // dgvwAlumnos
            // 
            this.dgvwAlumnos.AllowUserToAddRows = false;
            this.dgvwAlumnos.AllowUserToDeleteRows = false;
            this.dgvwAlumnos.AllowUserToResizeRows = false;
            this.dgvwAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwAlumnos.Location = new System.Drawing.Point(10, 60);
            this.dgvwAlumnos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvwAlumnos.Name = "dgvwAlumnos";
            this.dgvwAlumnos.ReadOnly = true;
            this.dgvwAlumnos.RowHeadersVisible = false;
            this.dgvwAlumnos.RowTemplate.Height = 24;
            this.dgvwAlumnos.Size = new System.Drawing.Size(326, 223);
            this.dgvwAlumnos.TabIndex = 74;
            this.dgvwAlumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwAlumnos_CellClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(11, 35);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(213, 20);
            this.txtBuscar.TabIndex = 75;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // frmAgregarAlumnoExtemporaneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 406);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmAgregarAlumnoExtemporaneo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGREGAR ALUMNOS EXTEMPORANEOS";
            this.Load += new System.EventHandler(this.frmAgregarAlumnoExtemporaneo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvwAlumnos;
        private System.Windows.Forms.TextBox txtBuscar;
        private MaterialSkin.Controls.MaterialRaisedButton btnGuardar;
        private System.Windows.Forms.DataGridView dgvwNotas;
    }
}