using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class PrimeNumber
    {
        static bool isPrime(int n)

        {
            if (n <= 1)
                return false;
            for (int i = 2; i <= n / 2; i++)

                if (n % i == 0)

                    return false;
            return true;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (isPrime(n))
                Console.WriteLine("true and {0} is the prime number",n);
            else
                Console.WriteLine("false and {0} is not the prime number",n);
        }
    }
}
