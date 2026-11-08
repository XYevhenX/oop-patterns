using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            FactoryMethod.Program.Run();

            Facade.Program.Run();

            Console.ReadLine();
        }
    }
}