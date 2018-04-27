namespace InstitutoDeIdiomas
{
    partial class frmCorregirPago
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.rbRecibo = new System.Windows.Forms.RadioButton();
            this.dgvwPagos = new System.Windows.Forms.DataGridView();
            this.txtRecibo = new System.Windows.Forms.TextBox();
            this.txtNuevoRecibo = new System.Windows.Forms.TextBox();
            this.btnCambiar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminarPago = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwPagos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNombre);
            this.groupBox1.Controls.Add(this.rbRecibo);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(179, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por";
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNombre.Location = new System.Drawing.Point(170, 26);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(144, 20);
            this.rbNombre.TabIndex = 3;
            this.rbNombre.TabStop = true;
            this.rbNombre.Text = "Nombre del alumno";
            this.rbNombre.UseVisualStyleBackColor = true;
            // 
            // rbRecibo
            // 
            this.rbRecibo.AutoSize = true;
            this.rbRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRecibo.Location = new System.Drawing.Point(29, 26);
            this.rbRecibo.Name = "rbRecibo";
            this.rbRecibo.Size = new System.Drawing.Size(129, 20);
            this.rbRecibo.TabIndex = 2;
            this.rbRecibo.TabStop = true;
            this.rbRecibo.Text = "N° recibo                ";
            this.rbRecibo.UseVisualStyleBackColor = true;
            // 
            // dgvwPagos
            // 
            this.dgvwPagos.AllowUserToAddRows = false;
            this.dgvwPagos.AllowUserToDeleteRows = false;
            this.dgvwPagos.AllowUserToResizeRows = false;
            this.dgvwPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwPagos.GridColor = System.Drawing.SystemColors.Control;
            this.dgvwPagos.Location = new System.Drawing.Point(12, 119);
            this.dgvwPagos.Name = "dgvwPagos";
            this.dgvwPagos.ReadOnly = true;
            this.dgvwPagos.RowHeadersVisible = false;
            this.dgvwPagos.Size = new System.Drawing.Size(697, 210);
            this.dgvwPagos.TabIndex = 2;
            this.dgvwPagos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwPagos_CellClick);
            // 
            // txtRecibo
            // 
            this.txtRecibo.Location = new System.Drawing.Point(593, 340);
            this.txtRecibo.Name = "txtRecibo";
            this.txtRecibo.ReadOnly = true;
            this.txtRecibo.Size = new System.Drawing.Size(116, 20);
            this.txtRecibo.TabIndex = 5;
            // 
            // txtNuevoRecibo
            // 
            this.txtNuevoRecibo.Location = new System.Drawing.Point(593, 369);
            this.txtNuevoRecibo.Name = "txtNuevoRecibo";
            this.txtNuevoRecibo.Size = new System.Drawing.Size(116, 20);
            this.txtNuevoRecibo.TabIndex = 7;
            // 
            // btnCambiar
            // 
            this.btnCambiar.Depth = 0;
            this.btnCambiar.Enabled = false;
            this.btnCambiar.Location = new System.Drawing.Point(593, 399);
            this.btnCambiar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Primary = true;
            this.btnCambiar.Size = new System.Drawing.Size(116, 23);
            this.btnCambiar.TabIndex = 8;
            this.btnCambiar.Text = "CAMBIAR";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnEliminarPago);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCambiar);
            this.panel1.Controls.Add(this.txtNuevoRecibo);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dgvwPagos);
            this.panel1.Controls.Add(this.txtRecibo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 435);
            this.panel1.TabIndex = 9;
            // 
            // btnEliminarPago
            // 
            this.btnEliminarPago.BackColor = System.Drawing.Color.DarkRed;
            this.btnEliminarPago.FlatAppearance.BorderSize = 0;
            this.btnEliminarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPago.ForeColor = System.Drawing.Color.White;
            this.btnEliminarPago.Location = new System.Drawing.Point(12, 342);
            this.btnEliminarPago.Name = "btnEliminarPago";
            this.btnEliminarPago.Size = new System.Drawing.Size(102, 23);
            this.btnEliminarPago.TabIndex = 13;
            this.btnEliminarPago.Text = "ELIMINAR PAGO";
            this.btnEliminarPago.UseVisualStyleBackColor = false;
            this.btnEliminarPago.Click += new System.EventHandler(this.btnEliminarPago_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(55, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Escriba aquí";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(154, 83);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(389, 21);
            this.txtBuscar.TabIndex = 11;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(465, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nuevo N° recibo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(465, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Actual N° recibo ";
            // 
            // frmCorregirPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 498);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmCorregirPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CORREGIR PAGO";
            this.Load += new System.EventHandler(this.frmCorregirPago_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwPagos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvwPagos;
        private System.Windows.Forms.TextBox txtRecibo;
        private System.Windows.Forms.TextBox txtNuevoRecibo;
        private MaterialSkin.Controls.MaterialRaisedButton btnCambiar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.RadioButton rbRecibo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnEliminarPago;
    }
}