namespace DiamanteLetras.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-- Diamante de Letras");
        Console.WriteLine();

        int n = 5;
        int px = n;
        int py = n;

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j < n * 2; j++)
            {
                if (j == px || j == py)
                {
                    Console.Write("*");
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
    }
}
