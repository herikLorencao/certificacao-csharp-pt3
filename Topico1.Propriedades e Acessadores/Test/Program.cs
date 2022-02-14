using System;
using Topico1;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new ContaCorrente();
            conta.Sacar(200);
            Console.WriteLine(conta.Saldo);
        }
    }
}