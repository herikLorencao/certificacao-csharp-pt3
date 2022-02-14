using System;

namespace Topico1
{
    public class Conta
    {
        public decimal Saldo { get; private set; }

        public Conta()
        {
            Saldo = 1000;
            Console.WriteLine(Saldo);
        }

        public void Sacar(decimal valor)
        {
            Saldo -= valor;
        }
    }
}