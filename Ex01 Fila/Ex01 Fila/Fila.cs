using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_Fila
{
    class Fila
    {
        public OrdemServico Head { get; set; } //Propriedade Head = começo
        public OrdemServico Tail { get; set; } //Propriedade Tail = fim

        public bool Vazia() //Verificar se a fila está vazia
        {
            if ((Head == null) && (Tail == null)) //Se começo e fim estiver nulo
            {
                return true; //Fila vazia
            }
            return false; //Fila preenchida
        }
        public int Push(OrdemServico aux, int QtdOS) //Adicionar elemento à fila
        {
            if (Vazia()) //Se vazia:
            {
                Head = aux; //Head e Tail recebem o auxiliar, pois é o primeiro elemento
                Tail = aux;
            }
            else //Se não:
            {
                Tail.Proximo = aux; //Encadeamento da nova ordem de serviço
                Tail = Tail.Proximo; //Atualizando o Tail
            }
            QtdOS += 1;
            Console.WriteLine("\nElemento inserido com sucesso!");
            return QtdOS;
        }
        public void Print() //Imprimir elementos da fila na tela
        {
            if (Vazia()) //Se vazia:
            {
                Console.WriteLine("Impossível imprimir uma fila vazia!");
            }
            else //Se não:
            {
                OrdemServico aux = Head; //Auxiliar do mesmo tipo recebe o primeiro elemento
                do
                {
                    Console.WriteLine(aux.ToString()); //Imprimir os componentes do primeiro elemento, no caso auxiliar
                    aux = aux.Proximo; //Auxiliar recebe o próximo componente da fila

                } while (aux != null); //Realizar enquanto o auxiliar não for nulo
            }
            return;
        }

        public int Pop(int QtdOS) //Excluir o primeiro elemento da fila
        {
            if (Vazia()) //Se vazia:
            {
                Console.WriteLine("\nImpossível remover elementos de uma pilha vazia!");
            }
            else //Se não:
            {
                Head = Head.Proximo; //Primeiro elemento da fila(cabeça) recebe o próximo
                QtdOS -= 1;
                Console.WriteLine("\nElemento removido com sucesso!");
                if (Head == null) //Se o começo for nulo:
                {
                    Tail = null; //O fim também deverá ser nulo, logo: fila vazia
                    Console.WriteLine("\nFila vazia!");
                }
            }
            return QtdOS;
        }

        public void Search(int numero) //Pesquisar elementos da fila pelo número
        {
            if (Vazia()) //Se vazia:
            {
                Console.WriteLine("\nImpossível fazer a pesquisa de uma fila vazia!");
            }
            else //Se não:
            {
                OrdemServico aux = Head; //Auxiliar do mesmo tipo recebe o primeiro elemento
                do // Laço para percorrer a fila
                {
                    if(aux.Numero == numero)
                    Console.WriteLine(aux.ToString()); //Imprimir os componentes do primeiro elemento, no caso auxiliar
                    aux = aux.Proximo; //Auxiliar recebe o próximo componente da fila

                } while (aux != null); //Realizar enquanto o auxiliar não for nulo
            }
            return;
        }

    }//end class
}//end namespace
