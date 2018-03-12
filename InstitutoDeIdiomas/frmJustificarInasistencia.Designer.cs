namespace InstitutoDeIdiomas
{
    partial class frmJustificarInasistencia
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvwLista = new System.Windows.Forms.DataGridView();
            this.cmbIdiomas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbGrupos = new System.Windows.Forms.ComboBox();
            this.dgvwAsistencia = new System.Windows.Forms.DataGridView();
            this.btnJustificar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwAsistencia)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(150, 20);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(210, 20);
            this.txtBuscar.TabIndex = 18;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ingrese el apellido :";
            // 
            // dgvwLista
            // 
            this.dgvwLista.AllowUserToAddRows = false;
            this.dgvwLista.AllowUserToDeleteRows = false;
            this.dgvwLista.AllowUserToResizeColumns = false;
            this.dgvwLista.AllowUserToResizeRows = false;
            this.dgvwLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwLista.Location = new System.Drawing.Point(12, 54);
            this.dgvwLista.Name = "dgvwLista";
            this.dgvwLista.ReadOnly = true;
            this.dgvwLista.RowHeadersVisible = false;
            this.dgvwLista.Size = new System.Drawing.Size(657, 125);
            this.dgvwLista.TabIndex = 17;
            this.dgvwLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwLista_CellClick);
            // 
            // cmbIdiomas
            // 
            this.cmbIdiomas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdiomas.Enabled = false;
            this.cmbIdiomas.FormattingEnabled = true;
            this.cmbIdiomas.Location = new System.Drawing.Point(88, 186);
            this.cmbIdiomas.Name = "cmbIdiomas";
            this.cmbIdiomas.Size = new System.Drawing.Size(140, 21);
            this.cmbIdiomas.TabIndex = 20;
            this.cmbIdiomas.SelectedIndexChanged += new System.EventHandler(this.cmbIdiomas_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Idioma :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Grupos";
            // 
            // cmbGrupos
            // 
            this.cmbGrupos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupos.Enabled = false;
            this.cmbGrupos.FormattingEnabled = true;
            this.cmbGrupos.Location = new System.Drawing.Point(88, 218);
            this.cmbGrupos.Name = "cmbGrupos";
            this.cmbGrupos.Size = new System.Drawing.Size(272, 21);
            this.cmbGrupos.TabIndex = 23;
            this.cmbGrupos.SelectedIndexChanged += new System.EventHandler(this.cmbGrupos_SelectedIndexChanged);
            // 
            // dgvwAsistencia
            // 
            this.dgvwAsistencia.AllowUserToAddRows = false;
            this.dgvwAsistencia.AllowUserToDeleteRows = false;
            this.dgvwAsistencia.AllowUserToResizeRows = false;
            this.dgvwAsistencia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvwAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwAsistencia.Location = new System.Drawing.Point(12, 246);
            this.dgvwAsistencia.Name = "dgvwAsistencia";
            this.dgvwAsistencia.ReadOnly = true;
            this.dgvwAsistencia.RowHeadersVisible = false;
            this.dgvwAsistencia.Size = new System.Drawing.Size(657, 228);
            this.dgvwAsistencia.TabIndex = 25;
            this.dgvwAsistencia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwAsistencia_CellClick);
            // 
            // btnJustificar
            // 
            this.btnJustificar.Depth = 0;
            this.btnJustificar.Enabled = false;
            this.btnJustificar.Location = new System.Drawing.Point(560, 480);
            this.btnJustificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnJustificar.Name = "btnJustificar";
            this.btnJustificar.Primary = true;
            this.btnJustificar.Size = new System.Drawing.Size(109, 34);
            this.btnJustificar.TabIndex = 27;
            this.btnJustificar.Text = "JUSTIFICAR";
            this.btnJustificar.UseVisualStyleBackColor = true;
            this.btnJustificar.Click += new System.EventHandler(this.btnJustificar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnJustificar);
            this.panel1.Controls.Add(this.dgvwAsistencia);
            this.panel1.Controls.Add(this.cmbGrupos);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbIdiomas);
            this.panel1.Controls.Add(this.dgvwLista);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 527);
            this.panel1.TabIndex = 0;
            // 
            // frmJustificarInasistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 591);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmJustificarInasistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JUSTIFICAR INASISTENCIA";
            ((System.ComponentModel.ISupportInitialize)(this.dgvwLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwAsistencia)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvwLista;
        private System.Windows.Forms.ComboBox cmbIdiomas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbGrupos;
        private System.Windows.Forms.DataGridView dgvwAsistencia;
        private MaterialSkin.Controls.MaterialRaisedButton btnJustificar;
        private System.Windows.Forms.Panel panel1;
    }
}