﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculationSystemAssign8
{
    /*    class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Choose Employee Type:");
                Console.WriteLine("1. HR");
                Console.WriteLine("2. Admin");
                Console.WriteLine("3. Software Developer");

                int employeeType = int.Parse(Console.ReadLine());

                switch (employeeType)
                {
                    case 1:
                        Console.Write("Enter working hours: ");
                        int workingHoursHR = int.Parse(Console.ReadLine());

                        Console.Write("Enter number of working days: ");
                        int numWorkingDaysHR = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Monthly Salary: {CalculateSalary(workingHoursHR, numWorkingDaysHR)}");
                        break;

                    case 2:
                        Console.Write("Enter working hours: ");
                        int workingHoursAdmin = int.Parse(Console.ReadLine());

                        Console.Write("Enter number of working days: ");
                        int numWorkingDaysAdmin = int.Parse(Console.ReadLine());

                        Console.Write("Enter project handles: ");
                        int projectHandlesAdmin = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Monthly Salary: {CalculateSalary(workingHoursAdmin, numWorkingDaysAdmin, projectHandlesAdmin)}");
                        break;

                    case 3:
                        Console.Write("Enter working hours: ");
                        int workingHoursDev = int.Parse(Console.ReadLine());

                        Console.Write("Enter number of working days: ");
                        int numWorkingDaysDev = int.Parse(Console.ReadLine());

                        Console.Write("Enter project handles: ");
                        int projectHandlesDev = int.Parse(Console.ReadLine());

                        Console.Write("Enter extras: ");
                        int extrasDev = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Monthly Salary: {CalculateSalary(workingHoursDev, numWorkingDaysDev, projectHandlesDev, extrasDev)}");
                        break;

                    default:
                        Console.WriteLine("Invalid employee type.");
                        break;
                }

                Console.ReadLine();
            }

            static decimal CalculateSalary(int wHour, int nWDays, int projectHandles = 0, int extras = 0)
            {
                decimal baseSalary = wHour * nWDays * 100;
                decimal projectSalary = projectHandles * 3000;
                decimal extrasSalary = extras * 2000;

                decimal totalSalary = baseSalary + projectSalary + extrasSalary;

                return totalSalary;
            }
        }
    }*/


    public enum EmployeeType
    {
        HR,
        Admin,
        SoftwareDeveloper
    }

    public class Program
    {
        public static double CalculateSalary(EmployeeType employeeType, double workingHour, double numberOfWorkingDays, double projectHandles = 0, double extras = 0)
        {
            double salary = 0;

            switch (employeeType)
            {
                case EmployeeType.HR:
                    salary = workingHour * numberOfWorkingDays * 100 + 1 * 3000;
                    break;

                case EmployeeType.Admin:
                    salary = workingHour * numberOfWorkingDays * 100 + projectHandles * 3000;
                    break;

                case EmployeeType.SoftwareDeveloper:
                    salary = workingHour * numberOfWorkingDays * 100 + projectHandles * 3000 + extras * 2000;
                    break;
            }

            return salary;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Choose Employee Type:");
            Console.WriteLine("1. HR");
            Console.WriteLine("2. Admin");
            Console.WriteLine("3. Software Developer");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            double workingHour, numberOfWorkingDays, projectHandles, extras;
            double salary;

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Working Hour: ");
                    workingHour = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter Number of Working Days: ");
                    numberOfWorkingDays = Convert.ToDouble(Console.ReadLine());
                    salary = CalculateSalary(EmployeeType.HR, workingHour, numberOfWorkingDays);
                    Console.WriteLine("Monthly Salary: $" + salary);
                    break;

                case 2:
                    Console.Write("Enter Working Hour: ");
                    workingHour = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter Number of Working Days: ");
                    numberOfWorkingDays = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter Project Handles: ");
                    projectHandles = Convert.ToDouble(Console.ReadLine());
                    salary = CalculateSalary(EmployeeType.Admin, workingHour, numberOfWorkingDays, projectHandles);
                    Console.WriteLine("Monthly Salary: $" + salary);
                    break;

                case 3:
                    Console.Write("Enter Working Hour: ");
                    workingHour = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter Number of Working Days: ");
                    numberOfWorkingDays = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter Project Handles: ");
                    projectHandles = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter Extras: ");
                    extras = Convert.ToDouble(Console.ReadLine());
                    salary = CalculateSalary(EmployeeType.SoftwareDeveloper, workingHour, numberOfWorkingDays, projectHandles, extras);
                    Console.WriteLine("Monthly Salary: $" + salary);
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

            Console.ReadKey();
        }
    }
}