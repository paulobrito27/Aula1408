using System;
using System.Linq;


namespace Aula1408.Models
{
    class Carro
    {
        public string Placa { get; set; }
        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public double Valor { get; set; }

        public Carro(string placa, string fabricante, string modelo, string cor, double valor)
        {
            Placa = placa;
            Fabricante = fabricante;
            Modelo = modelo;
            Cor = cor;
            Valor = valor;
        }

        //METODOS
        public static void MostraFrota(params Carro[] litaCarros)
        {
            foreach (var carro in litaCarros)
            {
                Console.WriteLine($"{carro.Modelo} -> {carro.Valor}");
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Valor total dos carros = {litaCarros.Sum( q => q.Valor)}");
        }

    }
}
