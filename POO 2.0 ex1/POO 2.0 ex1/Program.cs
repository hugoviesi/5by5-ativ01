using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_2._0_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            Console.Clear();
            Proprietario p = new Proprietario();
            Veiculo v = new Veiculo();
            do
            {
                Console.WriteLine("==========================");
                Console.WriteLine("1- Informar todos os dados");
                Console.WriteLine("2- Imprimir todos os dados");
                Console.WriteLine("3- Sair");
                Console.WriteLine("==========================");
                Console.Write("\nDigite sua opção: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("DADOS DO VEÍCULO:");
                        Console.Write("RENAVAM: ");
                        v.Renavam = int.Parse(Console.ReadLine());

                        Console.Write("CHASSIS: ");
                        v.Chassis = int.Parse(Console.ReadLine());

                        Console.Write("PLACA: ");
                        v.Placa = string.Format(Console.ReadLine());

                        Console.Write("MARCA: ");
                        v.Marca = string.Format(Console.ReadLine());

                        Console.Write("MODELO: ");
                        v.Modelo = string.Format(Console.ReadLine());

                        Console.Write("COR: ");
                        v.Cor = string.Format(Console.ReadLine());

                        Console.Write("ANO DE FABRICAÇÃO: ");
                        v.Ano = int.Parse(Console.ReadLine());

                        Console.WriteLine("\nDADOS DO PROPRIETÁRIO:");

                        Console.Write("CPF: ");
                        p.Cpf = int.Parse(Console.ReadLine());

                        Console.Write("NOME: ");
                        p.Nome = string.Format(Console.ReadLine());

                        Console.Write("ENDEREÇO: ");
                        p.Endereco = string.Format(Console.ReadLine());

                        Console.Write("DATA DE NASCIMENTO: ");
                        p.DataNascimento = string.Format(Console.ReadLine());

                        Console.Write("DATA DE COMPRA: ");
                        p.DataCompra = string.Format(Console.ReadLine());
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("TODOS OS DADOS DO VEÍCULO:");
                        v.ImprimirDados();
                        Console.WriteLine("\nTODOS OS DADOS DO PROPRIETÁRIO:");
                        p.ImprimirValores();
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("PRESSIONE QUALQUER BOTÃO PARA CONFIRMAR SUA OPÇÃO E SAIR...");
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (op != 3);
        }
    }
}
