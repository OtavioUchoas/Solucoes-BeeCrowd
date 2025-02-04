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
    int numeros = int.Parse(b);
    int[] casos = Console.ReadLine().Split(' ').Take(numeros).Select(int.Parse).ToArray();
    double c = casos.Length;
    double d = casos.Count(x => x == 1);
    if (d/c >= (double)2 / 3)
    {
        Console.WriteLine("impeachment");
    }
    else
    {
        Console.WriteLine("acusacao arquivada");
    }

}

    }

}