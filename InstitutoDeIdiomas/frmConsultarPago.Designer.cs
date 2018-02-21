namespace InstitutoDeIdiomas
{
    partial class frmConsultarPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarPago));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GRIDVIEWALUMNNOM = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTCONNOMBRE = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BTNBUSCARPORDNI = new System.Windows.Forms.Button();
            this.GRIDVIEWALUMDNI = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTCONSDNI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IMGALUMNCONS = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.GRIDVIEWPAGOSCONS = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.GRIDVIEWOTROSPAGOS = new System.Windows.Forms.DataGridView();
            this.GRIDVIEWMATRICULA = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDVIEWALUMNNOM)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDVIEWALUMDNI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMGALUMNCONS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDVIEWPAGOSCONS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDVIEWOTROSPAGOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDVIEWMATRICULA)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(11, 30);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(686, 173);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.GRIDVIEWALUMNNOM);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.TXTCONNOMBRE);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(678, 147);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "BUSCAR POR NOMBRE";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GRIDVIEWALUMNNOM
            // 
            this.GRIDVIEWALUMNNOM.AllowUserToAddRows = false;
            this.GRIDVIEWALUMNNOM.AllowUserToDeleteRows = false;
            this.GRIDVIEWALUMNNOM.AllowUserToResizeRows = false;
            this.GRIDVIEWALUMNNOM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRIDVIEWALUMNNOM.Location = new System.Drawing.Point(4, 52);
            this.GRIDVIEWALUMNNOM.Margin = new System.Windows.Forms.Padding(2);
            this.GRIDVIEWALUMNNOM.Name = "GRIDVIEWALUMNNOM";
            this.GRIDVIEWALUMNNOM.ReadOnly = true;
            this.GRIDVIEWALUMNNOM.RowHeadersVisible = false;
            this.GRIDVIEWALUMNNOM.RowTemplate.Height = 24;
            this.GRIDVIEWALUMNNOM.Size = new System.Drawing.Size(671, 92);
            this.GRIDVIEWALUMNNOM.TabIndex = 3;
            this.GRIDVIEWALUMNNOM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRIDVIEWALUMNNOM_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "INGRESA LOS APELLIDOS Y NOMBRES DEL ALUMNO";
            // 
            // TXTCONNOMBRE
            // 
            this.TXTCONNOMBRE.Location = new System.Drawing.Point(4, 29);
            this.TXTCONNOMBRE.Margin = new System.Windows.Forms.Padding(2);
            this.TXTCONNOMBRE.Name = "TXTCONNOMBRE";
            this.TXTCONNOMBRE.Size = new System.Drawing.Size(410, 20);
            this.TXTCONNOMBRE.TabIndex = 1;
            this.TXTCONNOMBRE.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXTBUSCARPORNOMBRE_KeyUp);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BTNBUSCARPORDNI);
            this.tabPage1.Controls.Add(this.GRIDVIEWALUMDNI);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.TXTCONSDNI);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(678, 147);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "BUSCAR POR D.N.I.";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BTNBUSCARPORDNI
            // 
            this.BTNBUSCARPORDNI.Location = new System.Drawing.Point(284, 28);
            this.BTNBUSCARPORDNI.Margin = new System.Windows.Forms.Padding(2);
            this.BTNBUSCARPORDNI.Name = "BTNBUSCARPORDNI";
            this.BTNBUSCARPORDNI.Size = new System.Drawing.Size(92, 19);
            this.BTNBUSCARPORDNI.TabIndex = 5;
            this.BTNBUSCARPORDNI.Text = "BUSCAR";
            this.BTNBUSCARPORDNI.UseVisualStyleBackColor = true;
            this.BTNBUSCARPORDNI.Click += new System.EventHandler(this.BTNBUSCARPORDNI_Click);
            // 
            // GRIDVIEWALUMDNI
            // 
            this.GRIDVIEWALUMDNI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRIDVIEWALUMDNI.Location = new System.Drawing.Point(4, 52);
            this.GRIDVIEWALUMDNI.Margin = new System.Windows.Forms.Padding(2);
            this.GRIDVIEWALUMDNI.Name = "GRIDVIEWALUMDNI";
            this.GRIDVIEWALUMDNI.ReadOnly = true;
            this.GRIDVIEWALUMDNI.RowTemplate.Height = 24;
            this.GRIDVIEWALUMDNI.Size = new System.Drawing.Size(671, 92);
            this.GRIDVIEWALUMDNI.TabIndex = 4;
            this.GRIDVIEWALUMDNI.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRIDVIEWALUMNDNI_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "INGRESA EL D.N.I. DEL ALUMNO";
            // 
            // TXTCONSDNI
            // 
            this.TXTCONSDNI.Location = new System.Drawing.Point(4, 29);
            this.TXTCONSDNI.Margin = new System.Windows.Forms.Padding(2);
            this.TXTCONSDNI.Name = "TXTCONSDNI";
            this.TXTCONSDNI.Size = new System.Drawing.Size(275, 20);
            this.TXTCONSDNI.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(393, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "EMPIEZA BUSCANDO AL ALUMNO QUE QUIERAS CONSULTAR SUS PAGOS";
            // 
            // IMGALUMNCONS
            // 
            this.IMGALUMNCONS.Location = new System.Drawing.Point(702, 48);
            this.IMGALUMNCONS.Margin = new System.Windows.Forms.Padding(2);
            this.IMGALUMNCONS.Name = "IMGALUMNCONS";
            this.IMGALUMNCONS.Size = new System.Drawing.Size(140, 152);
            this.IMGALUMNCONS.TabIndex = 3;
            this.IMGALUMNCONS.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(13, 209);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 2);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 226);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(512, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "AQUI SE MUESTRAN TODOS LOS RECIBOS DEL ALUMNO SELECCIONA PARA MOSTRAR DETALLE";
            // 
            // GRIDVIEWPAGOSCONS
            // 
            this.GRIDVIEWPAGOSCONS.AllowUserToAddRows = false;
            this.GRIDVIEWPAGOSCONS.AllowUserToDeleteRows = false;
            this.GRIDVIEWPAGOSCONS.AllowUserToResizeRows = false;
            this.GRIDVIEWPAGOSCONS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GRIDVIEWPAGOSCONS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRIDVIEWPAGOSCONS.Location = new System.Drawing.Point(11, 242);
            this.GRIDVIEWPAGOSCONS.Margin = new System.Windows.Forms.Padding(2);
            this.GRIDVIEWPAGOSCONS.Name = "GRIDVIEWPAGOSCONS";
            this.GRIDVIEWPAGOSCONS.ReadOnly = true;
            this.GRIDVIEWPAGOSCONS.RowHeadersVisible = false;
            this.GRIDVIEWPAGOSCONS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.GRIDVIEWPAGOSCONS.RowTemplate.Height = 24;
            this.GRIDVIEWPAGOSCONS.Size = new System.Drawing.Size(458, 100);
            this.GRIDVIEWPAGOSCONS.TabIndex = 6;
            this.GRIDVIEWPAGOSCONS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRIDVIEWPAGOSCONS_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 359);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "DETALLE DEL PAGO";
            // 
            // GRIDVIEWOTROSPAGOS
            // 
            this.GRIDVIEWOTROSPAGOS.AllowUserToAddRows = false;
            this.GRIDVIEWOTROSPAGOS.AllowUserToDeleteRows = false;
            this.GRIDVIEWOTROSPAGOS.AllowUserToResizeRows = false;
            this.GRIDVIEWOTROSPAGOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRIDVIEWOTROSPAGOS.Location = new System.Drawing.Point(14, 400);
            this.GRIDVIEWOTROSPAGOS.Margin = new System.Windows.Forms.Padding(2);
            this.GRIDVIEWOTROSPAGOS.Name = "GRIDVIEWOTROSPAGOS";
            this.GRIDVIEWOTROSPAGOS.ReadOnly = true;
            this.GRIDVIEWOTROSPAGOS.RowHeadersVisible = false;
            this.GRIDVIEWOTROSPAGOS.RowTemplate.Height = 24;
            this.GRIDVIEWOTROSPAGOS.Size = new System.Drawing.Size(455, 150);
            this.GRIDVIEWOTROSPAGOS.TabIndex = 8;
            // 
            // GRIDVIEWMATRICULA
            // 
            this.GRIDVIEWMATRICULA.AllowUserToAddRows = false;
            this.GRIDVIEWMATRICULA.AllowUserToDeleteRows = false;
            this.GRIDVIEWMATRICULA.AllowUserToResizeRows = false;
            this.GRIDVIEWMATRICULA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRIDVIEWMATRICULA.Location = new System.Drawing.Point(490, 400);
            this.GRIDVIEWMATRICULA.Margin = new System.Windows.Forms.Padding(2);
            this.GRIDVIEWMATRICULA.Name = "GRIDVIEWMATRICULA";
            this.GRIDVIEWMATRICULA.ReadOnly = true;
            this.GRIDVIEWMATRICULA.RowHeadersVisible = false;
            this.GRIDVIEWMATRICULA.RowTemplate.Height = 24;
            this.GRIDVIEWMATRICULA.Size = new System.Drawing.Size(520, 150);
            this.GRIDVIEWMATRICULA.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 381);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "PAGOS EN GENERAL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(490, 381);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "PAGOS DE MATRICULAS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(490, 292);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "XXXXXXX";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(490, 265);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(329, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "NOMBRE DEL TRABAJADOR QUE REGISTRO EL PAGO";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.GRIDVIEWPAGOSCONS);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.IMGALUMNCONS);
            this.panel2.Controls.Add(this.GRIDVIEWMATRICULA);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.GRIDVIEWOTROSPAGOS);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1018, 569);
            this.panel2.TabIndex = 14;
            // 
            // frmConsultarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1018, 633);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmConsultarPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTAR PAGO";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDVIEWALUMNNOM)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDVIEWALUMDNI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMGALUMNCONS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDVIEWPAGOSCONS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDVIEWOTROSPAGOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDVIEWMATRICULA)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView GRIDVIEWALUMDNI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTCONSDNI;
        private System.Windows.Forms.DataGridView GRIDVIEWALUMNNOM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTCONNOMBRE;
        private System.Windows.Forms.PictureBox IMGALUMNCONS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView GRIDVIEWPAGOSCONS;
        private System.Windows.Forms.Button BTNBUSCARPORDNI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView GRIDVIEWOTROSPAGOS;
        private System.Windows.Forms.DataGridView GRIDVIEWMATRICULA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
    }
}