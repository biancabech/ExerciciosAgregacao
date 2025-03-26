using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosAgregacao
{
    internal class Universidade
    {
        public string Nome;
        public List<Aluno> listaDeAlunos = new List<Aluno>();

        public void AdicionarUmAluno()
        {
            Console.WriteLine("Quantos alunos você deseja cadastrar:");
            int qtde = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtde; i++)
            {
                Aluno aluno1 = new Aluno();

                Console.WriteLine("Digite o número da matrícula:");
                aluno1.Matricula = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o nome do aluno:");
                aluno1.Nome = Console.ReadLine();

                listaDeAlunos.Add(aluno1);
                Console.WriteLine(" ");
            }
        }

        public void RemoverUmAluno()
        {
            Console.WriteLine("Digite o nome do aluno que deseja remover:");
            string nomeAluno = Console.ReadLine();

            Aluno alunoEncontrado = listaDeAlunos.Find(aluno => aluno.Nome == nomeAluno);
            listaDeAlunos.Remove(alunoEncontrado);
        }

        public void ExibirAlunos()
        {
            foreach (var item in listaDeAlunos)
            {
                Console.WriteLine($"Matricula: {item.Matricula}");
                Console.WriteLine($"Nome: {item.Nome}\n");
            }
        }
    }
}
