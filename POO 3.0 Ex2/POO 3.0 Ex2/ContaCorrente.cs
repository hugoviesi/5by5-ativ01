using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_3._0_Ex2
{
    class ContaCorrente
    {
        public int agencia;
        public int numero;
        public float saldo;

        public int Agencia
        {
            get //Controla a leitura do atributo
            {
                return agencia;
            }
            set //Controla a escrita no atributo
            {
                agencia = value;
            }
        }

        public int Numero
        {
            get
            {
                return numero;
            }
            set
            {
                numero = value;
            }
        }
        public float Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                saldo = value;
            }
        }
        public void ImprimirSaldo()
        {
            Console.WriteLine("SALDO ATUAL: " + saldo);
        }

        public void Deposito(float valor)
        {
            this.saldo += valor;
        }

        public bool Saque(float valor)
        {
            if(this.saldo >= valor)
            {
                this.saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Transferir(float valor, ContaCorrente destino)
        {
            if (this.Saque(valor))
            {

                destino.Deposito(valor);
            }
        }
        public void ImprimirDados()
        {
            Console.WriteLine("AGÊNCIA: " + agencia);
            Console.WriteLine("NÚMERO: " + numero);
            Console.WriteLine("SALDO: " + saldo);
        }
    }
}
