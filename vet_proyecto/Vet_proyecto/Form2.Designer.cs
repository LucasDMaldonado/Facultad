namespace Vet_proyecto
{
    partial class Form2
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.txtfiltroNombre = new System.Windows.Forms.TextBox();
            this.rbtMascotasRepo = new System.Windows.Forms.RadioButton();
            this.rbtDueños = new System.Windows.Forms.RadioButton();
            this.rbtVeterinariosRepo = new System.Windows.Forms.RadioButton();
            this.txtFiltroApel = new System.Windows.Forms.TextBox();
            this.cboFiltroTipo = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.DisplayToolbar = false;
            this.crystalReportViewer1.Location = new System.Drawing.Point(221, 2);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(862, 454);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // txtfiltroNombre
            // 
            this.txtfiltroNombre.Location = new System.Drawing.Point(12, 123);
            this.txtfiltroNombre.Name = "txtfiltroNombre";
            this.txtfiltroNombre.Size = new System.Drawing.Size(185, 20);
            this.txtfiltroNombre.TabIndex = 1;
            // 
            // rbtMascotasRepo
            // 
            this.rbtMascotasRepo.AutoSize = true;
            this.rbtMascotasRepo.Location = new System.Drawing.Point(12, 24);
            this.rbtMascotasRepo.Name = "rbtMascotasRepo";
            this.rbtMascotasRepo.Size = new System.Drawing.Size(71, 17);
            this.rbtMascotasRepo.TabIndex = 4;
            this.rbtMascotasRepo.TabStop = true;
            this.rbtMascotasRepo.Text = "Mascotas";
            this.rbtMascotasRepo.UseVisualStyleBackColor = true;
            this.rbtMascotasRepo.CheckedChanged += new System.EventHandler(this.rbtMascotasRepo_CheckedChanged);
            // 
            // rbtDueños
            // 
            this.rbtDueños.AutoSize = true;
            this.rbtDueños.Location = new System.Drawing.Point(12, 47);
            this.rbtDueños.Name = "rbtDueños";
            this.rbtDueños.Size = new System.Drawing.Size(62, 17);
            this.rbtDueños.TabIndex = 5;
            this.rbtDueños.TabStop = true;
            this.rbtDueños.Text = "Dueños";
            this.rbtDueños.UseVisualStyleBackColor = true;
            this.rbtDueños.CheckedChanged += new System.EventHandler(this.rbtDueños_CheckedChanged);
            // 
            // rbtVeterinariosRepo
            // 
            this.rbtVeterinariosRepo.AutoSize = true;
            this.rbtVeterinariosRepo.Location = new System.Drawing.Point(12, 70);
            this.rbtVeterinariosRepo.Name = "rbtVeterinariosRepo";
            this.rbtVeterinariosRepo.Size = new System.Drawing.Size(80, 17);
            this.rbtVeterinariosRepo.TabIndex = 6;
            this.rbtVeterinariosRepo.TabStop = true;
            this.rbtVeterinariosRepo.Text = "Veterinarios";
            this.rbtVeterinariosRepo.UseVisualStyleBackColor = true;
            this.rbtVeterinariosRepo.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // txtFiltroApel
            // 
            this.txtFiltroApel.Location = new System.Drawing.Point(12, 168);
            this.txtFiltroApel.Name = "txtFiltroApel";
            this.txtFiltroApel.Size = new System.Drawing.Size(185, 20);
            this.txtFiltroApel.TabIndex = 7;
            // 
            // cboFiltroTipo
            // 
            this.cboFiltroTipo.FormattingEnabled = true;
            this.cboFiltroTipo.Location = new System.Drawing.Point(12, 168);
            this.cboFiltroTipo.Name = "cboFiltroTipo";
            this.cboFiltroTipo.Size = new System.Drawing.Size(185, 21);
            this.cboFiltroTipo.TabIndex = 8;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(12, 237);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 48);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 486);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cboFiltroTipo);
            this.Controls.Add(this.txtFiltroApel);
            this.Controls.Add(this.rbtVeterinariosRepo);
            this.Controls.Add(this.rbtDueños);
            this.Controls.Add(this.rbtMascotasRepo);
            this.Controls.Add(this.txtfiltroNombre);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
      
        private System.Windows.Forms.TextBox txtfiltroNombre;
        private System.Windows.Forms.RadioButton rbtMascotasRepo;
        private System.Windows.Forms.RadioButton rbtDueños;
        private System.Windows.Forms.RadioButton rbtVeterinariosRepo;
        private System.Windows.Forms.TextBox txtFiltroApel;
        private System.Windows.Forms.ComboBox cboFiltroTipo;
        private System.Windows.Forms.Button btnBuscar;
    }
}