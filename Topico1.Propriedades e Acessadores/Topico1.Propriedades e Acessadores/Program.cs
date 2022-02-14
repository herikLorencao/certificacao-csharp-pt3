using System;

namespace Topico1
{
    class Program
    {
        static void Main(string[] args)
        {
            var funcionario = new Funcionario(1200);
            Console.WriteLine(funcionario.Salario);
        }

        class Funcionario
        {
            private decimal salario;
            public Funcionario(decimal salario)
            {
                Salario = salario;
            }

            public decimal Salario
            {
                get => salario;
                private set
                {
                    if (value < 0) throw new ArgumentOutOfRangeException();
                    salario = value;
                }
            }
        }
    }
}