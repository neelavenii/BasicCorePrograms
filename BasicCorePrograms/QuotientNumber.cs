using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class QuotientNumber
    {
        public static void Quotient()
        {
            int num, div , rem, quo =0;
            Console.WriteLine("Enter a Number : ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a divisor  : ");
            div = Convert.ToInt32(Console.ReadLine());

            if ( num > div)
            {
                while (num >= div)
                {
                    num = num - div;
                    quo++;
                }
                rem = num;
                Console.WriteLine("\nThe quotient is :" + quo + "\nThe remainder is :" + rem);
            }
            else
                Console.WriteLine("Enter valid input");
        }
    }
}
