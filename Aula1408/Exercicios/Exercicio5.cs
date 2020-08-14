using System;
using Aula1408.Models;


namespace Aula1408.Exercicios
{
    class Exercicio5
    {
        public static void Executar()
        {
            var a1 = new Amigo("Paulo", "152-452132", 27, 10, 1980);
            var a2 = new Amigo("Gustavo", "152-452132", 7, 11, 1995);
            var a3 = new Amigo("Tiago", "152-452132", 08, 1, 2000);
            var a4 = new Amigo("Fernando", "152-452132", 03, 8, 2000);
            var a5 = new Amigo("Lucia", "152-452132", 30, 7, 2000);
            var a6 = new Amigo("Marcos", "152-452132", 27, 6, 2000);
            var a7 = new Amigo("Pedro", "152-452132", 25, 2, 2000);
            var a8 = new Amigo("Julia", "152-452132", 12, 10, 2000);

            Amigo[] listaAmigos = {a1, a2, a3, a4, a5, a6, a7, a8};

            Amigo.MostraOrdenadoAlfabetico(a1, a2, a3, a4, a5, a6, a7, a8);


            Console.WriteLine("\n========================================\n");
            Console.Write("Informe o nome a ser pesquisado: ");
            string nomePesquisa = Console.ReadLine();


            Amigo.PesquisaAmigo(nomePesquisa , listaAmigos);

        }
    }
}
