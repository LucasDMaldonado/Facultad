using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vet_proyecto
{
    public partial class CyberVet : Form
    {
        AccesoDatos OD = new AccesoDatos(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Usuario\source\repos\Vet_proyecto\Veterinaria.mdb");
        const int tam = 10;
        Mascota[] MA = new Mascota[tam];
        int c;


        public CyberVet()
        {
            InitializeComponent();
            for (int i = 0; i < tam; i++)
            {
                MA[i] = null;
            }
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ocultar(0);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void cargarCombo(ComboBox combo, string nombreTabla)
        {
            DataTable DT = new DataTable();
            DT = OD.consultarTabla(nombreTabla);
            combo.DataSource = DT;
            combo.ValueMember = DT.Columns[0].ColumnName;
            combo.DisplayMember = DT.Columns[1].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            txtMascota.Focus();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ocultar(1);

        }

        private void ocultar (int x)

        {
          if(x==1)
            {
                gbxMascotas.Show();
                gbxDueños.Hide();
                gbxVet.Hide();

            }
          else
                if(x==2)
            {
                gbxMascotas.Hide();
                gbxDueños.Show();
                gbxVet.Hide();

            }
            else
                if (x==3)
            {
                gbxMascotas.Hide();
                gbxDueños.Hide();
                gbxVet.Show();


            }
          else 
                if (x==0)
            {
                gbxMascotas.Hide();
                gbxDueños.Hide();
                gbxVet.Hide();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ocultar(2);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ocultar(3);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }

      
    }


