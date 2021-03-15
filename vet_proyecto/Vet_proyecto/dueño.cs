using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vet_proyecto
{
    public class Dueño : Persona
    {
        int Cod_Dueño;

        //CONSTRUCTORES:

        public Dueño() : base()
        {
            Cod_Dueño = 0;
        }

        public Dueño(int cdu, string nom, string ape, string dir, int tel, string mail) : base(nom, ape, dir, tel, mail)
        {
            Cod_Dueño = cdu;
        }

        //PROPIEDADES:
        public int pCod_dueño
        {
            set { Cod_Dueño = value; }
            get { return Cod_Dueño; }
        }

        //METODOS:
        public string DueñotoString()
        {
            return base.toStringPersona() +
                   "Código de Dueño: " + pCod_dueño.ToString();
        }
    }
}
