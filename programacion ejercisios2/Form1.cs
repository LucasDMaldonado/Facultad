using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programacion_ejercisios2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            double prom_saldo;
            int caj_ahor, cta_cor;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboCuenta.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCuenta.Items.Add("Caja de Ahorro");
            cboCuenta.Items.Add("Cuenta Corriente");
            rbtFemenino.Checked = true;


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rbtFemenino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Cliente CL = new Cliente();
            Cuenta C = new Cuenta();
            CL.pNombre = txtNombre.Text;
            CL.pApellido = txtApellido.Text;
            CL.pDocumento = Convert.ToInt32(txtDoc.Text);
            CL.pSexo = rbtFemenino.Checked;
            C.pTipo_cuenta = cboCuenta.SelectedIndex;
            C.Pnumero_cuenta = Convert.ToInt32(txtNumeroCuenta.Text);
            C.pSaldo = Convert.ToInt32(txtSaldo.Text);




        }
    }
}
