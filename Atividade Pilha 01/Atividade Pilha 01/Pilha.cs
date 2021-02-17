using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Pilha_01
{
    class Pilha
    {
        public Livro Topo { get; set; }

        public void Push(Livro aux)    //Inserir elementos na pilha
        {
            aux.Anterior = Topo;
            Topo = aux;
            
            Console.WriteLine("\nElemento inserido com sucesso.");
            
            return;
        }

        private bool Vazia()    //Verificar se pilha está vazia
        {
            if(Topo == null)
            {
                return true;
            }
            return false;
        }

        public void Imprimir()  //Imprimir elementos da pilha
        {
            if (Vazia())
            {
                Console.WriteLine("\nNão há elementos na pilha para imprimir.");
            }
            else
            {
                Livro aux = Topo;
                Console.WriteLine("\nOs elementos da pilha são:");
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Anterior;
                } while (aux != null);
            }
        }

        public int Pop(int QtdLivros)   //Retirar elementos da pilha
        {
            if (Vazia())
            {
                Console.WriteLine("\nImpossível remover elementos de uma pilha vazia.");
                QtdLivros = 0;
            }
            else
            {
                Topo = Topo.Anterior;
                Console.WriteLine("\nElemento removido com sucesso!\n");
                QtdLivros -= 1;
            }
            return QtdLivros;
        }
    }
}
