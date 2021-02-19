using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_Fila
{
    class OrdemServico
    {
        public int Numero { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public int Prazo { get; set; }
        public OrdemServico Proximo { get; set; }

        public override string ToString()
        {
            return $"\n>>INFORMAÇÔES DA ORDEM DE SERVIÇO:<<\n" +
                        $"Número: {Numero}\n" +
                        $"Tipo: {Tipo}\n" +
                        $"Descrição: {Descricao}\n" +
                        //$"Data de Criação: {DataCriacao.ToString("dd/MM/yyyy")}\n" +
                        $"Data de Criação: {DataCriacao}\n" +
                        $"Prazo: {Prazo} dia(s)";
        }
    }//end class
}//end namespace
