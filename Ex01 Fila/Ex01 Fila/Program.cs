using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_Fila
{
    class Program
    {
        static void Main(string[] args)
        {
            Fila NewFila = new Fila
            {
                Head = null,
                Tail = null
            };

            //Declarando Variáveis:
            int op = 0, numero = 0, prazo = 0, numeroPesq = 0, sitQtd = 0;
            string tipo = " ", descricao = " ";
            
            do
            {
                Console.Clear(); //Limpar o console
                op = Menu(op);
                switch (op)
                {
                    case 1: //Adicionar elemento à fila
                        numero = PedirNumero(numero);
                        tipo = PedirTipo(tipo);
                        descricao = PedirDescricao(descricao);
                        prazo = PedirPrazo(prazo);
                        OrdemServico NewOrdem = new OrdemServico 
                        { 
                            Numero = numero, 
                            Tipo = tipo, 
                            Descricao = descricao, 
                            DataCriacao = DateTime.Now, 
                            Prazo = prazo, 
                            Proximo = null 
                        };
                        sitQtd = NewFila.Push(NewOrdem, sitQtd);
                        Finalizar();
                        break;
                    case 2: //Remover elemento da fila
                        sitQtd = NewFila.Pop(sitQtd);
                        Finalizar();
                        break;
                    case 3: //Imprimir fila
                        NewFila.Print();
                        Finalizar();
                        break;
                    case 4: //Quantidade de elementos da fila
                        Console.WriteLine($"\nHá {sitQtd} elemento(s) na fila.");
                        Finalizar();
                        break;
                    case 5: //Pesquisar elemento da fila pelo número
                        numeroPesq = PesquisarNumero(numeroPesq);
                        NewFila.Search(numeroPesq);
                        Finalizar();
                        break;
                    case 6: //Sair
                        Console.ReadKey();
                        break;
                }
            } while (op != 6);
        }

        static private int Menu(int op)
        {
            Console.WriteLine(">>>Menu<<<");
            Console.WriteLine("1- Inserir Ordem de Serviço");
            Console.WriteLine("2- Remover Ordem de Serviço");
            Console.WriteLine("3- Imprimir Fila");
            Console.WriteLine("4- Quantidade de Elementos da Fila");
            Console.WriteLine("5- Buscar por Elemento da Fila pelo Número");
            Console.WriteLine("6- Sair");
            Console.Write("\nDigite sua opção: ");
            op = int.Parse(Console.ReadLine());
            
            return op;
        }

        static private int PedirNumero(int numero)
        {
            Console.Write("\nInsira o número: ");
            numero = int.Parse(Console.ReadLine());

            return numero;
        }

        static private string PedirTipo(string tipo)
        {
            Console.Write("Insira o tipo do serviço: ");
            tipo = string.Format(Console.ReadLine());

            return tipo;
        }

        static private string PedirDescricao(string descricao)
        {
            Console.Write("Insira a descrição do serviço: ");
            descricao = string.Format(Console.ReadLine());

            return descricao;
        }

        

        static private int PedirPrazo(int numero)
        {
            Console.Write("Insira o prazo do serviço: ");
            numero = int.Parse(Console.ReadLine());

            return numero;
        }

        static private void Finalizar()
        {
            Console.Write("\nPRESSIONE QUALQUER TECLA PARA VOLTAR AO MENU...");
            Console.ReadKey();
            return;
        }

        static private int PesquisarNumero(int numeroPesq)
        {
            Console.Write("\nInsira o número a ser pesquisado: ");
            numeroPesq = int.Parse(Console.ReadLine());

            return numeroPesq;
        }

    }//end class
}//end namespace