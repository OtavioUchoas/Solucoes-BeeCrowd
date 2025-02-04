using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 


int[] tamanho = Console.ReadLine().Split(' ').Take(2).Select(int.Parse).ToArray();
int[,] matriz = new int[tamanho[0], tamanho[1]];
int bingo = 0;
for (int i = 0; i < tamanho[0]; i++)
{
    int[] numeros = Console.ReadLine().Split(' ').Take(tamanho[1]).Select(int.Parse).ToArray();
    for (int j = 0; j < tamanho[1]; j++)
    {
        matriz[i, j] = numeros[j];
    }
}
for (int i = 1; i < tamanho[0]-1; i++)
{
    for (int j = 1; j < tamanho[1]-1; j++)
    {
        if (matriz[i, j] == 42 && matriz[i, j-1] == 7 && matriz[i, j+1] == 7 
            && matriz[i-1, j] == 7 && matriz[i-1, j-1] == 7 && matriz[i - 1, j +1] == 7 &&
            matriz[i +1, j] == 7 && matriz[i +1, j -1] == 7 && matriz[i +1, j + 1] == 7)
        {
            Console.WriteLine($"{i+1} {j+1}");
            bingo++;
        }
        

        
    }
}
if (bingo == 0)
{
    Console.WriteLine("0 0");
}




    }

}