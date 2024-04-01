using System.Runtime.InteropServices;

namespace DiamanteLetras.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-- Diamante de Letras");
        Console.WriteLine();

        Console.WriteLine("Insira uma letra do alfabeto para formar o diamante: ");
        char letra = char.Parse(Console.ReadLine());

        string stringAlfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        char[] alfabeto = stringAlfabeto.ToCharArray();

        int n = 5;
        int px = n;
        int py = n;

        for (int i = 1; i < n; i++)
        {
            for (int j = 1; j < n * 2; j++)
            {
                if (j == px || j == py)
                {
                    Console.Write(alfabeto[i - 1]);
                }
                else
                {
                    Console.Write(" ");
                }
            }
            px--;
            py++;
            Console.WriteLine();
        }


        n = 5;
        px = 1;
        py = n * 2 - 1;

        Console.WriteLine(n);
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j < n * 2; j++)
            {
                if (j == px || j == py)
                {
                    Console.Write(alfabeto[i - 1]);

                }
                else
                {
                    Console.Write(" ");
                }
            }
            px++;
            py--;
            Console.WriteLine();
        }
    }
}
