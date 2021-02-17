using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Pilha_01
{
    class Program
    {
        static Pilha NovaPilha = new Pilha() { Topo = null };
        

        static void Main(string[] args)
        {
            int QtdLivros = 0, op, i = 0;
            string titulo, autor;
            int isbn, SituacaoQtd = 0;

            Livro[] VetorLivro = new Livro[10];

            do
            {
                Console.Clear();
                op = Menu();
                switch (op)
                {
                    case 1:
                        Console.Write("\nDigite o título do livro: ");
                        titulo = string.Format(Console.ReadLine());
                        Console.Write("Digite o autor do livro: ");
                        autor = string.Format(Console.ReadLine());
                        Console.Write("Digite o ISBN do livro: ");
                        isbn = int.Parse(Console.ReadLine());
                        
                        VetorLivro[i] = new Livro
                        {
                            Titulo = titulo,
                            Autor = autor,
                            Isbn = isbn,
                            Anterior = null
                        };
                        NovaPilha.Push(VetorLivro[i]);
                        
                        i += 1;                       
                        SituacaoQtd += 1;

                        Console.Write("\nPRESSIONE QUALQUER TECLA PARA VOLTAR AO INÍCIO... ");
                        Console.ReadKey();
                        break;
                    case 2: //remover livro
                        SituacaoQtd = NovaPilha.Pop(SituacaoQtd);
                        Console.Write("\nPRESSIONE QUALQUER TECLA PARA VOLTAR AO INÍCIO... ");
                        Console.ReadKey();
                        break;
                    case 3: //imprimir pilha
                        NovaPilha.Imprimir();
                        Console.Write("\nPRESSIONE QUALQUER TECLA PARA VOLTAR AO INÍCIO... ");
                        Console.ReadKey();
                        break;
                    case 4: //quantidade de elementos da pilha
                        Console.WriteLine($"A pilha possui {SituacaoQtd} livros.");
                        Console.Write("\nPRESSIONE QUALQUER TECLA PARA VOLTAR AO INÍCIO... ");
                        Console.ReadKey();
                        break;
                    case 5: //buscar livro pelo título                                            


                        Console.Write("\nPRESSIONE QUALQUER TECLA PARA VOLTAR AO INÍCIO... ");
                        Console.ReadKey();
                        break;
                    case 6: //sair
                        break;
                    default:
                        break;
                }
            } while (op != 6 || QtdLivros == 10);

            Console.Write("\nPRESSIONE QUALQUER TECLA PARA CONFIRMAR A SAÍDA... ");
            Console.ReadKey();
        }

        static private int Menu()
        {
            int op;
            Console.WriteLine(">>Menu Principal<<");
            Console.WriteLine("1- Inserir livro");
            Console.WriteLine("2- Remover livro");
            Console.WriteLine("3- Imprimir pilha");
            Console.WriteLine("4- Imprimir quantidade de elementos da pilha");
            Console.WriteLine("5- Buscar livro pelo título");
            Console.WriteLine("6- Sair");

            Console.Write("\nDigite sua opção: ");
            op = int.Parse(Console.ReadLine());

            return op;
        }
    }
}
