using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenandOdd
{
    class SumofEvenAndOdd
    {
        static void Main(string[] args)
        {
            SumofEvenAndOdd1();

        }

        static void SumofEvenAndOdd1()
        {
            Console.WriteLine("Enter 10 Numbers");
            int[] arr = new int[10];
            int Sum_of_Even = 0;
            int Sum_of_Odd = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Sum_of_Even = Sum_of_Even + arr[i];

                }
                else
                {
                    Sum_of_Odd = Sum_of_Odd + arr[i];
                }

            }
            int[] Sum_of_arr = { Sum_of_Even, Sum_of_Odd };
            //Sum_of_arr[0] = Sum_of_Even;
            //Sum_of_arr[1] = Sum_of_Odd;cw     
            Console.WriteLine(Sum_of_arr[0] + "," + Sum_of_arr[1]);

            Console.ReadLine();

        }
    }
}
