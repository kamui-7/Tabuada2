using System;

namespace Tabuada2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i, produto;

            Console.Write("Deseja saber a tabuada de qual numero? ");
            n = int.Parse(Console.ReadLine());

            for(i = 0; i <= 10; i++)
            {
                produto = n * i;
                Console.WriteLine(n + " X " + i + " = " + produto);
            }
        }
    }
}
