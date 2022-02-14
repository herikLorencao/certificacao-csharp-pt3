using System;
using System.Collections.Generic;

namespace Topico5.Comparacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno
            {
                Nome = "José da Silva",
                DataNascimento = new DateTime(1990, 1, 1)
            };

            Aluno aluno2 = new Aluno
            {
                Nome = "José da Silva",
                DataNascimento = new DateTime(1995, 1, 1)
            };

            Aluno aluno3 = new Aluno
            {
                Nome = "josé da silva",
                DataNascimento = new DateTime(1990, 1, 1)
            };

            Console.WriteLine(aluno1.Equals(aluno2));
            Console.WriteLine(aluno1.Equals(aluno3));
            
            Aluno aluno4 = new Aluno
            {
                Nome = "João da Silva",
                DataNascimento = new DateTime(1985, 1, 1)
            };

            Aluno aluno5 = new Aluno
            {
                Nome = "Ana da silva",
                DataNascimento = new DateTime(1990, 1, 1)
            };

            List<Aluno> alunos = new List<Aluno>()
            {
                aluno1,
                aluno2,
                aluno3,
                aluno4,
                aluno5
            };
            
            alunos.Sort();
            
            alunos.ForEach(aluno => Console.WriteLine(aluno));
        }
    }
    
    class Aluno : IComparable
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome}, Data nascimento: {DataNascimento:dd/MM/yyyy}";
        }

        public int CompareTo(object? obj)
        {
            var outroAluno = obj as Aluno;
            if (outroAluno == null) return -1;
            var comparacaoData = DateTime.Compare(DataNascimento, outroAluno.DataNascimento);
            if (comparacaoData != 0) return comparacaoData;
            return string.Compare(Nome, outroAluno.Nome, StringComparison.CurrentCulture);
        }

        public override bool Equals(object? obj)
        {
            var outroAluno = obj as Aluno;
            return Nome.Equals(outroAluno?.Nome, StringComparison.CurrentCultureIgnoreCase) &&
                   DataNascimento.Equals(outroAluno?.DataNascimento);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}