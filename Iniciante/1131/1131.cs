using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

      
      int grenais = 0;
int inter = 0;
int gremio = 0;
int empate = 0;
while (true)
{
    int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    if (a[0] > a[1])
    {
        grenais++;
        inter++;
    }
    if (a[0] < a[1])
    {
        grenais++;
        gremio++;
    }
    if (a[0] == a[1])
    {
        grenais++;
        empate++;
    }
    string resp = "";
    while (resp != "1" && resp != "2")
    {
        Console.WriteLine("Novo grenal (1-sim 2-nao)");
        resp = Console.ReadLine();
        
        
    }
    if (resp == "1")
    {
        continue;
    }
    else
    {
        break;

    }
    
}
Console.WriteLine(grenais + " grenais");
Console.WriteLine($"Inter:{inter}");
Console.WriteLine($"Gremio:{gremio}");
Console.WriteLine($"Empates:{empate}");
if (inter > gremio)
{
    Console.WriteLine("Inter venceu mais");
}
if (inter < gremio)
{
    Console.WriteLine("Gremio venceu mais");
}
if (inter == gremio)
{
    Console.WriteLine("Nao houve vencedor");
}
      
      
    }

}