using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

        while (true)
{
    string b = Console.ReadLine();
    if (string.IsNullOrEmpty(b))
    {
        break;
    }
    int[] n = b.Split(' ').Select(int.Parse).ToArray();
    int[,] matriz = new int[n[0], n[1]];
    for (int i = 0; i < n[0]; i++)
    {
        int[] array = Console.ReadLine().Split(' ').Take(n[1]).Select(int.Parse).ToArray();
        for (int j = 0; j < n[1]; j++)
        {
            matriz[i, j] = array[j];
        }
    }
    for (int i = 0; i < n[0]; i++)
    {
        for (int j = 0; j < n[1]; j++)
        {
            int proximidade = 0;
            if (matriz[i, j] == 1)
            {
                Console.Write("9");
            }
            else
            {
                if (i > 0 && matriz[i-1,j] == 1)
                {
                    proximidade++;
                }
                if (j < n[1]-1 && matriz[i, j +1] == 1)
                {
                    proximidade++;
                }
                if (i < n[0]-1 && matriz[i+1, j] == 1)
                {
                    proximidade++;
                }
                if (j>0 && matriz[i, j-1] == 1)
                {
                    proximidade++;
                }
                Console.Write(proximidade);
            }
        }
            Console.WriteLine("");
    }

}


    }

}