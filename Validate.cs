using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{

    class ValidDate  
    {
        static bool isLeap(int year)
        {
            return (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0));
        }

        static bool isValidDate()
        {
            Console.WriteLine("Enter the  DAY:");
            int Day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the MONTH:");
            int Month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the YEAR:");
            int Year = Convert.ToInt32(Console.ReadLine());

            if (Year > 9999 ||
           Year < 1500)
                return false;

            if (Month < 1 || Month > 12)
                return false;


            if (Day < 1 || Day > 31)
                return false;

            if (Month == 2)
            {
                if (isLeap(Year))
                    return (Day <= 29);
                else
                    return (Day <= 28);
            }

            if (Month == 4 || Month == 6 ||
            Month == 9 || Month == 11)
                return (Day <= 30);

            return true;
        }

        public static void Main(string[] args)
        {
            if (isValidDate())
            {
                Console.WriteLine("The date is ValidDate");
            }
            else

                Console.WriteLine("The date is invalid date");
        }
    }
}