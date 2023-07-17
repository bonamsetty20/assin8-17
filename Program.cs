using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{




    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Type:");
            Console.WriteLine("1-HR");
            Console.WriteLine("2-Admin");
            Console.WriteLine("3-Software Developer");
            Console.Write("Enter employee type: ");
            int employeeType = int.Parse(Console.ReadLine());

            int workingHours, workingDays, projectHandles, extras;

            Console.Write("Enter working hours: ");
            workingHours = int.Parse(Console.ReadLine());

            Console.Write("Enter number of working days: ");
            workingDays = int.Parse(Console.ReadLine());
            if (employeeType == 1 || employeeType == 3)
            {
                Console.Write("Enter number of project handles: ");
                projectHandles = int.Parse(Console.ReadLine());
            }
            else
            {
                projectHandles = 0;
            }

            if (employeeType == 3)
            {
                Console.Write("Enter number of extras: ");
                extras = int.Parse(Console.ReadLine());
            }
            else
            {
                extras = 0;
            }
            decimal monthlySalary = CalculateMonthlySalary(employeeType, workingHours, workingDays, projectHandles, extras);

            Console.WriteLine($"Monthly Salary: {monthlySalary:C}");
        }

        static decimal CalculateMonthlySalary(int employeeType, int workingHours, int workingDays, int projectHandles, int extras)
        {
            decimal salary = 0;

            if (employeeType == 1) // HR
            {
                salary = workingHours * workingDays * 100 + projectHandles * 3000;
            }
            else if (employeeType == 2) // Admin
            {
                salary = workingHours * workingDays * 100;
            }
            else if (employeeType == 3) // Software Developer
            {
                salary = workingHours * workingDays * 100 + projectHandles * 3000 + extras * 2000;
            }

            return salary;
        }
    }
}
