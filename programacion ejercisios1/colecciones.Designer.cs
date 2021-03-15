using System;

namespace programacion_ejercisios1
{
    partial class FrmColecciones
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
            this.lstCuadroIzquierda = new System.Windows.Forms.ListBox();
            this.lstCuadroDerecha = new System.Windows.Forms.ListBox();
            this.btnPasarDerecha = new System.Windows.Forms.Button();
            this.btnPasarTodoDerecha = new System.Windows.Forms.Button();
            this.btnPasarTodoIzquierda = new System.Windows.Forms.Button();
            this.btnPasarIzquierda = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCuadroIzquierda
            // 
            this.lstCuadroIzquierda.FormattingEnabled = true;
            this.lstCuadroIzquierda.Location = new System.Drawing.Point(31, 42);
            this.lstCuadroIzquierda.Name = "lstCuadroIzquierda";
            this.lstCuadroIzquierda.Size = new System.Drawing.Size(153, 290);
            this.lstCuadroIzquierda.TabIndex = 0;
            // 
            // lstCuadroDerecha
            // 
            this.lstCuadroDerecha.FormattingEnabled = true;
            this.lstCuadroDerecha.Location = new System.Drawing.Point(278, 42);
            this.lstCuadroDerecha.Name = "lstCuadroDerecha";
            this.lstCuadroDerecha.Size = new System.Drawing.Size(153, 290);
            this.lstCuadroDerecha.TabIndex = 1;
            // 
            // btnPasarDerecha
            // 
            this.btnPasarDerecha.Location = new System.Drawing.Point(201, 58);
            this.btnPasarDerecha.Name = "btnPasarDerecha";
            this.btnPasarDerecha.Size = new System.Drawing.Size(60, 35);
            this.btnPasarDerecha.TabIndex = 2;
            this.btnPasarDerecha.Text = ">";
            this.btnPasarDerecha.UseVisualStyleBackColor = true;
            this.btnPasarDerecha.Click += new System.EventHandler(this.btnPasarDerecha_Click);
            // 
            // btnPasarTodoDerecha
            // 
            this.btnPasarTodoDerecha.Location = new System.Drawing.Point(201, 99);
            this.btnPasarTodoDerecha.Name = "btnPasarTodoDerecha";
            this.btnPasarTodoDerecha.Size = new System.Drawing.Size(60, 35);
            this.btnPasarTodoDerecha.TabIndex = 3;
            this.btnPasarTodoDerecha.Text = ">>";
            this.btnPasarTodoDerecha.UseVisualStyleBackColor = true;
            this.btnPasarTodoDerecha.Click += new System.EventHandler(this.btnPasarTodoDerecha_Click);
            // 
            // btnPasarTodoIzquierda
            // 
            this.btnPasarTodoIzquierda.Location = new System.Drawing.Point(201, 191);
            this.btnPasarTodoIzquierda.Name = "btnPasarTodoIzquierda";
            this.btnPasarTodoIzquierda.Size = new System.Drawing.Size(60, 35);
            this.btnPasarTodoIzquierda.TabIndex = 4;
            this.btnPasarTodoIzquierda.Text = "<<";
            this.btnPasarTodoIzquierda.UseVisualStyleBackColor = true;
            this.btnPasarTodoIzquierda.Click += new System.EventHandler(this.btnPasarTodoIzquierda_Click);
            // 
            // btnPasarIzquierda
            // 
            this.btnPasarIzquierda.Location = new System.Drawing.Point(201, 232);
            this.btnPasarIzquierda.Name = "btnPasarIzquierda";
            this.btnPasarIzquierda.Size = new System.Drawing.Size(60, 35);
            this.btnPasarIzquierda.TabIndex = 5;
            this.btnPasarIzquierda.Text = "<";
            this.btnPasarIzquierda.UseVisualStyleBackColor = true;
            this.btnPasarIzquierda.Click += new System.EventHandler(this.btnPasarIzquierda_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(322, 442);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(109, 30);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // FrmColecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 499);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnPasarIzquierda);
            this.Controls.Add(this.btnPasarTodoIzquierda);
            this.Controls.Add(this.btnPasarTodoDerecha);
            this.Controls.Add(this.btnPasarDerecha);
            this.Controls.Add(this.lstCuadroDerecha);
            this.Controls.Add(this.lstCuadroIzquierda);
            this.Name = "FrmColecciones";
            this.Text = "Colecciones";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.ListBox lstCuadroIzquierda;
        private System.Windows.Forms.ListBox lstCuadroDerecha;
        private System.Windows.Forms.Button btnPasarDerecha;
        private System.Windows.Forms.Button btnPasarTodoDerecha;
        private System.Windows.Forms.Button btnPasarTodoIzquierda;
        private System.Windows.Forms.Button btnPasarIzquierda;
        private System.Windows.Forms.Button btnRegistrar;
    }
}

