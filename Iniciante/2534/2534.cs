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
    int[] casos = b.Split(' ').Take(2).Select(int.Parse).ToArray();
    int[] numeros = new int[casos[1]];
    int[] notas = new int[casos[0]];
    for (int i = 0; i < casos[0]; i++)
    {
        notas[i] = int.Parse(Console.ReadLine());
        
    }
    for (int i = 0; i < casos[1]; i++)
    {
        numeros[i] = int.Parse(Console.ReadLine());
    }
    Array.Sort(notas);
    Array.Reverse(notas);
    for (int i = 0; i < numeros.Length; i++)
    {
        Console.WriteLine(notas[numeros[i]-1]);
    }
}
    

    }

}