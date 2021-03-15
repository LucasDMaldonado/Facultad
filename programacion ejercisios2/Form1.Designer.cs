namespace programacion_ejercisios2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCliente = new System.Windows.Forms.TabPage();
            this.tabObserv = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLimiteDet = new System.Windows.Forms.Label();
            this.lblSaldoDet = new System.Windows.Forms.Label();
            this.lblCuentaDet = new System.Windows.Forms.Label();
            this.lblNombreDet = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cboCuenta = new System.Windows.Forms.ComboBox();
            this.rbtFemenino = new System.Windows.Forms.RadioButton();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.lblTipoCuenta = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCtaCorriente = new System.Windows.Forms.Label();
            this.lblCajaAhorro = new System.Windows.Forms.Label();
            this.lblClteFem = new System.Windows.Forms.Label();
            this.lblPromCjaAhorro = new System.Windows.Forms.Label();
            this.lblPromCtaCorriente = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLimMayor = new System.Windows.Forms.Label();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.txtNumeroCuenta = new System.Windows.Forms.TextBox();
            this.lblNroCuenta = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabCliente.SuspendLayout();
            this.tabObserv.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCliente);
            this.tabControl1.Controls.Add(this.tabObserv);
            this.tabControl1.Location = new System.Drawing.Point(8, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(478, 449);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCliente
            // 
            this.tabCliente.BackColor = System.Drawing.Color.Transparent;
            this.tabCliente.Controls.Add(this.txtSaldo);
            this.tabCliente.Controls.Add(this.lblSaldo);
            this.tabCliente.Controls.Add(this.txtNumeroCuenta);
            this.tabCliente.Controls.Add(this.lblNroCuenta);
            this.tabCliente.Controls.Add(this.groupBox1);
            this.tabCliente.Controls.Add(this.btnRegistrar);
            this.tabCliente.Controls.Add(this.cboCuenta);
            this.tabCliente.Controls.Add(this.rbtFemenino);
            this.tabCliente.Controls.Add(this.rbtMasculino);
            this.tabCliente.Controls.Add(this.lblTipoCuenta);
            this.tabCliente.Controls.Add(this.txtCodigo);
            this.tabCliente.Controls.Add(this.lblCodigo);
            this.tabCliente.Controls.Add(this.txtDoc);
            this.tabCliente.Controls.Add(this.lblDocumento);
            this.tabCliente.Controls.Add(this.txtApellido);
            this.tabCliente.Controls.Add(this.lblApellido);
            this.tabCliente.Controls.Add(this.txtNombre);
            this.tabCliente.Controls.Add(this.lblNombre);
            this.tabCliente.Location = new System.Drawing.Point(4, 22);
            this.tabCliente.Name = "tabCliente";
            this.tabCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabCliente.Size = new System.Drawing.Size(470, 423);
            this.tabCliente.TabIndex = 0;
            this.tabCliente.Text = "Clientes";
            // 
            // tabObserv
            // 
            this.tabObserv.BackColor = System.Drawing.Color.Transparent;
            this.tabObserv.Controls.Add(this.btnConsulta);
            this.tabObserv.Controls.Add(this.lblLimMayor);
            this.tabObserv.Controls.Add(this.label6);
            this.tabObserv.Controls.Add(this.lblPromCtaCorriente);
            this.tabObserv.Controls.Add(this.lblPromCjaAhorro);
            this.tabObserv.Controls.Add(this.lblClteFem);
            this.tabObserv.Controls.Add(this.lblCajaAhorro);
            this.tabObserv.Controls.Add(this.lblCtaCorriente);
            this.tabObserv.Location = new System.Drawing.Point(4, 22);
            this.tabObserv.Name = "tabObserv";
            this.tabObserv.Padding = new System.Windows.Forms.Padding(3);
            this.tabObserv.Size = new System.Drawing.Size(470, 423);
            this.tabObserv.TabIndex = 1;
            this.tabObserv.Text = "Observaciones";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLimiteDet);
            this.groupBox1.Controls.Add(this.lblSaldoDet);
            this.groupBox1.Controls.Add(this.lblCuentaDet);
            this.groupBox1.Controls.Add(this.lblNombreDet);
            this.groupBox1.Location = new System.Drawing.Point(6, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 144);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // lblLimiteDet
            // 
            this.lblLimiteDet.AutoSize = true;
            this.lblLimiteDet.Location = new System.Drawing.Point(10, 107);
            this.lblLimiteDet.Name = "lblLimiteDet";
            this.lblLimiteDet.Size = new System.Drawing.Size(84, 13);
            this.lblLimiteDet.TabIndex = 20;
            this.lblLimiteDet.Text = "Limite de credito";
            // 
            // lblSaldoDet
            // 
            this.lblSaldoDet.AutoSize = true;
            this.lblSaldoDet.Location = new System.Drawing.Point(10, 81);
            this.lblSaldoDet.Name = "lblSaldoDet";
            this.lblSaldoDet.Size = new System.Drawing.Size(34, 13);
            this.lblSaldoDet.TabIndex = 19;
            this.lblSaldoDet.Text = "Saldo";
            // 
            // lblCuentaDet
            // 
            this.lblCuentaDet.AutoSize = true;
            this.lblCuentaDet.Location = new System.Drawing.Point(10, 53);
            this.lblCuentaDet.Name = "lblCuentaDet";
            this.lblCuentaDet.Size = new System.Drawing.Size(41, 13);
            this.lblCuentaDet.TabIndex = 18;
            this.lblCuentaDet.Text = "Cuenta";
            // 
            // lblNombreDet
            // 
            this.lblNombreDet.AutoSize = true;
            this.lblNombreDet.Location = new System.Drawing.Point(10, 25);
            this.lblNombreDet.Name = "lblNombreDet";
            this.lblNombreDet.Size = new System.Drawing.Size(44, 13);
            this.lblNombreDet.TabIndex = 17;
            this.lblNombreDet.Text = "Nombre";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(334, 347);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(101, 36);
            this.btnRegistrar.TabIndex = 36;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cboCuenta
            // 
            this.cboCuenta.FormattingEnabled = true;
            this.cboCuenta.Location = new System.Drawing.Point(121, 121);
            this.cboCuenta.Name = "cboCuenta";
            this.cboCuenta.Size = new System.Drawing.Size(121, 21);
            this.cboCuenta.TabIndex = 34;
            // 
            // rbtFemenino
            // 
            this.rbtFemenino.AutoSize = true;
            this.rbtFemenino.Location = new System.Drawing.Point(334, 46);
            this.rbtFemenino.Name = "rbtFemenino";
            this.rbtFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbtFemenino.TabIndex = 33;
            this.rbtFemenino.TabStop = true;
            this.rbtFemenino.Text = "Femenino";
            this.rbtFemenino.UseVisualStyleBackColor = true;
            this.rbtFemenino.CheckedChanged += new System.EventHandler(this.rbtFemenino_CheckedChanged);
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Location = new System.Drawing.Point(334, 20);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtMasculino.TabIndex = 32;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // lblTipoCuenta
            // 
            this.lblTipoCuenta.AutoSize = true;
            this.lblTipoCuenta.Location = new System.Drawing.Point(16, 129);
            this.lblTipoCuenta.Name = "lblTipoCuenta";
            this.lblTipoCuenta.Size = new System.Drawing.Size(79, 13);
            this.lblTipoCuenta.TabIndex = 31;
            this.lblTipoCuenta.Text = "Tipo de cuenta";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(121, 95);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 30;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(16, 102);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 29;
            this.lblCodigo.Text = "Codigo";
            // 
            // txtDoc
            // 
            this.txtDoc.Location = new System.Drawing.Point(121, 69);
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(100, 20);
            this.txtDoc.TabIndex = 28;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(16, 76);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(62, 13);
            this.lblDocumento.TabIndex = 27;
            this.lblDocumento.Text = "Documento";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(121, 43);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 26;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(16, 46);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 25;
            this.lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(121, 17);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 24;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 23;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCtaCorriente
            // 
            this.lblCtaCorriente.AutoSize = true;
            this.lblCtaCorriente.Location = new System.Drawing.Point(21, 33);
            this.lblCtaCorriente.Name = "lblCtaCorriente";
            this.lblCtaCorriente.Size = new System.Drawing.Size(141, 13);
            this.lblCtaCorriente.TabIndex = 0;
            this.lblCtaCorriente.Text = "Cantidad Cuentas Corrientes";
            this.lblCtaCorriente.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCajaAhorro
            // 
            this.lblCajaAhorro.AutoSize = true;
            this.lblCajaAhorro.Location = new System.Drawing.Point(21, 59);
            this.lblCajaAhorro.Name = "lblCajaAhorro";
            this.lblCajaAhorro.Size = new System.Drawing.Size(107, 13);
            this.lblCajaAhorro.TabIndex = 1;
            this.lblCajaAhorro.Text = "Cantidad Caja Ahorro";
            // 
            // lblClteFem
            // 
            this.lblClteFem.AutoSize = true;
            this.lblClteFem.Location = new System.Drawing.Point(21, 136);
            this.lblClteFem.Name = "lblClteFem";
            this.lblClteFem.Size = new System.Drawing.Size(98, 13);
            this.lblClteFem.TabIndex = 2;
            this.lblClteFem.Text = "Clientes Femeninos";
            // 
            // lblPromCjaAhorro
            // 
            this.lblPromCjaAhorro.AutoSize = true;
            this.lblPromCjaAhorro.Location = new System.Drawing.Point(21, 111);
            this.lblPromCjaAhorro.Name = "lblPromCjaAhorro";
            this.lblPromCjaAhorro.Size = new System.Drawing.Size(137, 13);
            this.lblPromCjaAhorro.TabIndex = 2;
            this.lblPromCjaAhorro.Text = "Promedio saldo Caja Ahorro";
            // 
            // lblPromCtaCorriente
            // 
            this.lblPromCtaCorriente.AutoSize = true;
            this.lblPromCtaCorriente.Location = new System.Drawing.Point(21, 84);
            this.lblPromCtaCorriente.Name = "lblPromCtaCorriente";
            this.lblPromCtaCorriente.Size = new System.Drawing.Size(161, 13);
            this.lblPromCtaCorriente.TabIndex = 2;
            this.lblPromCtaCorriente.Text = "Promedio saldo Cuenta Corriente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-176, -9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "label3";
            // 
            // lblLimMayor
            // 
            this.lblLimMayor.AutoSize = true;
            this.lblLimMayor.Location = new System.Drawing.Point(21, 161);
            this.lblLimMayor.Name = "lblLimMayor";
            this.lblLimMayor.Size = new System.Drawing.Size(66, 13);
            this.lblLimMayor.TabIndex = 3;
            this.lblLimMayor.Text = "Limite Mayor";
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(317, 345);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(110, 31);
            this.btnConsulta.TabIndex = 4;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            // 
            // txtNumeroCuenta
            // 
            this.txtNumeroCuenta.Location = new System.Drawing.Point(121, 148);
            this.txtNumeroCuenta.Name = "txtNumeroCuenta";
            this.txtNumeroCuenta.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroCuenta.TabIndex = 39;
            // 
            // lblNroCuenta
            // 
            this.lblNroCuenta.AutoSize = true;
            this.lblNroCuenta.Location = new System.Drawing.Point(16, 151);
            this.lblNroCuenta.Name = "lblNroCuenta";
            this.lblNroCuenta.Size = new System.Drawing.Size(96, 13);
            this.lblNroCuenta.TabIndex = 38;
            this.lblNroCuenta.Text = "Numero de Cuenta";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(121, 174);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo.TabIndex = 41;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(16, 174);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(34, 13);
            this.lblSaldo.TabIndex = 40;
            this.lblSaldo.Text = "Saldo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 489);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabCliente.ResumeLayout(false);
            this.tabCliente.PerformLayout();
            this.tabObserv.ResumeLayout(false);
            this.tabObserv.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLimiteDet;
        private System.Windows.Forms.Label lblSaldoDet;
        private System.Windows.Forms.Label lblCuentaDet;
        private System.Windows.Forms.Label lblNombreDet;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cboCuenta;
        private System.Windows.Forms.RadioButton rbtFemenino;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.Label lblTipoCuenta;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TabPage tabObserv;
        private System.Windows.Forms.Label lblLimMayor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPromCtaCorriente;
        private System.Windows.Forms.Label lblPromCjaAhorro;
        private System.Windows.Forms.Label lblClteFem;
        private System.Windows.Forms.Label lblCajaAhorro;
        private System.Windows.Forms.Label lblCtaCorriente;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtNumeroCuenta;
        private System.Windows.Forms.Label lblNroCuenta;
    }
}

