using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1408.Models
{
    class Escola
    {
        public string NomeDaEscola { get; set; }
        public int QuantidaDeAlunos { get; set; }

        public Escola(string nomeDaEscola, int quantidaDeAlunos)
        {
            NomeDaEscola = nomeDaEscola;
            QuantidaDeAlunos = quantidaDeAlunos;
        }

        public static void MostrarOrdenado( Escola[] listaEscolas)
        {
            var listaNova  =  listaEscolas.OrderByDescending(q => q.QuantidaDeAlunos);
            foreach (var escola in listaNova)
            {
                Console.WriteLine($"Nome: {escola.NomeDaEscola} , quantidade: {escola.QuantidaDeAlunos}");
            }
        }
    }
}
