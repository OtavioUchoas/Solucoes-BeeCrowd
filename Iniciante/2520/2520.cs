using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

      int localizacao2i = 0;
int localizacao2j = 0;
int localizacao1i = 0;
int localizacao1j = 0;
while (true)
{
    int passos = 0;
    string b = Console.ReadLine();
    if (string.IsNullOrEmpty(b))
    {
        break;
    }
    int[] numeros = b.Split(' ').Take(2).Select(int.Parse).ToArray();
    int[,] matriz = new int[numeros[0], numeros[1]];
    for (int i = 0; i < numeros[0]; i++)
    {
        int[] array = Console.ReadLine().Split(' ').Take(numeros[1]).Select(int.Parse).ToArray();
        for (int j = 0; j < numeros[1]; j++)
        {
            matriz[i, j] = array[j];
        }
    }
    for (int i = 0; i < numeros[0]; i++)
    {
        for (int j = 0; j < numeros[1]; j++)
        {
            if (matriz[i, j] == 2)
            {
                localizacao2i = i;
                localizacao2j = j;
            }
            else if (matriz[i, j] == 1)
            {
                localizacao1i = i;
                localizacao1j = j;
            }
        }
    }
    while ((localizacao1i != localizacao2i) || (localizacao1j != localizacao2j))
    {
        if (localizacao1j > localizacao2j)
        {
            localizacao1j--;
            passos++;
        } 
        if (localizacao1j < localizacao2j)
        {
            localizacao1j++;
            passos++;
        }
        if (localizacao1i > localizacao2i)
        {
            localizacao1i--;
            passos++;
        }
        if (localizacao1i < localizacao2i)
        {
            localizacao1i++;
            passos++;
        }
    }
    Console.WriteLine(passos);
}


    }

}