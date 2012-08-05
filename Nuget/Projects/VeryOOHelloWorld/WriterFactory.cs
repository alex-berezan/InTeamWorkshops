namespace VeryOOHelloWorld
{
    public class WriterFactory
    {
        public IWriter CreateWriter()
        {
            return new ConsoleWriter();
        }
    }
}