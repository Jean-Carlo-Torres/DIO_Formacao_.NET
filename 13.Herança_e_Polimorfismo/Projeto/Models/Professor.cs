using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

        public override void Apresentar(){
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade}, e sou um Professor, meu salario é {Salario}");
        }
    }
}