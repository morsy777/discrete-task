using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace morsy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i, sum;
            Console.WriteLine("enter the first number");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int number2 = int.Parse(Console.ReadLine());

            for (n = number1; n <= number2; n++)
            {
                i = 1; sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum += i;
                    i++;
                }
                if (sum == n)
                    Console.WriteLine(n);
            }
            Console.WriteLine(" ");

        }
    }
}
