using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class EvenOdd
    {
        public static void CheckEvenOdd()
        {
            int number, remainder;
            Console.WriteLine("Enter the integer value");
            number = Convert.ToInt32(Console.ReadLine());

            remainder = number % 2;

            if (remainder == 0)
                Console.WriteLine("{0} is an even number", number);
            else
                Console.WriteLine("{0} is an Odd number", number);
            Console.ReadLine();

        }
    }
}
