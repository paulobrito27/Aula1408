using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1408.Models
{
    class Circulo
    {

        //Propriedades--------------------------------------

        private double _raio;
        public double Raio
        {
            get { return _raio; }
            set { _raio = value; }
        }

        public double Area { get; private set; }
        public double Diametro { get; private set; }
        public double Perimetro { get; private set; }



        //CONSTRUTORES-------------------------------------------------------------
        public Circulo(double raio = 1)
        {
            _raio = raio;
            Diametro = _raio * 2;
            Area = Math.PI * Math.Pow(_raio,2.0);
            Perimetro = 2 * Math.PI * _raio;

        }


        //MÉTODOS 

        public void ApresentarValores()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Raio = {_raio:F} ");
            Console.WriteLine($"Area = {Area:F} ");
            Console.WriteLine($"Diametro = {Diametro:F}");
            Console.WriteLine($"Perimetro = {Perimetro:F}");
            Console.WriteLine("--------------------------------------");
        }



    }
}
