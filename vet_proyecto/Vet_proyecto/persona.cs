using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vet_proyecto
{
    public abstract class Persona
    {
        string Nombres;
        string Apellidos;
        string Direccion;
        int Telefono;
        string Email;

        //CONSTRUCTORES:

        public Persona()
        {
            Nombres = "";
            Apellidos = "";
            Direccion = "";
            Telefono = 0;
            Email = "";
        }


        public Persona(string nom, string ape, string dir, int tel, string mail)
        {
            Nombres = nom;
            Apellidos = ape;
            Direccion = dir;
            Telefono = tel;
            Email = mail;
        }

        //PROPIEDADES:

        public string pNombres
        {
            set { Nombres = value; }
            get { return Nombres; }
        }

        public string pApellidos
        {
            set { Apellidos = value; }
            get { return Apellidos; }
        }

        public string pDireccion
        {
            set { Direccion = value; }
            get { return Direccion; }
        }

        public int pTelefono
        {
            set { Telefono = value; }
            get { return Telefono; }
        }

        public string pEmail
        {
            set { Email = value; }
            get { return Email; }
        }

        //METODOS:
        public string toStringPersona()
        {
            return "Nombres: " + pNombres +
                    "Apellidos: " + pApellidos +
                    "Dirección: " + pDireccion +
                    "Teléfono: " + pTelefono.ToString() +
                    "E-mail :" + pEmail;


        }
    }
}
