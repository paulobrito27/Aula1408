using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula1408.Models;

namespace Aula1408.Exercicios
{
    class Exercicio2
    {

        public static void Executar()
        {

            Circulo c1 = new Circulo();

            Circulo c2 = new Circulo(2.3);

            c1.ApresentarValores();
            Console.WriteLine("\n====================\n");
            c2.ApresentarValores();

            Console.ReadKey();
        }
    }
}
