using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VeryOOHelloWorld;

namespace LetsInstallSomePackage
{
    class Program
    {
        static void Main(string[] args)
        {
            WriterFactory factory = new WriterFactory();
            factory.CreateWriter().Writeline("Yahoo.ua");

            Console.ReadLine();
        }
    }
}
