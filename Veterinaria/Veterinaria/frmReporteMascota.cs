using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Veterinaria
{
    public partial class frmReporteMascota : Form
    {
        int x = 0;
        int y = 0;
        OleDbCommand comand;
        OleDbConnection conexion;
        string cadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\GONZALO\Desktop\Parcial1w502019\dbfMascotas.mdb";
        DataTable tabla;
        rptMascota rm;
        public frmReporteMascota()
        {
            InitializeComponent();
            btnContraer.Visible = false;
            btnExpandir.Visible = true;
            cargarCombo(cboEspecie, "Especie");
            cboEspecie.SelectedIndex = -1;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
           
        }
        public void conectar()
        {
            conexion = new OleDbConnection(cadenaConexion);
            conexion.Open();
            comand = new OleDbCommand();
            comand.Connection = conexion;
            comand.CommandType = CommandType.Text;
        }

        public DataTable consultarBD(string consultaSQL)
        {
            DataTable tabla = new DataTable();
            conectar();
            comand.CommandText = consultaSQL;
            tabla.Load(comand.ExecuteReader());
            conexion.Close();
            conexion.Dispose();
            return tabla;
        }

        public void cargarCombo(ComboBox cmb, string nombreTabla)
        {
            conectar();
            comand.CommandText = "SELECT * FROM " + nombreTabla + " ORDER BY 2";
            tabla = new DataTable();
            tabla.Load(comand.ExecuteReader());
            cmb.DataSource = tabla;
            cmb.ValueMember = tabla.Columns[0].ColumnName;
            cmb.DisplayMember = tabla.Columns[1].ColumnName;
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            conexion.Close();
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
            //rm.NewGenerator = true;
            //rm. = consultarBD("SELECT * FROM Mascota ORDER BY 1");
            
            

            //Mascota
            

            ////this.ProductoTableAdapter.Fill(this.DBFProductoDataSet.Producto);

            //this.reportViewer1.RefreshReport();
        }

        private void btnVerPorEspecie_Click(object sender, EventArgs e)
        {
            //rm = consultarBD("SELECT * FROM Mascota WHERE especie = " + cboEspecie.SelectedIndex+1 + " ORDER BY 1");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnContraer_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnContraer.Visible = false;
            btnExpandir.Visible = true;
        }

        private void btnExpandir_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnContraer.Visible = true;
            btnExpandir.Visible = false;
        }

        private void frmReporteMascota_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                x = e.X;
                y = e.Y;
            }
            else
            {
                Left = Left + (e.X - x);
                Top = Top + (e.Y - y);
            }
        }
    }
}
