using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4validdate
{
    class leafyear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the year : ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (((year%4==0)&&(year%100 != 0) || (year%400==0)))
            {
                Console.WriteLine("{0} is a leap year", year);
            }
            else
            {
                Console.WriteLine("{0} is not a leaf year", year);
            }
        }
    }
}
