using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vet_proyecto
{
    public class Veterinario : Persona
    {
        int Cod_Veterinario;
       int Especialista;

        //CONSTRUCTORES:

        public Veterinario() : base()
        {
            Cod_Veterinario = 0;
            Especialista = 0;
        }

        public Veterinario(int codv, int esp, string nom, string ape, string dir, int tel, string mail) : base(nom, ape, dir, tel, mail)
        {
            Cod_Veterinario = codv;
            Especialista = esp;
        }

        //PROPIEDADES:

        public int pCodigo_Veterinario
        {
            set { Cod_Veterinario = value; }
            get { return Cod_Veterinario; }
        }

        public int pEspecialista
        {
            set { Especialista = value; }
            get { return Especialista; }
        }

        //METODOS:

        public string toStringVeterinario()
        {
            return base.toStringPersona() +
                   "Código de Veterinario: " + pCodigo_Veterinario.ToString()
                    +"Especialista: " + pEspecialista.ToString();
        }
    }
}
