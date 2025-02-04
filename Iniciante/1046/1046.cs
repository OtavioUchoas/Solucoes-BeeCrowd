using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

      int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
if (a[1] <= a[0])
{
    a[1] += 24;
}
Console.WriteLine($"O JOGO DUROU {a[1] - a[0]} HORA(S)") ;

    }

}