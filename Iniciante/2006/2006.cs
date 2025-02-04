using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

    int candidatos = 0;
int cha = int.Parse(Console.ReadLine());
int[] a = Console.ReadLine().Split(' ').Take(5).Select(int.Parse).ToArray();
for (int i = 0; i < 5; i++)
{
    if (cha == a[i])
    {
        candidatos++;
    }
    else
    {
        continue;
    }
}
Console.WriteLine(candidatos);

    }

}