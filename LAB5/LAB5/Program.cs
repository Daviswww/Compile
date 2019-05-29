using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime;
namespace LAB5
{
    class Program
    {
        static void Main(string[] args)
        {
            //string filename = Console.ReadLine();
            System.IO.StreamReader stream = new System.IO.StreamReader("a.txt");
            string line;
            while (!stream.EndOfStream)
            {
                line = stream.ReadToEnd();
                Lexer1 lexer = new Lexer1(new AntlrInputStream(line));
                Parser1 parser = new Parser1(new CommonTokenStream(lexer));
                parser.main_rule();

            }
            Console.WriteLine("\npress any key to exit.");
            Console.ReadKey();
        }
    }
}
