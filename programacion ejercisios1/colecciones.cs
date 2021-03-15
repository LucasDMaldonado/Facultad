using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programacion_ejercisios1
{
    public partial class FrmColecciones : Form
    {
        public FrmColecciones()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstCuadroIzquierda.Items.Add("Enero");
            lstCuadroIzquierda.Items.Add("febrero");
            lstCuadroIzquierda.Items.Add("Marzo");
            lstCuadroIzquierda.Items.Add("Abril");
            lstCuadroIzquierda.Items.Add("Mayo");
            lstCuadroIzquierda.Items.Add("Junio");
            lstCuadroIzquierda.Items.Add("Julio");
            lstCuadroIzquierda.Items.Add("Agosto");
            lstCuadroIzquierda.Items.Add("septiembre");
            lstCuadroIzquierda.Items.Add("Octubre");
            lstCuadroIzquierda.Items.Add("Noviembre");
            lstCuadroIzquierda.Items.Add("Diciembre);");

        }

        private void btnPasarDerecha_Click(object sender, EventArgs e)
        {
            if (lstCuadroIzquierda.Items.Count == 0)
            {
                MessageBox.Show("no hay elementos para transferir");

            }
            else
            if (lstCuadroIzquierda.SelectedItem == null)
            {
                MessageBox.Show("Primero debes seleccionar un mes, para realizar esta accion");
            }
            else
                lstCuadroDerecha.Items.Add(lstCuadroIzquierda.SelectedItem);
            lstCuadroIzquierda.Items.Remove(lstCuadroIzquierda.SelectedItem);

        }


        private void btnPasarTodoDerecha_Click(object sender, EventArgs e)
        {
            if (lstCuadroIzquierda.Items.Count == 0)
            {
                MessageBox.Show("no hay elementos para transferir");

            }
            else
                for (int i = 0; i < lstCuadroIzquierda.Items.Count; i++)
                {
                    lstCuadroDerecha.Items.Add(lstCuadroIzquierda.Items[i]);
                }
            lstCuadroIzquierda.Items.Clear();
        }

        private void btnPasarTodoIzquierda_Click(object sender, EventArgs e)
        {
            if (lstCuadroDerecha.Items.Count == 0)
            {
                MessageBox.Show("no hay elementos para transferir");

            }
            else
                for (int i = 0; i < lstCuadroDerecha.Items.Count; i++)
                {
                    lstCuadroIzquierda.Items.Add(lstCuadroDerecha.Items[i]);
                }
            lstCuadroDerecha.Items.Clear();
        }
        private void btnPasarIzquierda_Click(object sender, EventArgs e)
        {
            if (lstCuadroDerecha.Items.Count == 0)
            {
                MessageBox.Show("no hay elementos para transferir");

            }
            else
            if (lstCuadroDerecha.SelectedItem == null)
            {
                MessageBox.Show("Primero debes seleccionar un mes, para realizar esta accion");
            }
            else
                lstCuadroIzquierda.Items.Add(lstCuadroDerecha.SelectedItem);
            lstCuadroDerecha.Items.Remove(lstCuadroDerecha.SelectedItem);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los cambios han sido registrados");
            Close();
        }
    }
}

