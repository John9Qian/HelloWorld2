using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class HelloWorld
    {
        public void PrintHello(string[] s)
        {
            Console.WriteLine("Hello world! ");
            if (s.Length > 0)
            {
                Console.WriteLine("args contain {0} string",s.Length);
                for(int i = 0; i < s.Length; i++)
                {
                    Console.WriteLine("{0}", s[i]);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld hello = new HelloWorld();
            hello.PrintHello(args);
        }
    }
}
