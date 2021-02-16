using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_2._0_ex1
{
    class Veiculo
    {
        public int renavam;
        public int chassis;
        public string placa;
        public string marca;
        public string modelo;
        public string cor;
        public int ano;  
        
        public int Renavam
        {
            get //Controla leitura do atributo
            {
                return renavam;
            }
            set //Controla a escrita no atributo
            {
                renavam = value;
            }
        }

        public int Chassis
        {
            get
            {
                return chassis;
            }
            set
            {
                chassis = value;
            }
        }

        public string Placa
        {
            get
            {
                return placa;
            }
            set
            {
                placa = value;
            }
        }
        public string Marca
        {
            get
            {
                return marca;
            }
            set
            {
                marca = value;
            }
        }
        public string Modelo
        {
            get
            {
                return modelo;
            }
            set
            {
                modelo = value;
            }
        }
        public string Cor
        {
            get
            {
                return cor;
            }
            set
            {
                cor = value;
            }
        }
        public int Ano
        {
            get
            {
                return ano;
            }
            set
            {
                ano = value;
            }
        }

        public void ImprimirDados()
        {
            Console.WriteLine("RENAVAM: "+ renavam);
            Console.WriteLine("CHASSIS: "+ chassis);
            Console.WriteLine("PLACA: "+ placa);
            Console.WriteLine("MARCA: "+ marca);
            Console.WriteLine("MODELO: "+ modelo);
            Console.WriteLine("COR: "+ cor);
            Console.WriteLine("ANO DE FABRICAÇÃO: "+ ano);
        }
    }


}
