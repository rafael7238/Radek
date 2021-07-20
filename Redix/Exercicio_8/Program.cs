using System;

namespace Exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdCaracter = 0;
            string text = Console.ReadLine();
            foreach (var x in text)
            {
                qtdCaracter++;
            }
            Console.WriteLine($"String de tamanho {qtdCaracter}");
        }
    }
}
