using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class SwapNumbers
    {
        public static void Swap()
        {
            int num1, num2, temp;
            Console.WriteLine("Enter the number for num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number for num2");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swapping num1 = {0} and num2 = {1}", num1, num2);

            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("After swapping num1 = {0} and num2 = {1}", num1, num2);
            Console.ReadLine();
        }
    }
}
