using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

       long[] a = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
Console.WriteLine(a[0] * a[1]);

    }

}