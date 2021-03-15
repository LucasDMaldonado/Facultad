using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Vet_proyecto
{
    public partial class Form2 : Form
    {
        AccesoDatos OD = new AccesoDatos(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Usuario\source\repos\Vet_proyecto\Veterinaria.mdb");
        public Form2()
        {
            InitializeComponent();
        }

       public void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtMascotasRepo_CheckedChanged(object sender, EventArgs e)
        {
            txtFiltroApel.Hide();
        }

        private void rbtDueños_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (rbtMascotasRepo.Checked)
            {
                
                string consultaSQL = "SELECT * FROM Mascotas WHERE Nombre like '%" + txtfiltroNombre + "%'";
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Usuario\source\repos\Vet_proyecto\Veterinaria.mdb";
                OleDbCommand consulta = new OleDbCommand(consultaSQL,con);
                OleDbDataAdapter da = new OleDbDataAdapter(consulta);
                DataSet ds = new DataSet();
                da.Fill(ds, "mascotas");
                CrystalReport1 cr1 = new CrystalReport1();
                cr1.SetDataSource(ds);
                crystalReportViewer1.ReportSource = cr1;
                crystalReportViewer1.Refresh();




               

            }
        }
    }
}
