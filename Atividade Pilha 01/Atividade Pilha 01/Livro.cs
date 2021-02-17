using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Pilha_01
{
    class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Isbn { get; set; }
        public Livro Anterior { get; set; }

        public override string ToString()
        {
            return $"\n>>INFORMAÇÕES DO LIVRO:<<\n" +
                $"Título: {Titulo}\n" +
                $"Autor: {Autor}\n" +
                $"ISBN: {Isbn}";
        }
    }
}
