using System;

namespace VeryOOHelloWorld
{
    public class ConsoleWriter : IWriter
    {
        public void Writeline(string message)
        {
            Console.WriteLine(message);
        }
    }
}