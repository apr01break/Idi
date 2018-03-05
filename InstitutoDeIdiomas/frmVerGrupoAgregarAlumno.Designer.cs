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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerGrupoAgregarAlumno));
            this.dataGridViewGrupo = new System.Windows.Forms.DataGridView();
            this.btnAgregarAlumno = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnVerNotas = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrupo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGrupo
            // 
            this.dataGridViewGrupo.AllowUserToAddRows = false;
            this.dataGridViewGrupo.AllowUserToResizeRows = false;
            this.dataGridViewGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGrupo.Location = new System.Drawing.Point(11, 77);
            this.dataGridViewGrupo.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewGrupo.Name = "dataGridViewGrupo";
            this.dataGridViewGrupo.ReadOnly = true;
            this.dataGridViewGrupo.RowHeadersVisible = false;
            this.dataGridViewGrupo.RowTemplate.Height = 24;
            this.dataGridViewGrupo.Size = new System.Drawing.Size(803, 421);
            this.dataGridViewGrupo.TabIndex = 5;
            this.dataGridViewGrupo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGrupo_CellClick);
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
            // frmVerGrupoAgregarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 553);
            this.Controls.Add(this.dataGridViewGrupo);
            this.Controls.Add(this.btnVerNotas);
            this.Controls.Add(this.btnAgregarAlumno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmVerGrupoAgregarAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SELECCIONAR GRUPO";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrupo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewGrupo;
        private MaterialSkin.Controls.MaterialRaisedButton btnAgregarAlumno;
        private MaterialSkin.Controls.MaterialRaisedButton btnVerNotas;
    }
}