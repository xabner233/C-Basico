using System;
using System.Globalization;

namespace MembrosEstaticos
{
    class Program
    {
        
        static void Main(string[] args)

        {


            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double vol = Calculadora.Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de pi: " + Calculadora.pi.ToString("F2", CultureInfo.InvariantCulture));

        }

       
    }
}
