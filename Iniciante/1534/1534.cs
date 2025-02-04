using System; 

class URI {

    static void Main(string[] args) { 

    while (true)
{
    string entrada = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(entrada))
    {
        break;
    }
    int numero = int.Parse(entrada);
    int[,] matriz = new int[numero, numero];
    for (int i = 0; i < numero; i++)
    {
        for (int j = 0; j < numero; j++)
        {
            if (i == j)
            {
                continue;
            }
            else
            {
                matriz[i, j] = 3;
            }
        }
    }
    for (int i = 0, j = 0; i < numero && j < numero; i++, j++)
    {
        matriz[i, j] = 1;
    }
    for (int i = 0, j = numero - 1; i >= 0 && j >= 0; i++, j--)
    {
        matriz[i, j] = 2;
    }

    for (int i = 0; i < numero; i++)
    {
        for (int j = 0; j < numero; j++)
        {
            if (j == 0)
            {
                Console.Write(matriz[i, j]);
            }
            else
            {
                Console.Write(matriz[i, j]);
            }
        }
        Console.WriteLine("");
    }
}

    }

}