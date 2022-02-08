using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfprime
{
      class sumOfPrimes
        {
            static bool isPrimeNumber(int n)
            {
                if (n == 1)
                {
                    return false;
                }
                for (int i = 2; i * i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            public static int SumOfPrimes()
            {
                Console.WriteLine("Enter the from number: ");
                int from = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the to number: ");
                int to = Convert.ToInt32(Console.ReadLine());
                int sum = 0;
                for (int i = from; i <= to; i++)
                {
                    bool isPrime = isPrimeNumber(i);
                    if (isPrime)
                    {
                        sum = sum + i;
                    }
                }
                return sum;

            }
            static void Main(string[] args)
            {
                Console.WriteLine("Sum of Prime Numbers: " + SumOfPrimes());
            }
        }

    }

