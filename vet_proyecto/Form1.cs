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
    public partial class CyberVet : Form
    {
        AccesoDatos OD = new AccesoDatos(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Usuario\source\repos\Vet_proyecto\Veterinaria.mdb");
        const int tam = 100;
        Mascota[] MA = new Mascota[tam];
        Dueño[] DU = new Dueño[tam];
        Veterinario[] VE = new Veterinario[tam];
        int c;
        int focus;
        int lista;
        int combo;
        bool nuevo;
        public CyberVet()
        {
            InitializeComponent();
            for (int i = 0; i < tam; i++)
            {
                MA[i] = null;
            }
            c = 0;
            focus = 0;
            lista = 0;
            combo = 0;
            nuevo = true;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                lista++;

                if (lista == 1)
                {
                    cargarListas("Mascotas");

                }
                else
                    if (lista == 2)
                {
                    cargarListas("Dueños");

                }
                else
                    if (lista == 3)
                {
                    cargarListas("Veterinarios");

                }
            }
            for (int i = 0; i < 3; i++)
            {
                combo++;

                if (combo == 1)
                {
                    cargarCombo(cbotipo, "Tipos_Animal");

                }
                else
                    if (combo == 2)
                {
                    cargarCombo(cboDueño, "Dueños");

                }
                else
                    if (combo == 3)
                {
                    cargarCombo(cboVet, "Veterinarios");

                }
            }
            ocultar(0);
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
            nuevo = false;
            txtID.Enabled = false;
            txtMascota.Focus();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Limpiar();
            ocultar(1);
            txtID.Enabled = true;
            nuevo = true;
            focus = 1;


        }

        private void ocultar(int x)

        {
            if (x == 1)
            {
                btnBorrar.Show();
                BtnCancelar.Show();
                btnCargar.Show();
                btnEditar.Show();
                btnReport.Show();
                gbxMascotas.Show();
                gbxDueños.Hide();
                gbxVet.Hide();
              

            }
            else
                  if (x == 2)
            {
                btnBorrar.Show();
                BtnCancelar.Show();
                btnCargar.Show();
                btnEditar.Show();
                btnReport.Show();
                gbxMascotas.Hide();
                gbxDueños.Show();
                gbxVet.Hide();
                

            }
            else
                  if (x == 3)
            {
                btnBorrar.Show();
                BtnCancelar.Show();
                btnCargar.Show();
                btnEditar.Show();
                btnReport.Show();
                gbxMascotas.Hide();
                gbxDueños.Hide();
                gbxVet.Show();
               


            }
            else
                  if (x == 0)
            {
                btnBorrar.Hide();
                BtnCancelar.Hide();
                btnCargar.Hide();
                btnEditar.Hide();
                btnReport.Hide();
                gbxMascotas.Hide();
                gbxDueños.Hide();
                gbxVet.Hide();
             
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Limpiar();
            ocultar(2);
            txtIdDueño.Enabled = true;
            focus = 2;
            nuevo = true;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Limpiar();
            ocultar(3);
            txtIDvet.Enabled = true;
            focus = 3;
            nuevo = true;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("esta seguro de querer eliminar este este elemento",
                                    "ELIMINANDO",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning,
                                    MessageBoxDefaultButton.Button2) == DialogResult.Yes) ;
                //{
                //    string consultaSQL = "DELETE FROM producto WHERE codigo ="
                //                        + ap[lstProducto.SelectedIndex].pCodigo;
                //    oDato.actualizarBD(consultaSQL);
                //    cargarLista("PRODUCTO");
                //}
            }
        }
        private void Limpiar()
        {
            txtID.Clear();
            txtIdDueño.Clear();
            txtIDvet.Clear();
            txtdescrip.Clear();
            txtMascota.Clear();
            txtnombre.Clear();
            txtnombrevet.Clear();
            txtApellido.Clear();
            txtApellidovet.Clear();
            txtcallevet.Clear();
            txtMalidvet.Clear();
            txtTelVet.Clear();
            txtTel.Clear();
            txtMail.Clear();
            txtCalle.Clear();
            cboDueño.SelectedIndex = -1;
            cbotipo.SelectedIndex = -1;
            cboVet.SelectedIndex = -1;
            rbtHembra.Checked = false;
            rbtMacho.Checked = false;
            dtpFec_nac.Value = DateTime.Now;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            ocultar(0);
            Limpiar();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (focus == 1)
            {
                txtID.Enabled = false;
                txtMascota.Focus();
                nuevo = false;

            }
            else
                if (focus == 2)
            {
                txtIdDueño.Enabled = false;
                txtnombre.Focus();
                nuevo = false;

            }
            else
                if (focus == 3)
            {
                txtIDvet.Enabled = false;
                txtnombrevet.Focus();
                nuevo = false;

            }
        }
        private void actualizarCampos(int posicion)
        {
            if (focus == 1)
            {
                txtID.Text = MA[posicion].pCodigo.ToString();
                txtdescrip.Text = MA[posicion].pDescripcion;
                txtMascota.Text = MA[posicion].pnombre;
                cboDueño.SelectedValue = MA[posicion].pDueño;
                cboVet.SelectedValue = MA[posicion].pVet;
                cbotipo.SelectedValue = MA[posicion].pTipo;
                if (MA[posicion].pTipo == 1)
                    rbtHembra.Checked = true;
                else
                    rbtMacho.Checked = true;
                dtpFec_nac.Value = MA[posicion].pFecha;
            }
            if (focus == 2)
            {
                txtIdDueño.Text = DU[posicion].pCod_dueño.ToString();
                txtCalle.Text = DU[posicion].pDireccion;
                txtApellido.Text = DU[posicion].pApellidos;
                txtnombre.Text = DU[posicion].pNombres;
                txtTel.Text = DU[posicion].pTelefono.ToString();
                txtMail.Text = DU[posicion].pEmail;
            }
            if (focus == 3)
            {
                txtIDvet.Text = VE[posicion].pCodigo_Veterinario.ToString();
                txtcallevet.Text = VE[posicion].pDireccion;
                txtApellidovet.Text = VE[posicion].pApellidos;
                txtnombrevet.Text = VE[posicion].pNombres;
                txtTelVet.Text = VE[posicion].pTelefono.ToString();
                txtMalidvet.Text = VE[posicion].pEmail;
            }
        }
        private void cargarListas(string nombreTabla)
        {
            if (lista == 1)
            {
                nombreTabla = "Mascotas";
                c = 0;
                lstMascota.Items.Clear();
                OD.leerTabla(nombreTabla);
                while (OD.pLector.Read())
                {

                    Mascota M = new Mascota();
                    if (!OD.pLector.IsDBNull(0))
                        M.pCodigo = OD.pLector.GetInt32(0);
                    if (!OD.pLector.IsDBNull(1))
                        M.pnombre = OD.pLector.GetString(1);
                    if (!OD.pLector.IsDBNull(2))
                        M.pDescripcion = OD.pLector.GetString(2);
                    if (!OD.pLector.IsDBNull(3))
                        M.pFecha = OD.pLector.GetDateTime(3);
                    if (!OD.pLector.IsDBNull(4))
                        M.pTipo = OD.pLector.GetInt32(4);
                    if (!OD.pLector.IsDBNull(5))
                        M.pDueño = OD.pLector.GetInt32(5);
                    if (!OD.pLector.IsDBNull(6))
                        M.pSexo = OD.pLector.GetInt32(6);
                    if (!OD.pLector.IsDBNull(7))
                        M.pVet = OD.pLector.GetInt32(7);

                    MA[c] = M;
                    c++;


                }
                OD.pLector.Close();
                OD.desconectar();
                for (int i = 0; i < c; i++)

                {
                    lstMascota.Items.Add(MA[i].pCodigo + " - " + MA[i].pnombre).ToString();
                }
            }
            else
                if (lista == 2)
            {
                nombreTabla = "Dueños";
                c = 0;
                lstDueños.Items.Clear();
                OD.leerTabla(nombreTabla);
                while (OD.pLector.Read())
                {

                    Dueño d = new Dueño();
                    if (!OD.pLector.IsDBNull(0))
                        d.pCod_dueño = OD.pLector.GetInt32(0);
                    if (!OD.pLector.IsDBNull(1))
                        d.pNombres = OD.pLector.GetString(1);
                    if (!OD.pLector.IsDBNull(2))
                        d.pApellidos = OD.pLector.GetString(2);
                    if (!OD.pLector.IsDBNull(3))
                        d.pDireccion = OD.pLector.GetString(3);
                    if (!OD.pLector.IsDBNull(4))
                        d.pTelefono = OD.pLector.GetInt32(4);
                    if (!OD.pLector.IsDBNull(5))
                        d.pEmail = OD.pLector.GetString(5);

                    DU[c] = d;
                    c++;


                }
                OD.pLector.Close();
                OD.desconectar();
                for (int i = 0; i < c; i++)

                {
                    lstDueños.Items.Add(DU[i].pCod_dueño + " - " + DU[i].pNombres).ToString();
                }
            }
            else
                if (lista == 3)
            {
                nombreTabla = "Veterinarios";
                c = 0;
                lstVet.Items.Clear();
                OD.leerTabla(nombreTabla);
                while (OD.pLector.Read())
                {

                    Veterinario v = new Veterinario();
                    if (!OD.pLector.IsDBNull(0))
                        v.pCodigo_Veterinario = OD.pLector.GetInt32(0);
                    if (!OD.pLector.IsDBNull(1))
                        v.pNombres = OD.pLector.GetString(1);
                    if (!OD.pLector.IsDBNull(2))
                        v.pApellidos = OD.pLector.GetString(2);
                    if (!OD.pLector.IsDBNull(3))
                        v.pTelefono = OD.pLector.GetInt32(3);
                    if (!OD.pLector.IsDBNull(4))
                        v.pDireccion = OD.pLector.GetString(4);
                    if (!OD.pLector.IsDBNull(5))
                        v.pEmail = OD.pLector.GetString(5);
                    //if (!OD.pLector.IsDBNull(6))
                    //    v.pEspecialista = OD.pLector.GetBoolean(6);


                    VE[c] = v;
                    c++;


                }
                OD.pLector.Close();
                OD.desconectar();
                for (int i = 0; i < c; i++)

                {
                    lstVet.Items.Add(VE[i].pCodigo_Veterinario + " - " + VE[i].pNombres).ToString();
                }
            }
        }
        private bool validar()
        {
            if (focus == 1)
            {
                if (string.IsNullOrWhiteSpace(txtID.Text) ||
                    string.IsNullOrWhiteSpace(txtMascota.Text) ||
                    string.IsNullOrWhiteSpace(txtdescrip.Text) ||
                    cboDueño.SelectedItem == null ||
                    cbotipo.SelectedItem == null ||
                    cboVet.SelectedItem == null ||
                    dtpFec_nac.Value >= DateTime.Now ||
                    rbtHembra.Checked == false &&
                    rbtMacho.Checked == false)
                {
                    MessageBox.Show("Ha olvidado ingresar un dato", "Error",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }


            if (focus == 2)
            {
                if (
                  string.IsNullOrWhiteSpace(txtIdDueño.Text) ||
                  string.IsNullOrWhiteSpace(txtCalle.Text) ||
                  string.IsNullOrWhiteSpace(txtApellido.Text) ||
                  string.IsNullOrWhiteSpace(txtnombre.Text) ||
                  string.IsNullOrWhiteSpace(txtTel.Text) ||
                  string.IsNullOrWhiteSpace(txtMail.Text)
                  )
                {
                    MessageBox.Show("Ha olvidado ingresar un dato", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }
            }
            if (focus == 3)
            {
                if (

                string.IsNullOrWhiteSpace(txtIDvet.Text) ||
                string.IsNullOrWhiteSpace(txtcallevet.Text) ||
                string.IsNullOrWhiteSpace(txtApellidovet.Text) ||
                string.IsNullOrWhiteSpace(txtnombrevet.Text) ||
                string.IsNullOrWhiteSpace(txtTelVet.Text) ||
                string.IsNullOrWhiteSpace(txtMalidvet.Text)
                )
                {
                    MessageBox.Show("Ha olvidado ingresar un dato", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }
            }
            return true;

        }
        private bool Existe(int pk)
        {
            if (focus == 1)
            {
                for (int i = 0; i < c; i++)
                {
                    if (MA[i].pCodigo == pk)
                        return true;
                }

            }

            if (focus == 2)
            {
                for (int i = 0; i < c; i++)
                {
                    if (DU[i].pCod_dueño == pk)
                        return true;
                }

            }

            if (focus == 3)
            {
                for (int i = 0; i < c; i++)
                {
                    if (VE[i].pCodigo_Veterinario == pk)
                        return true;
                }

            }
            return false;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

           
            if (focus == 1)
            {
                validar();
                string consultaSQL = "";
                Mascota m = new Mascota();
                m.pCodigo = Convert.ToInt32(txtID.Text);
                m.pnombre = txtMascota.Text;
                m.pDescripcion = txtdescrip.Text;
                m.pTipo = Convert.ToInt32(cbotipo.SelectedValue);
                m.pDueño = Convert.ToInt32(cboDueño.SelectedValue);
                m.pVet = Convert.ToInt32(cboVet.SelectedValue);
                if (rbtHembra.Checked)
                    m.pSexo = 1;
                else
                    m.pSexo = 2;

                m.pFecha = dtpFec_nac.Value;
                if (nuevo)
                {
                    if (!Existe(m.pCodigo))
                    {
                        consultaSQL = "INSERT INTO Mascotas ( id_Mascota,Nombre,Descripcion,Fec_Nacim,id_Tipo_Animal,Id_Dueño,Sexo,Id_Veterinario) "
                            + "VALUES ("
                            + m.pCodigo + ",'"
                            + m.pnombre + "','"
                            + m.pDescripcion + "','"
                            + m.pFecha + "',"
                            + m.pTipo + ","
                            + m.pDueño + ","
                            + m.pSexo + ","
                            + m.pVet + ")";
                        OD.actualizarBD(consultaSQL);
                        lista = 1;
                        cargarListas("Mascotas");
                    }
                    else
                    {
                        MessageBox.Show("esta Mascota ya se encuentra registrada...");
                    }

                }




                else
                if (nuevo==false)
                {
                    consultaSQL = "UPDATE Mascotas"
                        + " SET"
                        + "Nombre = '" + m.pnombre + "',"
                        + "Descripcion = '" + m.pDescripcion + "',"
                        + "Fec_nacim = '" + m.pFecha + "',"
                        + "id_Tipo_Animal =" + m.pTipo + ","
                        + "id_Dueño = " + m.pDueño + ","
                        + "sexo =" + m.pSexo + ","
                        + "id_Veterinario =" + m.pVet
                    + " WHERE codigo = " + m.pCodigo;
                    OD.actualizarBD(consultaSQL);
                    lista = 1;
                    cargarListas("Mascotas");
                }
            }
            if (focus == 2)
            {
                validar();
                string consultaSQL = "";
                Dueño d = new Dueño();
                d.pCod_dueño = Convert.ToInt32(txtIdDueño.Text);
                d.pNombres = txtnombre.Text;
                d.pApellidos = txtApellido.Text;
                d.pDireccion = txtCalle.Text;
                d.pTelefono = Convert.ToInt32(txtTel.Text);
                d.pEmail = txtMail.Text;

                if (nuevo)
                {
                    if (!Existe(d.pCod_dueño))
                    {
                        consultaSQL = "INSERT INTO Dueños(Id_Dueño,Nombres,Apellidos,Calle,Telefono,[E-mail] )"
                            + "VALUES("
                            + d.pCod_dueño + ",'"
                            + d.pNombres + "','"
                            + d.pApellidos + "','"
                            + d.pDireccion + "',"
                            + d.pTelefono + ",'"
                            + d.pEmail + "')";

                        OD.actualizarBD(consultaSQL);
                        lista = 2;
                        cargarListas("Dueños");
                    }
                    else
                    {
                        MessageBox.Show("el Dueño ya se encuentra registrado...");
                    }

                }

                else
                {
                    consultaSQL = "UPDATE Dueños"
                        + " SET"
                        + " Nombre = '" + d.pNombres + "',"
                        + " Apellidos = '" + d.pApellidos + "',"
                        + " Calle = '" + d.pDireccion + "',"
                        + " Telefono =" + d.pTelefono + ","
                        + " [E-mail] = '" + d.pEmail + "'"
                        + " WHERE id_Dueño = " + d.pCod_dueño;
                    OD.actualizarBD(consultaSQL);
                    lista = 2;
                    cargarListas("Dueños");
                }
            }
            if (focus == 3)
            {
                validar();
                string consultaSQL = "";
                Veterinario v = new Veterinario();
                v.pCodigo_Veterinario = Convert.ToInt32(txtIDvet.Text);
                v.pNombres = txtnombrevet.Text;
                v.pApellidos = txtApellidovet.Text;
                v.pDireccion = txtcallevet.Text;
                v.pTelefono = Convert.ToInt32(txtTelVet.Text);
                v.pEmail = txtMalidvet.Text;
                if (cbxEspecialista.Checked)
                {
                    v.pEspecialista = 1;
                }
                else
                {
                    v.pEspecialista = 0;
                }

                if (nuevo)
                {
                    if (!Existe(v.pCodigo_Veterinario))
                    {
                        consultaSQL = "INSERT INTO Veterinarios (Id_Veterinario,Apellidos,Nombres,Telefono,Direccion,[E-mail],Especialista)"
                            + " VALUES ("
                            + v.pCodigo_Veterinario + ",'"
                            + v.pApellidos + "','"
                            + v.pNombres + "',"
                            + v.pTelefono + ",'"
                            + v.pDireccion + "','"
                            + v.pEmail + "',"
                            +v.pEspecialista + ")";

                        OD.actualizarBD(consultaSQL);
                        lista = 3;
                        cargarListas("Veterinarios");
                    }
                    else
                    {
                        MessageBox.Show("el Veterinario ya se encuentra registrado...");
                    }

                }

                if (nuevo ==false)
                {
                    consultaSQL = "UPDATE Veterinarios"
                        + " SET"
                        + " Nombre = '" + v.pNombres + "',"
                        + " Apellidos = '" + v.pApellidos + "',"
                        + " Direccion = '" + v.pDireccion + "',"
                        + " Telefono =" + v.pTelefono + ","
                        + " [E-mail] = " + v.pEmail + "',"
                        + " Especialista = " + v.pEspecialista
                        + " WHERE id_Veterinario = " + v.pCodigo_Veterinario;
                    OD.actualizarBD(consultaSQL);
                    lista = 3;
                    cargarListas("Veterinarios");
                }
            }

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarCampos(lstVet.SelectedIndex);
        }

        private void lstDueños_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarCampos(lstDueños.SelectedIndex);
        }

        private void lstMascota_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarCampos(lstMascota.SelectedIndex);
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
           

        }

    }
}

