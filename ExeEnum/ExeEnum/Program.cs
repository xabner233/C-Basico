using System;
using System.Globalization;
using ExeEnum.Entitis.Enums;
using ExeEnum.Entitis;


namespace ExeEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string dpname = Console.ReadLine();
            Console.Write("Enter worker data: ");
            Console.Write("Name");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior):");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double basesalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(dpname);
            Worker worker = new Worker(name, level, basesalary, dept);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter #" + i + " contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valueperhour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration(hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valueperhour, hours);
                worker.AddContract(contract);


            }


            Console.WriteLine("Enter month and year to calculate income (MM/YYYY): ");
            string monthandyear = Console.ReadLine();
            int month = int.Parse(monthandyear.Substring(0, 2));
            int year = int.Parse(monthandyear.Substring(3));
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name) ;
            Console.WriteLine("Income for: " + monthandyear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
