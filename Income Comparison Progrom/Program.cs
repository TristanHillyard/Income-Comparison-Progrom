using System;

namespace Income_Comparison_Progrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            int Person1;
            Console.WriteLine("Person1");
            int hrlyRate;
            Console.WriteLine("Hourly Rate?");
            hrlyRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(hrlyRate);
            Console.ReadLine();

            Console.WriteLine("Hours worked a week?");
            int hrsWorked;
            hrsWorked = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(hrsWorked);
            Console.ReadLine();

            int Person2;
            Console.WriteLine("Person2");
            Console.WriteLine("Hourly Rate?");
            hrlyRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(hrlyRate);
            Console.ReadLine();

            Console.WriteLine("Hours worked a week?");
            hrsWorked = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(hrsWorked);
            Console.ReadLine();

            Console.WriteLine("Annual Salary for Person 1:");
            Person1 = hrlyRate * hrsWorked * 52;
            Console.WriteLine(Person1);
            Console.ReadLine();

            Console.WriteLine("Annual Salary for Person 2:");
            Person2 = hrsWorked * hrsWorked * 52;
            Console.WriteLine(Person2);
            Console.ReadLine();

            bool annualSalary;
            annualSalary = Person1 > Person2;
            Console.WriteLine(annualSalary);
        }
    }
}
