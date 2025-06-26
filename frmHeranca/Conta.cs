using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmHeranca
{
    public class Conta
    {
        private double saldo;
        private double valor;
        private int numeroConta;

        public double Saldo { get => saldo; set => saldo = value; }
        public double Valor { get => valor; set => valor = value; }
        public int NumeroConta { get => numeroConta; set => numeroConta = value; }

        public void depositar()
        {
            Saldo = Valor + Valor;

            return this.saldo;
        }
        public void sacar()
        {

        }
        public void transferir()
        {

        }
       
    }
}
