using System;
using System.Collections.Generic;
using System.Globalization;
using MetodosAbstratos.Entities;



namespace MetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contribuintes> list = new List<Contribuintes>(); 

            Console.Write("Enter the number of tax payers: ");
            int cont = int.Parse(Console.ReadLine());

            for (int i = 1; i <= cont; i++)
            {
                Console.WriteLine($"Tax payer {i} data: ");
                Console.Write("Individual or company (i/c): " );
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual incomes: ");
                double valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                double valorimposto = 0;
                



                if (ch == 'i')
                {
                    if ( valor < 20000.00)
                    {
                        valorimposto = 15.00;
                        
                    }
                    if(valor > 20000.00)
                    {
                        valorimposto = 25.00;

                    }

                    Console.Write("Healt expenditures: ");
                    double saude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Fisica(name, valor, valorimposto, saude));

                }

                if (ch == 'c')
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());

                    if (employees <= 10)
                    {
                        valorimposto = 16;
                    }
                    if (employees > 10)
                    {
                        valorimposto = 14;
                    }

                    list.Add(new Juridica(name, valor, valorimposto, employees));

                }

            }
            
            foreach (Contribuintes contribuintes in list)
            {
                Console.Write(contribuintes.Nome + ": $ " + contribuintes.CalculoImposto().ToString("F2", CultureInfo.InvariantCulture)) ;

            }
        }
    }
}
