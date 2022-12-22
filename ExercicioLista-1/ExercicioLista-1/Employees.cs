using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLista_1
{
    internal class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employees()
        {

        }

        public Employees(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage)
        {
            Salary = Salary + (Salary * (percentage/100)) ;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Id);
            sb.Append(", ");
            sb.Append(Name);
            sb.Append(", ");
            sb.Append(Salary.ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
