namespace Veterinaria
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mascotasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.especiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veterinariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dueñosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mascotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veterinariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dueñosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMascota = new System.Windows.Forms.Button();
            this.btnVeterinarios = new System.Windows.Forms.Button();
            this.btnDueños = new System.Windows.Forms.Button();
            this.btnInformes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnSalirX = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(100, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 406);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.informesToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(9, 21);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(318, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mascotasToolStripMenuItem1,
            this.veterinariosToolStripMenuItem1,
            this.dueñosToolStripMenuItem1});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // mascotasToolStripMenuItem1
            // 
            this.mascotasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.especiesToolStripMenuItem});
            this.mascotasToolStripMenuItem1.Name = "mascotasToolStripMenuItem1";
            this.mascotasToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.mascotasToolStripMenuItem1.Text = "Mascotas";
            this.mascotasToolStripMenuItem1.Click += new System.EventHandler(this.mascotasToolStripMenuItem1_Click);
            // 
            // especiesToolStripMenuItem
            // 
            this.especiesToolStripMenuItem.Name = "especiesToolStripMenuItem";
            this.especiesToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.especiesToolStripMenuItem.Text = "Especies";
            // 
            // veterinariosToolStripMenuItem1
            // 
            this.veterinariosToolStripMenuItem1.Name = "veterinariosToolStripMenuItem1";
            this.veterinariosToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.veterinariosToolStripMenuItem1.Text = "Veterinarios";
            this.veterinariosToolStripMenuItem1.Click += new System.EventHandler(this.veterinariosToolStripMenuItem1_Click);
            // 
            // dueñosToolStripMenuItem1
            // 
            this.dueñosToolStripMenuItem1.Name = "dueñosToolStripMenuItem1";
            this.dueñosToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.dueñosToolStripMenuItem1.Text = "Dueños";
            this.dueñosToolStripMenuItem1.Click += new System.EventHandler(this.dueñosToolStripMenuItem1_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mascotasToolStripMenuItem,
            this.veterinariosToolStripMenuItem,
            this.dueñosToolStripMenuItem});
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // mascotasToolStripMenuItem
            // 
            this.mascotasToolStripMenuItem.Name = "mascotasToolStripMenuItem";
            this.mascotasToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.mascotasToolStripMenuItem.Text = "Mascotas";
            this.mascotasToolStripMenuItem.Click += new System.EventHandler(this.mascotasToolStripMenuItem_Click);
            // 
            // veterinariosToolStripMenuItem
            // 
            this.veterinariosToolStripMenuItem.Name = "veterinariosToolStripMenuItem";
            this.veterinariosToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.veterinariosToolStripMenuItem.Text = "Veterinarios";
            // 
            // dueñosToolStripMenuItem
            // 
            this.dueñosToolStripMenuItem.Name = "dueñosToolStripMenuItem";
            this.dueñosToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.dueñosToolStripMenuItem.Text = "Dueños";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraToolStripMenuItem,
            this.calendarioToolStripMenuItem,
            this.backUpToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            // 
            // calendarioToolStripMenuItem
            // 
            this.calendarioToolStripMenuItem.Name = "calendarioToolStripMenuItem";
            this.calendarioToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.calendarioToolStripMenuItem.Text = "Calendario";
            // 
            // backUpToolStripMenuItem
            // 
            this.backUpToolStripMenuItem.Name = "backUpToolStripMenuItem";
            this.backUpToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.backUpToolStripMenuItem.Text = "Backup";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // btnMascota
            // 
            this.btnMascota.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMascota.Location = new System.Drawing.Point(-22, 95);
            this.btnMascota.Name = "btnMascota";
            this.btnMascota.Size = new System.Drawing.Size(116, 39);
            this.btnMascota.TabIndex = 2;
            this.btnMascota.Text = "Mascotas";
            this.btnMascota.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMascota.UseVisualStyleBackColor = false;
            this.btnMascota.Click += new System.EventHandler(this.btnMascota_Click);
            // 
            // btnVeterinarios
            // 
            this.btnVeterinarios.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnVeterinarios.Location = new System.Drawing.Point(-22, 140);
            this.btnVeterinarios.Name = "btnVeterinarios";
            this.btnVeterinarios.Size = new System.Drawing.Size(116, 39);
            this.btnVeterinarios.TabIndex = 3;
            this.btnVeterinarios.Text = "Veterinarios";
            this.btnVeterinarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVeterinarios.UseVisualStyleBackColor = false;
            this.btnVeterinarios.Click += new System.EventHandler(this.btnVeterinarios_Click);
            // 
            // btnDueños
            // 
            this.btnDueños.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDueños.Location = new System.Drawing.Point(-22, 185);
            this.btnDueños.Name = "btnDueños";
            this.btnDueños.Size = new System.Drawing.Size(116, 39);
            this.btnDueños.TabIndex = 4;
            this.btnDueños.Text = "Dueños";
            this.btnDueños.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDueños.UseVisualStyleBackColor = false;
            this.btnDueños.Click += new System.EventHandler(this.btnDueños_Click);
            // 
            // btnInformes
            // 
            this.btnInformes.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnInformes.Location = new System.Drawing.Point(-22, 230);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(116, 39);
            this.btnInformes.TabIndex = 5;
            this.btnInformes.Text = "Informes";
            this.btnInformes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInformes.UseVisualStyleBackColor = false;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalir.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSalir.Location = new System.Drawing.Point(-22, 398);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(116, 39);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnSalirX
            // 
            this.btnSalirX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalirX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSalirX.Location = new System.Drawing.Point(747, 2);
            this.btnSalirX.Name = "btnSalirX";
            this.btnSalirX.Size = new System.Drawing.Size(22, 22);
            this.btnSalirX.TabIndex = 0;
            this.btnSalirX.Text = "X";
            this.btnSalirX.UseVisualStyleBackColor = false;
            this.btnSalirX.Click += new System.EventHandler(this.btnSalirX_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMaximizar.Location = new System.Drawing.Point(719, 2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(22, 22);
            this.btnMaximizar.TabIndex = 7;
            this.btnMaximizar.Text = "#";
            this.btnMaximizar.UseVisualStyleBackColor = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMinimizar.Location = new System.Drawing.Point(689, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(22, 22);
            this.btnMinimizar.TabIndex = 8;
            this.btnMinimizar.Text = "--";
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRestaurar.Location = new System.Drawing.Point(719, 2);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(22, 22);
            this.btnRestaurar.TabIndex = 9;
            this.btnRestaurar.Text = "<";
            this.btnRestaurar.UseVisualStyleBackColor = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(782, 467);
            this.Controls.Add(this.btnSalirX);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnMaximizar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnInformes);
            this.Controls.Add(this.btnDueños);
            this.Controls.Add(this.btnVeterinarios);
            this.Controls.Add(this.btnMascota);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mascotasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem especiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veterinariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dueñosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mascotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veterinariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dueñosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button btnMascota;
        private System.Windows.Forms.Button btnVeterinarios;
        private System.Windows.Forms.Button btnDueños;
        private System.Windows.Forms.Button btnInformes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnSalirX;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnRestaurar;
    }
}

