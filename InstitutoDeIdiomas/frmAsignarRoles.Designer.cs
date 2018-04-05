namespace InstitutoDeIdiomas
{
    partial class frmAsignarRoles
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
            this.dgvwRoles = new System.Windows.Forms.DataGridView();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwRoles)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvwRoles
            // 
            this.dgvwRoles.AllowUserToAddRows = false;
            this.dgvwRoles.AllowUserToDeleteRows = false;
            this.dgvwRoles.AllowUserToResizeRows = false;
            this.dgvwRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwRoles.Location = new System.Drawing.Point(11, 47);
            this.dgvwRoles.Margin = new System.Windows.Forms.Padding(2);
            this.dgvwRoles.Name = "dgvwRoles";
            this.dgvwRoles.RowHeadersVisible = false;
            this.dgvwRoles.RowTemplate.Height = 24;
            this.dgvwRoles.Size = new System.Drawing.Size(536, 397);
            this.dgvwRoles.TabIndex = 37;
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(178, 13);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(343, 21);
            this.cmbUsuarios.TabIndex = 38;
            this.cmbUsuarios.SelectedIndexChanged += new System.EventHandler(this.cmbUsuarios_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Selecciona el usuario";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvwRoles);
            this.panel1.Controls.Add(this.cmbUsuarios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 491);
            this.panel1.TabIndex = 40;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Location = new System.Drawing.Point(454, 452);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = true;
            this.btnGuardar.Size = new System.Drawing.Size(93, 29);
            this.btnGuardar.TabIndex = 40;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmAsignarRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 555);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmAsignarRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASIGNAR ROLES";
            this.Load += new System.EventHandler(this.frmAsignarRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvwRoles)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvwRoles;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnGuardar;
    }
}