using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========== Tabuada ===========\n");

            Console.Write("Tabuada do número: ");
            int.TryParse(Console
            .ReadLine()
            .ToString(), out int _valor);

            Console.WriteLine();

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{_valor} x {i} = {_valor*i}");
            }
        }
    }
}
