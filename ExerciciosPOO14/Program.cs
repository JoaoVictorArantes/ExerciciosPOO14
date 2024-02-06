using ExerciciosPOO14.Entities;

namespace ExerciciosPOO14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int aux = int.Parse(Console.ReadLine());

            for (int i = 0; i < aux; i++)
            {
                Console.WriteLine($"Employee #{i + 1} data:");

                Console.Write("Outsourced (y/n)? ");
                char CharAux = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                String Name = Console.ReadLine();

                Console.Write("Hours: ");
                int Hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double ValuePerHour = double.Parse(Console.ReadLine());

                if (CharAux == 'y')
                {
                    Console.Write("Additional charge: ");
                    double AdditionalCharge = double.Parse(Console.ReadLine());

                    list.Add(new OutsourcedEmployee(Name, Hours, ValuePerHour, AdditionalCharge));
                }
                else
                {
                    list.Add(new Employee(Name, Hours, ValuePerHour));
                }

                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");

            foreach (Employee emp in list)
            {
                Console.WriteLine($"{emp.Name} - ${emp.Payment().ToString("F2")}");
            }

            Console.ReadKey();
        }
    }
}
