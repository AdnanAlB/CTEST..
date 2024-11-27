using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad är ditt namn?");

           string  userinput = Console.ReadLine();
            Console.WriteLine("Hej " + userinput + "!");

        }
    }
}
