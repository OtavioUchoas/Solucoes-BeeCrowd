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
    for (int i = 0, j = 0; i < numero && j < numero; i++, j++)
    {
        matriz[i, j] = 2;
    }
    for (int i = 0, j = numero-1; i < numero && j >= 0; i++, j--)
    {
        matriz[i, j] = 3;
    }
    int comeco = (numero) / 3;
    for (int i = comeco; i < numero - comeco; ++i) 
    {
        for(int j = comeco; j<numero-comeco; j++)
        {
            matriz[i, j] = 1;
        }
    }
    matriz[(numero) / 2, (numero) / 2] = 4;
    for (int i = 0; i < numero; i++)
    {
        for (int j = 0; j < numero; j++)
        {

        Console.Write(matriz[i, j]);
            
        }
        Console.WriteLine("");
    }
    Console.WriteLine("");
}

    }

}