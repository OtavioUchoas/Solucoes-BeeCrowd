using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

     int entrada = int.Parse(Console.ReadLine());
float saque = 0;
float bloqueios = 0;
float ataques = 0;
float etsaque = 0;
float ebloqueios = 0;
float eataques = 0;

for (int i = 0; i < entrada; i++)
{
    string nome = Console.ReadLine();

    float[] a = Console.ReadLine().Split(' ').Take(3).Select(float.Parse).ToArray();
    float[] b = Console.ReadLine().Split(' ').Take(3).Select(float.Parse).ToArray();
    etsaque += a[0];
    ebloqueios += a[1];
    eataques += a[2];
    saque += b[0];
    bloqueios+= b[1];
    ataques += b[2];
}
Console.WriteLine($"Pontos de Saque: {(saque / etsaque)*100:f2} %.");
Console.WriteLine($"Pontos de Bloqueio: {(bloqueios / ebloqueios)*100:f2} %.");
Console.WriteLine($"Pontos de Ataque: {(ataques / eataques)*100:f2} %.");

    }

}