﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeter.Hello();
            Greeter.WhoopWhoop();
            Greeter.Goodbye();
            Greeter.Friday();
            
            Console.WriteLine("Press the ANY key");
            Console.ReadKey();

        }
    }

    static class Greeter {
        public static void Hello() {
            Console.WriteLine("Hej Codesion & Bitbucket!");
        }

        public static void WhoopWhoop()
        {
            Console.WriteLine("Friday!! :D");
        }

        public static void Goodbye() {
            Console.WriteLine("And goodbye!");
        }

        internal static void Friday()
        {
            Console.WriteLine("Freeedag :D");            
        }
    }
}
