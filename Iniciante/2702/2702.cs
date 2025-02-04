using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

       int soma = 0;
int[] a = Console.ReadLine().Split(' ').Take(3).Select(int.Parse).ToArray();
int[] b = Console.ReadLine().Split(' ').Take(3).Select(int.Parse).ToArray();
for (int i = 0; i < 3; i++)
{
    if (b[i] > a[i])
    {
        soma += b[i] - a[i];
    }
}
Console.WriteLine(soma);
    }

}