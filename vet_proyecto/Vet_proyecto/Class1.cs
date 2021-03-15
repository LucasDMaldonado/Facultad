using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Vet_proyecto
{
    class AccesoDatos
    {
        private OleDbConnection conexion;
        private OleDbCommand comando;
        private OleDbDataReader lector;
        private string CadenaConexion;

        public OleDbDataReader pLector
        {
            set { lector = value; }
            get { return lector; }
        }
        public string pCadenaConexion
        {
            set { CadenaConexion = value; }
            get { return CadenaConexion; }
        }
        public AccesoDatos()
        {
            conexion = new OleDbConnection();
            comando = new OleDbCommand();
            lector = null;
            CadenaConexion = null;
        }
        public AccesoDatos(string cadenaConexion)

        {
            conexion = new OleDbConnection();
            comando = new OleDbCommand();
            lector = null;
            this.CadenaConexion = cadenaConexion;
        }
        public void conectar()
        {
            conexion.ConnectionString = CadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;

        }
        public void desconectar()
        {
            conexion.Close();
            conexion.Dispose();
        }
        public DataTable consultarTabla(string NombreTabla)
        {
            DataTable Tabla = new DataTable();
            conectar();
            comando.CommandText = "SELECT * FROM " + NombreTabla + " ORDER BY 2";
            Tabla.Load(comando.ExecuteReader());
            desconectar();
            return Tabla;
        }
        public void leerTabla(string nombreTabla)
        {
            conectar();
            comando.CommandText = "select * from " + nombreTabla;
            lector = comando.ExecuteReader();
        }


        public DataTable consultarBD(string consultaSQL)
        {
            DataTable Tabla = new DataTable();
            conectar();
            comando.CommandText = consultaSQL;
            Tabla.Load(comando.ExecuteReader());
            desconectar();
            return Tabla;
        }

        public void actualizarBD(string consultaSQL)

        {
            conectar();
            comando.CommandText = consultaSQL;
            comando.ExecuteNonQuery();
            desconectar();
        }

        public DataSet crystalrp()
        {
            conectar();
            string s = "SELECT * FROM Mascotas";
            comando.CommandText = s;
            OleDbDataAdapter adap = new OleDbDataAdapter(comando);
            DataSet ds = new DataSet();
            adap.Fill(ds, "Mascota");
            desconectar();
            return ds;

        }

    }
}
