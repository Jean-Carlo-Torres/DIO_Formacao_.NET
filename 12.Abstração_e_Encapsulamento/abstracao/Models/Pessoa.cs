using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace abstracao.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar(){
            Console.WriteLine($"Hello, i'm {Nome}, and have {Idade} years old");
        }
    }
}