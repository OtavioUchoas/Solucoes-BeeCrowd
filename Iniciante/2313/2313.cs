using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

    
    int[] a = Console.ReadLine().Split(' ').Take(3).Select(int.Parse).ToArray();
if (a[0] < a[1] + a[2] && a[1] < a[0]+ a[2] && a[2] < a[0] + a[1])
{
    if (a[0] == a[1] && a[1] == a[2])
    {
        Console.WriteLine($"Valido-Equilatero");
        Console.WriteLine("Retangulo: N");
    }
    else if ((a[0] == a[1] && a[2] != a[1]) || (a[1] == a[2] && a[1] != a[2]) || (a[2] == a[0] && a[2] != a[1]))
    {
        Console.WriteLine("Valido-Isoceles");
        Console.WriteLine("Retangulo: N");
    }
    else
    {
        Console.WriteLine($"Valido-Escaleno");
        Array.Sort(a);
        if (a[2] * a[2] == a[1] * a[1] + a[0] * a[0])
        {
            Console.WriteLine("Retangulo: S");
        }
        else
        {
            Console.WriteLine("Retangulo: N");
        }
    }
}
else
{
    Console.WriteLine("Invalido");
}

    
    
    

    }

}