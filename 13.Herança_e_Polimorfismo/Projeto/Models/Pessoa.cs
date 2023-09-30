using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Models
{
    public class Pessoa
    {
        public Pessoa(){}

        public Pessoa(string nome, int idade){
            Nome = nome;
            Idade = idade;
        }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Apresentar(){
            Console.WriteLine($"Hello, my name is {Nome} and have {Idade} years old");
        }
    }
}