using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacion_ejercisios2
{
    class Cliente
    {
        string nombre;
        string apellido;
        int documento;
        bool sexo;

        public Cliente()
        {
            nombre = "";
            apellido = "";
            documento = 0;
            sexo = true;
        }
        public Cliente(string nom,string ape, int doc, bool sex)
        {
            nombre = nom;
            apellido = ape;
            documento = doc;
            sexo = sex;

        }
        public string pNombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public string pApellido
        {
            set { apellido = value; }
            get { return apellido; }
        }
        public int pDocumento
        {
            set { documento = value;}
            get { return documento; }
        }
        public bool pSexo
        {
            set { sexo = value; }
            get { return sexo; }
        }
        public string ToStringCliente()
        {
            string genero = "";
            if (sexo == true)
            {
                genero = "Femenino";
            }
            else
                genero = "Masculino";
            return 
                "Nombre: " + nombre + " " + apellido + 
                "\n Documento: " + documento + 
                "\nSexo: " + genero;


        }

        

    }
}
