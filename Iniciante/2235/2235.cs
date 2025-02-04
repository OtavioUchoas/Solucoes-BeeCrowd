using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

int[] a = Console.ReadLine().Split(' ').Take(3).Select(int.Parse).ToArray();
if (a[0] + a[1] == a[2] || a[0] + a[2] == a[1] || a[2] + a[1] == a[0] || Math.Abs(a[0] - a[1]) == 0
    || Math.Abs(a[2] - a[0]) == 0 || Math.Abs(a[2] - a[1]) == 0)
{
    Console.WriteLine("S");
}
else
{
    Console.WriteLine("N");
}




    }

}