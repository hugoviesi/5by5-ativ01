using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_2._0_ex1
{
    class Proprietario
    {
        public int cpf;
        public string nome;
        public string endereco;
        public string dataNascimento;
        public string dataCompra;

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
        public string DataNascimento
        {
            get
            {
                return dataNascimento;
            }
            set
            {
                dataNascimento = value;
            }
        }
        public string DataCompra
        {
            get
            {
                return dataCompra;
            }
            set
            {
                dataCompra = value;
            }
        }

        public void ImprimirValores()
        {
            Console.WriteLine("CPF: " + cpf);
            Console.WriteLine("NOME: " + nome);
            Console.WriteLine("ENDEREÇO: " + endereco);
            Console.WriteLine("DATA DE NASCIMENTO: " + dataNascimento);
            Console.WriteLine("DATA DE COMPRA: " + dataCompra);
        }

    }
}
