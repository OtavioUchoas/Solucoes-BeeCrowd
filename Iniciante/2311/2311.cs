using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 


int entrada = int.Parse(Console.ReadLine());
for (int i = 0; i < entrada; i++)
{
    string nome = Console.ReadLine();
    float dificuldade = float.Parse(Console.ReadLine());
    float[] sequencia = Console.ReadLine().Split(' ').Select(float.Parse).ToArray();
    float max = sequencia.Max();
    float min = sequencia.Min();
    float soma = sequencia.Sum();
    Console.WriteLine($"{nome} {(soma - max - min)*dificuldade:f2}");
}







    }

}