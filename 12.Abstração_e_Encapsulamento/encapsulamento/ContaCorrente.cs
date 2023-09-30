using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace encapsulamento
{
    public class ContaCorrente
    {

        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }

        public int NumeroConta { get; set; }
        private decimal saldo;
        public void Sacar(decimal valor){
            if(saldo >= valor){
            saldo -= valor;
            Console.WriteLine("Saque realizado com sucesso");
            } else {
                Console.WriteLine("Não foi possivel realizar o saque"); 
            }
        }

        public void ExibirSaldo(){
            Console.WriteLine($"Saldo disponível é {saldo}");
        }
    }
}