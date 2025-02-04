using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

     int casos = 0;
int numeros = int.Parse(Console.ReadLine());
for (int i = 0; i < numeros; i++)
{
    string c = Console.ReadLine();
    float[] n = Console.ReadLine().Split(' ').Take(3).Select(float.Parse).ToArray();
    if (c == "min")
    {
        Array.Sort(n);
        Console.WriteLine($"Caso #{++casos}: {n[0]}");
    }
    else if (c == "max") 
    {
        Array.Sort(n);
        Console.WriteLine($"Caso #{++casos}: {n[2]}");
    }
    else if (c == "mean")
    {
        Console.WriteLine($"Caso #{++casos}: {Math.Floor(n.Sum()/3)}");
    }
    else if (c == "eye")
    {
        Console.WriteLine($"Caso #{++casos}: {Math.Floor(0.30 * n[0] + 0.59 * n[1] + 0.11 * n[2])}");
    } 
}

    }

}