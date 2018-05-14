namespace InstitutoDeIdiomas
{
    partial class frmVerGrupoAgregarAlumno
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerGrupoAgregarAlumno));
            this.dataGridViewGrupo = new System.Windows.Forms.DataGridView();
            this.btnAgregarAlumno = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnVerNotas = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrupo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGrupo
            // 
            this.dataGridViewGrupo.AllowUserToAddRows = false;
            this.dataGridViewGrupo.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGrupo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGrupo.Location = new System.Drawing.Point(11, 105);
            this.dataGridViewGrupo.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewGrupo.Name = "dataGridViewGrupo";
            this.dataGridViewGrupo.ReadOnly = true;
            this.dataGridViewGrupo.RowHeadersVisible = false;
            this.dataGridViewGrupo.RowTemplate.Height = 24;
            this.dataGridViewGrupo.Size = new System.Drawing.Size(829, 393);
            this.dataGridViewGrupo.TabIndex = 5;
            this.dataGridViewGrupo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGrupo_CellClick);
            this.dataGridViewGrupo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGrupo_CellDoubleClick);
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.Depth = 0;
            this.btnAgregarAlumno.Enabled = false;
            this.btnAgregarAlumno.Location = new System.Drawing.Point(366, 509);
            this.btnAgregarAlumno.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Primary = true;
            this.btnAgregarAlumno.Size = new System.Drawing.Size(153, 32);
            this.btnAgregarAlumno.TabIndex = 9;
            this.btnAgregarAlumno.Text = "AGREGAR ALUMNOS";
            this.btnAgregarAlumno.UseVisualStyleBackColor = true;
            this.btnAgregarAlumno.Visible = false;
            this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click);
            // 
            // btnVerNotas
            // 
            this.btnVerNotas.Depth = 0;
            this.btnVerNotas.Enabled = false;
            this.btnVerNotas.Location = new System.Drawing.Point(366, 509);
            this.btnVerNotas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVerNotas.Name = "btnVerNotas";
            this.btnVerNotas.Primary = true;
            this.btnVerNotas.Size = new System.Drawing.Size(153, 32);
            this.btnVerNotas.TabIndex = 10;
            this.btnVerNotas.Text = "VER GRUPO";
            this.btnVerNotas.UseVisualStyleBackColor = true;
            this.btnVerNotas.Visible = false;
            this.btnVerNotas.Click += new System.EventHandler(this.btnVerNotas_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(186, 77);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(231, 20);
            this.txtBuscar.TabIndex = 11;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ingrese número de grupo";
            // 
            // frmVerGrupoAgregarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dataGridViewGrupo);
            this.Controls.Add(this.btnVerNotas);
            this.Controls.Add(this.btnAgregarAlumno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmVerGrupoAgregarAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SELECCIONAR GRUPO";
            this.Load += new System.EventHandler(this.frmVerGrupoAgregarAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrupo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewGrupo;
        private MaterialSkin.Controls.MaterialRaisedButton btnAgregarAlumno;
        private MaterialSkin.Controls.MaterialRaisedButton btnVerNotas;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
    }
}