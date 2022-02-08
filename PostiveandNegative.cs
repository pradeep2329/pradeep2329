using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3posandnegIfclause
{
    public class postiveandnegtive
    {
        public static void Main(string[] args)
        {
            int a;
            Console.Write("Enter the number : ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a>=0)
            {
                Console.WriteLine("{0} is Positive number", a);

            }
            else
            {
                Console.WriteLine("{0} is a negative number",a);
            }
        }
    }
}
