namespace InstitutoDeIdiomas
{
    partial class ControlAlumno
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlAlumno));
            this.label1 = new System.Windows.Forms.Label();
            this.Consultar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRecord = new InstitutoDeIdiomas.BotonCircular();
            this.btnConsultar = new InstitutoDeIdiomas.BotonCircular();
            this.btnActualizar = new InstitutoDeIdiomas.BotonCircular();
            this.btnRegistrar = new InstitutoDeIdiomas.BotonCircular();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Registrar";
            // 
            // Consultar
            // 
            this.Consultar.AutoSize = true;
            this.Consultar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consultar.Location = new System.Drawing.Point(61, 273);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(70, 17);
            this.Consultar.TabIndex = 9;
            this.Consultar.Text = "Consultar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Record Académico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(321, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Actualizar";
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.Color.Yellow;
            this.btnRecord.FlatAppearance.BorderSize = 0;
            this.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecord.Image = ((System.Drawing.Image)(resources.GetObject("btnRecord.Image")));
            this.btnRecord.Location = new System.Drawing.Point(312, 35);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(90, 90);
            this.btnRecord.TabIndex = 7;
            this.btnRecord.UseVisualStyleBackColor = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.Location = new System.Drawing.Point(48, 176);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(90, 90);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.SlateBlue;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(312, 176);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(90, 90);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.Image")));
            this.btnRegistrar.Location = new System.Drawing.Point(48, 35);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(90, 90);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // ControlAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnRegistrar);
            this.Name = "ControlAlumno";
            this.Size = new System.Drawing.Size(486, 329);
            this.Load += new System.EventHandler(this.ControlAlumno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BotonCircular btnRegistrar;
        private BotonCircular btnActualizar;
        private BotonCircular btnConsultar;
        private BotonCircular btnRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Consultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
