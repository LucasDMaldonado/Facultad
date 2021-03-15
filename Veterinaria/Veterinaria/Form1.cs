using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria
{
    public partial class Form1 : Form
    {
        int x = 0;
        int y = 0;

        public Form1()
        {
            InitializeComponent();
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void btnMascota_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            frmMascota fr = new frmMascota();
            fr.TopLevel = false;
            fr.Dock = DockStyle.Fill;
            panel1.Controls.Add(fr);
            fr.Show();
        }

        private void btnVeterinarios_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            frmVeterinario fr = new frmVeterinario();
            fr.TopLevel = false;
            fr.Dock = DockStyle.Fill;
            panel1.Controls.Add(fr);
            fr.Show();

        }

        private void btnDueños_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            frmDueño fr = new frmDueño();
            fr.TopLevel = false;
            fr.Dock = DockStyle.Fill;
            panel1.Controls.Add(fr);
            fr.Show();
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            frmReporteMascota fr = new frmReporteMascota();
            fr.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalirX_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void mascotasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            frmMascota fr = new frmMascota();
            fr.TopLevel = false;
            fr.Dock = DockStyle.Fill;
            panel1.Controls.Add(fr);
            fr.Show();
        }

        private void veterinariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            frmVeterinario fr = new frmVeterinario();
            fr.TopLevel = false;
            fr.Dock = DockStyle.Fill;
            panel1.Controls.Add(fr);
            fr.Show();
        }

        private void dueñosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            frmDueño fr = new frmDueño();
            fr.TopLevel = false;
            fr.Dock = DockStyle.Fill;
            panel1.Controls.Add(fr);
            fr.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
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

        private void mascotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            frmReporteMascota fr = new frmReporteMascota();
            fr.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
