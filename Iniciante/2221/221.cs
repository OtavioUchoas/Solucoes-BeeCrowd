using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

    int quantidade = int.Parse(Console.ReadLine());
for (int i = 0; i < quantidade; i++)
{
    int bonus = int.Parse(Console.ReadLine());
    int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    int[] b = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    int golpe = 0;
    int golpe1 = 0;
    if (a[2] %2  == 0)
    {
        golpe = (a[0] + a[1]) / 2 + bonus;
    }
    else
    {
        golpe = (a[0] + a[1]) / 2;
    }
    if (b[2] % 2 == 0)
    {
        golpe1 = (b[0] + b[1]) / 2 + bonus;
    }
    else
    {
        golpe1 = (b[0] + b[1]) / 2;
    }
    if (golpe == golpe1)
    {
        Console.WriteLine("Empate");
    } 
    else if (golpe > golpe1)
    {
        Console.WriteLine("Dabriel");
    }
    else if (golpe < golpe1)
    {
        Console.WriteLine("Guarte");
    }
} 

    }

}