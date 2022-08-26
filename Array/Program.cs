using System;
using System.Globalization;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {

            Produt[] vect = new Produt[10];

            Console.WriteLine("Quantos quartos serão alugados?");
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Rent #1: \nName: ");
                string name = Console.ReadLine();
                Console.WriteLine("Eamil: ");
                string email = Console.ReadLine();
                Console.WriteLine("Room: ");
                int q = int.Parse(Console.ReadLine());

                vect[q] = new Produt(name, email);

            }


            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);

                }
            }
        }
        }
    }
