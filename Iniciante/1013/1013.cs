using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

        int[] n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

int e = ((n[0] + n[1] + Math.Abs(n[0] - n[1])))*1/2;
int c = ((e + n[2] + Math.Abs(e - n[2])))*1/2;
Console.WriteLine(Math.Max(e, c) + " eh o maior");

    }

}