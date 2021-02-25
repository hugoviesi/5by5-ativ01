using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List.Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Contato contato = new Contato();
            List<Contato> meusContatos = new List<Contato>();
            List<Telefone> meusTelefones = new List<Telefone>();

            Arquivo arquivoListaContatos = new Arquivo
            {
                FilePath = @"C:\Users\viesi\source\repos\List.Ex01",
                FileName = "ListaContato",
                FileExtension = "csv"
            };

            arquivoListaContatos.InitializeFile(meusContatos);

            int op = 0;
            do
            {
                Console.Clear();
                op = Menu(op);
                switch (op)
                {
                    case 1:
                        contato = InserirContato();
                        Inserir(meusContatos, contato);
                        arquivoListaContatos.WriteInFile(meusContatos);
                        Console.WriteLine("\nPRESSIONE QUALQUER TECLA PARA VOLTAR AO MENU...");
                        Console.ReadKey();
                        break;
                    case 2:
                        Remover(meusContatos, contato);
                        arquivoListaContatos.WriteInFile(meusContatos);
                        Console.WriteLine("\nPRESSIONE QUALQUER TECLA PARA VOLTAR AO MENU...");
                        Console.ReadKey();
                        break;
                    case 3:
                        Localizar(meusContatos, contato);
                        Console.WriteLine("\nPRESSIONE QUALQUER TECLA PARA VOLTAR AO MENU...");
                        Console.ReadKey();
                        break;
                    case 4:
                        meusContatos.ForEach(c => Console.WriteLine(c.ToString()));
                        Console.WriteLine("\nPRESSIONE QUALQUER TECLA PARA VOLTAR AO MENU...");
                        Console.ReadKey();
                        break;
                    case 5:
                        ImprimirEspecifico(meusContatos, contato);
                        Console.WriteLine("\nPRESSIONE QUALQUER TECLA PARA VOLTAR AO MENU...");
                        Console.ReadKey();
                        break;
                    case 6:
                        OrdemAlfabetica(meusContatos, contato);
                        Console.WriteLine("\nPRESSIONE QUALQUER TECLA PARA VOLTAR AO MENU...");
                        Console.ReadKey();
                        break;
                    //case 7:
                        
                    //    Console.WriteLine("\nPRESSIONE QUALQUER TECLA PARA VOLTAR AO MENU...");
                    //    Console.ReadKey();
                    //    break;
                    case 8:

                        break;
                }
            } while (op != 8);
        }

        static public int Menu(int op)
        {
            Console.WriteLine(">>> MENU PRINCIPAL <<<");
            Console.Write("1- Inserir novo contato\n" +
                              "2- Remover contato\n" +
                              "3- Localizar contato\n" +
                              "4- Imprimir contatos\n" +
                              "5- Imprimir contato específico\n" +
                              "6- Contatos em ordem alfabética\n" +
                              "7- Contatos em ordem numérica(não está funcionando)\n" +
                              "8- Sair\n\n" +
                              "Digite sua opção: ");
            op = int.Parse(Console.ReadLine());
            
            return op;
        }

        private static Contato InserirContato()
        {
            string nome, tipo;
            int ddd;
            long numero;
            long[] phone = new long[10];

            Console.Write("Informe o nome do contato: ");
            nome = Console.ReadLine();

            Console.Write("Informe o tipo do contato: ");
            tipo = Console.ReadLine();

            Console.Write("Informe o DDD do contato: ");
            ddd = int.Parse(Console.ReadLine());

            Console.Write("Informe o numero do contato: ");
            numero = long.Parse(Console.ReadLine());

            return new Contato
            {
                Nome = nome,
                telefone = new Telefone
                {
                   //new Telefone
                   //{
                       DDD = ddd,
                       Numero = numero,
                       Tipo = tipo
                   //}
                }
            };
        }

        static public void Inserir(List<Contato> contatos, Contato contato)
        {
            contatos.Add(contato);
            return;
        }

        static public void Remover(List<Contato> contatos, Contato Contato)
        {
            Console.Write("Insira o nome a ser excluído: ");
            string nome = Console.ReadLine();
            foreach(Contato c in contatos)
            {
                if (c.Nome == nome)
                {
                    contatos.Remove(c);
                    break;
                }
            }
            
            return;
        }

        static public void Localizar(List<Contato> contatos, Contato Contato)
        {
            Console.Write("Insira o nome a ser localizado: ");
            string nome = Console.ReadLine();
            foreach (Contato c in contatos)
            {
                if (c.Nome == nome)
                {
                    Console.WriteLine(c.ToString());
                    break;
                }
            }
            
            return;
        }

        static public void ImprimirEspecifico(List<Contato> contatos, Contato Contato)
        {
            foreach (Contato c in contatos)
            {
                Console.Write("Deseja imprimir o próximo contato da lista?\n" +
                              "1- Sim\n" +
                              "2- Não\n" +
                "Digite sua escolha: ");
                int escolha = int.Parse(Console.ReadLine());
                if(escolha == 1)
                {
                    Console.WriteLine(c.ToString());
                }
                else if(escolha == 2)
                {
                    break;
                }                       
            }
            
            return;
        }
        static public void OrdemAlfabetica(List<Contato> contatos, Contato Contato)
        {
            contatos.Sort(delegate (Contato c, Contato c2)
            {
                return c.Nome.CompareTo(c2.Nome);
            });
            contatos.ForEach(delegate (Contato c)
            {
                Console.WriteLine(c.ToString());
            });
        }

        static public void LendoArquivos()
        {
            Stream entrada = File.Open("entrada.txt", FileMode.Open);
            StreamReader leitor = new StreamReader(entrada);
      
            string linha = leitor.ReadLine();

            while (linha != null)
            {
                Console.WriteLine(linha);
                linha = leitor.ReadLine();
            }

            leitor.Close();
            entrada.Close();

            if (File.Exists("entrada.txt"))
            {
                entrada = File.Open("entrada.txt", FileMode.Open);
                leitor = new StreamReader(entrada);
                linha = leitor.ReadLine();

                while (linha != null)
                {
                    Console.WriteLine(linha);
                    linha = leitor.ReadLine();
                }
                
                leitor.Close();
                entrada.Close();
            }

        }

    }
}