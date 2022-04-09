using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Factors
    {
        public static void PrimeFactors()
        {
            Console.WriteLine("Enter positive number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int originalNumber = 1;
            if (number < 0)
            {
                Console.WriteLine("Invalied number!");
                Console.ReadLine();
            }
            else
            {
                for (int count = 2; number > 1; count++)
                {
                    while (number % count == 0)
                    {
                        Console.Write("{0}", count);
                        number /= count;
                        originalNumber *= count;
                    }
                }
                    Console.WriteLine("\nOriginal Number after Prime Factorization");
                    Console.ReadLine();
                }
            }
        }
    }


