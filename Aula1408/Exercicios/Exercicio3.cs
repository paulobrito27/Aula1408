using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula1408.Models;

namespace Aula1408.Exercicios
{
    class Exercicio3
    {
        public static void Executar()
        {
            Carro c1 = new Carro("ABC-2654", "FORD", "FUSION", "PRETO", 25000.00 );
            Carro c2 = new Carro("ABC-2222", "FIAT", "UNO", "BRANCO", 7000.00);
            Carro c3 = new Carro("ABC-3333", "VOLKS", "FUSCA", "VERMELHO", 5000.00);
            Carro c4 = new Carro("ABC-4444", "FORD", "FIESTA", "PRETO", 27000.00);
            Carro c5 = new Carro("ABC-5555", "RENAULT", "CLIO", "PRATA", 15000.00);

            Console.WriteLine("\n\n------------------------teste1-------------------------------\n");
            Carro.MostraFrota(c1, c2, c3);


            Console.WriteLine("\n\n------------------------teste2-------------------------------\n");
            Carro.MostraFrota(c1, c2, c3, c4);



            Console.WriteLine("\n\n------------------------teste3-------------------------------\n");
            Carro.MostraFrota(c1, c2, c3, c4, c5);
        }
    }
}
