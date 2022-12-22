using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLista_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Employees> listemployees = new List<Employees>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Emplyoee #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine().Replace(',', '.'), CultureInfo.InvariantCulture);

                Employees employees = new Employees(id, name, salary);
                listemployees.Add(employees);
            }

            Console.WriteLine();
            Console.Write("Enter the employee id that will have salary increase : ");
            int sid = int.Parse(Console.ReadLine());

            Employees employees1 = listemployees.Find(x => x.Id == sid);

            if (employees1 != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine().Replace(',', '.'), CultureInfo.InvariantCulture);
                employees1.IncreaseSalary(percentage);

            }
            else
            {
                Console.WriteLine("This Id does not exist!");
            }

            Console.WriteLine("Updated list of employees: ");
            foreach (Employees employees in listemployees)
            {
                Console.WriteLine(employees);
            }
            Console.ReadKey();
        }
    }
}
