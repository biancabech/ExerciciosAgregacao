using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosAgregacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Endereco endereco1 = new Endereco();
            endereco1.Cidade = "Mexico";
            endereco1.Bairro = "Los Hermanos";
            endereco1.Rua = "Abacaxi";
            endereco1.Numero = 1;

            Pessoa pessoa1 = new Pessoa();
            pessoa1.Id = 1;
            pessoa1.Nome = "Jhonny Dep";
            pessoa1.Idade = 34;
            pessoa1.Endereco = endereco1;
            Console.WriteLine(pessoa1.Endereco.Rua);

            //-----------------------------------------
            Motor motor1 = new Motor();
            motor1.Marca = "AGL";
            motor1.Modelo = "AGL touch";

            Carro carro1 = new Carro();
            carro1.Marca = "Fiat";
            carro1.Modelo = "Uno";
            carro1.Ano = 2020;
            carro1.Motor = motor1;
            //-----------------------------------------
            // 3. Professor e Disciplina

            Disciplina disciplina1 = new Disciplina();
            disciplina1.Id= 1;
            disciplina1.Nome = "História";
            
            Professor professor1 = new Professor();
            professor1.Id = 1;
            professor1.Nome = "Madalena";
            professor1.Disciplina = disciplina1;
            //-----------------------------------------
            // 11.Universidade e Alunos

        }
    }
}
