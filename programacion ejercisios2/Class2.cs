using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacion_ejercisios2
{
    class Cuenta : Cliente
    {
        int tipo_cuenta;
        int codigo;
        int num_cuenta;
        int saldo;

        public Cuenta() : base()
        {
            tipo_cuenta = 0;
            codigo = 0;
            num_cuenta = 0;
            saldo = 0;
        }
        public Cuenta(int tip_cue, int cod, int numcta, int sal, string no, string ap, int d, bool se) : base(no, ap, d, se)
        {
            tipo_cuenta = tip_cue;
            codigo = cod;
            num_cuenta = numcta;
            saldo = sal;
        }
        public int pTipo_cuenta
        {
            set { tipo_cuenta = value; }
            get { return tipo_cuenta; }
        }
        public int PCodigo
        {
            set { codigo = value; }
            get { return codigo; }

        }
        public int Pnumero_cuenta
        {
            set { num_cuenta = value; }
            get { return num_cuenta; }

        }
        public int pSaldo
        {
            set { saldo = value; }
            get { return saldo; }
        }
        public double LimiteCredito()
        {
            return (saldo / 12) * 5;
        }
        public string ToStringCuenta()
        {
            string texto = "";

            if (tipo_cuenta == 0)
            {
                texto = "caja de ahorro";
            }
            else
                texto = "cuenta corriente";
            return base.ToStringCliente() +
                "\nTipo de cuenta: " + texto +
                "\nNumero de cuenta: " + num_cuenta.ToString() +
                "\nSaldo: " + saldo.ToString();

        }
    }
}
