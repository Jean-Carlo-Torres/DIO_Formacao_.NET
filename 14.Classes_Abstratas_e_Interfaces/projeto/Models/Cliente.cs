using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto.Models
{
    public class Cliente : Pessoa
    {
        public Cliente(string nome, string email, int cpf): base(nome, email, cpf)
    {
        
    }

        public int Agencia { get; set; }
    }
}