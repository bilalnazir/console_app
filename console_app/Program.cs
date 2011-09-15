using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's you name?");
            var name = Console.ReadLine();
            Console.WriteLine("Hello, " + name.ToString());
            Console.ReadLine(); 
        }
    }
}
