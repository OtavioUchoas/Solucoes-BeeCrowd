using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

int[] sequencia = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

if (sequencia[1] > sequencia[2]
    && sequencia[3] > sequencia[0]
    && (sequencia[2] + sequencia[3]) > (sequencia[0] + sequencia[1])
    && sequencia[2] > 0 && sequencia[3] > 0 && sequencia[0] % 2 == 0)
{
    Console.WriteLine("Valores aceitos");
}
else
{
    Console.WriteLine("Valores nao aceitos");
}





        
    }

}