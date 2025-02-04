using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

      while (true)
{
    string entrada = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(entrada))
    {
        break;
    }
    int maximo = int.Parse(entrada);
    int[] a  = Console.ReadLine().Split(' ').Take(maximo).Select(int.Parse).ToArray();
    int valor_max = a.Max();
    if (valor_max < 10)
    {
        Console.WriteLine("1");
    }
    else if (valor_max >= 10 && valor_max <20)
    {
        Console.WriteLine("2");
    }
    else if (valor_max >= 20)
    {
        Console.WriteLine("3");
    }

}
    }

}