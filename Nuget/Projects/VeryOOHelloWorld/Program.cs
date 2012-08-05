using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VeryOOHelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var factory = new WriterFactory();
            IWriter writer = factory.CreateWriter();
            writer.Writeline("Get ready for my first hello world on c#!");
            writer.Writeline("Hello World!");

            writer.Writeline("Press any key ...");
            Console.ReadKey(true);
        }
    }
}
