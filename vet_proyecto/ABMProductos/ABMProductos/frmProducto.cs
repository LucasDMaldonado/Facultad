using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ABMProductos
{
    public partial class frmProducto : Form
    {
        AccesoDatos oDato = new AccesoDatos(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Usuario\Desktop\ABMProductos\DBFProducto.mdb");
        const int tam = 10;
        Producto[] ap = new Producto[tam];
        int c;
        bool nuevo;
        public frmProducto()
        {
            InitializeComponent();
            for (int i = 0; i < tam; i++)
            {
                ap[i] = null;
            }
            nuevo = false;
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {


            cargarCombo(cboMarca,"Marca");
            cargarLista("producto");
            Habilitar(false);

        }
        private bool validar()
        {
            if(txtCodigo.Text=="")
            {
                MessageBox.Show("debe ingresar un codigo");
                txtCodigo.Focus();
                return false;
            }
            return true;
        }
        private void cargarLista(string nombreTabla)
        {
            c = 0;
            lstProducto.Items.Clear();
            oDato.leerTabla(nombreTabla);
            while (oDato.pLector.Read())
            {
               
                Producto p = new Producto();
                if (!oDato.pLector.IsDBNull(0))
                    p.pCodigo = oDato.pLector.GetInt32(0);
                if (!oDato.pLector.IsDBNull(1))
                    p.pDetalle = oDato.pLector["detalle"].ToString();
                if (!oDato.pLector.IsDBNull(2))
                    p.pTipo = oDato.pLector.GetInt32(2);
                if (!oDato.pLector.IsDBNull(3))
                    p.pMarca = oDato.pLector.GetInt32(3);
                if (!oDato.pLector.IsDBNull(4))
                    p.pPrecio = oDato.pLector.GetDouble(4);
                if (!oDato.pLector.IsDBNull(5))
                    p.pFecha = oDato.pLector.GetDateTime(5);
                ap[c] = p;
                c++;


            }
            oDato.pLector.Close();
            oDato.desconectar();
            for (int i = 0; i < c; i++)

            {
                lstProducto.Items.Add(ap[i]).ToString();
            }
        }
        private void cargarCombo( ComboBox combo, string nombreTabla)
        {
            DataTable DT = new DataTable();
            DT = oDato.consultarTabla(nombreTabla);
            combo.DataSource = DT;
            combo.ValueMember = DT.Columns[0].ColumnName;
            combo.DisplayMember = DT.Columns[1].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private bool existe(int pk)
        {
            for (int i = 0; i < c; i++)
            {
                if (ap[i].pCodigo == pk)
                    return true;
            }
            return false;
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                string consultaSQL = "";
                Producto p = new Producto();
                p.pCodigo = Convert.ToInt32(txtCodigo.Text);
                p.pDetalle = txtDetalle.Text;
                p.pMarca = Convert.ToInt32(cboMarca.SelectedValue);
                if (rbtNoteBook.Checked)
                    p.pTipo = 1;
                else
                    p.pTipo = 2;
                p.pPrecio = Convert.ToInt32(txtPrecio.Text);
                p.pFecha = dtpFecha.Value;

                if (nuevo)
                {
                    if (!existe(p.pCodigo))
                    {
                        consultaSQL = "INSERT INTO PRODUCTO ( codigo,detalle,marca,tipo,precio,fecha)"
                            + "VALUES("
                            + p.pCodigo + ",'"
                            + p.pDetalle + "',"
                            + p.pMarca + ","
                            + p.pTipo + ","
                            + p.pPrecio + ",'"
                            + p.pFecha + "')";
                        oDato.actualizarBD(consultaSQL);
                        cargarLista("producto");
                    }
                    else
                    {
                        MessageBox.Show("este producto ya se encuentra registrado...");
                    }

                }

                else
                {
                    consultaSQL = "UPDATE PRODUCTO"
                        + " SET"
                        + " detalle = '" + p.pDetalle + "',"
                        + " marca =  " + p.pMarca + ","
                        + " tipo = " + p.pTipo + ","
                        + " precio = " + p.pPrecio + ","
                        + " fecha = '" + p.pFecha + "'"
                        + " WHERE codigo = " + p.pCodigo;
                    oDato.actualizarBD(consultaSQL);
                    cargarLista("producto");
                }
                Habilitar(false);
                nuevo = false;
            }
        }

        
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            Habilitar(true);
            Limpiar();
            txtCodigo.Focus();

        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Habilitar(false);
            nuevo = false;

        }

        private void lstProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarCampos(lstProducto.SelectedIndex);
        }
        
        private void actualizarCampos(int posicion)
        {
            txtCodigo.Text = ap[posicion].pCodigo.ToString();
            txtDetalle.Text = ap[posicion].pDetalle;
            txtPrecio.Text = ap[posicion].pPrecio.ToString();
            cboMarca.SelectedValue = ap[posicion].pMarca;
            if (ap[posicion].pTipo == 1)
                rbtNoteBook.Checked = true;
            else
                rbtNetBook.Checked = true;
            dtpFecha.Value = ap[posicion].pFecha;
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            txtCodigo.Enabled = false;
            txtDetalle.Focus();


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("esta seguro de querer eliminar este producto",
                                "ELIMINANDO",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning,
                                MessageBoxDefaultButton.Button2)==DialogResult.Yes)
            {
                string consultaSQL = "DELETE FROM producto WHERE codigo ="
                                    + ap[lstProducto.SelectedIndex].pCodigo;
                oDato.actualizarBD(consultaSQL);
                cargarLista("PRODUCTO");
            }
        }
        private void Habilitar(bool x)
        {
            txtCodigo.Enabled = x;
            txtDetalle.Enabled =x;
            txtPrecio.Enabled = x;
            rbtNetBook.Enabled =x;
            rbtNoteBook.Enabled =x;
            cboMarca.Enabled = x;
            dtpFecha.Enabled = x;
            btnCancelar.Enabled =x;
            btnGrabar.Enabled = x;



            btnEditar.Enabled = !x;
            btnNuevo.Enabled = !x;
            btnSalir.Enabled = !x;
            lstProducto.Enabled = !x;
        }
        private void Limpiar()
        {
            txtCodigo.Clear();
            txtDetalle.Text = "";
            txtPrecio.Text = string.Empty;
            cboMarca.SelectedIndex = -1;
            rbtNetBook.Checked = false;
            rbtNoteBook.Checked = false;
            dtpFecha.Value = DateTime.Today;
        }


        private void CboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
