using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto.Models
{
    public class Pessoa
    {

        public Pessoa(string nome, string email, int cpf){
            Nome = nome;
            Email = email;
            Cpf = cpf;
        }

        public string Nome { get; set; }
        public string Email { get; set; }
        public int Cpf { get; set; }

        public virtual void DadosPessoa(){
            Console.WriteLine($"Nome: {Nome}\nEmail: {Email}\nCPF: {Cpf}");
            Console.WriteLine("===================");
        }
    }
}