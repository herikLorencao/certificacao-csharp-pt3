using System;

namespace Topico3.Interfaces_Explicitas
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario(1500);
            funcionario.CPF = "123.456.789-00";
            funcionario.Nome = "josé da silva";
            funcionario.DataNascimento = new DateTime(2000, 1, 1);

            // Cast para definir qual interface está sendo utilizada
            ((IFuncionario) funcionario).CargaHorariaMensal = 168;
            funcionario.EfeturarPagamento();
            funcionario.CrachaGerado += (s, e) => { Console.WriteLine("Crachá gerado"); };
            ((IFuncionario) funcionario).GerarCracha();
        }
    }

    interface IPlantonista
    {
        int CargaHorariaMensal { get; set; }

        void GerarCracha();
    }

    interface IFuncionario
    {
        string CPF { get; set; }
        string Nome { get; set; }
        DateTime DataNascimento { get; set; }

        event EventHandler CrachaGerado;

        void GerarCracha();

        decimal Salario { get; }
        int CargaHorariaMensal { get; set; }

        void EfeturarPagamento();
    }

    class Funcionario : IFuncionario, IPlantonista
    {
        public string CPF { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public event EventHandler CrachaGerado;

        void IFuncionario.GerarCracha()
        {
            if (CrachaGerado != null)
            {
                CrachaGerado(this, new EventArgs());
            }
        }

        void IPlantonista.GerarCracha()
        {
            if (CrachaGerado != null)
            {
                CrachaGerado(this, new EventArgs());
            }
        }

        public decimal Salario { get; }

        int IFuncionario.CargaHorariaMensal { get; set; }
        int IPlantonista.CargaHorariaMensal { get; set; }

        public Funcionario(decimal salario)
        {
            Salario = salario;
        }

        public void EfeturarPagamento()
        {
            Console.WriteLine("Pagamento Efetuado");
        }
    }
}