using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hellos
{
    class Program
    {
        static void Main(string[] args)
        {
            new Hello();
            Console.WriteLine("say hi" );
            Hello.printHello();
            Console.ReadKey();


        }

        public class Hello {
            public Hello() {
                int number = 0;
                string hello = "hello";
            }
            public static void printHello() {
                Console.WriteLine("this time i print this");
            }
        }
    }
}
