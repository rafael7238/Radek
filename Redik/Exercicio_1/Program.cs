using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // imprime cada número de 1 até 100 em uma nova linha.
            /*Para cada múltiplo de 3, imprima "Foo", ao invés do número.
            Para cada múltiplo de 5, imprima "Baa", ao invés do número.
            Para números múltiplos simultaneamente de 3 e 5, imprima "FooBaa", ao invés do número.*/

            for (int num1 = 1; num1 <= 100; num1++)
            {
                if (num1 % 5 == 0 && num1 % 3 == 0)
                    Console.WriteLine("FooBaa");
                else if (num1 % 3 == 0)
                    Console.WriteLine("Foo");
                else if (num1 % 5 == 0)
                    Console.WriteLine("Baa");
                else
                    Console.WriteLine(num1);
            }
        }
    }
}
