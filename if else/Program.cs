using System;
using System.Globalization;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Primeiro valor?");
            double x1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Primeiro valor?");
            double x2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string c1;

            if (x1 > 0 && x2 >0)
            {
                
               c1 = "Q1";
            }
            else   if ( x1 >0 && x2 < 0)
            {
                c1 = "Q4";
                }

            else if (x1 < 0 && x2 > 0)
            {
                c1 = "Q2";
                            }
            else if (x1 < 0 && x2 < 0)
            {
                c1 = "Q3";
            }
            else
            {
                c1 = "Centro";
            }

            Console.WriteLine(c1);



        }
    }
}
