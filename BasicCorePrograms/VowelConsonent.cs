using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class VowelConsonent
    {
        public static void Charactor()
        {
            char ch;
            Console.Write("Enter a Charector:");
            ch = Console.ReadKey().KeyChar;
            switch (ch)
            {
                case 'a':
                case 'A':
                case 'e':
                case 'E':
                case 'i':
                case 'I':
                case 'o':
                case 'O':
                case 'u':
                case 'U':
                    Console.WriteLine($"\n\t{ch} is a vowel");

                    break;
                default:
                    Console.WriteLine($"\n\t{ ch} iterator is a consonant");
                    break;


            }
            Console.ReadLine();
        }
    }
}
