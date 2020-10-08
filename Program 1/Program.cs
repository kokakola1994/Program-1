using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pierwszy program");

            Console.ForegroundColor = ConsoleColor.Red;

            Console.BackgroundColor = ConsoleColor.Yellow;

           for(int i = 1; i < 10; i++)
            {
                Console.WriteLine("Linijka {0}", i);
               // Console.WriteLine("Linijka " + i);
            }
            przykladowametoda();
        }
        static void przykladowametoda()
        {
            Console.Beep(2000, 3000);
        }
    }
}
