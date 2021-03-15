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
    public partial class frmMascota : Form
    {
        OleDbCommand comand;
        OleDbConnection conexion;
        OleDbDataReader lector;
        string cadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Usuario\Desktop\dbfMascotas.mdb";
        DataTable tabla;
        int band = 0;
        int c;
        const int tam = 100;
        Mascota[] ma = new Mascota[tam];
        public frmMascota()
        {
            InitializeComponent();
            for (int i = 0; i < tam; i++)
            {
                ma[i] = null;
            }
            listarMascotas("Mascota");
            limpiarCampos();
            habilitar(false, true, true, true, false, false);
            txtCodigo.Enabled = false;
            cargarCombo(cboEspecie, "Especie");
            cargarCombo(cboVeterinario, "Veterinario");
            cargarCombo(cboDueño, "Dueño");
        }

        public void listarMascotas(string nombreTabla)
        {
            conectar();
            c = 0;
            comand.CommandText = "SELECT * FROM " + nombreTabla + " ORDER BY 1";
            lector = comand.ExecuteReader();
            while (lector.Read())
            {
                ma[c] = new Mascota();
                if (!lector.IsDBNull(0))
                    ma[c].pCodigo = lector.GetInt32(0);
                if (!lector.IsDBNull(1))
                    ma[c].pNombre = lector.GetString(1);
                if (!lector.IsDBNull(2))
                    ma[c].pEspecie = lector.GetInt32(2);
                if (!lector.IsDBNull(3))
                    ma[c].pSexo = lector.GetInt32(3);
                if (!lector.IsDBNull(4))
                    ma[c].pFechaNacimiento = lector.GetDateTime(4);
                if (!lector.IsDBNull(5))
                    ma[c].pVeterinario = lector.GetInt32(5);
                if (!lector.IsDBNull(6))
                    ma[c].pDueño = lector.GetInt32(6);
                c++;
            }

            lector.Close();
            conexion.Close();
            lstMascotas.Items.Clear();
            for (int i = 0; i < c; i++)
            {
                lstMascotas.Items.Add(ma[i].pCodigo + " - " + ma[i].pNombre);
            }
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

        public void generaraCodigo(string nombreTabla)
        {
            listarMascotas("Mascota");
            int codigo = 1;
            for (int i = 0; i < c; i++)
            {
                if (ma[i].pCodigo == codigo)
                {
                    codigo++;
                }
                else
                    txtCodigo.Text = Convert.ToString(codigo);
            }
            txtCodigo.Text = Convert.ToString(codigo);
        }
        public void rellenarDatos(int i)
        {
            txtCodigo.Text = Convert.ToString(ma[i].pCodigo);
            txtNombre.Text = ma[i].pNombre;
            cboEspecie.SelectedIndex = ma[i].pEspecie - 1;
            if (ma[i].pSexo == 1)
                rbtMacho.Checked = true;
            else
                rbtHembra.Checked = true;
            dtpFechaNac.Value = ma[i].pFechaNacimiento;
            cboVeterinario.SelectedIndex = ma[i].pVeterinario - 1;
            cboDueño.SelectedIndex = ma[i].pDueño - 1;
        }
        public void conectar()
        {
            conexion = new OleDbConnection(cadenaConexion);
            conexion.Open();
            comand = new OleDbCommand();
            comand.Connection = conexion;
            comand.CommandType = CommandType.Text;
        }

        public void habilitar(bool tb, bool n, bool ed, bool el, bool a, bool c)
        {
            habilitarTexBox(tb);
            btnNuevo.Enabled = n;
            btnEditar.Enabled = ed;
            btnEliminar.Enabled = el;
            btnAceptar.Enabled = a;
            btnCancelar.Enabled = c;
        }

        public void habilitarTexBox(bool tb)
        {
            txtNombre.Enabled = tb;
            cboEspecie.Enabled = tb;
            rbtMacho.Enabled = tb;
            rbtHembra.Enabled = tb;
            dtpFechaNac.Enabled = tb;
            cboVeterinario.Enabled = tb;
            cboDueño.Enabled = tb;
            lstMascotas.Enabled = !tb;
        }

        public void limpiarCampos()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            cboEspecie.SelectedIndex = -1;
            rbtHembra.Checked = false;
            rbtMacho.Checked = false;
            dtpFechaNac.Value = DateTime.Today;
            cboVeterinario.SelectedIndex = -1;
            cboDueño.SelectedIndex = -1;
        }

        public bool validarDatos()
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Ingrese un Codigo");
                txtCodigo.Focus();
                return false;
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese un Nombre");
                txtNombre.Focus();
                return false;
            }
            if (band == 1)
            {
                conectar();
                comand.CommandText = "SELECT * FROM Mascota";
                lector = comand.ExecuteReader();
                while (lector.Read())
                {
                    if (Convert.ToInt32(txtCodigo.Text) == lector.GetInt32(0))
                    {
                        MessageBox.Show("Ha ingresado un Codigo ya guardado");
                        txtCodigo.Text = "";
                        txtCodigo.Focus();
                        return false;
                    }
                }
                conexion.Close();
            }
            if (cboEspecie.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una Especie");
                cboEspecie.Focus();
                return false;
            }
            if (rbtHembra.Checked == false && rbtMacho.Checked == false)
            {
                MessageBox.Show("Seleccione un Sexo");
                return false;
            }
            if (cboVeterinario.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una Veterinario");
                cboVeterinario.Focus();
                return false;
            }
            if (cboDueño.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una Dueño");
                cboDueño.Focus();
                return false;
            }
            return true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            band = 1;
            habilitar(true, false, false, false, true, true);
            txtCodigo.Enabled = false;
            limpiarCampos();
            generaraCodigo("Mascota");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            band = 2;
            if (lstMascotas.SelectedIndex > -1)
            {
                habilitar(true, false, false, false, true, true);
                rellenarDatos(lstMascotas.SelectedIndex);
                txtCodigo.Enabled = false;
            }
            else
            {
                MessageBox.Show("Seleccione una mascota de la lista que quiera editar");
                habilitar(false, true, true, true, false, false);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            band = 3;
            if (lstMascotas.SelectedIndex > -1)
            {

                habilitar(false, false, false, false, true, true);
                rellenarDatos(lstMascotas.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Seleccione una mascota de la lista que quiera eliminar");
                habilitar(false, true, true, true, false, false);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarDatos() == true)
            {
                Mascota m = new Mascota();
                m.pCodigo = Convert.ToInt32(txtCodigo.Text);
                m.pNombre = txtNombre.Text;
                m.pEspecie = cboEspecie.SelectedIndex + 1;
                if (rbtMacho.Checked == true)
                    m.pSexo = 1;
                else
                    m.pSexo = 2;
                m.pFechaNacimiento = dtpFechaNac.Value;
                m.pVeterinario = cboVeterinario.SelectedIndex + 1;
                m.pDueño = cboDueño.SelectedIndex + 1;
                conectar();
                if (band == 1)
                {
                    comand.CommandText = "INSERT INTO Mascota (codigo,nombre,especie,sexo,fechaNacimiento,dueño,veterinario)"
                                         + "VALUES ("
                                         + m.pCodigo + ",'"
                                         + m.pNombre + "',"
                                         + m.pEspecie + ","
                                         + m.pSexo + ",'"
                                         + m.pFechaNacimiento + "',"
                                         + m.pVeterinario + ","
                                         + m.pDueño + ")";
                    comand.ExecuteNonQuery();
                }
                else
                {
                    if (band == 2)
                    {
                        comand.CommandText = " UPDATE Mascota " +
                                             " SET nombre = '" + m.pNombre + "'," +
                                             "     especie = " + m.pEspecie + " ," +
                                             "     sexo = " + m.pSexo + " ," +
                                             "    fechaNacimiento = '" + m.pFechaNacimiento + " '," +
                                             "    veterinario = " + m.pVeterinario + "," +
                                             "        dueño = " + m.pDueño +
                                             " WHERE codigo = " + m.pCodigo;
                        comand.ExecuteNonQuery();
                    }
                    else
                    {
                        comand.CommandText = " DELETE FROM Mascota " +
                                                " WHERE codigo = " + m.pCodigo;
                        comand.ExecuteNonQuery();

                    }
                }
                conexion.Close();
                listarMascotas("Mascota");
                habilitar(false, true, true, true, false, false);
                limpiarCampos();
                lstMascotas.SelectedIndex = -1;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            listarMascotas("Mascota");
            limpiarCampos();
            habilitar(false, true, true, true, false, false);
            cargarCombo(cboEspecie, "Especie");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
