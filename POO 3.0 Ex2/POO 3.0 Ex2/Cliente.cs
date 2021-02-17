using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_3._0_Ex2
{
    class Cliente //Classe chamada Cliente
    {
        //Atributos
        public int cpf; 
        public string nome;
        public string endereco;

        public int Cpf
        {
            get
            {
                return cpf;
            }
            set
            {
                cpf = value;
            }
        }
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }
        public string Endereco
        {
            get
            {
                return endereco;
            }
            set
            {
                endereco = value;
            }
        }

        public void ImprimirDados()
        {
            Console.WriteLine("CPF: " + cpf);
            Console.WriteLine("NOME: " + nome);
            Console.WriteLine("ENDEREÇO: " + endereco);
        }      

    }
}
