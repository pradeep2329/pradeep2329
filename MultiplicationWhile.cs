using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2while
{
    public class multiplicationWhile
    {
        public static void Main(string[] args)
        {

            Console.Write("Enter a number  :");
            int a = Convert.ToInt32(Console.ReadLine());

            int i = 1; //initialization
            while (i <= 10) //condition
            {
                Console.WriteLine(a + "*" + i + "=" + (a * i));
                i++; //increament
            }

            Console.ReadLine();
            
        }
    }
}
