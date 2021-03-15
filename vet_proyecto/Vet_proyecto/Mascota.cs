using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vet_proyecto
{
    class Mascota
    {
        int codigo;

        public int pCodigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        string nombre;

        public string pnombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        string Descripcion;

        public string pDescripcion
        {
            get { return Descripcion; }
            set { Descripcion = value; }
        }
        int sexo;

        public int pSexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        int vet;

        public int pVet
        {
            get { return vet; }
            set { vet = value; }
        }
        int tipo;

        public int pTipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        int dueño;

        public int pDueño
        {
            get { return dueño; }
            set { dueño = value; }
        }
        DateTime fec_nac;

        public DateTime pFecha
        {
            get { return fec_nac; }
            set { fec_nac = value; }
        }

        override public string ToString()
        {
            return codigo + " - " + Descripcion;
        }
    }
}
