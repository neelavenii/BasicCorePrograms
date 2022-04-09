using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic core Programs");
           EvenOdd evenOdd = new EvenOdd();
            EvenOdd.CheckEvenOdd();
            Harmonic.HarmonicNumbers();
            SwapNumbers.Swap();
            VowelConsonent.Charactor();
            Factors.PrimeFactors();
            Console.ReadLine();
        }
    }
}
