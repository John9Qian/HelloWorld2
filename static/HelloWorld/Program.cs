using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Hello
    {
        public static void printHelloWorld(string[] args)
        {
            Console.WriteLine("HelloWorld!");
            if (args.Length != 0)
            {
                Console.WriteLine("args contain {0} string", args.Length);
                for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine("{0}", args[i]);
                }
            }
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            Hello.printHelloWorld(args);
            Console.ReadKey();
        }
    }
}
