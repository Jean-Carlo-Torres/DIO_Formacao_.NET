using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2.Sintaxe.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar(){
            Console.WriteLine($"My name is {Nome} and i have {Idade} years old");
        }
    }
}