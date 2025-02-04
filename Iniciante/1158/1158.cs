using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

        int casos = int.Parse(Console.ReadLine());
int soma = 0;
for (int i = 0; i < casos; i++)
{
    int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    for(int j = a[0]; j <= (a[0]+(a[1]*2)-1); j++)
    {
        if (j%2 == 0)
        {
            continue;
        }
        else
        {
            soma += j;
        }

        
    }
    Console.WriteLine(soma);
    soma = 0;
}

    }

}