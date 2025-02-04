using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

        int entrada = int.Parse(Console.ReadLine());
int[] a = Console.ReadLine().Split(' ').Take(entrada).Select(int.Parse).ToArray();


int menor = a.Min();
Console.WriteLine($"Menor valor: {menor}");
Console.WriteLine($"Posicao: {Array.IndexOf(a, menor)}");

    }

}