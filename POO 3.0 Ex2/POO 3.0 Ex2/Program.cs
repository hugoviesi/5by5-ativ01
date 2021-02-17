using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_3._0_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação das instâncias: objetos
            Cliente c = new Cliente();
            ContaCorrente cc2 = new ContaCorrente();
            ContaCorrente cc = new ContaCorrente();
            int op; //variável op

            do
            {   //Menu de opções
                Console.Clear();
                Console.WriteLine("========================");
                Console.WriteLine("1- Criar conta corrente");
                Console.WriteLine("2- Imprimir dados da conta/cliente");
                Console.WriteLine("3- Realizar depósito");
                Console.WriteLine("4- Realizar saque");
                Console.WriteLine("5- Fazer transferência");
                Console.WriteLine("6- Visualizar o saldo atual");
                Console.WriteLine("7- Sair");
                Console.WriteLine("========================");

                Console.Write("\nDigite sua opção: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("DADOS DO CLIENTE:");
                        Console.Write("Digite o CPF: ");
                        c.Cpf = int.Parse(Console.ReadLine());

                        Console.Write("Digite o seu nome: ");
                        c.Nome = string.Format(Console.ReadLine());

                        Console.Write("Digite o seu endereço: ");
                        c.Endereco = string.Format(Console.ReadLine());

                        Console.WriteLine("\nDADOS DA CONTA CORRENTE:");

                        Console.Write("Digite a Agência: ");
                        cc.Agencia = int.Parse(Console.ReadLine());

                        Console.Write("Digite o Número: ");
                        cc.Numero = int.Parse(Console.ReadLine());

                        Console.Write("Digite o Saldo: ");
                        cc.Saldo = float.Parse(Console.ReadLine());
                        Console.Write("\nPRESSIONE QUALQUER TECLA PARA VOLTAR AO MENU: ");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("TODOS OS DADOS DO CLIENTE:");
                        c.ImprimirDados();
                        Console.WriteLine("\nTODOS OS DADOS DA CONTA CORRENTE:");
                        cc.ImprimirDados();
                        Console.Write("\nPRESSIONE QUALQUER TECLA PARA VOLTAR AO MENU: ");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        float valor_deposito;
                        Console.Write("Digite o valor do depósito: ");
                        valor_deposito = float.Parse(Console.ReadLine());
                        cc.Deposito(valor_deposito);
                        Console.Write("\nPRESSIONE QUALQUER TECLA PARA VOLTAR AO MENU: ");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        float valor_saque;
                        bool sacou = false;
                        Console.Write("Digite o valor do saque: ");
                        valor_saque = float.Parse(Console.ReadLine());
                        sacou = cc.Saque(valor_saque);
                        if (sacou)
                        {
                            Console.WriteLine("\nSaque realizado!!!");
                        }
                        else if (!sacou)
                        {
                            Console.WriteLine("\nSaque não realizado...");
                        }
                        Console.Write("\nPRESSIONE QUALQUER TECLA PARA VOLTAR AO MENU: ");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        float valor_transferencia;
                        Console.Write("Digite o valor a ser transferido: ");
                        valor_transferencia = float.Parse(Console.ReadLine());
                        cc.Transferir(valor_transferencia, cc2); //exemplo
                        Console.Write("\nPRESSIONE QUALQUER TECLA PARA VOLTAR AO MENU: ");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        cc.ImprimirSaldo();
                        Console.Write("\nPRESSIONE QUALQUER TECLA PARA VOLTAR AO MENU: ");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        Console.Write("PRESSIONE QUALQUER BOTÃO PARA CONFIRMAR SUA OPÇÃO E SAIR...");
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }

            } while (op != 7);

            Console.ReadKey();
        }
    }
}
