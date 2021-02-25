using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List.Ex01
{
    class Telefone
    {
        public long Numero { get; set; }
        public int DDD { get; set; }
        public string Tipo { get; set; }
        public override string ToString()
        {
            return $"Telefone {Tipo}: ({DDD}) {Numero}\n";
        }
    }
}