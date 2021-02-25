using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List.Ex01
{
    class Contato
    {
        public string Nome { get; set; }
        public Telefone telefone { get; set; } //public Telefone[] telefones { get; set; }
        public override string ToString()
        {
            //string telefones = "";
            //foreach (Telefone t in Telefones)
            //{
            //    telefones += t.ToString();
            //}
      
            return $"{Nome}\n{telefone}"; 
        }

        public string ToConversor()
        {
            return $"{Nome},{telefone.Tipo},{telefone.DDD},{telefone.Numero}";
        }

    }
}