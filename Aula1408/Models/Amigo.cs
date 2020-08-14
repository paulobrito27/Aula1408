using System;
using System.Linq;


namespace Aula1408.Models
{
    class Amigo
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }

        public Amigo(string nome, string telefone, int dia, int mes, int ano)
        {
            Nome = nome;
            Telefone = telefone;
            Dia = dia;
            Mes = mes;
            Ano = ano;
        }

        public static void MostraOrdenadoAlfabetico(params Amigo[] listAmigos)
        {
            var listaOrdenada = listAmigos.OrderBy(q => q.Nome);
            foreach (var amigo in listaOrdenada)
            {
                Console.WriteLine($"Nome: {amigo.Nome}, telefone: {amigo.Telefone}, nascimento: {amigo.Dia}/{amigo.Mes}/{amigo.Ano}");
            }
        }

        public static void PesquisaAmigo(string nome, Amigo[] listAmigos)
        {
            var achou = false;

            foreach (var amigo in listAmigos)
            {
                if (amigo.Nome.ToUpper() == nome.ToUpper())
                {
                    Console.WriteLine($"nascimento: {amigo.Dia}/{amigo.Mes}/{amigo.Ano}");
                    achou = true;
                }
            }

            if (!achou)
            {
                Console.WriteLine("Amigo não foi encontrado");
            }
        }

    }
}
