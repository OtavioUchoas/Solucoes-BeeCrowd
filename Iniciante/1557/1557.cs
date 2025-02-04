using System;
using System.Runtime;

class URI
{
    static int digitos(int numero)
    {
        return (int)Math.Floor(Math.Log10(numero)) + 1;
    }

    static string espaco(int numero, int limite)
    {
        string resposta = numero.ToString();

        int espacos = limite - resposta.Length;
        for (int i = 0; i < espacos; ++i)
        {
            resposta = " " + resposta;
        }

        return resposta;
    }

    static void Main(string[] args)
    {
        string entrada;

        while ((entrada = Console.ReadLine()) != null)
        {
            int N = int.Parse(entrada);

            if (N == 0)
            {
                break;
            }

            int limite = digitos(1 << (2 * N - 2));

            for (int i = 0; i < N; ++i)
            {
                Console.Write((1 << i).ToString().PadLeft(limite));
                for (int j = 1; j < N; ++j)
                {
                    Console.Write($" {(1 << (i + j)).ToString().PadLeft(limite)}");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }
        /*
while (true)
{
    int tamanho = int.Parse(Console.ReadLine());
    if (tamanho == 0)
    {
        break;
    }
    int[,] matriz = new int[tamanho, tamanho];
    for (int i = 0; i < tamanho; i++)
    {
        for (int j = 0; j < tamanho; j++)
        {
            matriz[i, j] = (int)Math.Pow(2, i + j);

        }
    }
    for (int i = 0; i < tamanho; i++)
    {
        for (int j = 0; j < tamanho; j++)
        {
            if (j == 0)
            {
                Console.Write($"{matriz[i, j]}".PadLeft(3));
            }
            else
            {
                Console.Write($"{matriz[i, j]}".PadLeft(4));
            }
        }
        Console.WriteLine("");
    }
   
}
*/
    }
}