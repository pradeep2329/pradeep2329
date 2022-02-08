using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Temp
{
    public class Temperature
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the celsius value : ");
            int celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kelvin value is = {0}", celsius + 273);
            Console.WriteLine("fahrenheit value is ={0}", celsius * 18 / 10 + 32);

        }
    }
}
