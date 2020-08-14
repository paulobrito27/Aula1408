using System;
using Aula1408.Models;

namespace Aula1408.Exercicios
{
    class Exercicio4
    {
        public static void Executar()
        {
            Escola[] lista = new Escola[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.Write($"\nInforme o nome da {i + 1}° escola: ");
                string nomeDaEscola = Console.ReadLine();

                Console.Write($"\nInforme o numero de alunos da escola {nomeDaEscola}:  ");
                int quantidaDeAlunos = Convert.ToInt32(Console.ReadLine());

                lista[i] = new Escola(nomeDaEscola, quantidaDeAlunos);
            }

            Escola.MostrarOrdenado(lista);

        }
    }
}
