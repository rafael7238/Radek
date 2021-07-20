using System;
using System.Linq;

namespace Exercicio_2
{

    /*
     1. Concatenar um caractere minúsculo do alfabeto português ao final da string.
     2. Remover o último caractere da string. Se a string estiver vazia, ela permanecerá vazia
     */
    /*Dado um número inteiro k e duas strings s e t, determine se você consegue converter s em t através de 
         * exatamente k operações descritas acima sobre s. Se possível, o programa imprime 'sim', 
         * do contrário imprime 'não'.*/

    /*Imprima 'sim' se você puder obter a string t executando exatamente k operações sobre a string s, e imprime 'não' no caso contrário.*/

   public class Desafio2
    {
        public string s;
        public string t;
        public int k;
        char c = ' ';


        public bool ConcatERemove(string s, string t, int k)
        {
            int posicaoReducao = -1;
            var qtdCaracteresT = 0;
            s = s.PadRight(k, ' ');
            var diferencaoEntreTInformadoETAchado = 0;


            for (var x = s.Length; x > 0; x--)
            {
                for (var y = t.Length; y > 0; y--)
                {
                    qtdCaracteresT++;
                    string strS = new string(s.ToCharArray(0, x));
                    string strT = new string(t.ToCharArray(0, y));

                    if (strS == strT)

                    {
                        posicaoReducao = s.Length - x;
                        if (t.Length != strT.Length)
                            diferencaoEntreTInformadoETAchado = t.Length - strT.Length;
                        else
                            diferencaoEntreTInformadoETAchado = t.Length;
                        break;

                    }
                }
                if (posicaoReducao != -1)
                    break;
            }

            var valida = (k == posicaoReducao + diferencaoEntreTInformadoETAchado);
            return valida;

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Desafio2 df = new Desafio2();
            df.s = Console.ReadLine().ToLower();
            if (df.s.Length < 1 || df.s.Length > 100)
            {
                Console.WriteLine("Impossível Continuar. Valor de S tem que estar entre 1 e 100");
                Console.Clear();
            }
            df.t = Console.ReadLine().ToLower();
            if (df.t.Length < 1 || df.t.Length > 100)
            {
                Console.WriteLine("Impossível Continuar. Valor de T tem que estar entre 1 e 100");
                Console.Clear();
            }
            df.k = Convert.ToInt32(Console.ReadLine());
            if (df.k < 1 || df.k > 100)
            {
                Console.WriteLine("Impossível Continuar. Valor de K tem que estar entre 1 e 100");
                Console.Clear();
            }
            var valida = df.ConcatERemove(df.s, df.t, df.k);

            if (valida)
                Console.WriteLine("Sim");
            else
                Console.WriteLine("Não");

        }
    }
}
