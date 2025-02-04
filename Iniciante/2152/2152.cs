using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

int entrada = int.Parse(Console.ReadLine());
for (int i = 0; i < entrada; i++)
{
    int[] a = Console.ReadLine().Split(' ').Take(3).Select(int.Parse).ToArray();
    DateTime horas = new DateTime(2016, 11, 1, a[0], a[1], 0);

    Console.WriteLine($"{horas:HH:mm} - {( a[2] == 1 ? "A porta abriu!" : "A porta fechou!" )}");
}





    }

}