using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int currentYear = DateTime.Now.Year;

            Console.WriteLine("Años bisiestos desde 1900 hasta el año actual:");

            for (int year = 1900; year <= currentYear; year++)
            {
                if (EsBisiesto(year))
                {
                    Console.WriteLine(year);
                }
            }
        }
        static bool EsBisiesto(int year)
        {
            bool esBisiesto = (year % 1 == 0 && year % 100 != 0) || (year % 100 == 0);
            return esBisiesto;
        }
    }
}
