using System; 

class URI {

    static void Main(string[] args) { 

        while (true)
{
    int tamanho = int.Parse(Console.ReadLine());

    if (tamanho == 0)
    {
        break;
    }
    int gambiarra = 0;
    int rodadas = 0;
    int contador = 1;
    int[,] matriz = new int[tamanho, tamanho];
    for (int i = 0, j = rodadas; i < tamanho && j < tamanho; i++, j++)
    {
        matriz[i, j] = contador;

        if (i == tamanho - 1)
        {
            rodadas++;
            i = -1;
            j = rodadas - 1;
            gambiarra++;
            contador++;
        }
        if (j == tamanho - 1)
        {
            rodadas++;
            i = -1;
            j = rodadas - 1;
            gambiarra++;
            contador++;
        }
        if (gambiarra == tamanho - 1)
        {
            matriz[(i + 1), (j + 1)] = contador;
            break;
        }
    }
    if (tamanho > 1)
    {
        int loops_i = 1;
        int semigambiarra = 2;
        gambiarra = 0;
        contador = 2;
        for (int i = loops_i, j = 0; i < tamanho && j < tamanho-1; i++, j++)
        {
            matriz[i, j] = contador;
            if (j == tamanho - semigambiarra)
            {
                semigambiarra++;
                j = -1;
                loops_i++;
                i = loops_i-1;
                contador++;
            }

            

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
    Console.WriteLine("");
}


    }

}