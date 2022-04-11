using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class LargestNumber
    {
        public static void FindLargeNum()
        {
            int Num1, Num2, Num3;
            Console.WriteLine("Enter First number :");
            Num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number :");
            Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third number :");
            Num3 = Convert.ToInt32(Console.ReadLine());

            if (Num1 > Num2 && Num1 > Num3)
            {
                Console.WriteLine(Num1 + "is the largest");
            }
            else if (Num2 > Num1 && Num2 > Num3)
            {
                Console.WriteLine(Num2 + "is the largest");
            }
            else
            {
                Console.WriteLine(Num3 + "is the largest");
            }
            Console.ReadLine();
        }
    }
}
