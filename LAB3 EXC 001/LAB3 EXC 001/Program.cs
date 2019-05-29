using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3_EXC_001
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = Console.ReadLine();
            System.IO.StreamReader stream = new System.IO.StreamReader(filename);

            MyLanguageParser parser = new MyLanguageParser();
            string line;
            while(!stream.EndOfStream)
            {
                line = stream.ReadToEnd();
                parser.Parse(line);
            }

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
