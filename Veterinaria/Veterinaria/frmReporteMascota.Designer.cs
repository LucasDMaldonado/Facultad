namespace Veterinaria
{
    partial class frmReporteMascota
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
            this.rptMascota1 = new Veterinaria.rptMascota();
            this.btnTodo = new System.Windows.Forms.Button();
            this.cboEspecie = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerPorEspecie = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExpandir = new System.Windows.Forms.Button();
            this.btnContraer = new System.Windows.Forms.Button();
            this.rptMascota2 = new Veterinaria.rptMascota();
            this.SuspendLayout();
            // 
            // btnTodo
            // 
            this.btnTodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTodo.Location = new System.Drawing.Point(66, 468);
            this.btnTodo.Name = "btnTodo";
            this.btnTodo.Size = new System.Drawing.Size(75, 23);
            this.btnTodo.TabIndex = 2;
            this.btnTodo.Text = "Ver Todo";
            this.btnTodo.UseVisualStyleBackColor = true;
            this.btnTodo.Click += new System.EventHandler(this.btnTodo_Click);
            // 
            // cboEspecie
            // 
            this.cboEspecie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cboEspecie.FormattingEnabled = true;
            this.cboEspecie.Location = new System.Drawing.Point(475, 468);
            this.cboEspecie.Name = "cboEspecie";
            this.cboEspecie.Size = new System.Drawing.Size(95, 21);
            this.cboEspecie.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 473);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione la Especie";
            // 
            // btnVerPorEspecie
            // 
            this.btnVerPorEspecie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerPorEspecie.Location = new System.Drawing.Point(576, 468);
            this.btnVerPorEspecie.Name = "btnVerPorEspecie";
            this.btnVerPorEspecie.Size = new System.Drawing.Size(75, 23);
            this.btnVerPorEspecie.TabIndex = 5;
            this.btnVerPorEspecie.Text = "Ver";
            this.btnVerPorEspecie.UseVisualStyleBackColor = true;
            this.btnVerPorEspecie.Click += new System.EventHandler(this.btnVerPorEspecie_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(609, 8);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "REPORTE MASCOTAS";
            // 
            // btnExpandir
            // 
            this.btnExpandir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpandir.Location = new System.Drawing.Point(528, 8);
            this.btnExpandir.Name = "btnExpandir";
            this.btnExpandir.Size = new System.Drawing.Size(75, 23);
            this.btnExpandir.TabIndex = 8;
            this.btnExpandir.Text = "Expandir";
            this.btnExpandir.UseVisualStyleBackColor = true;
            this.btnExpandir.Click += new System.EventHandler(this.btnExpandir_Click);
            // 
            // btnContraer
            // 
            this.btnContraer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContraer.Location = new System.Drawing.Point(528, 8);
            this.btnContraer.Name = "btnContraer";
            this.btnContraer.Size = new System.Drawing.Size(75, 23);
            this.btnContraer.TabIndex = 9;
            this.btnContraer.Text = "Contrar";
            this.btnContraer.UseVisualStyleBackColor = true;
            this.btnContraer.Click += new System.EventHandler(this.btnContraer_Click);
            // 
            // frmReporteMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 516);
            this.Controls.Add(this.btnContraer);
            this.Controls.Add(this.btnExpandir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVerPorEspecie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboEspecie);
            this.Controls.Add(this.btnTodo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReporteMascota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReporteMascota";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmReporteMascota_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTodo;
        private System.Windows.Forms.ComboBox cboEspecie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerPorEspecie;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        private rptMascota rptMascota1;
        private System.Windows.Forms.Button btnExpandir;
        private System.Windows.Forms.Button btnContraer;
        private rptMascota rptMascota2;
    }
}