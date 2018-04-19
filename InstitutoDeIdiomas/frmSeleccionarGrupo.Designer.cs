namespace InstitutoDeIdiomas
{
    partial class frmSeleccionarGrupo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeleccionarGrupo));
            this.label3 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvwGrupo = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegistrarAsistencias = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnRegistroAuxiliar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnRegistrarNotas = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnVerAsistenciasNotas = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwGrupo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // lblNombre
            // 
            resources.ApplyResources(this.lblNombre, "lblNombre");
            this.lblNombre.Name = "lblNombre";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // dgvwGrupo
            // 
            this.dgvwGrupo.AllowUserToAddRows = false;
            this.dgvwGrupo.AllowUserToResizeRows = false;
            this.dgvwGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvwGrupo, "dgvwGrupo");
            this.dgvwGrupo.Name = "dgvwGrupo";
            this.dgvwGrupo.ReadOnly = true;
            this.dgvwGrupo.RowHeadersVisible = false;
            this.dgvwGrupo.RowTemplate.Height = 24;
            this.dgvwGrupo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwGrupo_CellClick);
            this.dgvwGrupo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwGrupo_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnVerAsistenciasNotas);
            this.panel1.Controls.Add(this.btnRegistrarAsistencias);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dgvwGrupo);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnRegistroAuxiliar);
            this.panel1.Controls.Add(this.btnRegistrarNotas);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btnRegistrarAsistencias
            // 
            this.btnRegistrarAsistencias.Depth = 0;
            resources.ApplyResources(this.btnRegistrarAsistencias, "btnRegistrarAsistencias");
            this.btnRegistrarAsistencias.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrarAsistencias.Name = "btnRegistrarAsistencias";
            this.btnRegistrarAsistencias.Primary = true;
            this.btnRegistrarAsistencias.UseVisualStyleBackColor = true;
            this.btnRegistrarAsistencias.Click += new System.EventHandler(this.btnRegistrarAsistencias_Click);
            // 
            // btnRegistroAuxiliar
            // 
            this.btnRegistroAuxiliar.Depth = 0;
            resources.ApplyResources(this.btnRegistroAuxiliar, "btnRegistroAuxiliar");
            this.btnRegistroAuxiliar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistroAuxiliar.Name = "btnRegistroAuxiliar";
            this.btnRegistroAuxiliar.Primary = true;
            this.btnRegistroAuxiliar.UseVisualStyleBackColor = true;
            this.btnRegistroAuxiliar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRegistrarNotas
            // 
            this.btnRegistrarNotas.Depth = 0;
            resources.ApplyResources(this.btnRegistrarNotas, "btnRegistrarNotas");
            this.btnRegistrarNotas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrarNotas.Name = "btnRegistrarNotas";
            this.btnRegistrarNotas.Primary = true;
            this.btnRegistrarNotas.UseVisualStyleBackColor = true;
            this.btnRegistrarNotas.Click += new System.EventHandler(this.btnRegistrarNotas_Click);
            // 
            // btnVerAsistenciasNotas
            // 
            this.btnVerAsistenciasNotas.Depth = 0;
            resources.ApplyResources(this.btnVerAsistenciasNotas, "btnVerAsistenciasNotas");
            this.btnVerAsistenciasNotas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVerAsistenciasNotas.Name = "btnVerAsistenciasNotas";
            this.btnVerAsistenciasNotas.Primary = true;
            this.btnVerAsistenciasNotas.UseVisualStyleBackColor = true;
            this.btnVerAsistenciasNotas.Click += new System.EventHandler(this.btnVerAsistenciasNotas_Click);
            // 
            // frmSeleccionarGrupo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmSeleccionarGrupo";
            this.Load += new System.EventHandler(this.frmSeleccionarGrupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvwGrupo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dgvwGrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnRegistroAuxiliar;
        private MaterialSkin.Controls.MaterialRaisedButton btnRegistrarNotas;
        private MaterialSkin.Controls.MaterialRaisedButton btnRegistrarAsistencias;
        private MaterialSkin.Controls.MaterialRaisedButton btnVerAsistenciasNotas;
    }
}