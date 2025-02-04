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
    int[] casos = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    string[] atributos = new string[casos[0]];
    string[] atributos1 = new string[casos[1]];
    for (int i = 0; i < casos[0]; i++)
    {
        atributos[i] = Console.ReadLine();
    }
    for (int i = 0; i < casos[1]; i++)
    {
        atributos1[i] = Console.ReadLine();
    }
    int[] indexcartas = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    int atributoescolhido = int.Parse(Console.ReadLine());
    string c = atributos[indexcartas[0]-1];
    string d = atributos1[indexcartas[1]-1];
    int[] ncarta1 = c.Split(' ').Select(int.Parse).ToArray();
    int[] ncarta2 = d.Split(' ').Select(int.Parse).ToArray();
    if (ncarta1[atributoescolhido - 1] == ncarta2[atributoescolhido - 1])
    {
        Console.WriteLine("Empate");
    }
    else if (ncarta1[atributoescolhido-1] > ncarta2[atributoescolhido-1])
    {
        Console.WriteLine("Marcos");
    }
    else
    {
        Console.WriteLine("Leonardo");
    }
}
        
        
        
        
        
        

    }

}